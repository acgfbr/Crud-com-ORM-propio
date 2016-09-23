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

        public List<ProdutoModel> Get(string like, bool useCat, bool useMarc, bool useLote, int idcat, int idmarca,
            int idlote, bool useVecto, DateTime inicio, DateTime fim)
        {
            var query =
                @"SELECT pro.*, cat.descricao as nome_categoria, ma.descricao as nome_marca, lo.nro_lote as nome_lote FROM produto pro

                            inner join categoria cat on cat.codigo = pro.codigo_categoria
                            inner join marca ma on ma.codigo = pro.codigo_marca
                            inner join lote lo on lo.codigo = pro.codigo_lote ";

            query += "where pro.descricao like '%#REPLACE#%'";
            query = query.Replace("#REPLACE#", like);

            if (useCat)
            {
                query += " and cat.codigo = #idcat";
                query = query.Replace("#idcat", idcat.ToString());
            }

            if (useMarc)
            {
                query += " and ma.codigo = #idma";
                query = query.Replace("#idma", idmarca.ToString());
            }

            if (useLote)
            {
                query += " and lo.codigo = #idlo";
                query = query.Replace("#idlo", idlote.ToString());
            }

            if (useVecto)
            {
                query += " and lo.data_vencimento BETWEEN '#inicio' and '#fim'";
                query = query.Replace("#inicio", inicio.ToString("yyyy-MM-dd HH:mm:ss.fff"))
                    .Replace("#fim", fim.ToString("yyyy-MM-dd HH:mm:ss.fff"));
            }

            return new BaseDAL().GetGeneric<ProdutoModel>(query);
        }

        public EstoqueBusca GetTotalEstoqueBusca(int idproduto)
        {
            var query = @"SELECT pro.valor_venda * lo.qtde  AS total, lo.qtde AS qtde
                            FROM produto pro
                            inner join lote lo on lo.codigo = pro.codigo_lote 
                            WHERE pro.descricao like '%%' 
                            and pro.codigo = #idprod";
            query = query.Replace("#idprod", idproduto.ToString());
            return new BaseDAL().GetGeneric<EstoqueBusca>(query)[0];
        }
    }

    public class EstoqueBusca
    {
        public int total { get; set; }
        public decimal qtde { get; set; }
    }
}
