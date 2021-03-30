using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arthesanatus.Model.Entity
{
    public class Receita
    {
        public int ReceitaID { get; set; }
        public string Descricao { get; set; }
        public byte[] FotoReceita { get; set; }
        public virtual Revista Revista { get; set; }

    }
}
