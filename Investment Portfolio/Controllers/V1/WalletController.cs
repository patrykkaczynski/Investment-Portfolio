using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Investment_Portfolio.Controllers.V1
{
    
    [ApiVersion("1.0")]
    [Route("api/wallet")]
    [ApiController]
    [Authorize]
    public class WalletController : ControllerBase
    {
        /// <summary>
        /// Gets the list of elements
        /// </summary>
        [HttpGet]
        public ActionResult<string> GetAll()
        {
            var elements = new List<string>() { "test", "test1", "test2" };
            return Ok(elements);
        }

    }
}
