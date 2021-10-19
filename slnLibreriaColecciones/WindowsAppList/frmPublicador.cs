using LibreriaEntidades.AdministrarPublicadores;
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
    public partial class frmPublicador : Form
    {
        List<Publicador> publicadores = new List<Publicador>();
        public frmPublicador()
        {
            InitializeComponent();
        }

        private void frmPublicador_Load(object sender, EventArgs e)
        {
            ActualizarListarPublicadores();
        }

        private void ActualizarListarPublicadores()
        {
            gridListarPublicador.DataSource = null;
            gridListarPublicador.DataSource = AdminPublicador.listar();
        }

        private void bntinsertarPublicador_Click(object sender, EventArgs e)
        {
            agregarPublicador();
            LimpiarGrid();
        }

        private void agregarPublicador()
        {
            AdminPublicador.insertar(new Publicador(Convert.ToInt32(txtPublicadorID.Text), txtPublicadorApellido.Text, txtPublicadorNombre.Text, Convert.ToDateTime(txtPublicadorFechaNacimiento.Text), txtPublicadorCiudad.Text));
        }

        private void LimpiarGrid()
        {
            txtPublicadorApellido.Clear();
            txtPublicadorCiudad.Clear();
            txtPublicadorFechaNacimiento.Clear();
            txtPublicadorID.Clear();
            txtPublicadorNombre.Clear();
        }

        private void btnListarPublicador_Click(object sender, EventArgs e)
        {
            ActualizarListarPublicadores();
        }

        private void btnEliminarPublicador_Click(object sender, EventArgs e)
        {
            AdminPublicador.eliminar(Convert.ToInt32(txtEliminarPublicador.Text));
            txtEliminarPublicador.Clear();
        }
    }
}
