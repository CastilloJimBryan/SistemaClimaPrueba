using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class Usuario 
    {
        public int UsuarioID {  get; set; }
        public string UsuarioNombre { get; set; }
        public string UsuarioApellido { get; set; }
        public string UsuarioPass {  get; set; }
        public int Rol_Id { get; set; }
    }
}
