using Investment_Portfolio.Models;
using Investment_Portfolio.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Investment_Portfolio.Controllers.V1
{
    [Route("api/account")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountService _accountService;
        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        /// <summary>
        /// Register a User
        /// </summary>
        /// <remarks>
        /// Sample request:
        /// 
        /// 
        ///     POST api/account/register
        ///     {    
        ///         "firstName": "Mike",
        ///         "lastName": "Andrew",
        ///         "email": "mikeandrew@gmail.com",
        ///         "dateOfBirth": "2023-01-09",
        ///         "country": "US",
        ///         "password": "Test@1234",
        ///         "confirmPassword": "Test@1234"
        ///     }
        /// </remarks>
        /// <param name="userRegistrationDto"></param>
        /// <returns></returns>
        [HttpPost("register")]
        [Produces("application/json")]
        public async Task<IActionResult> RegisterUser([FromBody] UserRegistrationDto userRegistrationDto)
        {
            await _accountService.RegisterUserAsync(userRegistrationDto);


            return Ok();
        }
       
    }
}
