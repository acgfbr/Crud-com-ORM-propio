using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;

namespace BLL
{
    public class MarcaBLL
    {
        public bool SaveOrUpdate(MarcaModel marca)
        {
            return new BaseDAL().SaveOrUpdate(marca, marca.codigo == 0, "marca");
        }

        public bool Delete(int codigo)
        {
            return new BaseDAL().Delete("marca", codigo);
        }

        public List<MarcaModel> Get(string like)
        {
            var query = "SELECT * FROM marca ";
            if (!string.IsNullOrEmpty(like))
            {
                query += "where descricao like '%#REPLACE#%'";
                query = query.Replace("#REPLACE#", like);
            }

            return new BaseDAL().GetGeneric<MarcaModel>(query);
        }
    }
}
