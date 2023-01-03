using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Investment_Portfolio.Controllers.V1
{
    [ApiVersion("1.0")]
    [Route("api/wallet")]
    [ApiController]
    public class WalletController : ControllerBase
    {
        [HttpGet]
        public ActionResult<string> GetAll([FromBody])
        {
            var elements = new List<string>() { "test", "test1", "test2" };
            return Ok(elements);
        }


    }
}
