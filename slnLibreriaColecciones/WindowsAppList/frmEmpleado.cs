using LibreriaEntidades.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsAppList
{
    public partial class frmEmpleado : Form
    {
        List<Empleado> empleados = new List<Empleado>();
        public frmEmpleado()
        {
            InitializeComponent();
        }

        private void frmEmpleado_Load(object sender, EventArgs e)
        {
            empleados.Add(new Empleado(1, "Maidana", "Jonathan", Convert.ToDateTime("05/06/1996"), "Argentina", "Chacho"));
            empleados.Add(new Empleado(2, "Diaz", "Paulo", Convert.ToDateTime("15/08/1980"), "Chile", "Vina del Mar"));
            empleados.Add(new Empleado(3, "Rojas", "Robert", Convert.ToDateTime("11/09/1986"), "Paraguay", "Asuncion"));
            actualizarGridEmpleados();
            
        }
        private void Limpiartxt()
        {
            txtEmpleadoApellido.Clear();
            txtEmpleadoCiudad.Clear();
            txtEmpleadoFechaNacimiento.Clear();
            txtEmpleadoID.Clear();
            txtEmpleadoNacionalidad.Clear();
            txtEmpleadoNombre.Clear();
        }

        private void actualizarGridEmpleados()
        {
            gridListarEmpleados.DataSource = null;
            gridListarEmpleados.DataSource = empleados;
        }

        private void btnGuardarEmpleado_Click(object sender, EventArgs e)
        {
            empleados.Add(new Empleado(Convert.ToInt32(txtEmpleadoID.Text), txtEmpleadoApellido.Text, txtEmpleadoNombre.Text, Convert.ToDateTime(txtEmpleadoFechaNacimiento.Text), txtEmpleadoNacionalidad.Text, txtEmpleadoCiudad.Text));
            Limpiartxt();
        }

        private void btnMostrarEmpleados_Click(object sender, EventArgs e)
        {
            actualizarGridEmpleados();
        }

        private void btnTraerPorID_Click(object sender, EventArgs e)
        {
            if (empleados != null)
            {
                foreach (Empleado empleado in empleados)
                {
                    if (empleado.Nombre == txtTraerPorID.Text)
                    {
                        MessageBox.Show("\n " + "ID Empleado: " + empleado.ID + "\n Apellido: " + empleado.Apellido + "\n Nombre: " + empleado.Nombre + "\n Fecha Nacimiento:" + empleado.FechaNacimiento.ToShortDateString() + "\n Nacionalidad: " + empleado.Nacionalidad + "\n Ciudad: " + empleado.Ciudad);
                    }
                }
            }
        }

        private void btnEliminarEmpleado_Click(object sender, EventArgs e)
        {
            int contador = 0;
            if(empleados != null)
            {
                foreach (Empleado empleado in empleados)
                {
                    if(empleado.Nombre == txtEliminarEmpleado.Text)
                    {
                        contador++;
                    }
                }
                empleados.RemoveAt(contador);
            }
        }
    }
}
