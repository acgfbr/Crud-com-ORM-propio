using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;

namespace BLL
{
    public class LoteBLL
    {
        public bool SaveOrUpdate(LoteModel lote)
        {
            return new BaseDAL().SaveOrUpdate(lote, lote.codigo == 0, "lote");
        }

        public bool Delete(int codigo)
        {
            return new BaseDAL().Delete("lote", codigo);
        }

        public List<LoteModel> Get(string like)
        {
            var query = "SELECT * FROM lote ";
            if (!string.IsNullOrEmpty(like))
            {
                query += "where nro_lote like '%#REPLACE#%'";
                query = query.Replace("#REPLACE#", like);
            }

            return new BaseDAL().GetGeneric<LoteModel>(query);
        }
    }
}
