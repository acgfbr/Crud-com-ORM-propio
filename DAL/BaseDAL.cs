using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Util;

namespace DAL
{
    public class BaseDAL : IDisposable
    {
        public Tuple<List<SqlParameter>, string, string> Cria_Parametros<T>(T classe)
        {
            var nome_variaveis = string.Empty;
            var nome_valores = string.Empty;

            var parameters = new List<SqlParameter>();

            var props = classe.GetType().GetProperties();
            var ignored = classe.GetType().GetProperties().Where(p => p.IsDefined(typeof(VARIAVEL_IGNORADA_BASE_DAL), false)).ToList();

            var lst_without_atribs = props.Except(ignored).ToList();

            lst_without_atribs.RemoveAt(0);

            foreach (var item in lst_without_atribs)
            {
                parameters.Add(new SqlParameter("@" + item.Name, PropertyValue.GetPropertyValue(classe, item.Name) ?? DBNull.Value));
                nome_variaveis += item.Name + ",";
                nome_valores += "@"+item.Name + ",";
            }

            return new Tuple<List<SqlParameter>, string, string>(parameters, nome_variaveis, nome_valores);
        }


        public bool Delete(string nometabela, int codigo)
        {
            var query = "delete from " + nometabela + " where codigo = " + codigo;
            var help = new ToneHelper();
            help.ExecuteNonQuery(query);
            return true;
        }

        public bool SaveOrUpdate<T>(T classe, bool isInsert, string nometabela)
        {
            var tupla = Cria_Parametros(classe);
            var parameters = tupla.Item1;
            var variaveis = tupla.Item2;
            var valores = tupla.Item3;
            variaveis = variaveis.TrimEnd(',');
            valores = valores.TrimEnd(',');

            if (isInsert)
            {
                var query = "insert into " + nometabela + " (" + variaveis + " ) values ( "+valores+" )";

                var help = new ToneHelper();
                help.ExecuteNonQuery(query, parameters.ToArray());
                return true;
            }
            else
            {
                var id = classe.GetType().GetProperty("codigo").GetValue(classe, null);

                var updatequery = string.Empty;
                
                var vars = variaveis.Split(',');
                var parametros = valores.Split(',');

                var i = 0;
                foreach (var item in vars)
                {
                    if(i < vars.Length-1)
                        updatequery += item + " = " + parametros[i] +  ", ";
                    else
                        updatequery += item + " = " + parametros[i] + " ";

                    i ++;
                }
                var query = "update " + nometabela + " set "+updatequery+ " where codigo = #ID#";
                query = query.Replace("#ID#", id.ToString());
                
                var help = new ToneHelper();
                help.ExecuteNonQuery(query, parameters.ToArray());
                return true;
            }
        }

        public List<T> GetGeneric<T>(string query) where T : class, new()
        {
            var data_table = new DataTable();
            var toneHelper = new ToneHelper();
            toneHelper.OpenConnection();
            toneHelper.command.CommandText = query;
            using (var t = new SqlDataAdapter(toneHelper.command))
            {
                t.Fill(data_table);
            }
            toneHelper.CloseConection();
            
            return toneHelper.DataTableToList<T>(data_table);
        }

        public void Dispose()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
        
    }
}
