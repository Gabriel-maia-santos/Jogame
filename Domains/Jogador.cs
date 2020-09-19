using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Jogame.Domains {
    public class Jogador {
        [Key]
        public Guid Id { get; set; }
        public string Name {get; set;}
        public string Email {get; set;}
        public int Senha {get; set;}
        public DateTime DataNasc {get; set;}

        public Jogador() {
            Id = Guid.NewGuid();
        }
    }
}
