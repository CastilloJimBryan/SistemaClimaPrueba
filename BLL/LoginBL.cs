using BEL;
using DAL;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class LoginBL
    {
        UsuarioDAL usuarioDAL;

        public LoginBL()
        {
            usuarioDAL= new UsuarioDAL();
        }

        public void Login(string text1,string text2)
        {
            if (String.IsNullOrEmpty(text1) || String.IsNullOrEmpty(text2)) throw new Exception("Campos Vacios!");
            Usuario user=usuarioDAL.ObtenerNomYPass(text1,text2);
            if (user == null) throw new Exception("Usuario y/o Contraseña Incorrecto");
            ManejoSessiones.LogIn(user);
        }
        public void LogOut()
        {
            ManejoSessiones.LogOut();
        }
    }
}
