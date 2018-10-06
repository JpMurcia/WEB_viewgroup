using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using viewGroup_este_si.Models;

namespace viewGroup_este_si.Controllers
{
    public class loginController
    {
        private modelUsuario usuario = new modelUsuario();

        public loginController()
        {
        }

        public DataTable iniciarSesion(modelUsuario usu)
        {
            return usuario.validarUsuario(usu);
        }
    }
}