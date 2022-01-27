using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class CL_UsuarioEN
    {
        public int Id { get; set; }
        public string Usuario { get; set; }
        public string Password { get; set; }
        public int id_Tipo { get; set; }
        public int id_Menu { get; set; }
        public string Descripcion_Menu { get; set; }
        public string Url_Menu { get; set; }
        public int PadreId { get; set; }
    }
}
