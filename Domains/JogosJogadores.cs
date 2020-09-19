using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Jogame.Domains {
    public class JogosJogadores {
        /// <summary>
        /// Criando os Id de Jogador e Jogo utilizando Guid
        /// </summary>
        [Key]
        // Utilizando a FK IdJogo
        public Guid Id { get; set; }
        public Guid IdJogo { get; set;}
        [ForeignKey("IdJogo")]
        public Jogo Jogo { get; set; }

        //Utilizando a FK Id Jogador
        public Guid IdJogador { get; set;}
        [ForeignKey("IdJogador")]
        public Jogador Jogador { get; set; }

        public JogosJogadores() {
            Id = Guid.NewGuid();
        }
    }
}
