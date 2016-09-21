using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Util;

namespace DAL
{
    public class BaseDAL : IDisposable
    {
        public Tuple<List<SqlParameter>, string, string> Cria_Parametros<T>(int i, T classe)
        {
            var nome_variaveis = string.Empty;
            var nome_valores = string.Empty;

            var parameters = new List<SqlParameter>();

            var props = classe.GetType().GetProperties();
            var ignored = classe.GetType().GetProperties().Where(p => p.IsDefined(typeof(VARIAVEL_IGNORADA_BASE_DAL), false)).ToList();

            var lst_without_atribs = props.Except(ignored).ToList();

            if (i == 1)
                lst_without_atribs.RemoveAt(0);

            foreach (var item in lst_without_atribs)
            {
                parameters.Add(new SqlParameter("@" + item.Name, PropertyValue.GetPropertyValue(classe, item.Name) ?? DBNull.Value));
                nome_variaveis += item.Name + ",";
                nome_valores += "@"+item.Name + ",";
            }

            return new Tuple<List<SqlParameter>, string, string>(parameters, nome_variaveis, nome_valores);
        }

        

        public bool SaveOrUpdate<T>(T classe, bool isInsert)
        {
            var tupla = Cria_Parametros(isInsert ? 1 : 0, classe);
            var parameters = tupla.Item1;
            var vars = tupla.Item2;
            var valores = tupla.Item3;
            vars = vars.TrimEnd(',');
            valores = valores.TrimEnd(',');

            if (isInsert)
            {
                var query = "insert into " + classe.GetType().Name.ToLower() + " (" + vars + " ) values ( "+valores+" )";

                var help = new ToneHelper();
                help.ExecuteNonQuery(query, parameters.ToArray());
                return true;
                
            }
            else
            {
                return false;
            }
            
        }

        

        
        public void Dispose()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
        
    }
}
