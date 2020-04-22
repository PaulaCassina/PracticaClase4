namespace Logica
{
    public static class Conversor_temperatura
    {
        public static double ObternerTemperaturaCelsius(double temperatura)
        {
            return temperatura / 2.12;
        }

        public static double ObtenerTemperaturaFahrenheit(double temperatura)
        {
            return temperatura * 2.12;
        }
    }
}
