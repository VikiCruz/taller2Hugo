using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TallerHugo2
{
    public partial class frmLogin : Form
    {
        private int numIntentosFallidos;
        private const string USUARIO = "pepe";
        private const string CONTRASEÑA = "pepe123*";
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtUsuario.Text = USUARIO;
            txtContrasena.Text = CONTRASEÑA;
            numIntentosFallidos = 0;
            this.CenterToScreen();
            txtUsuario.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string usuarioIngresado = txtUsuario.Text;
            string contrasenaIngresada = txtContrasena.Text;

            if (usuarioIngresado== USUARIO && contrasenaIngresada==CONTRASEÑA)
            {
                using(frmAuxilios frmAuxilios= new frmAuxilios())
                {
                    this.Hide();
                    frmAuxilios.ShowDialog();
                }
            }
            else
            {
                numIntentosFallidos++;
                MessageBox.Show("Datos incorrectos. Cantidad de intentos restantes " + (3 - numIntentosFallidos), "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);


                if (numIntentosFallidos==3)
                {
                    this.Close();
                }
            }



        }
    }
}
