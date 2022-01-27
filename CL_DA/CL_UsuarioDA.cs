using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ClassLibrary1;
using System.Data;

namespace CL_DA
{
    public class CL_UsuarioDA
    {
        CL_Connection Conectar = new CL_Connection();
        public List<CL_UsuarioEN> Login(Usuario CLusuario) 
        {
            List<CL_UsuarioEN> Lista = new List<CL_UsuarioEN>();
            SqlConnection Connection = Conectar.Conexion();
            Connection.Open();
            SqlCommand Command = new SqlCommand("SP_Login",Connection);
            Command.CommandType = System.Data.CommandType.StoredProcedure;
            Command.Parameters.AddWithValue("@Usuario", CLusuario.usuario);
            Command.Parameters.AddWithValue("@Password", CLusuario.password);
            SqlDataReader Data = Command.ExecuteReader();
            foreach (IDataRecord DataRecord in Data) 
            {
                CL_UsuarioEN UsuarioEN = new CL_UsuarioEN();
                UsuarioEN.Id = Convert.ToInt32(Data[0].ToString());
                UsuarioEN.Usuario = Data[1].ToString();
                UsuarioEN.Password = Data[2].ToString();
                UsuarioEN.id_Tipo = Convert.ToInt32(Data[3].ToString());
                UsuarioEN.id_Menu = Convert.ToInt32(Data[4].ToString());
                UsuarioEN.Descripcion_Menu = Data[5].ToString();
                UsuarioEN.Url_Menu = Data[6].ToString();
                UsuarioEN.PadreId = Convert.ToInt32(Data[7].ToString());
                Lista.Add(UsuarioEN);
            }
            Connection.Close();
            return Lista;
        }
        //public List<CL_Menu> ObtenerMenu() 
        //{
        //    List<CL_Menu> ListaMenu = new List<CL_Menu>();
        //    SqlConnection Connection = Conectar.Conexion();
        //    Connection.Open();
        //    SqlCommand Command = new SqlCommand("SP_ObtenerMenu",Connection);
        //    Command.CommandType = System.Data.CommandType.StoredProcedure;
        //    SqlDataReader Table = Command.ExecuteReader();

        //    while (Table.Read()) 
        //    {
        //        CL_Menu listaMenu = new CL_Menu();
        //        listaMenu.id_Menu = Convert.ToInt32(Table[0].ToString());
        //        listaMenu.Descripcion = Table[1].ToString();
        //        listaMenu.id_tipo = Convert.ToInt32(Table[2].ToString());
        //        ListaMenu.Add(listaMenu);
        //    }
        //    return ListaMenu;


        //}
    }
}
