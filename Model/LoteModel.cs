using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class LoteModel
    {
        [Display(Name = "Código", Order = 1)]
        public int codigo { get; set; }
        [Display(Name = "Número Lote", Order = 2)]
        public string nro_lote { get; set; }
        [Display(Name = "Quantidade", Order = 3)]
        public double qtde { get; set; }
        [Display(Name = "Data Vencimento", Order = 4)]
        public DateTime data_vencimento { get; set; }
    }
}
