using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Logica
{
    public static class Extensiones
    {
        public static int RetornarCantidadPalabras(this string cadenastring)
        {
            string[] arraypalabras = cadenastring.Split(' ');
            return arraypalabras.Count();
            
        }

        public static int RetornarCantidadPalabras(this string cadenastring, char separador)
        {
            string[] arraypalabras = cadenastring.Split(separador);
            return arraypalabras.Count();
        }

        public static decimal ObtenerMinutosDiferenciaFechas(this DateTime fechamayor, DateTime fechamenor)
        {
            TimeSpan diferenciaFechas = fechamayor - fechamenor;
            double diferenciaensegundos = diferenciaFechas.TotalSeconds;
            return Convert.ToDecimal(diferenciaensegundos/60);
        }

        public static decimal ObtenerPromedio(this List<int> listaenteros)
        {
            decimal total =Convert.ToDecimal(listaenteros.Average());
            return total;
        }

        public static int ObtenerMultiplicacionParesImpares(this List<int> listaenteros)
        {
            int multiplicacion = (listaenteros.FindAll(x => x % 2 == 0).Sum())*((listaenteros.First(x=>x%2!=0)*2)+((listaenteros.FindAll(x=>x%2!=0).Sum()*-1)));

            return multiplicacion;
        }

        public static DateTime ObtenerFechaAPartirString (this string fecha)
        {
            DateTime fechaobtenida = new DateTime();
            try
            {
               fechaobtenida = DateTime.Parse(fecha);
            }
            catch(Exception)
            {
                fechaobtenida = DateTime.MinValue;
            }
            return fechaobtenida;
        }

        public static string InvertirString(this string frase)
        {
            return frase.Reverse().ToString();

        }

        public static string ConcatenarArrayString(this string [] arraystring, char separador)
        {
            return string.Join(separador.ToString(), arraystring);
        }

        public static bool EsMail (this string cadena)
        {
            public 
        }
    }
}
