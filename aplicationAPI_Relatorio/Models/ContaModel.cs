namespace aplicationAPI_Relatorio.Models
{
    public class ContaModel : Entity
    {
        public int? CodBarras { get; set; }
        public string? Vencimento {  get; set; }
        public string? TitularConta { get; set; }
        public string? PrestadorServico { get; set; }
        public int? Valor {  get; set; }
        public string? Banco {  get; set; }
    }
}
