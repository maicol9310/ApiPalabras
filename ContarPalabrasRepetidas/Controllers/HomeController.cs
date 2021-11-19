using Core;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContarPalabrasRepetidas.Controllers
{
    public class Texto {public string palabras { get; set; }}

    [ApiController]
    [Route("api/[controller]")]
    public class HomeController : ControllerBase
    {

        [HttpPost]
        [Route("Palabras")]
        public async Task<IActionResult> PalabrasPost([FromBody] Texto texto)
        {
            try
            {
                if (!String.IsNullOrEmpty(texto.palabras))
                {
                    Result ed = new Result();
                    var result = await ed.GetResultado(texto.palabras);
                    return Ok(result);
                }
                else
                {
                    return Ok("Digite palabras"); ;
                }
            }
            catch(Exception e){

                throw e;
            }
        }
    }
}
