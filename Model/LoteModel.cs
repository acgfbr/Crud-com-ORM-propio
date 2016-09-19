using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class LoteModel
    {
        public int codigo_lote { get; set; }
        public string nro_lote { get; set; }
        public double qtde { get; set; }
        public DateTime data_vencimento { get; set; }
    }
}
