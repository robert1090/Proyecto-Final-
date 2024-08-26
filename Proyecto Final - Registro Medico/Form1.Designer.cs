namespace Proyecto_Final___Registro_Medico
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ListaPacientes = new System.Windows.Forms.DataGridView();
            this.BTNGuardar = new System.Windows.Forms.Button();
            this.BTNLimpiar = new System.Windows.Forms.Button();
            this.BTNSalir = new System.Windows.Forms.Button();
            this.Nombre = new System.Windows.Forms.Label();
            this.Titulo = new System.Windows.Forms.Label();
            this.Edad = new System.Windows.Forms.Label();
            this.Sexo = new System.Windows.Forms.Label();
            this.Diagnostico = new System.Windows.Forms.Label();
            this.Sangre = new System.Windows.Forms.Label();
            this.Practicas = new System.Windows.Forms.Label();
            this.Residencia = new System.Windows.Forms.Label();
            this.Telefono = new System.Windows.Forms.Label();
            this.Observaciones = new System.Windows.Forms.Label();
            this.BTNEditar = new System.Windows.Forms.Button();
            this.BTNBuscar = new System.Windows.Forms.Button();
            this.NombreBOX = new System.Windows.Forms.TextBox();
            this.EdadBOX = new System.Windows.Forms.TextBox();
            this.SexoBOX = new System.Windows.Forms.TextBox();
            this.PracticaBOX = new System.Windows.Forms.TextBox();
            this.DiagBOX = new System.Windows.Forms.TextBox();
            this.SangreBOX = new System.Windows.Forms.TextBox();
            this.TelefonoBOX = new System.Windows.Forms.TextBox();
            this.ObservacionBOX = new System.Windows.Forms.TextBox();
            this.ResidenciaBOX = new System.Windows.Forms.TextBox();
            this.BuscarBOX = new System.Windows.Forms.TextBox();
            this.NombreBuscar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ListaPacientes)).BeginInit();
            this.SuspendLayout();
            // 
            // ListaPacientes
            // 
            this.ListaPacientes.BackgroundColor = System.Drawing.Color.Silver;
            this.ListaPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListaPacientes.Location = new System.Drawing.Point(21, 238);
            this.ListaPacientes.Name = "ListaPacientes";
            this.ListaPacientes.Size = new System.Drawing.Size(1007, 330);
            this.ListaPacientes.TabIndex = 2;
            // 
            // BTNGuardar
            // 
            this.BTNGuardar.Location = new System.Drawing.Point(21, 193);
            this.BTNGuardar.Name = "BTNGuardar";
            this.BTNGuardar.Size = new System.Drawing.Size(122, 39);
            this.BTNGuardar.TabIndex = 3;
            this.BTNGuardar.Text = "Guardar";
            this.BTNGuardar.UseVisualStyleBackColor = true;
            this.BTNGuardar.Click += new System.EventHandler(this.BTNGuardar_Click);
            // 
            // BTNLimpiar
            // 
            this.BTNLimpiar.Location = new System.Drawing.Point(149, 193);
            this.BTNLimpiar.Name = "BTNLimpiar";
            this.BTNLimpiar.Size = new System.Drawing.Size(122, 39);
            this.BTNLimpiar.TabIndex = 4;
            this.BTNLimpiar.Text = "Limpiar Casillas";
            this.BTNLimpiar.UseVisualStyleBackColor = true;
            this.BTNLimpiar.Click += new System.EventHandler(this.BTNLimpiar_Click);
            // 
            // BTNSalir
            // 
            this.BTNSalir.Location = new System.Drawing.Point(906, 193);
            this.BTNSalir.Name = "BTNSalir";
            this.BTNSalir.Size = new System.Drawing.Size(122, 39);
            this.BTNSalir.TabIndex = 5;
            this.BTNSalir.Text = "Salir";
            this.BTNSalir.UseVisualStyleBackColor = true;
            this.BTNSalir.Click += new System.EventHandler(this.BTNSalir_Click);
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre.Location = new System.Drawing.Point(18, 59);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(69, 17);
            this.Nombre.TabIndex = 6;
            this.Nombre.Text = "Nombre:";
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.BackColor = System.Drawing.Color.Transparent;
            this.Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Titulo.Location = new System.Drawing.Point(16, 9);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(298, 25);
            this.Titulo.TabIndex = 7;
            this.Titulo.Text = "Registro Medico de Pacientes";
            // 
            // Edad
            // 
            this.Edad.AutoSize = true;
            this.Edad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edad.Location = new System.Drawing.Point(18, 92);
            this.Edad.Name = "Edad";
            this.Edad.Size = new System.Drawing.Size(50, 17);
            this.Edad.TabIndex = 8;
            this.Edad.Text = "Edad:";
            // 
            // Sexo
            // 
            this.Sexo.AutoSize = true;
            this.Sexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sexo.Location = new System.Drawing.Point(18, 123);
            this.Sexo.Name = "Sexo";
            this.Sexo.Size = new System.Drawing.Size(48, 17);
            this.Sexo.TabIndex = 9;
            this.Sexo.Text = "Sexo:";
            // 
            // Diagnostico
            // 
            this.Diagnostico.AutoSize = true;
            this.Diagnostico.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Diagnostico.Location = new System.Drawing.Point(274, 92);
            this.Diagnostico.Name = "Diagnostico";
            this.Diagnostico.Size = new System.Drawing.Size(98, 17);
            this.Diagnostico.TabIndex = 10;
            this.Diagnostico.Text = "Diagnostico:";
            // 
            // Sangre
            // 
            this.Sangre.AutoSize = true;
            this.Sangre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sangre.Location = new System.Drawing.Point(274, 59);
            this.Sangre.Name = "Sangre";
            this.Sangre.Size = new System.Drawing.Size(125, 17);
            this.Sangre.TabIndex = 11;
            this.Sangre.Text = "Tipo de Sangre:";
            // 
            // Practicas
            // 
            this.Practicas.AutoSize = true;
            this.Practicas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Practicas.Location = new System.Drawing.Point(274, 123);
            this.Practicas.Name = "Practicas";
            this.Practicas.Size = new System.Drawing.Size(151, 17);
            this.Practicas.TabIndex = 12;
            this.Practicas.Text = "Practica a Realizar:";
            // 
            // Residencia
            // 
            this.Residencia.AutoSize = true;
            this.Residencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Residencia.Location = new System.Drawing.Point(639, 59);
            this.Residencia.Name = "Residencia";
            this.Residencia.Size = new System.Drawing.Size(93, 17);
            this.Residencia.TabIndex = 13;
            this.Residencia.Text = "Residencia:";
            // 
            // Telefono
            // 
            this.Telefono.AutoSize = true;
            this.Telefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Telefono.Location = new System.Drawing.Point(639, 92);
            this.Telefono.Name = "Telefono";
            this.Telefono.Size = new System.Drawing.Size(161, 17);
            this.Telefono.TabIndex = 14;
            this.Telefono.Text = "Numero de Telefono:";
            // 
            // Observaciones
            // 
            this.Observaciones.AutoSize = true;
            this.Observaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Observaciones.Location = new System.Drawing.Point(639, 123);
            this.Observaciones.Name = "Observaciones";
            this.Observaciones.Size = new System.Drawing.Size(121, 17);
            this.Observaciones.TabIndex = 15;
            this.Observaciones.Text = "Observaciones:";
            // 
            // BTNEditar
            // 
            this.BTNEditar.Location = new System.Drawing.Point(778, 193);
            this.BTNEditar.Name = "BTNEditar";
            this.BTNEditar.Size = new System.Drawing.Size(122, 39);
            this.BTNEditar.TabIndex = 16;
            this.BTNEditar.Text = "Editar";
            this.BTNEditar.UseVisualStyleBackColor = true;
            this.BTNEditar.Click += new System.EventHandler(this.BTNEditar_Click);
            // 
            // BTNBuscar
            // 
            this.BTNBuscar.Location = new System.Drawing.Point(277, 193);
            this.BTNBuscar.Name = "BTNBuscar";
            this.BTNBuscar.Size = new System.Drawing.Size(122, 39);
            this.BTNBuscar.TabIndex = 17;
            this.BTNBuscar.Text = "Buscar";
            this.BTNBuscar.UseVisualStyleBackColor = true;
            this.BTNBuscar.Click += new System.EventHandler(this.BTNBuscar_Click);
            // 
            // NombreBOX
            // 
            this.NombreBOX.Location = new System.Drawing.Point(93, 58);
            this.NombreBOX.Name = "NombreBOX";
            this.NombreBOX.Size = new System.Drawing.Size(175, 20);
            this.NombreBOX.TabIndex = 18;
            this.NombreBOX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NombreBOX_KeyPress);
            // 
            // EdadBOX
            // 
            this.EdadBOX.Location = new System.Drawing.Point(93, 91);
            this.EdadBOX.Name = "EdadBOX";
            this.EdadBOX.Size = new System.Drawing.Size(175, 20);
            this.EdadBOX.TabIndex = 19;
            this.EdadBOX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EdadBOX_KeyPress);
            // 
            // SexoBOX
            // 
            this.SexoBOX.Location = new System.Drawing.Point(93, 122);
            this.SexoBOX.Name = "SexoBOX";
            this.SexoBOX.Size = new System.Drawing.Size(175, 20);
            this.SexoBOX.TabIndex = 20;
            this.SexoBOX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SexoBOX_KeyPress);
            // 
            // PracticaBOX
            // 
            this.PracticaBOX.Location = new System.Drawing.Point(431, 122);
            this.PracticaBOX.Name = "PracticaBOX";
            this.PracticaBOX.Size = new System.Drawing.Size(202, 20);
            this.PracticaBOX.TabIndex = 21;
            // 
            // DiagBOX
            // 
            this.DiagBOX.Location = new System.Drawing.Point(431, 91);
            this.DiagBOX.Name = "DiagBOX";
            this.DiagBOX.Size = new System.Drawing.Size(202, 20);
            this.DiagBOX.TabIndex = 22;
            // 
            // SangreBOX
            // 
            this.SangreBOX.Location = new System.Drawing.Point(431, 58);
            this.SangreBOX.Name = "SangreBOX";
            this.SangreBOX.Size = new System.Drawing.Size(202, 20);
            this.SangreBOX.TabIndex = 23;
            this.SangreBOX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SangreBOX_KeyPress);
            // 
            // TelefonoBOX
            // 
            this.TelefonoBOX.Location = new System.Drawing.Point(806, 92);
            this.TelefonoBOX.Name = "TelefonoBOX";
            this.TelefonoBOX.Size = new System.Drawing.Size(222, 20);
            this.TelefonoBOX.TabIndex = 24;
            this.TelefonoBOX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TelefonoBOX_KeyPress);
            // 
            // ObservacionBOX
            // 
            this.ObservacionBOX.Location = new System.Drawing.Point(806, 122);
            this.ObservacionBOX.Name = "ObservacionBOX";
            this.ObservacionBOX.Size = new System.Drawing.Size(222, 20);
            this.ObservacionBOX.TabIndex = 25;
            // 
            // ResidenciaBOX
            // 
            this.ResidenciaBOX.Location = new System.Drawing.Point(806, 58);
            this.ResidenciaBOX.Name = "ResidenciaBOX";
            this.ResidenciaBOX.Size = new System.Drawing.Size(222, 20);
            this.ResidenciaBOX.TabIndex = 26;
            // 
            // BuscarBOX
            // 
            this.BuscarBOX.Location = new System.Drawing.Point(575, 203);
            this.BuscarBOX.Name = "BuscarBOX";
            this.BuscarBOX.Size = new System.Drawing.Size(197, 20);
            this.BuscarBOX.TabIndex = 27;
            this.BuscarBOX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BuscarBOX_KeyPress);
            // 
            // NombreBuscar
            // 
            this.NombreBuscar.AutoSize = true;
            this.NombreBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreBuscar.Location = new System.Drawing.Point(405, 204);
            this.NombreBuscar.Name = "NombreBuscar";
            this.NombreBuscar.Size = new System.Drawing.Size(164, 17);
            this.NombreBuscar.TabIndex = 28;
            this.NombreBuscar.Text = "Nombre del Paciente:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1050, 580);
            this.Controls.Add(this.NombreBuscar);
            this.Controls.Add(this.BuscarBOX);
            this.Controls.Add(this.ResidenciaBOX);
            this.Controls.Add(this.ObservacionBOX);
            this.Controls.Add(this.TelefonoBOX);
            this.Controls.Add(this.SangreBOX);
            this.Controls.Add(this.DiagBOX);
            this.Controls.Add(this.PracticaBOX);
            this.Controls.Add(this.SexoBOX);
            this.Controls.Add(this.EdadBOX);
            this.Controls.Add(this.NombreBOX);
            this.Controls.Add(this.BTNBuscar);
            this.Controls.Add(this.BTNEditar);
            this.Controls.Add(this.Observaciones);
            this.Controls.Add(this.Telefono);
            this.Controls.Add(this.Residencia);
            this.Controls.Add(this.Practicas);
            this.Controls.Add(this.Sangre);
            this.Controls.Add(this.Diagnostico);
            this.Controls.Add(this.Sexo);
            this.Controls.Add(this.Edad);
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.BTNSalir);
            this.Controls.Add(this.BTNLimpiar);
            this.Controls.Add(this.BTNGuardar);
            this.Controls.Add(this.ListaPacientes);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ListaPacientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ListaPacientes;
        private System.Windows.Forms.Button BTNGuardar;
        private System.Windows.Forms.Button BTNLimpiar;
        private System.Windows.Forms.Button BTNSalir;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.Label Edad;
        private System.Windows.Forms.Label Sexo;
        private System.Windows.Forms.Label Diagnostico;
        private System.Windows.Forms.Label Sangre;
        private System.Windows.Forms.Label Practicas;
        private System.Windows.Forms.Label Residencia;
        private System.Windows.Forms.Label Telefono;
        private System.Windows.Forms.Label Observaciones;
        private System.Windows.Forms.Button BTNEditar;
        private System.Windows.Forms.Button BTNBuscar;
        private System.Windows.Forms.TextBox NombreBOX;
        private System.Windows.Forms.TextBox EdadBOX;
        private System.Windows.Forms.TextBox SexoBOX;
        private System.Windows.Forms.TextBox PracticaBOX;
        private System.Windows.Forms.TextBox DiagBOX;
        private System.Windows.Forms.TextBox SangreBOX;
        private System.Windows.Forms.TextBox TelefonoBOX;
        private System.Windows.Forms.TextBox ObservacionBOX;
        private System.Windows.Forms.TextBox ResidenciaBOX;
        private System.Windows.Forms.TextBox BuscarBOX;
        private System.Windows.Forms.Label NombreBuscar;
    }
}

