using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Data;
using ProEventos.API.Models;
//dotnet watch run
/// <Explicação geral do arquivo>
/// Arquivo destinado a controlar a seção de Eventos do programa ProEventos
/// Contendo funções como get, post e put...
/// 
/// </summary>

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventosController : ControllerBase
    {
        private readonly DataContext _context;

        public EventosController(DataContext context)
        {
            _context = context;
        }

/// <Request de Get>
/// Parte do código onde está o método get da classe de controlador dos eventos
/// O primeiro deles é caso seja requisitado do BackEnd um Json de todos os eventos e seus dados
/// O segundo é para caso seja requisitado o Json de um evento com uma rota de ID especificado,
/// neste caso, somente os eventos do ID requisitado serão enviados.
/// </summary>

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _context.Eventos;
        }

        [HttpGet("{id}")]
        public Evento GetById(int id)
        {
            return _context.Eventos.FirstOrDefault
            (
                evento => evento.EventoID == id
            );
        }

// Fim do Request do Get

/// <Request do Post>
/// Método da API
/// </summary>

        [HttpPost]
        public string Post()
        {
            return "Exemplo de Post";
        }
// Fim do request do Post

/// <Request do Put>
/// 
/// </summary>

        [HttpPut("{id}")]
        public string Put(int id)
        {
            return $"Exemplo de Put com id = {id}";
        }
// Fim do request do Put

/// <Request do Delete>
/// 
/// </summary>

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return $"Exemplo de Delete  com id = {id}";
        }

// Fim do request do Delete    

    }
}
