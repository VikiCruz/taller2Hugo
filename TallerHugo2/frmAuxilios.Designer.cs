namespace TallerHugo2
{
    partial class frmAuxilios
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuOpciones = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCalcular = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNuevo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombreEmpleado = new System.Windows.Forms.TextBox();
            this.txtSueldoBasico = new System.Windows.Forms.TextBox();
            this.cmbCantidadHijos = new System.Windows.Forms.ComboBox();
            this.chkNoSocio = new System.Windows.Forms.CheckBox();
            this.chkSaludo = new System.Windows.Forms.CheckBox();
            this.groupSexo = new System.Windows.Forms.GroupBox();
            this.rbT = new System.Windows.Forms.RadioButton();
            this.rbMas = new System.Windows.Forms.RadioButton();
            this.rbFem = new System.Windows.Forms.RadioButton();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.grupoResultados = new System.Windows.Forms.GroupBox();
            this.txtResultados = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.menuStrip1.SuspendLayout();
            this.groupSexo.SuspendLayout();
            this.grupoResultados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuOpciones});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(470, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuOpciones
            // 
            this.menuOpciones.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCalcular,
            this.menuNuevo,
            this.toolStripSeparator1,
            this.MenuSalir});
            this.menuOpciones.Name = "menuOpciones";
            this.menuOpciones.Size = new System.Drawing.Size(69, 20);
            this.menuOpciones.Text = "Opciones";
            // 
            // menuCalcular
            // 
            this.menuCalcular.Name = "menuCalcular";
            this.menuCalcular.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.menuCalcular.Size = new System.Drawing.Size(180, 22);
            this.menuCalcular.Text = "&Calcular";
            this.menuCalcular.Click += new System.EventHandler(this.menuCalcular_Click);
            // 
            // menuNuevo
            // 
            this.menuNuevo.Name = "menuNuevo";
            this.menuNuevo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.menuNuevo.Size = new System.Drawing.Size(180, 22);
            this.menuNuevo.Text = "&Nuevo";
            this.menuNuevo.Click += new System.EventHandler(this.menuNuevo_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // MenuSalir
            // 
            this.MenuSalir.Name = "MenuSalir";
            this.MenuSalir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.MenuSalir.Size = new System.Drawing.Size(180, 22);
            this.MenuSalir.Text = "&Salir";
            this.MenuSalir.Click += new System.EventHandler(this.MenuSalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre Empleado:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cantidad de hijos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sueldo básico:";
            // 
            // txtNombreEmpleado
            // 
            this.txtNombreEmpleado.Location = new System.Drawing.Point(147, 35);
            this.txtNombreEmpleado.Name = "txtNombreEmpleado";
            this.txtNombreEmpleado.Size = new System.Drawing.Size(121, 20);
            this.txtNombreEmpleado.TabIndex = 5;
            // 
            // txtSueldoBasico
            // 
            this.txtSueldoBasico.Location = new System.Drawing.Point(147, 88);
            this.txtSueldoBasico.Name = "txtSueldoBasico";
            this.txtSueldoBasico.Size = new System.Drawing.Size(121, 20);
            this.txtSueldoBasico.TabIndex = 6;
            this.txtSueldoBasico.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSueldoBasico_KeyPress);
            // 
            // cmbCantidadHijos
            // 
            this.cmbCantidadHijos.FormattingEnabled = true;
            this.cmbCantidadHijos.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmbCantidadHijos.Location = new System.Drawing.Point(147, 61);
            this.cmbCantidadHijos.Name = "cmbCantidadHijos";
            this.cmbCantidadHijos.Size = new System.Drawing.Size(121, 21);
            this.cmbCantidadHijos.TabIndex = 7;
            // 
            // chkNoSocio
            // 
            this.chkNoSocio.AutoSize = true;
            this.chkNoSocio.Location = new System.Drawing.Point(35, 129);
            this.chkNoSocio.Name = "chkNoSocio";
            this.chkNoSocio.Size = new System.Drawing.Size(134, 17);
            this.chkNoSocio.TabIndex = 8;
            this.chkNoSocio.Text = "NO Socio de Sindicato";
            this.chkNoSocio.UseVisualStyleBackColor = true;
            // 
            // chkSaludo
            // 
            this.chkSaludo.AutoSize = true;
            this.chkSaludo.Location = new System.Drawing.Point(35, 153);
            this.chkSaludo.Name = "chkSaludo";
            this.chkSaludo.Size = new System.Drawing.Size(59, 17);
            this.chkSaludo.TabIndex = 9;
            this.chkSaludo.Text = "Saludo";
            this.chkSaludo.UseVisualStyleBackColor = true;
            this.chkSaludo.CheckedChanged += new System.EventHandler(this.chkSaludo_CheckedChanged);
            // 
            // groupSexo
            // 
            this.groupSexo.Controls.Add(this.rbT);
            this.groupSexo.Controls.Add(this.rbMas);
            this.groupSexo.Controls.Add(this.rbFem);
            this.groupSexo.Location = new System.Drawing.Point(35, 176);
            this.groupSexo.Name = "groupSexo";
            this.groupSexo.Size = new System.Drawing.Size(200, 64);
            this.groupSexo.TabIndex = 10;
            this.groupSexo.TabStop = false;
            this.groupSexo.Text = "Sexo";
            this.groupSexo.Visible = false;
            // 
            // rbT
            // 
            this.rbT.AutoSize = true;
            this.rbT.Location = new System.Drawing.Point(112, 30);
            this.rbT.Name = "rbT";
            this.rbT.Size = new System.Drawing.Size(32, 17);
            this.rbT.TabIndex = 15;
            this.rbT.TabStop = true;
            this.rbT.Text = "T";
            this.rbT.UseVisualStyleBackColor = true;
            // 
            // rbMas
            // 
            this.rbMas.AutoSize = true;
            this.rbMas.Location = new System.Drawing.Point(57, 30);
            this.rbMas.Name = "rbMas";
            this.rbMas.Size = new System.Drawing.Size(34, 17);
            this.rbMas.TabIndex = 1;
            this.rbMas.TabStop = true;
            this.rbMas.Text = "M";
            this.rbMas.UseVisualStyleBackColor = true;
            // 
            // rbFem
            // 
            this.rbFem.AutoSize = true;
            this.rbFem.Location = new System.Drawing.Point(7, 30);
            this.rbFem.Name = "rbFem";
            this.rbFem.Size = new System.Drawing.Size(31, 17);
            this.rbFem.TabIndex = 0;
            this.rbFem.TabStop = true;
            this.rbFem.Text = "F";
            this.rbFem.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(282, 186);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 11;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // grupoResultados
            // 
            this.grupoResultados.Controls.Add(this.txtResultados);
            this.grupoResultados.Location = new System.Drawing.Point(35, 246);
            this.grupoResultados.Name = "grupoResultados";
            this.grupoResultados.Size = new System.Drawing.Size(400, 159);
            this.grupoResultados.TabIndex = 12;
            this.grupoResultados.TabStop = false;
            this.grupoResultados.Text = "Resultados";
            // 
            // txtResultados
            // 
            this.txtResultados.Location = new System.Drawing.Point(7, 20);
            this.txtResultados.Multiline = true;
            this.txtResultados.Name = "txtResultados";
            this.txtResultados.ReadOnly = true;
            this.txtResultados.Size = new System.Drawing.Size(387, 133);
            this.txtResultados.TabIndex = 0;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(282, 415);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 13;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(383, 415);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 14;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmAuxilios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 450);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.grupoResultados);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.groupSexo);
            this.Controls.Add(this.chkSaludo);
            this.Controls.Add(this.chkNoSocio);
            this.Controls.Add(this.cmbCantidadHijos);
            this.Controls.Add(this.txtSueldoBasico);
            this.Controls.Add(this.txtNombreEmpleado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmAuxilios";
            this.Text = "Auxilios familiares";
            this.Load += new System.EventHandler(this.frmAuxilios_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupSexo.ResumeLayout(false);
            this.groupSexo.PerformLayout();
            this.grupoResultados.ResumeLayout(false);
            this.grupoResultados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombreEmpleado;
        private System.Windows.Forms.TextBox txtSueldoBasico;
        private System.Windows.Forms.ComboBox cmbCantidadHijos;
        private System.Windows.Forms.ToolStripMenuItem menuOpciones;
        private System.Windows.Forms.CheckBox chkNoSocio;
        private System.Windows.Forms.CheckBox chkSaludo;
        private System.Windows.Forms.GroupBox groupSexo;
        private System.Windows.Forms.RadioButton rbT;
        private System.Windows.Forms.RadioButton rbMas;
        private System.Windows.Forms.RadioButton rbFem;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.GroupBox grupoResultados;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolStripMenuItem menuCalcular;
        private System.Windows.Forms.ToolStripMenuItem menuNuevo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem MenuSalir;
        private System.Windows.Forms.TextBox txtResultados;
    }
}