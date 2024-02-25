using aplicationAPI_Relatorio.Models;
using aplicationAPI_Relatorio.Repositories.Interfaces;

namespace aplicationAPI_Relatorio.Repositories
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        public Task<UsuarioModel> Adicionar(UsuarioModel usuario)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Apagar(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<UsuarioModel> Atualizar(UsuarioModel usuario, Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<UsuarioModel> BuscarPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<UsuarioModel>> BuscarTodosUsuarios()
        {
            throw new NotImplementedException();
        }
    }
}
