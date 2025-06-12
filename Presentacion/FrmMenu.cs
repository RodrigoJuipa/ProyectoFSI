using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void perfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPerfil frm = new FrmPerfil();
            frm.ShowDialog();
        }

        private void cambiarContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmActualizarContraseña frm = new FrmActualizarContraseña();
            frm.ShowDialog();
        }

        private void verOdontólogosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOdontologos frm = new FrmOdontologos();
            frm.ShowDialog();
        }

        private void registrarNuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRegistrarOdontologo frm = new FrmRegistrarOdontologo();
            frm.ShowDialog();
        }

        private void verPacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPacientes frm = new FrmPacientes();
            frm.ShowDialog();
        }

        private void registrarNuevoPacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRegistrarPaciente frm = new FrmRegistrarPaciente();
            frm.ShowDialog();
        }

        private void crearNuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCrearPerfil frm = new FrmCrearPerfil();
            frm.ShowDialog();
        }

        private void verCitasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCitas frm = new FrmCitas();
            frm.ShowDialog();
        }

        private void programarNuevaCitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRegistrarCita frm = new FrmRegistrarCita();
            frm.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
