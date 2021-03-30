using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arthesanatus.Model.Entity
{
    public class Revista
    {
        public Revista()
        {

        }

        public int RevistaID { get; set; }
        public int NumeroEdicao { get; set; }
        public Mes MesEdicao { get; set; }
        public int AnoEdicao { get; set; }
        public string Tema { get; set; }
        public byte[] FotoCpa { get; set; }
        public virtual ICollection<Receita> ColecaoReceitas { get; set; }
    }
}
