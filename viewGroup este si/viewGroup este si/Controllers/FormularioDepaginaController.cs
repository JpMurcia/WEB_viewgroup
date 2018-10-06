using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using viewGroup_este_si.Models;

namespace viewGroup_este_si.Controllers
{
    public class FormularioDepaginaController
    {
        private Grupo_inve_semillero grupo = new Grupo_inve_semillero();

        public FormularioDepaginaController()
        {
        }

        public DataTable consultarGrupoController(Grupo_inve_semillero group)
        {
            return grupo.consultargrupoModel(group);
        }
    }
}