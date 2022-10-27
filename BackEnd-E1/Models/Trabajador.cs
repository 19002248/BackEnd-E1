using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BackEnd_E1.Models
{
    public class Trabajador
    {
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public DateTime FechaN { get; set; }
        public double Sueldo { get; set; }
        public bool EsFijo { get; set; }

    }
}