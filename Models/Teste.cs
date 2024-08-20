namespace api_csharp.Models
{
    public class Teste
    {
        public string Nome { get; set; }

        public int TemperaturaC { get; set; }

        public int Temperatura => 32 + (int)(TemperaturaC / 0.5556);

        public string? Sobrenome { get; set; }
    }
}
