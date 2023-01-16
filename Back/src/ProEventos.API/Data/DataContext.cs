using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProEventos.API.Models;

/// <função>
/// Será uma classe, usada como Context para a criação da 
/// tabela de eventos.
/// 
/// (DbContext - DataBaseContext - Contexto de base de dados)
/// </função>

namespace ProEventos.API.Data
{
    /// <summary>
    /// O contexto de dados da api herda os métodos e atributos da classe
    /// DbContext -> DataBaseContext do EntityFrameworkCore
    /// </summary>
    public class DataContext : DbContext 
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) {}
     public DbSet<Evento> Eventos { get; set; }   
    }
}