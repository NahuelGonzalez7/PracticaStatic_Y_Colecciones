using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaEntidades.Models
{
    public abstract class Persona
    {
        public int ID { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Nacionalidad { get; set; }
        public string Ciudad { get; set; }

        public Persona(int iD, string apellido, string nombre, DateTime fechaNacimiento,string nacionalidad, string ciudad)
        {
            ID = iD;
            Apellido = apellido;
            Nombre = nombre;
            FechaNacimiento = fechaNacimiento;
            Nacionalidad = nacionalidad;
            Ciudad = ciudad;
        }
    }
}
