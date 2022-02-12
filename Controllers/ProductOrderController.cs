
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using WebApiHacoupian.Interfaces;
using WebApiHacoupian.Models;
using WebApiHacoupian.ViewModel;

namespace WebApiHacoupian.Controllers
{
    [EnableCors("myPolicy"), Route("api/[controller]/[action]")]
    [ApiController]
    //[Authorize]
    public class ProductOrderController : ControllerBase
    {
        #region varaibles
        private readonly IProductionOrder _productionOrder;
        private readonly IProductionOrderFinishedGoodProducts _productionOrderFinishedGoodProducts;
        private readonly IProductionOrderRawMaterialProducts _productionOrderRawMaterialProducts;
        private readonly IProductionOrderRawMaterialProductsDetails _productionOrderRawMaterialProductsDetails;
        private readonly IProductionOrderTracking _productionOrderTracking;
        private readonly IRawMaterialProduct _rawMaterialProduct;
        private readonly IFinishedGoodProduct _finishedGoodProduct;
        private readonly IProductionOrderMoreInfo _productionOrderMoreInfo;
        private readonly ICodingPatternValue _codingPatternValue;
        private readonly ICodingPatternValueType _codingPatternValueType;
        #endregion

        public ProductOrderController(
            IProductionOrder productionOrder,
            IProductionOrderFinishedGoodProducts productionOrderFinishedGoodProducts,
            IProductionOrderRawMaterialProducts productionOrderRawMaterialProducts,
            IProductionOrderRawMaterialProductsDetails productionOrderRawMaterialProductsDetails,
            IProductionOrderTracking productionOrderTracking,
            IRawMaterialProduct rawMaterialProduct,
            IFinishedGoodProduct finishedGoodProduct,
            IProductionOrderMoreInfo productionOrderMoreInfo,
            ICodingPatternValue codingPatternValue,
            ICodingPatternValueType codingPatternValueType)
        {
            _productionOrder = productionOrder;
            _productionOrderFinishedGoodProducts = productionOrderFinishedGoodProducts;
            _productionOrderRawMaterialProducts = productionOrderRawMaterialProducts;
            _productionOrderRawMaterialProductsDetails = productionOrderRawMaterialProductsDetails;
            _productionOrderTracking = productionOrderTracking;
            _rawMaterialProduct = rawMaterialProduct;
            _finishedGoodProduct = finishedGoodProduct;
            _productionOrderMoreInfo = productionOrderMoreInfo;
            _codingPatternValue = codingPatternValue;
            _codingPatternValueType = codingPatternValueType;
        }

