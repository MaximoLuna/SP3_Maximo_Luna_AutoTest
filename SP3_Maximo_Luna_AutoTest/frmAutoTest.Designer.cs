namespace SP3_Maximo_Luna_AutoTest
{
    partial class frmAutoTest
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
            this.mrcRegistroDeTurnos = new System.Windows.Forms.GroupBox();
            this.NumAñoFabricacion = new System.Windows.Forms.NumericUpDown();
            this.txtTitular = new System.Windows.Forms.TextBox();
            this.txtDominio = new System.Windows.Forms.TextBox();
            this.txtNumeroDeTurno = new System.Windows.Forms.TextBox();
            this.lblTitular = new System.Windows.Forms.Label();
            this.lblAñoFabricacion = new System.Windows.Forms.Label();
            this.lblDominio = new System.Windows.Forms.Label();
            this.lblNumeroDeTurno = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.mrcEstadistica = new System.Windows.Forms.GroupBox();
            this.txtCantidadConDominioDe6Caracteres = new System.Windows.Forms.TextBox();
            this.txtAñoDelMasAntiguo = new System.Windows.Forms.TextBox();
            this.txtCantidadDeTurnos = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mrcRegistroDeTurnos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumAñoFabricacion)).BeginInit();
            this.mrcEstadistica.SuspendLayout();
            this.SuspendLayout();
            // 
            // mrcRegistroDeTurnos
            // 
            this.mrcRegistroDeTurnos.Controls.Add(this.NumAñoFabricacion);
            this.mrcRegistroDeTurnos.Controls.Add(this.txtTitular);
            this.mrcRegistroDeTurnos.Controls.Add(this.txtDominio);
            this.mrcRegistroDeTurnos.Controls.Add(this.txtNumeroDeTurno);
            this.mrcRegistroDeTurnos.Controls.Add(this.lblTitular);
            this.mrcRegistroDeTurnos.Controls.Add(this.lblAñoFabricacion);
            this.mrcRegistroDeTurnos.Controls.Add(this.lblDominio);
            this.mrcRegistroDeTurnos.Controls.Add(this.lblNumeroDeTurno);
            this.mrcRegistroDeTurnos.Location = new System.Drawing.Point(12, 12);
            this.mrcRegistroDeTurnos.Name = "mrcRegistroDeTurnos";
            this.mrcRegistroDeTurnos.Size = new System.Drawing.Size(492, 228);
            this.mrcRegistroDeTurnos.TabIndex = 0;
            this.mrcRegistroDeTurnos.TabStop = false;
            this.mrcRegistroDeTurnos.Text = "Registro de Turnos";
            // 
            // NumAñoFabricacion
            // 
            this.NumAñoFabricacion.Location = new System.Drawing.Point(102, 108);
            this.NumAñoFabricacion.Name = "NumAñoFabricacion";
            this.NumAñoFabricacion.Size = new System.Drawing.Size(63, 20);
            this.NumAñoFabricacion.TabIndex = 3;
            // 
            // txtTitular
            // 
            this.txtTitular.Location = new System.Drawing.Point(102, 142);
            this.txtTitular.MaxLength = 30;
            this.txtTitular.Name = "txtTitular";
            this.txtTitular.Size = new System.Drawing.Size(345, 20);
            this.txtTitular.TabIndex = 6;
            // 
            // txtDominio
            // 
            this.txtDominio.Location = new System.Drawing.Point(102, 67);
            this.txtDominio.MaxLength = 7;
            this.txtDominio.Name = "txtDominio";
            this.txtDominio.Size = new System.Drawing.Size(112, 20);
            this.txtDominio.TabIndex = 5;
            // 
            // txtNumeroDeTurno
            // 
            this.txtNumeroDeTurno.Location = new System.Drawing.Point(102, 26);
            this.txtNumeroDeTurno.MaxLength = 999999;
            this.txtNumeroDeTurno.Name = "txtNumeroDeTurno";
            this.txtNumeroDeTurno.Size = new System.Drawing.Size(79, 20);
            this.txtNumeroDeTurno.TabIndex = 4;
            this.txtNumeroDeTurno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeroDeTurno_KeyPress);
            // 
            // lblTitular
            // 
            this.lblTitular.AutoSize = true;
            this.lblTitular.Location = new System.Drawing.Point(6, 149);
            this.lblTitular.Name = "lblTitular";
            this.lblTitular.Size = new System.Drawing.Size(36, 13);
            this.lblTitular.TabIndex = 3;
            this.lblTitular.Text = "Titular";
            // 
            // lblAñoFabricacion
            // 
            this.lblAñoFabricacion.AutoSize = true;
            this.lblAñoFabricacion.Location = new System.Drawing.Point(6, 108);
            this.lblAñoFabricacion.Name = "lblAñoFabricacion";
            this.lblAñoFabricacion.Size = new System.Drawing.Size(84, 13);
            this.lblAñoFabricacion.TabIndex = 2;
            this.lblAñoFabricacion.Text = "Año Fabricación";
            // 
            // lblDominio
            // 
            this.lblDominio.AutoSize = true;
            this.lblDominio.Location = new System.Drawing.Point(6, 65);
            this.lblDominio.Name = "lblDominio";
            this.lblDominio.Size = new System.Drawing.Size(45, 13);
            this.lblDominio.TabIndex = 1;
            this.lblDominio.Text = "Dominio";
            // 
            // lblNumeroDeTurno
            // 
            this.lblNumeroDeTurno.AutoSize = true;
            this.lblNumeroDeTurno.Location = new System.Drawing.Point(6, 26);
            this.lblNumeroDeTurno.Name = "lblNumeroDeTurno";
            this.lblNumeroDeTurno.Size = new System.Drawing.Size(90, 13);
            this.lblNumeroDeTurno.TabIndex = 0;
            this.lblNumeroDeTurno.Text = "Numero de Turno";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(540, 28);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 30);
            this.btnRegistrar.TabIndex = 0;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(540, 77);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(77, 30);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(540, 278);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(74, 30);
            this.btnConsultar.TabIndex = 2;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            // 
            // mrcEstadistica
            // 
            this.mrcEstadistica.Controls.Add(this.txtCantidadConDominioDe6Caracteres);
            this.mrcEstadistica.Controls.Add(this.txtAñoDelMasAntiguo);
            this.mrcEstadistica.Controls.Add(this.txtCantidadDeTurnos);
            this.mrcEstadistica.Controls.Add(this.label3);
            this.mrcEstadistica.Controls.Add(this.label2);
            this.mrcEstadistica.Controls.Add(this.label1);
            this.mrcEstadistica.Location = new System.Drawing.Point(13, 278);
            this.mrcEstadistica.Name = "mrcEstadistica";
            this.mrcEstadistica.Size = new System.Drawing.Size(491, 160);
            this.mrcEstadistica.TabIndex = 1;
            this.mrcEstadistica.TabStop = false;
            this.mrcEstadistica.Text = "Estadistica";
            // 
            // txtCantidadConDominioDe6Caracteres
            // 
            this.txtCantidadConDominioDe6Caracteres.Location = new System.Drawing.Point(213, 110);
            this.txtCantidadConDominioDe6Caracteres.Name = "txtCantidadConDominioDe6Caracteres";
            this.txtCantidadConDominioDe6Caracteres.Size = new System.Drawing.Size(100, 20);
            this.txtCantidadConDominioDe6Caracteres.TabIndex = 9;
            // 
            // txtAñoDelMasAntiguo
            // 
            this.txtAñoDelMasAntiguo.Location = new System.Drawing.Point(213, 73);
            this.txtAñoDelMasAntiguo.Name = "txtAñoDelMasAntiguo";
            this.txtAñoDelMasAntiguo.Size = new System.Drawing.Size(100, 20);
            this.txtAñoDelMasAntiguo.TabIndex = 8;
            // 
            // txtCantidadDeTurnos
            // 
            this.txtCantidadDeTurnos.Location = new System.Drawing.Point(213, 35);
            this.txtCantidadDeTurnos.Name = "txtCantidadDeTurnos";
            this.txtCantidadDeTurnos.Size = new System.Drawing.Size(100, 20);
            this.txtCantidadDeTurnos.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cantidad con dominio de 6 caracteres";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Año del más Antiguo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cantidad de Turnos";
            // 
            // frmAutoTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 467);
            this.Controls.Add(this.mrcEstadistica);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.mrcRegistroDeTurnos);
            this.Name = "frmAutoTest";
            this.Text = "AutoTest";
            this.mrcRegistroDeTurnos.ResumeLayout(false);
            this.mrcRegistroDeTurnos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumAñoFabricacion)).EndInit();
            this.mrcEstadistica.ResumeLayout(false);
            this.mrcEstadistica.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox mrcRegistroDeTurnos;
        private System.Windows.Forms.TextBox txtTitular;
        private System.Windows.Forms.TextBox txtDominio;
        private System.Windows.Forms.TextBox txtNumeroDeTurno;
        private System.Windows.Forms.Label lblTitular;
        private System.Windows.Forms.Label lblAñoFabricacion;
        private System.Windows.Forms.Label lblDominio;
        private System.Windows.Forms.Label lblNumeroDeTurno;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.GroupBox mrcEstadistica;
        private System.Windows.Forms.TextBox txtCantidadConDominioDe6Caracteres;
        private System.Windows.Forms.TextBox txtAñoDelMasAntiguo;
        private System.Windows.Forms.TextBox txtCantidadDeTurnos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown NumAñoFabricacion;
    }
}

