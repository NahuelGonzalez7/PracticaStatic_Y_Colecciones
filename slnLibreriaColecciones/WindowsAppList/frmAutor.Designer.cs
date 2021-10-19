
namespace WindowsAppList
{
    partial class frmAutor
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnTraerPorCiudad = new System.Windows.Forms.Button();
            this.gridListarAutores = new System.Windows.Forms.DataGridView();
            this.txtAutorNombre = new System.Windows.Forms.TextBox();
            this.txtAutorApellido = new System.Windows.Forms.TextBox();
            this.txtAutorID = new System.Windows.Forms.TextBox();
            this.txtAutorFechaNacimiento = new System.Windows.Forms.TextBox();
            this.txtAutorNacionalidad = new System.Windows.Forms.TextBox();
            this.txtAutorCiudad = new System.Windows.Forms.TextBox();
            this.lblAutor = new System.Windows.Forms.Label();
            this.lblAutorID = new System.Windows.Forms.Label();
            this.lblAutorApellido = new System.Windows.Forms.Label();
            this.lblAutorNombre = new System.Windows.Forms.Label();
            this.lblAutorFechaNac = new System.Windows.Forms.Label();
            this.lblAutorNacionalidad = new System.Windows.Forms.Label();
            this.lblAutorCiudad = new System.Windows.Forms.Label();
            this.txtBusquedaCiudad = new System.Windows.Forms.TextBox();
            this.lblBuscarCiudad = new System.Windows.Forms.Label();
            this.btnMostrarAutores = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridListarAutores)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(228, 113);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(230, 23);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnTraerPorCiudad
            // 
            this.btnTraerPorCiudad.Location = new System.Drawing.Point(15, 197);
            this.btnTraerPorCiudad.Name = "btnTraerPorCiudad";
            this.btnTraerPorCiudad.Size = new System.Drawing.Size(186, 23);
            this.btnTraerPorCiudad.TabIndex = 1;
            this.btnTraerPorCiudad.Text = "Traer autor por ciudad";
            this.btnTraerPorCiudad.UseVisualStyleBackColor = true;
            this.btnTraerPorCiudad.Click += new System.EventHandler(this.btnTraerPorCiudad_Click);
            // 
            // gridListarAutores
            // 
            this.gridListarAutores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridListarAutores.Location = new System.Drawing.Point(15, 237);
            this.gridListarAutores.Name = "gridListarAutores";
            this.gridListarAutores.Size = new System.Drawing.Size(621, 183);
            this.gridListarAutores.TabIndex = 2;
            // 
            // txtAutorNombre
            // 
            this.txtAutorNombre.Location = new System.Drawing.Point(50, 88);
            this.txtAutorNombre.Name = "txtAutorNombre";
            this.txtAutorNombre.Size = new System.Drawing.Size(143, 20);
            this.txtAutorNombre.TabIndex = 3;
            // 
            // txtAutorApellido
            // 
            this.txtAutorApellido.Location = new System.Drawing.Point(50, 62);
            this.txtAutorApellido.Name = "txtAutorApellido";
            this.txtAutorApellido.Size = new System.Drawing.Size(143, 20);
            this.txtAutorApellido.TabIndex = 4;
            // 
            // txtAutorID
            // 
            this.txtAutorID.Location = new System.Drawing.Point(50, 35);
            this.txtAutorID.Name = "txtAutorID";
            this.txtAutorID.Size = new System.Drawing.Size(143, 20);
            this.txtAutorID.TabIndex = 5;
            // 
            // txtAutorFechaNacimiento
            // 
            this.txtAutorFechaNacimiento.Location = new System.Drawing.Point(298, 31);
            this.txtAutorFechaNacimiento.Name = "txtAutorFechaNacimiento";
            this.txtAutorFechaNacimiento.Size = new System.Drawing.Size(160, 20);
            this.txtAutorFechaNacimiento.TabIndex = 6;
            // 
            // txtAutorNacionalidad
            // 
            this.txtAutorNacionalidad.Location = new System.Drawing.Point(298, 57);
            this.txtAutorNacionalidad.Name = "txtAutorNacionalidad";
            this.txtAutorNacionalidad.Size = new System.Drawing.Size(160, 20);
            this.txtAutorNacionalidad.TabIndex = 7;
            // 
            // txtAutorCiudad
            // 
            this.txtAutorCiudad.Location = new System.Drawing.Point(298, 87);
            this.txtAutorCiudad.Name = "txtAutorCiudad";
            this.txtAutorCiudad.Size = new System.Drawing.Size(160, 20);
            this.txtAutorCiudad.TabIndex = 8;
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutor.Location = new System.Drawing.Point(202, 9);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(55, 24);
            this.lblAutor.TabIndex = 9;
            this.lblAutor.Text = "Autor";
            // 
            // lblAutorID
            // 
            this.lblAutorID.AutoSize = true;
            this.lblAutorID.Location = new System.Drawing.Point(12, 42);
            this.lblAutorID.Name = "lblAutorID";
            this.lblAutorID.Size = new System.Drawing.Size(18, 13);
            this.lblAutorID.TabIndex = 10;
            this.lblAutorID.Text = "ID";
            // 
            // lblAutorApellido
            // 
            this.lblAutorApellido.AutoSize = true;
            this.lblAutorApellido.Location = new System.Drawing.Point(0, 69);
            this.lblAutorApellido.Name = "lblAutorApellido";
            this.lblAutorApellido.Size = new System.Drawing.Size(44, 13);
            this.lblAutorApellido.TabIndex = 11;
            this.lblAutorApellido.Text = "Apellido";
            // 
            // lblAutorNombre
            // 
            this.lblAutorNombre.AutoSize = true;
            this.lblAutorNombre.Location = new System.Drawing.Point(0, 95);
            this.lblAutorNombre.Name = "lblAutorNombre";
            this.lblAutorNombre.Size = new System.Drawing.Size(44, 13);
            this.lblAutorNombre.TabIndex = 12;
            this.lblAutorNombre.Text = "Nombre";
            // 
            // lblAutorFechaNac
            // 
            this.lblAutorFechaNac.AutoSize = true;
            this.lblAutorFechaNac.Location = new System.Drawing.Point(199, 38);
            this.lblAutorFechaNac.Name = "lblAutorFechaNac";
            this.lblAutorFechaNac.Size = new System.Drawing.Size(93, 13);
            this.lblAutorFechaNac.TabIndex = 13;
            this.lblAutorFechaNac.Text = "Fecha Nacimiento";
            // 
            // lblAutorNacionalidad
            // 
            this.lblAutorNacionalidad.AutoSize = true;
            this.lblAutorNacionalidad.Location = new System.Drawing.Point(208, 69);
            this.lblAutorNacionalidad.Name = "lblAutorNacionalidad";
            this.lblAutorNacionalidad.Size = new System.Drawing.Size(69, 13);
            this.lblAutorNacionalidad.TabIndex = 14;
            this.lblAutorNacionalidad.Text = "Nacionalidad";
            // 
            // lblAutorCiudad
            // 
            this.lblAutorCiudad.AutoSize = true;
            this.lblAutorCiudad.Location = new System.Drawing.Point(217, 94);
            this.lblAutorCiudad.Name = "lblAutorCiudad";
            this.lblAutorCiudad.Size = new System.Drawing.Size(40, 13);
            this.lblAutorCiudad.TabIndex = 15;
            this.lblAutorCiudad.Text = "Ciudad";
            // 
            // txtBusquedaCiudad
            // 
            this.txtBusquedaCiudad.Location = new System.Drawing.Point(15, 175);
            this.txtBusquedaCiudad.Name = "txtBusquedaCiudad";
            this.txtBusquedaCiudad.Size = new System.Drawing.Size(186, 20);
            this.txtBusquedaCiudad.TabIndex = 16;
            // 
            // lblBuscarCiudad
            // 
            this.lblBuscarCiudad.AutoSize = true;
            this.lblBuscarCiudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarCiudad.Location = new System.Drawing.Point(56, 156);
            this.lblBuscarCiudad.Name = "lblBuscarCiudad";
            this.lblBuscarCiudad.Size = new System.Drawing.Size(96, 16);
            this.lblBuscarCiudad.TabIndex = 17;
            this.lblBuscarCiudad.Text = "Buscar Ciudad";
            // 
            // btnMostrarAutores
            // 
            this.btnMostrarAutores.Location = new System.Drawing.Point(3, 114);
            this.btnMostrarAutores.Name = "btnMostrarAutores";
            this.btnMostrarAutores.Size = new System.Drawing.Size(219, 23);
            this.btnMostrarAutores.TabIndex = 18;
            this.btnMostrarAutores.Text = "Mostrar";
            this.btnMostrarAutores.UseVisualStyleBackColor = true;
            this.btnMostrarAutores.Click += new System.EventHandler(this.btnMostrarAutores_Click);
            // 
            // frmAutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 450);
            this.Controls.Add(this.btnMostrarAutores);
            this.Controls.Add(this.lblBuscarCiudad);
            this.Controls.Add(this.txtBusquedaCiudad);
            this.Controls.Add(this.lblAutorCiudad);
            this.Controls.Add(this.lblAutorNacionalidad);
            this.Controls.Add(this.lblAutorFechaNac);
            this.Controls.Add(this.lblAutorNombre);
            this.Controls.Add(this.lblAutorApellido);
            this.Controls.Add(this.lblAutorID);
            this.Controls.Add(this.lblAutor);
            this.Controls.Add(this.txtAutorCiudad);
            this.Controls.Add(this.txtAutorNacionalidad);
            this.Controls.Add(this.txtAutorFechaNacimiento);
            this.Controls.Add(this.txtAutorID);
            this.Controls.Add(this.txtAutorApellido);
            this.Controls.Add(this.txtAutorNombre);
            this.Controls.Add(this.gridListarAutores);
            this.Controls.Add(this.btnTraerPorCiudad);
            this.Controls.Add(this.btnGuardar);
            this.Name = "frmAutor";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmAutor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridListarAutores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnTraerPorCiudad;
        private System.Windows.Forms.DataGridView gridListarAutores;
        private System.Windows.Forms.TextBox txtAutorNombre;
        private System.Windows.Forms.TextBox txtAutorApellido;
        private System.Windows.Forms.TextBox txtAutorID;
        private System.Windows.Forms.TextBox txtAutorFechaNacimiento;
        private System.Windows.Forms.TextBox txtAutorNacionalidad;
        private System.Windows.Forms.TextBox txtAutorCiudad;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.Label lblAutorID;
        private System.Windows.Forms.Label lblAutorApellido;
        private System.Windows.Forms.Label lblAutorNombre;
        private System.Windows.Forms.Label lblAutorFechaNac;
        private System.Windows.Forms.Label lblAutorNacionalidad;
        private System.Windows.Forms.Label lblAutorCiudad;
        private System.Windows.Forms.TextBox txtBusquedaCiudad;
        private System.Windows.Forms.Label lblBuscarCiudad;
        private System.Windows.Forms.Button btnMostrarAutores;
    }
}

