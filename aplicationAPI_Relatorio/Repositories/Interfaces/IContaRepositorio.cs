using aplicationAPI_Relatorio.Models;

namespace aplicationAPI_Relatorio.Repositories.Interfaces
{
    public interface IContaRepositorio
    {
        Task<List<ContaModel>> BuscarTodasContas();
        Task<ContaModel> BuscarPorId(Guid id);
        Task<ContaModel> Adicionar(ContaModel conta);
        Task<ContaModel> Atualizar(ContaModel conta, Guid id);
        Task<bool> Apagar(Guid id);

    }
}
