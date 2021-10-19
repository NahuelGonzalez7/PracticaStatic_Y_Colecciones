
namespace WindowsAppList
{
    partial class frmEmpleado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnTraerPorID = new System.Windows.Forms.Button();
            this.btnEliminarEmpleado = new System.Windows.Forms.Button();
            this.btnGuardarEmpleado = new System.Windows.Forms.Button();
            this.lblEmpleadoApellido = new System.Windows.Forms.Label();
            this.lblEmpleadoNombre = new System.Windows.Forms.Label();
            this.lblEmpleadoID = new System.Windows.Forms.Label();
            this.lblEmpleadoFechaNacimiento = new System.Windows.Forms.Label();
            this.lblEmpleadoNacionalidad = new System.Windows.Forms.Label();
            this.lblEmpleadoCiudad = new System.Windows.Forms.Label();
            this.txtEmpleadoID = new System.Windows.Forms.TextBox();
            this.txtEmpleadoApellido = new System.Windows.Forms.TextBox();
            this.txtEmpleadoNombre = new System.Windows.Forms.TextBox();
            this.txtEmpleadoFechaNacimiento = new System.Windows.Forms.TextBox();
            this.txtEmpleadoNacionalidad = new System.Windows.Forms.TextBox();
            this.txtEmpleadoCiudad = new System.Windows.Forms.TextBox();
            this.gridListarEmpleados = new System.Windows.Forms.DataGridView();
            this.btnMostrarEmpleados = new System.Windows.Forms.Button();
            this.txtTraerPorID = new System.Windows.Forms.TextBox();
            this.txtEliminarEmpleado = new System.Windows.Forms.TextBox();
            this.lblNombreEmpleadoEliminado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridListarEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTraerPorID
            // 
            this.btnTraerPorID.Location = new System.Drawing.Point(255, 30);
            this.btnTraerPorID.Name = "btnTraerPorID";
            this.btnTraerPorID.Size = new System.Drawing.Size(150, 23);
            this.btnTraerPorID.TabIndex = 0;
            this.btnTraerPorID.Text = "Traer Empleado Por ID";
            this.btnTraerPorID.UseVisualStyleBackColor = true;
            this.btnTraerPorID.Click += new System.EventHandler(this.btnTraerPorID_Click);
            // 
            // btnEliminarEmpleado
            // 
            this.btnEliminarEmpleado.Location = new System.Drawing.Point(412, 110);
            this.btnEliminarEmpleado.Name = "btnEliminarEmpleado";
            this.btnEliminarEmpleado.Size = new System.Drawing.Size(150, 23);
            this.btnEliminarEmpleado.TabIndex = 1;
            this.btnEliminarEmpleado.Text = "Eliminar Empleado";
            this.btnEliminarEmpleado.UseVisualStyleBackColor = true;
            this.btnEliminarEmpleado.Click += new System.EventHandler(this.btnEliminarEmpleado_Click);
            // 
            // btnGuardarEmpleado
            // 
            this.btnGuardarEmpleado.Location = new System.Drawing.Point(255, 112);
            this.btnGuardarEmpleado.Name = "btnGuardarEmpleado";
            this.btnGuardarEmpleado.Size = new System.Drawing.Size(150, 23);
            this.btnGuardarEmpleado.TabIndex = 2;
            this.btnGuardarEmpleado.Text = "Guardar";
            this.btnGuardarEmpleado.UseVisualStyleBackColor = true;
            this.btnGuardarEmpleado.Click += new System.EventHandler(this.btnGuardarEmpleado_Click);
            // 
            // lblEmpleadoApellido
            // 
            this.lblEmpleadoApellido.AutoSize = true;
            this.lblEmpleadoApellido.Location = new System.Drawing.Point(12, 59);
            this.lblEmpleadoApellido.Name = "lblEmpleadoApellido";
            this.lblEmpleadoApellido.Size = new System.Drawing.Size(44, 13);
            this.lblEmpleadoApellido.TabIndex = 3;
            this.lblEmpleadoApellido.Text = "Apellido";
            // 
            // lblEmpleadoNombre
            // 
            this.lblEmpleadoNombre.AutoSize = true;
            this.lblEmpleadoNombre.Location = new System.Drawing.Point(12, 88);
            this.lblEmpleadoNombre.Name = "lblEmpleadoNombre";
            this.lblEmpleadoNombre.Size = new System.Drawing.Size(44, 13);
            this.lblEmpleadoNombre.TabIndex = 4;
            this.lblEmpleadoNombre.Text = "Nombre";
            // 
            // lblEmpleadoID
            // 
            this.lblEmpleadoID.AutoSize = true;
            this.lblEmpleadoID.Location = new System.Drawing.Point(21, 30);
            this.lblEmpleadoID.Name = "lblEmpleadoID";
            this.lblEmpleadoID.Size = new System.Drawing.Size(18, 13);
            this.lblEmpleadoID.TabIndex = 5;
            this.lblEmpleadoID.Text = "ID";
            // 
            // lblEmpleadoFechaNacimiento
            // 
            this.lblEmpleadoFechaNacimiento.AutoSize = true;
            this.lblEmpleadoFechaNacimiento.Location = new System.Drawing.Point(12, 115);
            this.lblEmpleadoFechaNacimiento.Name = "lblEmpleadoFechaNacimiento";
            this.lblEmpleadoFechaNacimiento.Size = new System.Drawing.Size(93, 13);
            this.lblEmpleadoFechaNacimiento.TabIndex = 6;
            this.lblEmpleadoFechaNacimiento.Text = "Fecha Nacimiento";
            // 
            // lblEmpleadoNacionalidad
            // 
            this.lblEmpleadoNacionalidad.AutoSize = true;
            this.lblEmpleadoNacionalidad.Location = new System.Drawing.Point(12, 141);
            this.lblEmpleadoNacionalidad.Name = "lblEmpleadoNacionalidad";
            this.lblEmpleadoNacionalidad.Size = new System.Drawing.Size(69, 13);
            this.lblEmpleadoNacionalidad.TabIndex = 7;
            this.lblEmpleadoNacionalidad.Text = "Nacionalidad";
            // 
            // lblEmpleadoCiudad
            // 
            this.lblEmpleadoCiudad.AutoSize = true;
            this.lblEmpleadoCiudad.Location = new System.Drawing.Point(12, 166);
            this.lblEmpleadoCiudad.Name = "lblEmpleadoCiudad";
            this.lblEmpleadoCiudad.Size = new System.Drawing.Size(40, 13);
            this.lblEmpleadoCiudad.TabIndex = 8;
            this.lblEmpleadoCiudad.Text = "Ciudad";
            // 
            // txtEmpleadoID
            // 
            this.txtEmpleadoID.Location = new System.Drawing.Point(64, 23);
            this.txtEmpleadoID.Name = "txtEmpleadoID";
            this.txtEmpleadoID.Size = new System.Drawing.Size(170, 20);
            this.txtEmpleadoID.TabIndex = 9;
            // 
            // txtEmpleadoApellido
            // 
            this.txtEmpleadoApellido.Location = new System.Drawing.Point(64, 52);
            this.txtEmpleadoApellido.Name = "txtEmpleadoApellido";
            this.txtEmpleadoApellido.Size = new System.Drawing.Size(170, 20);
            this.txtEmpleadoApellido.TabIndex = 10;
            // 
            // txtEmpleadoNombre
            // 
            this.txtEmpleadoNombre.Location = new System.Drawing.Point(64, 78);
            this.txtEmpleadoNombre.Name = "txtEmpleadoNombre";
            this.txtEmpleadoNombre.Size = new System.Drawing.Size(170, 20);
            this.txtEmpleadoNombre.TabIndex = 11;
            // 
            // txtEmpleadoFechaNacimiento
            // 
            this.txtEmpleadoFechaNacimiento.Location = new System.Drawing.Point(111, 104);
            this.txtEmpleadoFechaNacimiento.Name = "txtEmpleadoFechaNacimiento";
            this.txtEmpleadoFechaNacimiento.Size = new System.Drawing.Size(123, 20);
            this.txtEmpleadoFechaNacimiento.TabIndex = 12;
            // 
            // txtEmpleadoNacionalidad
            // 
            this.txtEmpleadoNacionalidad.Location = new System.Drawing.Point(87, 134);
            this.txtEmpleadoNacionalidad.Name = "txtEmpleadoNacionalidad";
            this.txtEmpleadoNacionalidad.Size = new System.Drawing.Size(147, 20);
            this.txtEmpleadoNacionalidad.TabIndex = 13;
            // 
            // txtEmpleadoCiudad
            // 
            this.txtEmpleadoCiudad.Location = new System.Drawing.Point(64, 160);
            this.txtEmpleadoCiudad.Name = "txtEmpleadoCiudad";
            this.txtEmpleadoCiudad.Size = new System.Drawing.Size(170, 20);
            this.txtEmpleadoCiudad.TabIndex = 14;
            // 
            // gridListarEmpleados
            // 
            this.gridListarEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridListarEmpleados.Location = new System.Drawing.Point(12, 186);
            this.gridListarEmpleados.Name = "gridListarEmpleados";
            this.gridListarEmpleados.Size = new System.Drawing.Size(647, 150);
            this.gridListarEmpleados.TabIndex = 15;
            // 
            // btnMostrarEmpleados
            // 
            this.btnMostrarEmpleados.Location = new System.Drawing.Point(255, 141);
            this.btnMostrarEmpleados.Name = "btnMostrarEmpleados";
            this.btnMostrarEmpleados.Size = new System.Drawing.Size(150, 23);
            this.btnMostrarEmpleados.TabIndex = 16;
            this.btnMostrarEmpleados.Text = "Mostrar";
            this.btnMostrarEmpleados.UseVisualStyleBackColor = true;
            this.btnMostrarEmpleados.Click += new System.EventHandler(this.btnMostrarEmpleados_Click);
            // 
            // txtTraerPorID
            // 
            this.txtTraerPorID.Location = new System.Drawing.Point(413, 30);
            this.txtTraerPorID.Name = "txtTraerPorID";
            this.txtTraerPorID.Size = new System.Drawing.Size(149, 20);
            this.txtTraerPorID.TabIndex = 17;
            // 
            // txtEliminarEmpleado
            // 
            this.txtEliminarEmpleado.Location = new System.Drawing.Point(432, 63);
            this.txtEliminarEmpleado.Name = "txtEliminarEmpleado";
            this.txtEliminarEmpleado.Size = new System.Drawing.Size(149, 20);
            this.txtEliminarEmpleado.TabIndex = 18;
            // 
            // lblNombreEmpleadoEliminado
            // 
            this.lblNombreEmpleadoEliminado.AutoSize = true;
            this.lblNombreEmpleadoEliminado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreEmpleadoEliminado.Location = new System.Drawing.Point(251, 61);
            this.lblNombreEmpleadoEliminado.Name = "lblNombreEmpleadoEliminado";
            this.lblNombreEmpleadoEliminado.Size = new System.Drawing.Size(175, 40);
            this.lblNombreEmpleadoEliminado.TabIndex = 19;
            this.lblNombreEmpleadoEliminado.Text = "Ingrese el nombre \r\ndel empleado a eliminar";
            // 
            // frmEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 344);
            this.Controls.Add(this.lblNombreEmpleadoEliminado);
            this.Controls.Add(this.txtEliminarEmpleado);
            this.Controls.Add(this.txtTraerPorID);
            this.Controls.Add(this.btnMostrarEmpleados);
            this.Controls.Add(this.gridListarEmpleados);
            this.Controls.Add(this.txtEmpleadoCiudad);
            this.Controls.Add(this.txtEmpleadoNacionalidad);
            this.Controls.Add(this.txtEmpleadoFechaNacimiento);
            this.Controls.Add(this.txtEmpleadoNombre);
            this.Controls.Add(this.txtEmpleadoApellido);
            this.Controls.Add(this.txtEmpleadoID);
            this.Controls.Add(this.lblEmpleadoCiudad);
            this.Controls.Add(this.lblEmpleadoNacionalidad);
            this.Controls.Add(this.lblEmpleadoFechaNacimiento);
            this.Controls.Add(this.lblEmpleadoID);
            this.Controls.Add(this.lblEmpleadoNombre);
            this.Controls.Add(this.lblEmpleadoApellido);
            this.Controls.Add(this.btnGuardarEmpleado);
            this.Controls.Add(this.btnEliminarEmpleado);
            this.Controls.Add(this.btnTraerPorID);
            this.Name = "frmEmpleado";
            this.Text = "frmEmpleado";
            this.Load += new System.EventHandler(this.frmEmpleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridListarEmpleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTraerPorID;
        private System.Windows.Forms.Button btnEliminarEmpleado;
        private System.Windows.Forms.Button btnGuardarEmpleado;
        private System.Windows.Forms.Label lblEmpleadoApellido;
        private System.Windows.Forms.Label lblEmpleadoNombre;
        private System.Windows.Forms.Label lblEmpleadoID;
        private System.Windows.Forms.Label lblEmpleadoFechaNacimiento;
        private System.Windows.Forms.Label lblEmpleadoNacionalidad;
        private System.Windows.Forms.Label lblEmpleadoCiudad;
        private System.Windows.Forms.TextBox txtEmpleadoID;
        private System.Windows.Forms.TextBox txtEmpleadoApellido;
        private System.Windows.Forms.TextBox txtEmpleadoNombre;
        private System.Windows.Forms.TextBox txtEmpleadoFechaNacimiento;
        private System.Windows.Forms.TextBox txtEmpleadoNacionalidad;
        private System.Windows.Forms.TextBox txtEmpleadoCiudad;
        private System.Windows.Forms.DataGridView gridListarEmpleados;
        private System.Windows.Forms.Button btnMostrarEmpleados;
        private System.Windows.Forms.TextBox txtTraerPorID;
        private System.Windows.Forms.TextBox txtEliminarEmpleado;
        private System.Windows.Forms.Label lblNombreEmpleadoEliminado;
    }
}