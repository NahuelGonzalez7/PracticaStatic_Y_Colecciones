using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaEntidades.Models
{
    public class Empleado : Persona
    {
        public Empleado(int id, string apellido, string nombre, DateTime fechaNacimiento, string nacionalidad, string ciudad) : base(id, apellido, nombre, fechaNacimiento,nacionalidad, ciudad) { }
    }
}
