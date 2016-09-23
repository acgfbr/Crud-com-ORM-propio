using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Util
{
    public class ToneHelper
    {
        //public static string sqlConnectionString = "Data Source=192.168.1.18;Initial Catalog=tone;Persist Security Info=True;User ID=sa;Password=pt66ypjx;Max Pool Size=300;";
        public static string sqlConnectionString = @"Server=TONEPANETONA233\SQLEXPRESS;Database=tone;Trusted_Connection=True;";
        

        public SqlConnection BdConnection { get; set; }
        public SqlCommand command;
        public SqlDataReader reader;
        public SqlDataAdapter adapter;
        public DataTable table;

        public string NomeStringConexao { get; set; }

        public ToneHelper()
        {
            this.NomeStringConexao = sqlConnectionString;

            this.BdConnection = new SqlConnection(this.NomeStringConexao);

            this.command = new SqlCommand();
            this.command.Connection = this.BdConnection;

            this.adapter = new SqlDataAdapter();

            this.table = new DataTable();

        }
        
        public void OpenConnection()
        {
            if (this.BdConnection.State == System.Data.ConnectionState.Closed)
            {
                this.BdConnection.Open();
            }
        }

        public void CloseConection()
        {
            this.BdConnection.Close();
        }
        
        public void ExecuteNonQuery(SqlCommand command)
        {
            command.ExecuteNonQuery();
        }

        public void ExecuteNonQuery(SqlCommand command, bool openConnection)
        {
            if (openConnection)
            {
                this.OpenConnection();
            }
            this.ExecuteNonQuery(command);
            if (openConnection)
            {
                this.CloseConection();
            }
        }

        public void ExecuteNonQuery(string query, params SqlParameter[] parameters)
        {
            Exception erro = null;
            try
            {
                this.OpenConnection();
                SqlCommand command = this.BdConnection.CreateCommand();
                command.CommandText = query;
                command.Parameters.AddRange(parameters);
                this.ExecuteNonQuery(command);
                this.CloseConection();
            }
            catch (Exception ex)
            {
                erro = ex;
            }
            finally
            {
                this.CloseConection();
            }

            if (erro != null)
            {
                throw erro;
            }
        }

        public void ExecuteCommands(params SqlCommand[] commands)
        {
            Exception erro = null;
            SqlTransaction trans = null;
            try
            {
                this.BdConnection.Open();
                trans = this.BdConnection.BeginTransaction();
                for (int i = 0; i < commands.Length; i++)
                {
                    commands[i].Transaction = trans;
                    this.ExecuteNonQuery(commands[i]);
                }
                trans.Commit();
                this.BdConnection.Close();
            }
            catch (Exception ex)
            {
                trans.Rollback();
                erro = ex;
            }
            finally
            {
                this.BdConnection.Close();
            }

            if (erro != null)
            {
                throw erro;
            }
        }
        public List<T> DataTableToList<T>(DataTable table) where T : class, new()
        {
            try
            {
                var list = new List<T>();

                foreach (var row in table.AsEnumerable())
                {
                    var obj = new T();

                    foreach (var prop in obj.GetType().GetProperties())
                    {
                        try
                        {
                            var propertyInfo = obj.GetType().GetProperty(prop.Name);
                            propertyInfo.SetValue(obj, Convert.ChangeType(row[prop.Name], propertyInfo.PropertyType), null);
                        }
                        catch(Exception ex)
                        {
                            continue;
                        }
                    }
                    list.Add(obj);
                }
                return list;
            }
            catch
            {
                return null;
            }
        }

    }
}
