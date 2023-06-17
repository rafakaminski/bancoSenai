using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace senaiBanco.Entidades
{
    public class Aluno : BaseEntitiy
    {
        [MaxLength(60), Required]
        public string Nome { get; set; }

        [Required]
        public DateTime Nascimento { get; set; }

        [MaxLength(14), Required]
        public string Cpf { get; set; }


        public Classe Classe { get; set; }

        public long ClasseId { get; set; }


    }
}
