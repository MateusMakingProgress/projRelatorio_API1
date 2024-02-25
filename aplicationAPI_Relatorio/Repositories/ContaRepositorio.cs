using aplicationAPI_Relatorio.Models;
using aplicationAPI_Relatorio.Repositories.Interfaces;

namespace aplicationAPI_Relatorio.Repositories
{
    public class ContaRepositorio : IContaRepositorio
    {
        public Task<ContaModel> Adicionar(ContaModel conta)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Apagar(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<ContaModel> Atualizar(ContaModel conta, Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<ContaModel> BuscarPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ContaModel>> BuscarTodasContas()
        {
            throw new NotImplementedException();
        }
    }
}
