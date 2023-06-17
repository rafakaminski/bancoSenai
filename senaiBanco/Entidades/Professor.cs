using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace senaiBanco.Entidades
{
    public class Professor : BaseEntitiy
    {
        [MaxLength(60), Required]
        public string Nome { get; set; }


        public Classe Classe { get; set; }  

        public Escola Escola { get; set; }

        public long EscolaId { get; set; }

    }
}
