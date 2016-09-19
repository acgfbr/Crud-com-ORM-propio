using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ProdutoModel
    {
        public int codigo { get; set; }
        public string descricao { get; set; }
        public double valor_custo { get; set; }
        public double valor_venda { get; set; }

        public int codigo_categoria { get; set; }
        public int codigo_marca { get; set; }
        public int codigo_lote { get; set; }
    }
}
