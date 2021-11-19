using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContarPalabrasRepetidas.Controllers
{
    [ApiController]
    public class ContarPalabraController : Controller
    {
        [HttpPost]
        [Route("PostPalabras/Palabras")]
        public async Task<string> Post([FromBody] string palabras)
        {
            return ;
        }
    }
}
