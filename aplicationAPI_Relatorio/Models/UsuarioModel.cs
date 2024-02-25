namespace aplicationAPI_Relatorio.Models
{
    public class UsuarioModel : Entity
    {
        public string? NomeUser { get; set; }
        public DateTime? DtaNascimento { get; set; }
        public string? Email { get; set; }
        public int CpfUser { get; set; }

    }
}
