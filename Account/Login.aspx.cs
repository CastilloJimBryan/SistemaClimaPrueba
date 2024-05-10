using BLL;
using Services;
using System;
using System.Collections.Generic;
using System.Deployment.Internal;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Account_Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            LoginBL loginBL = new LoginBL();
            loginBL.Login(TextBox1.Text, TextBox2.Text);
            Session["User"] = ManejoSessiones.Session.Nombre;
            Session["Rol"] = ManejoSessiones.Session.Rol;

          
            Response.Redirect("/Default.aspx");

        }catch(Exception ex) { Label3.Text = ex.Message; TextBox1.Text = "";TextBox2.Text = ""; }
    }
}