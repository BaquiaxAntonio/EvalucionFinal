namespace BlazorApp1
{
    public class Laptop:Dispositivo
    {
        public string MemoriaRam { get; set; }
        public string Almacenamiento { get; set; }

        public Laptop()
        {
            MemoriaRam = string.Empty;
            Almacenamiento = string.Empty;
        }

    }
}
