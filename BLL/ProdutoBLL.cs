using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;

namespace BLL
{
    public class ProdutoBLL
    {
        public bool SaveOrUpdate(ProdutoModel produto)
        {
            return new BaseDAL().SaveOrUpdate(produto, produto.codigo == 0, "produto");
        }

        public bool Delete(int codigo)
        {
            return new BaseDAL().Delete("produto", codigo);
        }

        public List<ProdutoModel> Get(string like)
        {
            var query = @"SELECT pro.*, cat.descricao as nome_categoria, ma.descricao as nome_marca, lo.nro_lote as nome_lote FROM produto pro

                            inner join categoria cat on cat.codigo = pro.codigo_categoria
                            inner join marca ma on ma.codigo = pro.codigo_marca
                            inner join lote lo on lo.codigo = pro.codigo_lote ";
            if (!string.IsNullOrEmpty(like))
            {
                query += "where pro.descricao like '%#REPLACE#%'";
                query = query.Replace("#REPLACE#", like);
            }

            return new BaseDAL().GetGeneric<ProdutoModel>(query);
        }
    }
}
