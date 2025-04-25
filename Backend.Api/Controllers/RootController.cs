using Microsoft.AspNetCore.Mvc;

namespace Backend.Api.Controllers
{
    [ApiController]
    public class RootController
    {
        [HttpGet("/")]
        public string Get()
        {
            return "OK";
        }
    }
}
