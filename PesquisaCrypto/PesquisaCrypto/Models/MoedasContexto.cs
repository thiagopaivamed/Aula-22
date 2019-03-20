using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PesquisaCrypto.Models
{
    public class MoedasContexto : DbContext
    {
        public DbSet<Moedas> Moedas { get; set; }

        public MoedasContexto(DbContextOptions<MoedasContexto> opcoes) : base(opcoes)
        {
                
        }

    }
}
