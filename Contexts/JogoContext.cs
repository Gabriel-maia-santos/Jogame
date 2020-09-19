using Jogame.Domains;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jogame.Contexts {
    public class JogoContext : DbContext {
        public DbSet<Jogo> Jogo { get; set; }
        public DbSet<Jogador> Jogador { get; set; }
        public DbSet<JogosJogadores> JogosJogadores { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer(@"Data Source=.\SqlExpress; Initial Catalog=Db_Jogame; user id=sa; password=sa132");
            base.OnConfiguring(optionsBuilder);
        }
    }
}