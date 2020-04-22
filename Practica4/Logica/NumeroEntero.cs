using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class NumeroEntero
    {
        public decimal Numero { get; set; }

        public static NumeroEntero operator / (NumeroEntero numero1, NumeroEntero numero2)
        {
            NumeroEntero resultadodivision = new NumeroEntero();
            resultadodivision.Numero = Convert.ToDecimal(numero1.Numero / numero2.Numero);
            return resultadodivision;

        }
    }
}
