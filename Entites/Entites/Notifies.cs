using System.ComponentModel.DataAnnotations.Schema;

namespace Entites.Entites
{
    public class Notifies
    {
        public Notifies()
        {
            Notitycoes = new List<Notifies>();
        }

        [NotMapped]
        public String NomePropriedade { get; set; }

        [NotMapped]
        public String Mensagem { get; set; }

        [NotMapped]
        public List<Notifies> Notitycoes { get; set; }

        public bool ValidarPropriedadeString(string valor, String nomePropriedade)
        {
            if (string.IsNullOrWhiteSpace(valor) || string.IsNullOrWhiteSpace(nomePropriedade))
            {
                Notitycoes.Add(new Notifies
                {
                    Mensagem = "Campo Obrigatorio !",
                    NomePropriedade = nomePropriedade
                }) ;

                return false;
            }
            return true;
        }

        public bool ValidarPropriedadeInt(int valor, String nomePropriedade)
        {
            if (valor < 1 || string.IsNullOrWhiteSpace(nomePropriedade))
            {
                Notitycoes.Add(new Notifies
                {
                    Mensagem = "Campo Obrigatorio !",
                    NomePropriedade = nomePropriedade
                });

                return false;
            }
            return true;
        }
    }
}