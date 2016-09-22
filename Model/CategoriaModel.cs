using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class CategoriaModel
    {
        [Display(Name = "Código", Order = 1)]
        public int codigo { get; set; }
        [Display(Name = "Descrição", Order = 2)]
        public string descricao { get; set; }
    }
}
