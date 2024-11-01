using System.ComponentModel.DataAnnotations.Schema;

namespace Entidade
{
    [Table("Estudantes")]
    public class Estudante
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public double Altura { get; set; }
        public double Peso { get; set; }
    }
}