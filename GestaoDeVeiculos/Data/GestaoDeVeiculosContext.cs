using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GestaoDeVeiculos.Models;

namespace GestaoDeVeiculos.Data
{
    public class GestaoDeVeiculosContext : DbContext
    {
        public GestaoDeVeiculosContext (DbContextOptions<GestaoDeVeiculosContext> options)
            : base(options)
        {
        }

        public DbSet<GestaoDeVeiculos.Models.Veiculo> Veiculo { get; set; }
    }
}
