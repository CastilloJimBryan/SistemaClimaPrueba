using BEL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UsuarioDAL
    {
        public void ValidarFilas(Usuario u,DataRow dr)
        {
            u.UsuarioId = int.Parse(dr["UsuarioId"].ToString());
            u.Nombre = dr["Nombre"].ToString();
            u.Apellido = dr["Apellido"].ToString();
            u.Pass = dr["Pass"].ToString();
            u.Rol = dr["Rol"].ToString();
        }
       
        public Usuario ObtenerNomYPass(string nom,string pass)
        {
            string sql = "SELECT UsuarioId,Nombre,Apellido,Pass,Rol FROM Usuario " +
                " INNER JOIN Rol ON Rol.RolId= Usuario.Rol_Id " +
                " WHERE Usuario.Nombre='" + nom + "' AND Pass='" + pass + "'";
            DAO dAO = new DAO();
            DataSet ds = dAO.Read(sql);
            if(ds.Tables.Count > 0 && ds.Tables[0].Rows.Count>0)
            {
                Usuario u=new Usuario();
                ValidarFilas(u, ds.Tables[0].Rows[0]);
                return u;
            }
            return null;
        }
    }
}
