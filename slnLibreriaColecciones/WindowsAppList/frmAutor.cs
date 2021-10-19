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
    public partial class frmAutor : Form
    {
        List<Autor> autores = new List<Autor>() { };
        List<Autor> listCiudadAutores = new List<Autor>() { };
        
        public frmAutor()
        {
            InitializeComponent();
        }

        private void frmAutor_Load(object sender, EventArgs e)
        {
            autores.Add(new Autor(1, "Pinola", "Javier",Convert.ToDateTime("09/12/1975"), "Buenos Aires", "Argentina"));
            autores.Add(new Autor(2, "Ponzio", "Leonardo",Convert.ToDateTime("29/11/1976"), "Santa Fe", "Argentina"));
            autores.Add(new Autor(3, "Perez", "Enzo",Convert.ToDateTime("10/04/1985"), "Mendoza", "Argentina"));
            ActualizarGrid();
        }

        private void ActualizarGrid()
        {
            gridListarAutores.DataSource = null;
            gridListarAutores.DataSource = autores;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            autores.Add(new Autor(Convert.ToInt32(txtAutorID.Text), txtAutorApellido.Text, txtAutorNombre.Text, Convert.ToDateTime(txtAutorFechaNacimiento.Text), txtAutorCiudad.Text, txtAutorNacionalidad.Text));
            clearTextBox();
        }

        private void clearTextBox()
        {
            txtAutorApellido.Clear();
            txtAutorNombre.Clear();
            txtAutorFechaNacimiento.Clear();
            txtAutorID.Clear();
            txtAutorCiudad.Clear();
            txtAutorNacionalidad.Clear();
        }

        private void btnMostrarAutores_Click(object sender, EventArgs e)
        {
            ActualizarGrid();
        }
       
        private void btnTraerPorCiudad_Click(object sender, EventArgs e)
        {
            buscarAutorCiudad();
        }

        private void buscarAutorCiudad()
        {
            foreach (Autor autor in autores)
            {
                if (autor.Ciudad == txtBusquedaCiudad.Text)
                {
                    listCiudadAutores.Add(autor);
                }
            }
            gridListarAutores.DataSource = listCiudadAutores;
        }
    }
}
