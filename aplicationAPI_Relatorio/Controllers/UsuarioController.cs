using aplicationAPI_Relatorio.Models;
using aplicationAPI_Relatorio.Repositories;
using aplicationAPI_Relatorio.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace aplicationAPI_Relatorio.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;
        public UsuarioController(IUsuarioRepositorio usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
        }
        [HttpGet]
        public async Task<ActionResult<List<UsuarioModel>>> ListarUsuarios()
        {
            List<UsuarioModel> usuario = await _usuarioRepositorio.BuscarTodosUsuarios();
            return Ok(usuario);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<List<UsuarioModel>>> BuscarUsuarioPorId(Guid id)
        {
            UsuarioModel usuario = await _usuarioRepositorio.BuscarPorId(id);
            return Ok(usuario);
        }
        [HttpPut("{id}")]
        public async Task<ActionResult<UsuarioModel>> Atualizar([FromBody] UsuarioModel usuario, Guid id)
        {
            usuario.Id = id;
            UsuarioModel usuarioPorId = await _usuarioRepositorio.BuscarPorId(id);
            await _usuarioRepositorio.Atualizar(usuario, id);
            return Ok(usuarioPorId);
        }
        [HttpPost]
        public async Task<ActionResult<UsuarioModel>> Cadastrar([FromBody] UsuarioModel usuarioModel)
        {
            UsuarioModel usuario = await _usuarioRepositorio.Adicionar(usuarioModel);
            return Ok(usuario);
        }
        [HttpDelete]
        public async Task<ActionResult<UsuarioModel>> Apagar(Guid id)
        {
            await _usuarioRepositorio.Apagar(id);
            return Ok();
        }
    }
}
