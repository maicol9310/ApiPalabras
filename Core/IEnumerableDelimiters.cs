using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core
{
    class IEnumerableDelimiters
    {
        public IEnumerable<string> ListaPalabras(string palabras)
        {
            return palabras.Split(' ', '.', ',').Where(st => !st.Equals(""));
        }
    }
}
