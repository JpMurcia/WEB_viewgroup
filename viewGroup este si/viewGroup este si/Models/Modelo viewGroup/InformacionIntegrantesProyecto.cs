using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace viewGroup_este_si.Models.Modelo_viewGroup
{
    public class InformacionIntegrantesProyecto
    {
        public usuario idUsuario { get; set; }
        public producto idProducto { get; set; }
        public int funcion { get; set; }
        public string descripcion { get; set; }
    }
}