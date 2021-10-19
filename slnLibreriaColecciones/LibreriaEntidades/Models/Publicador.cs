using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaEntidades.Models
{
    public class Publicador 
    {
        public int ID { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Ciudad { get; set; }
        public Publicador(int id, string apellido, string nombre, DateTime fechaNacimiento, string ciudad) 
        {
            ID = id;
            Apellido = apellido;
            Nombre = nombre;
            FechaNacimiento = fechaNacimiento;
            Ciudad = ciudad;
        }
    }
}
