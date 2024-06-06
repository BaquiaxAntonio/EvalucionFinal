namespace BlazorApp1
{
    public class Smartphone: Dispositivo
    {
        public string SistemaOperativo { get; set; }
        public string NumCamaras { get; set; }

        public Smartphone()
        {
            SistemaOperativo=string.Empty;
            NumCamaras=string.Empty;
        }
    }
}
