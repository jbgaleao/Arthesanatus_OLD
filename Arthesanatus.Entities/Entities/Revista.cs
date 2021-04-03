using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Arthesanatus.Domain.Entities
{
    [Table( "Revista" )]
    public class Revista
    {
        public Revista( )
        {
            Receitas = new List<Receita>();
        }

        [Key]
        public int RevistaID { get; set; }

        public int NumeroEdicao { get; set; }

        public int AnoEdicao { get; set; }

        public Mes MesEdicao { get; set; }

        public string Tema { get; set; }

        public byte[] Foto { get; set; }

        public virtual List<Receita> Receitas { get; set; }

    }
}
