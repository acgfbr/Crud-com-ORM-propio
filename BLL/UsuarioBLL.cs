using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;

namespace BLL
{
    public class UsuarioBLL
    {
        public DataTable table;

        public UsuarioBLL()
        {
            table = new DataTable();
        }

        public Usuario Get()
        {
            UsuarioDAL obj = new UsuarioDAL();
            return obj.Get(1);
        }

        public List<Usuario> ListAll()
        {
            var obj = new UsuarioDAL();
            return obj.ListAll();
            
        }

        public List<Usuario> ListByNome(string _nome)
        {
            UsuarioDAL obj = new UsuarioDAL();
            return obj.ListByNome(_nome);
            
        }

        public bool Store(Usuario usuario)
        {
            if (usuario.nome.Trim().Length == 0)
            {
                throw new Exception("O nome do usuario é obrigatório");
            }

            usuario.email = usuario.email.ToLower();

            var usuarioDAL = new UsuarioDAL();
            return usuarioDAL.SaveOrUpdate(usuario, usuario.id==0,"usuario");
            
        }
        public bool Delete(int _id)
        {
            if (_id < 1)
            {
                throw new Exception("Selecione um cliente antes de excluí-lo.");
            }

            var usuarioDAL = new UsuarioDAL();
            //if (usuarioDAL.Delete(_id))
                //return true;
            //else
                //return false;
            return false;
        }

    }
}
