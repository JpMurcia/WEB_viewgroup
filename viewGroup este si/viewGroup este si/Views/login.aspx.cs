using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using viewGroup_este_si.Controllers;
using viewGroup_este_si.Models;


namespace viewGroup_este_si.Views
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            modelUsuario a = new modelUsuario();
            a.nombre = usuarioNombre.Text;
            a.contrasena = usuarioContrasena.Text;
            loginController controlador = new loginController();
            DataTable datoRegreso = controlador.iniciarSesion(a);
            if (datoRegreso.Rows[0]["mensaje"].ToString() == "bueeeeena perro")
            {
                //Response.Write("<script>alert('Hola perro mir que si putito')</script>");
                //Response.Write("<script>alert('Otra cosa')</script>");

                Response.Redirect("FormularioDePagina.aspx");
            }
            else
            {
                Response.Write("<script>alert('Así fue que ce mamo')</script>");
            }


        }
    }
}