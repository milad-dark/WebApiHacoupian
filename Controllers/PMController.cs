using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using WebApiHacoupian.Interfaces;
using WebApiHacoupian.ViewModel;

namespace WebApiHacoupian.Controllers
{
    [EnableCors("myPolicy"), Route("api/[controller]/[action]")]
    [ApiController]
    public class PMController : ControllerBase
    {
        #region Varaible
        private readonly IRawMaterialProduct _rawMaterialProduct;
        private readonly IRawMaterialStockSheetItem _rawMaterialStockSheetItem;
        private readonly ILogger<SaleController> _logger;
        #endregion
        public PMController(IRawMaterialProduct rawMaterialProduct, IRawMaterialStockSheetItem rawMaterialStockSheetItem, ILogger<SaleController> logger)
        {
            _rawMaterialProduct = rawMaterialProduct;
            _rawMaterialStockSheetItem = rawMaterialStockSheetItem;
            _logger = logger;
        }

        [HttpPost]
        public async Task<IActionResult> GetMatrialPrice([FromBody] ProductViewModel productViewModel)
        {
            if (string.IsNullOrEmpty(productViewModel.barcode) || productViewModel.barcode.Length != 11)
                return BadRequest("بارکد را 11 رقمی وارد کنید");

            var rawProduct = await _rawMaterialProduct.GetRawMaterialProductByCode(productViewModel.barcode);
            if(rawProduct == null) return NotFound();

            var rawMaterial = await _rawMaterialStockSheetItem.GetLastPriceRawProduct(rawProduct.Id);

            return Ok(new { name= rawProduct.Name, price = rawMaterial.Price });
        }
    }
}
