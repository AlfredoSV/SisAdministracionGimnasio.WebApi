using Microsoft.AspNetCore.Mvc;
using SisAdministracionGimnasio.WebApi.Filtros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SisAdministracionGimnasio.WebApi.Controllers
{   
    [Route("api/[controller]")]
    [ApiController]   
    [FilterAuthorize]
    public class ClientesController : Controller
    {
        [HttpPost("[action]")]
        public IActionResult Index()
        {
            return Ok();
        }
    }
}
