﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace senaiBanco.Entidades
{
    public class Endereco : BaseEntitiy
    {

        [MaxLength(80)]
        public string Rua { get; set; }

        [MaxLength(50)]
        public string Bairro { get; set; }

        [MaxLength(60)]
        public string Cidade { get; set; }

        [MaxLength(60)]
        public string Estado { get; set; }

        [MaxLength(2)]
        public int Numero { get; set; }


        public long EscolaId { get; set; }  
        public Escola Escola { get; set; }


    }

}
