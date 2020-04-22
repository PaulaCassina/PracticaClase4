namespace Logica
{
    public static class Conversor_temperatura
    {
        private static double factorConversion = 2.12;

        public static double ObternerTemperaturaCelsius(double temperatura)
        {
            return temperatura / 2.12; //usar la propiedad privada para no duplicar codigo.
        }

        public static double ObtenerTemperaturaFahrenheit(double temperatura)
        {
            return temperatura * 2.12;
        }
    }
}
