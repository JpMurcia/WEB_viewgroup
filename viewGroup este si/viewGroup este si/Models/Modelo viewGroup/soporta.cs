﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace viewGroup_este_si.Models.Modelo_viewGroup
{
    public class soporta
    {
        public string idSoporte { get; set; }
        public string urlImage { get; set; }
        public producto fkProducto { get; set; }
    }
}