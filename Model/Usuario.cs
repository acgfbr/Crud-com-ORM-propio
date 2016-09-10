using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Util;

namespace Model
{
    public class Usuario
    {
        [Display(Name = "Código", Order = 1)]
        public int id { get; set; }
        [Display(Name = "Nome", Order = 2)]
        public string nome { get; set; }
        [Display(Name = "Email", Order = 3)]
        public string email { get; set; }
        [Display(Name = "Usuário", Order = 4)]
        public string usuario { get; set; }
        [Display(Name = "Senha", Order = 5)]
        public string senha { get; set; }
        [Display(Name = "Ativo?", Order = 6)]
        [ToneField(ToneAttribute.Check)]
        public bool ativo { get; set; }
    }
}
