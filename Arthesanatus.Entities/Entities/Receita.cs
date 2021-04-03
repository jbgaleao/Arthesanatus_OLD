using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Arthesanatus.Domain.Entities
{
    [Table( "Receita" )]
    public class Receita
    {
        [Key]
        public int ReceitaId { get; set; }

        public string Nome { get; set; }

        public string Descricao { get; set; }

        [ForeignKey( "Revista" )]
        public int RevistaId { get; set; }

        public virtual Revista Revista { get; set; }

    }
}
