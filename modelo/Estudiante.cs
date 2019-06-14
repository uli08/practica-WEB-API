using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace modelo
{
    public class Estudiante
    {
        [Key]
        public int IDestudiante { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string Bio { get; set; }
    }
}
