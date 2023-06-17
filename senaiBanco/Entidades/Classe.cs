using senaiBanco.Entidades.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace senaiBanco.Entidades
{
    public class Classe : BaseEntitiy
    {

        public SerieEnum Serie { get; set; }


        public Escola Escola { get; set; }

        public Professor Professor { get; set; }

        public List<Aluno> Alunos { get; set; }

        public long EscolaId { get; set; }

        public long ProfessorId { get; set; }

    }
}
