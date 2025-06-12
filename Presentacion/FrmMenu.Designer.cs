namespace Presentacion
{
    partial class FrmMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.perfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarContraseñaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearNuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odontólogosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verOdontólogosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarNuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pacientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verPacientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarNuevoPacienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.citasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verCitasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programarNuevaCitaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.odontólogosToolStripMenuItem,
            this.pacientesToolStripMenuItem,
            this.citasToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1285, 40);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.perfilToolStripMenuItem,
            this.cambiarContraseñaToolStripMenuItem,
            this.crearNuevoToolStripMenuItem});
            this.inicioToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(82, 36);
            this.inicioToolStripMenuItem.Text = "PERFIL";
            // 
            // perfilToolStripMenuItem
            // 
            this.perfilToolStripMenuItem.Name = "perfilToolStripMenuItem";
            this.perfilToolStripMenuItem.Size = new System.Drawing.Size(269, 30);
            this.perfilToolStripMenuItem.Text = "Perfil";
            this.perfilToolStripMenuItem.Click += new System.EventHandler(this.perfilToolStripMenuItem_Click);
            // 
            // cambiarContraseñaToolStripMenuItem
            // 
            this.cambiarContraseñaToolStripMenuItem.Name = "cambiarContraseñaToolStripMenuItem";
            this.cambiarContraseñaToolStripMenuItem.Size = new System.Drawing.Size(269, 30);
            this.cambiarContraseñaToolStripMenuItem.Text = "Actualizar contraseña";
            this.cambiarContraseñaToolStripMenuItem.Click += new System.EventHandler(this.cambiarContraseñaToolStripMenuItem_Click);
            // 
            // crearNuevoToolStripMenuItem
            // 
            this.crearNuevoToolStripMenuItem.Name = "crearNuevoToolStripMenuItem";
            this.crearNuevoToolStripMenuItem.Size = new System.Drawing.Size(269, 30);
            this.crearNuevoToolStripMenuItem.Text = "Crear nuevo";
            this.crearNuevoToolStripMenuItem.Click += new System.EventHandler(this.crearNuevoToolStripMenuItem_Click);
            // 
            // odontólogosToolStripMenuItem
            // 
            this.odontólogosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verOdontólogosToolStripMenuItem,
            this.registrarNuevoToolStripMenuItem});
            this.odontólogosToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.odontólogosToolStripMenuItem.Name = "odontólogosToolStripMenuItem";
            this.odontólogosToolStripMenuItem.Size = new System.Drawing.Size(163, 36);
            this.odontólogosToolStripMenuItem.Text = "ODONTÓLOGOS";
            // 
            // verOdontólogosToolStripMenuItem
            // 
            this.verOdontólogosToolStripMenuItem.Name = "verOdontólogosToolStripMenuItem";
            this.verOdontólogosToolStripMenuItem.Size = new System.Drawing.Size(228, 30);
            this.verOdontólogosToolStripMenuItem.Text = "Ver Odontólogos";
            this.verOdontólogosToolStripMenuItem.Click += new System.EventHandler(this.verOdontólogosToolStripMenuItem_Click);
            // 
            // registrarNuevoToolStripMenuItem
            // 
            this.registrarNuevoToolStripMenuItem.Name = "registrarNuevoToolStripMenuItem";
            this.registrarNuevoToolStripMenuItem.Size = new System.Drawing.Size(228, 30);
            this.registrarNuevoToolStripMenuItem.Text = "Registrar nuevo";
            this.registrarNuevoToolStripMenuItem.Click += new System.EventHandler(this.registrarNuevoToolStripMenuItem_Click);
            // 
            // pacientesToolStripMenuItem
            // 
            this.pacientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verPacientesToolStripMenuItem,
            this.registrarNuevoPacienteToolStripMenuItem});
            this.pacientesToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.pacientesToolStripMenuItem.Name = "pacientesToolStripMenuItem";
            this.pacientesToolStripMenuItem.Size = new System.Drawing.Size(120, 36);
            this.pacientesToolStripMenuItem.Text = "PACIENTES";
            // 
            // verPacientesToolStripMenuItem
            // 
            this.verPacientesToolStripMenuItem.Name = "verPacientesToolStripMenuItem";
            this.verPacientesToolStripMenuItem.Size = new System.Drawing.Size(218, 30);
            this.verPacientesToolStripMenuItem.Text = "Ver pacientes";
            this.verPacientesToolStripMenuItem.Click += new System.EventHandler(this.verPacientesToolStripMenuItem_Click);
            // 
            // registrarNuevoPacienteToolStripMenuItem
            // 
            this.registrarNuevoPacienteToolStripMenuItem.Name = "registrarNuevoPacienteToolStripMenuItem";
            this.registrarNuevoPacienteToolStripMenuItem.Size = new System.Drawing.Size(218, 30);
            this.registrarNuevoPacienteToolStripMenuItem.Text = "Registrar nuevo";
            this.registrarNuevoPacienteToolStripMenuItem.Click += new System.EventHandler(this.registrarNuevoPacienteToolStripMenuItem_Click);
            // 
            // citasToolStripMenuItem
            // 
            this.citasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verCitasToolStripMenuItem,
            this.programarNuevaCitaToolStripMenuItem});
            this.citasToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.citasToolStripMenuItem.Name = "citasToolStripMenuItem";
            this.citasToolStripMenuItem.Size = new System.Drawing.Size(74, 36);
            this.citasToolStripMenuItem.Text = "CITAS";
            // 
            // verCitasToolStripMenuItem
            // 
            this.verCitasToolStripMenuItem.Name = "verCitasToolStripMenuItem";
            this.verCitasToolStripMenuItem.Size = new System.Drawing.Size(217, 30);
            this.verCitasToolStripMenuItem.Text = "Ver citas";
            this.verCitasToolStripMenuItem.Click += new System.EventHandler(this.verCitasToolStripMenuItem_Click);
            // 
            // programarNuevaCitaToolStripMenuItem
            // 
            this.programarNuevaCitaToolStripMenuItem.Name = "programarNuevaCitaToolStripMenuItem";
            this.programarNuevaCitaToolStripMenuItem.Size = new System.Drawing.Size(217, 30);
            this.programarNuevaCitaToolStripMenuItem.Text = "Registrar nueva";
            this.programarNuevaCitaToolStripMenuItem.Click += new System.EventHandler(this.programarNuevaCitaToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(113, 36);
            this.reportesToolStripMenuItem.Text = "REPORTES";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.salirToolStripMenuItem.BackColor = System.Drawing.Color.Red;
            this.salirToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salirToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(178, 36);
            this.salirToolStripMenuItem.Text = "Cerrar Sesión";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1285, 777);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem perfilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambiarContraseñaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odontólogosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verOdontólogosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarNuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pacientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verPacientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarNuevoPacienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem citasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verCitasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem programarNuevaCitaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearNuevoToolStripMenuItem;
    }
}