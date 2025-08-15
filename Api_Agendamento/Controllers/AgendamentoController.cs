using Microsoft.AspNetCore.Mvc;
using Api_Agendamento.Controllers;
using Api_Agendamento.Models;
using Api_Agendamento.Interfaces;
using Api_Agendamento.DTOs;

namespace Api_Agendamento.Controllers
{
    [Route("v1/api/[controller]")]
    [ApiController]
    public class AgendamentoController : ControllerBase
    {
        private readonly IAgendamentoService _agendamentoService;

        public AgendamentoController(IAgendamentoService agendamentoService)
        {
            _agendamentoService = agendamentoService;
        }

        [HttpPost("create")]
        public async Task<IActionResult> CriarAgendamento(AgendamentoDTO agendamento)
        {
            var agendamentoCriado = await _agendamentoService.CriarAgendamentoAsync(agendamento);
            return Ok(agendamentoCriado);
        }

        [HttpPut("alterar/{id}")]
        public async Task<IActionResult> AlterarAgendamento(int id, [FromBody] AgendamentoDTO agendamento)
        {
            var idAgendamento = await _agendamentoService.BuscarAgendamentoAsync(id);

            if (idAgendamento == null)
                return Ok(new { message = "Agendamento não foi encontrado" });

            var agendamentoAlterado = await _agendamentoService.AlterarAgendamentoAsync(agendamento, idAgendamento);
            return Ok(agendamentoAlterado);
        }

        [HttpDelete("excluir")]
        public async Task<IActionResult> ExcluirAgendamento()
        {
            var tokenAgendamento = User.FindFirst("AgendamentoId")?.Value;

            if (tokenAgendamento == null)
                return Unauthorized(new { message = "Agendamento não encontrado" });

            int agendamentoId = int.Parse(tokenAgendamento);

            bool sucesso = await _agendamentoService.ExcluirAgendamentoAsync(agendamentoId);

            if (sucesso)
                return Ok(new { message = "Agendamento foi deletado com sucesso" });
            else
                return BadRequest(new { message = "Agendamento deletado com sucesso" });
        }

        [HttpGet("obterTodos")]
        public async Task<IActionResult> ObterAgendamento()
        {
            var listaAgendamento = await _agendamentoService.ObterAgendamentosAsync();

            return Ok(listaAgendamento);
        }

        [HttpGet("buscarAgendamento")]
        public async Task<IActionResult> BuscarAgendamento(int idAgendamento)
        {
            var agendamentoId = await _agendamentoService.BuscarAgendamentoAsync(idAgendamento);

            return Ok(agendamentoId);
        }
    }
}
