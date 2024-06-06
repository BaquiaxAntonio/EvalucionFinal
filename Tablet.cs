namespace BlazorApp1
{
    public class Tablet:Dispositivo
    {
        public string TamañoPantalla {  get; set; }
        public string Soporte { get; set; }

        public Tablet()
        {
            TamañoPantalla = string.Empty;
            Soporte = string.Empty;
        }
    }
}
