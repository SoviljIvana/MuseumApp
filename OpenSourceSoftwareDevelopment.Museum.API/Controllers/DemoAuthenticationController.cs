using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using NSwag.Annotations;
using OpenSourceSoftwareDevelopment.Museum.API.ServiceExtensions;

namespace OpenSourceSoftwareDevelopment.Museum.API.Controllers
{
    [OpenApiIgnore]
    public class DemoAuthenticationController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public DemoAuthenticationController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [Route("/get-token")]
        public IActionResult GenerateToken(string name = "aspnetcore-workshop-demo", bool guest = false, bool user = false, bool superUser = false, bool admin = false)
        {
            var jwt = JwtTokenGenerator
                .Generate(name, guest, user, admin, _configuration["Tokens:Issuer"], _configuration["Tokens:Key"]);

            return Ok(new { token = jwt });
        }
    }
}
