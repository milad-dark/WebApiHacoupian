using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using WebApiHacoupian.Interfaces;
using WebApiHacoupian.ViewModel;

namespace WebApiHacoupian.Controllers
{
    [EnableCors("myPolicy"), Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        #region varaibles
        private readonly ICodingPatternValueType _codingPatternValueType;
        private readonly ILogger<ProductController> _logger;
        #endregion

        public ProductController(ICodingPatternValueType codingPatternValueType, ILogger<ProductController> logger)
        {
            _codingPatternValueType = codingPatternValueType;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromBody] ProductViewModel productViewModel)
        {
            if(string.IsNullOrEmpty(productViewModel.barcode) || productViewModel.barcode.Length != 12)
                return BadRequest("بارکد را 13 رقمی وارد کنید");

            var getType = await _codingPatternValueType.GetPatternValueTypesByCode(productViewModel.barcode.Substring(0, 2));
            var getColor = await _codingPatternValueType.GetPatternValueColorByCode(productViewModel.barcode.Substring(5, 2));

            if (getType != null && getColor != null)
                return Ok(new { name = getType.Name,
                    color = getColor.Name,
                    size = productViewModel.barcode.Substring(7, 2) 
                });

            //System.Net.Http.Json.JsonContent.Create(new { barcode = barcode });
            return NotFound();
        }
    }
}
