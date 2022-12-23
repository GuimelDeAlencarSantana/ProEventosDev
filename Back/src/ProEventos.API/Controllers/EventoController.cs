using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
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
    public class EventoController : ControllerBase
    {
        /// <Explicação da classe Evento>
        /// Criação e instanciação da classe evento de forma explicita para fins de 
        /// teste e desinvolvimento
        /// </summary>
        public IEnumerable<Evento> _evento = new Evento[]
            {
              new Evento()
              {
                EventoID = 1,
                Local = "Cuiabá",
                Data = DateTime.Now.AddDays(2).ToString("dd/mm/yyyy") ,
                Tema = "Programação",
                QtdPessoas = 250,
                Lote = "1º lote",
                ImageURL = "foto.png"
              }, 
              new Evento()
              {
                EventoID = 2,
                Local = "São Paulo",
                Data = DateTime.Now.AddDays(2).ToString("dd/mm/yyyy") ,
                Tema = "Culinaria",
                QtdPessoas = 150,
                Lote = "3º lote",
                ImageURL = "Outra_Foto.png"
              }
            };

        public EventoController()
        {
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
            return _evento;
        }

        [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id)
        {
            return _evento.Where(evento => evento.EventoID == id);
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
