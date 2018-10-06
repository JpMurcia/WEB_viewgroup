using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace viewGroup_este_si.Models
{
    public class pagina_web
    {
        public string id { get; set; }
        public string urlPagina { get; set; }
        public plantilla plantilla  { get; set; }
        public Grupo_inve_semillero grupo { get; set; }
    }
}