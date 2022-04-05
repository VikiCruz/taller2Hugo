using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TallerHugo2
{
    public partial class frmAuxilios : Form
    {
        public frmAuxilios()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            salir();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiarFormulario();
        }



        private void btnCalcular_Click(object sender, EventArgs e)
        {
            calcular();
        }

        private void frmAuxilios_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            limpiarFormulario();
        }

        private void chkSaludo_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSaludo.Checked)
            {
                groupSexo.Visible = true;
            }
            else
            {
                groupSexo.Visible = false;
            }
        }

        private void txtSueldoBasico_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void menuCalcular_Click(object sender, EventArgs e)
        {
            calcular();
        }



        private void menuNuevo_Click(object sender, EventArgs e)
        {
            limpiarFormulario();
        }

        private void MenuSalir_Click(object sender, EventArgs e)
        {
            salir();
        }
        private void limpiarFormulario()
        {
            txtNombreEmpleado.Focus();
            cmbCantidadHijos.SelectedIndex = 0;
            txtSueldoBasico.Text = "0";
            chkNoSocio.Checked = false;
            chkSaludo.Checked = false;
            txtResultados.Text = string.Empty;
            rbFem.Checked = true;
        }
        private void salir()
        {
            System.Windows.Forms.Application.Exit();
        }

        private void calcular()
        {
            try { 
            int salarioBasico, hijosRegs, subsidio, total;

            salarioBasico = Convert.ToInt32(txtSueldoBasico.Text);
            hijosRegs = Convert.ToInt32(cmbCantidadHijos.Text);
            subsidio = (salarioBasico <= 1500000 ? 30000 : 15000) * hijosRegs;
            total = salarioBasico + subsidio;



            String strResultados = $"{(rbMas.Checked ? "Sr." : "Sra.")} {txtNombreEmpleado.Text} el subsidio familiar otorgado es: " + System.Environment.NewLine
                + System.Environment.NewLine + $"Salario básico: {salarioBasico.ToString("C",CultureInfo.CurrentCulture)}" + System.Environment.NewLine
                + $"Hijos registrados: {hijosRegs}" + System.Environment.NewLine
                + $"Subsidio: {subsidio.ToString("C", CultureInfo.CurrentCulture)}" + Environment.NewLine
                + $"TOTAL: {total.ToString("C", CultureInfo.CurrentCulture)}";

            txtResultados.Text = strResultados;
            }catch (Exception ex)
            {
                errorProvider1.SetError(txtSueldoBasico, "Error");
                MessageBox.Show("Se ha generado una excepción con la información ingresada", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
