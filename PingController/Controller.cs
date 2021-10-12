using System.Reflection;
using Microsoft.AspNetCore.Mvc;

namespace PingController
{
    [ApiController]
    public class Controller : ControllerBase
    {
        [HttpGet("/ping")]
        public ActionResult<PingDto> Ping()
        {
            var assembly = Assembly.GetEntryAssembly();
            return new PingDto
            {
                Name = assembly.GetName().Name,
                Version = assembly.GetCustomAttribute<AssemblyInformationalVersionAttribute>().InformationalVersion
            };
        }
    }
}
