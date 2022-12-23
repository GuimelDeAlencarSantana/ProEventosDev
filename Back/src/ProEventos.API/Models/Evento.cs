using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProEventos.API.Models
{

/// <Explicação de classe Evento>
/// Modelo de geração de Eventos
/// Características
/// </summary>

    public class Evento
    {
        public int EventoID { get; set; }
        public string Local { get; set; }
        public string Data { get; set; }
        public string Tema { get; set; }
        public int QtdPessoas { get; set; }
        public string Lote { get; set; }
        public string ImageURL { get; set; }
    }
}