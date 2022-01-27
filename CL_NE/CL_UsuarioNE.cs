using CL_DA;
using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_NE
{
    public class CL_UsuarioNE
    {
        private CL_UsuarioDA usuarioDA = new CL_UsuarioDA();
        public List<CL_UsuarioEN> Login(Usuario CLUsuario) 
        {
            return usuarioDA.Login(CLUsuario);
        }
        //public List<CL_Menu> ListaMenu() 
        //{
        //    return usuarioDA.ObtenerMenu();
        //}
    }
}
