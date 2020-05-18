using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Exa.Models
{
    public class Tabla1
    {
      [DisplayName("Numero de identificacion")]
        public int Id { get; set; }

      
        public string Nombre{get; set; }

        [DisplayName("Compañia")]
        public string Compania { get; set; }
      
        [DisplayName("Numero telefonico")]
        public int Empleados { get; set; }
    }
}