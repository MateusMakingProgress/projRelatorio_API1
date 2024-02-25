﻿using aplicationAPI_Relatorio.Models;

namespace aplicationAPI_Relatorio.Repositories.Interfaces
{
    public interface IUsuarioRepositorio
    {
        Task<List<UsuarioModel>> BuscarTodosUsuarios();
        Task<UsuarioModel> BuscarPorId(Guid id);
        Task<UsuarioModel> Adicionar(UsuarioModel usuario);
        Task<UsuarioModel> Atualizar(UsuarioModel usuario, Guid id);
        Task<bool> Apagar(Guid id);
    }
}
