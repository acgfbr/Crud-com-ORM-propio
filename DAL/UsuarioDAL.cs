using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Util;

namespace DAL
{
    public class UsuarioDAL
    {
        private readonly ToneHelper toneHelper;

        public UsuarioDAL()
        {
            toneHelper = new ToneHelper();
        }
        public Usuario Get(int id)
        {
            var usuario = new Usuario();

            try
            {
                toneHelper.OpenConnection();

                var query = "SELECT * FROM usuario where id=@id";
                toneHelper.command.CommandText = query;
                toneHelper.command.Parameters.AddWithValue("@id", id.ToString());
                toneHelper.reader = toneHelper.command.ExecuteReader();
                if (toneHelper.reader.Read())
                {
                    usuario.id = int.Parse(toneHelper.reader["id"].ToString());
                    usuario.nome = toneHelper.reader["nome"].ToString();
                    usuario.email = toneHelper.reader["email"].ToString();
                    usuario.usuario = toneHelper.reader["usuario"].ToString();
                    usuario.senha = toneHelper.reader["senha"].ToString();
                }
                toneHelper.reader.Close();
                this.toneHelper.CloseConection();
            }
            finally
            {
                if (toneHelper.reader != null)
                {
                    toneHelper.reader.Close();
                }
                this.toneHelper.CloseConection();
            }
            return usuario;
        }

        public List<Usuario> ListAll()
        {
            var lst_usuarios = new List<Usuario>();

            try
            {
                toneHelper.OpenConnection();

                var query = "SELECT * FROM usuario";
                toneHelper.command.CommandText = query;
                
                toneHelper.reader = toneHelper.command.ExecuteReader();
                while (toneHelper.reader.Read())
                {
                    var usuario = new Usuario
                    {
                        id = int.Parse(toneHelper.reader["id"].ToString()),
                        nome = toneHelper.reader["nome"].ToString(),
                        email = toneHelper.reader["email"].ToString(),
                        usuario = toneHelper.reader["usuario"].ToString(),
                        senha = toneHelper.reader["senha"].ToString()
                    };


                    lst_usuarios.Add(usuario);
                }
                toneHelper.reader.Close();
                this.toneHelper.CloseConection();
            }
            finally
            {
                toneHelper.reader?.Close();
                this.toneHelper.CloseConection();
            }
            return lst_usuarios;
        }

        public List<Usuario> ListByNome(string _nome)
        {
            var lst_usuarios = new List<Usuario>();

            try
            {
                toneHelper.OpenConnection();

                var query = "SELECT * FROM usuario where nome like '%#NOME%'";
                query = query.Replace("#NOME", _nome);

                toneHelper.command.CommandText = query;

                toneHelper.reader = toneHelper.command.ExecuteReader();
                while (toneHelper.reader.Read())
                {
                    var usuario = new Usuario
                    {
                        id = int.Parse(toneHelper.reader["id"].ToString()),
                        nome = toneHelper.reader["nome"].ToString(),
                        email = toneHelper.reader["email"].ToString(),
                        usuario = toneHelper.reader["usuario"].ToString(),
                        senha = toneHelper.reader["senha"].ToString()
                    };


                    lst_usuarios.Add(usuario);
                }
                toneHelper.reader.Close();
                this.toneHelper.CloseConection();
            }
            finally
            {
                toneHelper.reader?.Close();
                this.toneHelper.CloseConection();
            }
            return lst_usuarios;
        }

        public bool Store(Usuario usr, bool isInsert)
        {
            var query = @"USE [tone]
                            GO

                            INSERT INTO [dbo].[usuario]
                                       ([nome]
                                       ,[email]
                                       ,[usuario]
                                       ,[senha])
                                 VALUES
                                       (#NOME
                                       ,#EMAIL
                                       ,#USUARIO
                                       ,#SENHA)
                            GO";
        }

    }
}
