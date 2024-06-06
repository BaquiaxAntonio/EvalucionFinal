namespace BlazorApp1
{
    public class Dispositivo
    {
        public string NumSerie { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set;}

        public Dispositivo()
        {
            NumSerie = string.Empty;
            Marca = string.Empty;
            Modelo = string.Empty; 
        }
    }
}
