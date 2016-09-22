using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;
using Util;

namespace BLL
{
    public class CategoriaBLL
    {
        public bool SaveOrUpdate(CategoriaModel categoria)
        {
            return new BaseDAL().SaveOrUpdate(categoria, categoria.codigo == 0, "categoria");
        }

        public bool Delete(int codigo)
        {
            return new BaseDAL().Delete("categoria",codigo);
        }

        public List<CategoriaModel> Get(string like)
        {
            var query = "SELECT * FROM categoria ";
            if (!string.IsNullOrEmpty(like))
            {
                query += "where descricao like '%#REPLACE#%'";
                query = query.Replace("#REPLACE#", like);
            }
            
            return new BaseDAL().GetGeneric<CategoriaModel>(query);
        }

        
    }
}
