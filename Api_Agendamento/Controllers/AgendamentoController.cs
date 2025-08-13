using Microsoft.AspNetCore.Mvc;
using Api_Agendamento.Controllers;
using Api_Agendamento.Models;
using Api_Agendamento.Interfaces;
using Api_Agendamento.DTOs;

namespace Api_Agendamento.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AgendamentoController : ControllerBase
    {
        private readonly IAgendamentoService _agendamentoService;

        public AgendamentoController(IAgendamentoService agendamentoService)
        {
            _agendamentoService = agendamentoService;
        }
    }
}
