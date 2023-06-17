using senaiBanco.Contexto;
using senaiBanco.Entidades;

namespace senaiBanco
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var contexto = new SenaiContext();

            //var escola = contexto.Escola.Where(c => c.Nome == "Bertaso").FirstOrDefault();

            var professor = contexto.Professor.Where(c => c.Nome.Contains("Vagner")).FirstOrDefault();

            var escola = contexto.Escola.Where(c => c.Nome == "Senai").FirstOrDefault();
            escola.Nome = "Senai Chapeco";
            contexto.Update(escola);
            contexto.SaveChanges();



            var classe = new Classe()
            {
                Serie = Entidades.Enums.SerieEnum.quinta,
                EscolaId = escola.Id,
                ProfessorId = professor.Id
            };


            //var professor = new Professor()
            //{
            //    Nome = "Vagner",
            //    EscolaId = escola.Id
            //};




            //    var escola = new Escola()
            //    {
            //        Nome = "Bertaso",
            //        Endereco = new Endereco()
            //        {
            //            Rua = "Margaridas",
            //            Bairro = "São cristovao",
            //            Estado = "SC",
            //            Cidade = "Chapeco"

            //        }
            //    };



            //contexto.Escola.Add(escola);
            //contexto.Classe.Add(classe);
            //contexto.SaveChanges();

        }
    }
}