        [HttpPost]
        public IActionResult Get([FromBody] ProductOrderRequstModel OrderNumber)
        {
            if (ModelState.IsValid)
            {
                var productionOrder = _productionOrder.productionOrder(OrderNumber.Number);
                if (productionOrder.Result != null)
                {
                    var orderRawMaterialPro = _productionOrderRawMaterialProducts.productionOrderRawMaterialProducts(productionOrder.Result.Id);
                    var productOrderView = new ProductionOrderViewModel();
                    var lstProductOrder = new List<ProductionOrderList>();
                    var lstOrderModel = new List<OrderSizeCount>();
                    var clothMarkName = "";
                    DateTime dateOrder;
                    var productType = "";
                    double allMeasure = 0.0;

                    foreach (var ProDetail in orderRawMaterialPro.Result)
                    {
                        lstOrderModel.Clear();
                        long count = 0;
                        string product_Code = "";
                        var RawMaterialProductsDetail = _productionOrderRawMaterialProductsDetails.GetProductionOrderRawMaterialProductsDetails(ProDetail.Id);

                        //loop for get detail Orders
                        foreach (var item in RawMaterialProductsDetail.Result)
                        {
                            var orderFinishedGoodProduct = _productionOrderFinishedGoodProducts.GetProductionOrderFinishedGoodProducts(item.TblProductionOrderFinishedGoodProductsId).Result;

                            var finishedGoodProduct = _finishedGoodProduct.GetFinishedGoodProduct(orderFinishedGoodProduct.TblFinishedGoodProductId).Result;
                            lstOrderModel.Add(new OrderSizeCount
                            {
                                Header_Code = finishedGoodProduct.Code,
                                Size = finishedGoodProduct.Code.Substring(7, 2),
                                Order_Count = orderFinishedGoodProduct.OrderCount,
                                Product_count = orderFinishedGoodProduct.ProductionCount
                            });
                            //Production Type Model exp:کت شلوار
                            productType = finishedGoodProduct.Name;
                            //Substring Order Barcode and cut size from code exp:0121006--490
                            product_Code = SubstringOrderCode(lstOrderModel);
                        }
                        //sum order count and product count for all count orders
                        count = lstOrderModel.Sum(o => o.Order_Count) + lstOrderModel.Sum(o => o.Product_count);
                        //Get Mark Name and Production Barcode
                        var rawMaterialProduct = _rawMaterialProduct.GetRawMaterialProduct(ProDetail.TblRawMaterialProductId).Result;
                        //Get Mark/Code Company Cloth
                        clothMarkName = rawMaterialProduct.Name;
                        //Fill List of Orders
                        lstProductOrder.Add(new ProductionOrderList
                        {
                            Measure = ProDetail.Count,
                            Count = count,
                            Cloth_Code = rawMaterialProduct.Code,
                            Product_Code = product_Code,
                            Orders = lstOrderModel
                        });
                    }

                    dateOrder = _productionOrderTracking.productionOrderTrackings(productionOrder.Result.Id).Result.IssueDateTime;
                    allMeasure = (double)lstProductOrder.Sum(p => p.Measure);

                    var moreInfos = PatternValueTypes(productionOrder.Result.Id);
                    var kalite = moreInfos.LastOrDefault(m => m.TblCodingPatternKeyId == 17).Name;
                    var derap = moreInfos.LastOrDefault(m => m.TblCodingPatternKeyId == 13).Name;
                    var cloth = moreInfos.LastOrDefault(m => m.TblCodingPatternKeyId == 12).Name;

                    productOrderView = new ProductionOrderViewModel
                    {
                        productType = productType,
                        SumMeasure = allMeasure,
                        SumOrder = lstProductOrder.Sum(o => o.Count),
                        DateOrder = dateOrder,
                        Mark = clothMarkName,
                        ProductionOrders = lstProductOrder,
                        Explation = productionOrder.Result.Explanation,
                        Kalite = kalite,
                        Derap = derap
                    };
                    return Ok(productOrderView);
                }
                else
                    return NotFound();
            }
            else
                return BadRequest();
        }
        /// <summary>
        /// Get Patterns(Color,Model,Size,...) from productionOrderId
        /// </summary>
        /// <param name="productionOrderId"></param>
        /// <returns></returns>
        private List<TblCodingPatternValueType> PatternValueTypes(long productionOrderId)
        {
            var orderMoreInfos = _productionOrderMoreInfo.GetProductionOrderMoreInfos(productionOrderId);
            var codingPatternValues = _codingPatternValue.GetCodingPatternValues(orderMoreInfos.Result.Select(m => m.TblCodingPatternValueId).ToList()).Result;
            var codingPatternValueTypes = _codingPatternValueType.GetPatternValueTypes(codingPatternValues.Select(m => m.TblCodingPatternValueTypeId).ToList()).Result;

            return codingPatternValueTypes.ToList();
        }
        /// <summary>
        /// Change Order Code and cut size from Code. exp:012100346490 To 0121003--490
        /// </summary>
        /// <param name="lstOrderModel"></param>
        /// <returns></returns>
        private static string SubstringOrderCode(List<OrderSizeCount> lstOrderModel)
        {
            return lstOrderModel.LastOrDefault().Header_Code.Substring(0, 7) + "--" + lstOrderModel.LastOrDefault().Header_Code.Substring(9);
        }
    }
}
