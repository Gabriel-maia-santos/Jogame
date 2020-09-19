using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Jogame.Domains {
    public class Jogo {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set;}
        public string Descricao { get; set;}
        public DateTime DataLancamento { get; set;}

        public Jogo() {
            Id = Guid.NewGuid();
        }
    }
}
