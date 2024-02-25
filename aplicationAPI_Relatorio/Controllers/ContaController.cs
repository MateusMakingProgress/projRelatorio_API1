using aplicationAPI_Relatorio.Models;
using aplicationAPI_Relatorio.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace aplicationAPI_Relatorio.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContaController : ControllerBase
    {
        private readonly IContaRepositorio _contaRepositorio;
        public ContaController(IContaRepositorio contaRepositorio)
        {
            _contaRepositorio = contaRepositorio;
        }
        [HttpGet]
        public async Task<ActionResult<List<ContaModel>>> ListarContas()
        {
            List<ContaModel> contas = await _contaRepositorio.BuscarTodasContas();
            return Ok(contas);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<List<ContaModel>>> BuscarContaPorId(Guid id)
        {
            ContaModel conta = await _contaRepositorio.BuscarPorId(id);
            return Ok(conta);
        }
        [HttpPut("{id}")]
        public async Task<ActionResult<ContaModel>> Atualizar([FromBody] ContaModel conta, Guid id)
        {
            conta.Id = id;
            ContaModel contaPorId = await _contaRepositorio.BuscarPorId(id);
            await _contaRepositorio.Atualizar(conta, id);
            return Ok(contaPorId);
        }
        [HttpPost]
        public async Task<ActionResult<ContaModel>> Cadastrar([FromBody] ContaModel contaModel)
        {
            ContaModel conta = await _contaRepositorio.Adicionar(contaModel);
            return Ok(conta);
        }
        [HttpDelete]
        public async Task<ActionResult<ContaModel>> Apagar(Guid id)
        {
            await _contaRepositorio.Apagar(id);
            return Ok();
        }
    }
}
