using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace viewGroup_este_si.Models.Modelo_viewGroup
{
    public class ActividadUsuario
    {
        public Actividad actividad { get; set; }
        public usuario usuarioActividad { get; set; }
        public DateTime fechaAsignada { get; set; }
        public Boolean asistencia { get; set; }
        public string descripcion { get; set; }

    }
}