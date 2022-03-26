using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GestaoDeVeiculos.Models;

namespace GestaoDeVeiculos.Data
{
    // Classe Context é responsável pela comunicação com o Banco de Dados
    public class GestaoDeVeiculosContext : DbContext
    {
        public GestaoDeVeiculosContext (DbContextOptions<GestaoDeVeiculosContext> options)
            : base(options)
        {
        }
        // Declaração da tabela Veiculo no banco de dados
        public DbSet<GestaoDeVeiculos.Models.Veiculo> Veiculo { get; set; }
    }
}
