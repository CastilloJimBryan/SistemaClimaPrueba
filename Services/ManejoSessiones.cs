using BEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class ManejoSessiones
    {
        static Usuario _sesion;

        public static Usuario Session
        {
            get { return _sesion; }
        }

        public static void LogIn(Usuario usuario)
        {
            _sesion = usuario;
        }
        public static void LogOut()
        {
            _sesion = null;
        }
        public static bool IsLogged()
        {
            return Session!= null;
        }
    }
}
