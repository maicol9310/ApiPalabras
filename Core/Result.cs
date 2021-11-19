using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Core
{
    public class Result
    {
        public async Task<string> GetResultado(string linea)
        {
            IEnumerableDelimiters enu = new IEnumerableDelimiters();
            IEnumerable<string> newpalabras = enu.ListaPalabras(linea.ToLower());
            List<string> asList = newpalabras.ToList();

            var agrupacion = asList.GroupBy(x => x)
                 .Select(g => new { Palabra = g.Key, Recurrencia = g.Count() }).ToList();

            string result = JsonSerializer.Serialize(agrupacion);

            return await Task.FromResult(result);
        }
    }
}
