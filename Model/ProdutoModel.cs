using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Util;

namespace Model
{
    public class ProdutoModel
    {
        [Display(Name = "Código", Order = 1)]
        public int codigo { get; set; }
        [Display(Name = "Nome Produto", Order = 2)]
        public string descricao { get; set; }
        [Display(Name = "Valor de Custo", Order = 3)]
        public double valor_custo { get; set; }
        [Display(Name = "Valor de Venda", Order = 4)]
        public double valor_venda { get; set; }

        public int codigo_categoria { get; set; }

        [VARIAVEL_IGNORADA_BASE_DAL]
        [Display(Name = "Categoria", Order = 5)]
        public string nome_categoria { get; set; }
        
        public int codigo_marca { get; set; }

        [VARIAVEL_IGNORADA_BASE_DAL]
        [Display(Name = "Marca", Order = 6)]
        public string nome_marca { get; set; }

        public int codigo_lote { get; set; }

        [VARIAVEL_IGNORADA_BASE_DAL]
        [Display(Name = "Lote", Order = 7)]
        public string nome_lote { get; set; }
    }
}
