using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1practicas
{
    public partial class RecuperoContraseña : Form
    {
        public RecuperoContraseña()
        {
            InitializeComponent();
        }

        private void txtCodigoIngreso_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEnviarCodigo_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string mail = txtEmail.Text;

            ConsultaGen consulta = new ConsultaGen();
            if (string.IsNullOrEmpty(txtUsuario.Text) || string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("¡Debe completar todos los campos!","", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    if (consulta.ValidarUsuarioMail(usuario, mail))
                    {
                        MessageBox.Show("Un código ha sido enviado a su correo electrónico", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtCodigo.Enabled = true;
                        btnIngresarCodigo.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("¡Nombre de usuario y/o Correo no validos!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Se produjo un ERROR al conectar a la base de datos", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnIngresarCodigo_Click(object sender, EventArgs e)
        {
            int codigo;
            string usuario = txtUsuario.Text;
            if (int.TryParse(txtCodigo.Text, out codigo))
            {
                if (codigo == 01234)
                {
                    txtUsuario.Clear(); txtEmail.Clear();
                    ReestablecerContraseña reestablecer = new ReestablecerContraseña(usuario);
                    reestablecer.Show();
                    this.Close();
                }
                else MessageBox.Show("¡El código es incorrecto!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                MessageBox.Show("¡El campo no puede estar vacío!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else MessageBox.Show("¡El campo no puede contener letras!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }
        private void RecuperoContraseña_Load(object sender, EventArgs e)
        {

        }

        private void lblFechaNac_Click(object sender, EventArgs e)
        {

        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }

        private void txtUsuarioKey(object sender, KeyPressEventArgs UserKey)
        {
            if (Char.IsLetter(UserKey.KeyChar))
            {
                UserKey.Handled = false;
            }
            else if (Char.IsSeparator(UserKey.KeyChar))
            {
                UserKey.Handled = true;
            }
            else if (Char.IsControl(UserKey.KeyChar))
            {
                UserKey.Handled = false;
            }
            else if (Char.IsNumber(UserKey.KeyChar))
            {
                UserKey.Handled = false;
            }
            else
            {
                UserKey.Handled = true;
            }
        }
        private void btnCerrar2_Click(object sender, EventArgs e)
        {
            InicioSesion iniciosesion = new InicioSesion();
            iniciosesion.Show();
            this.Close();
        }

        private void btnMinizar2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lblIngreseCodigo_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void lblInicieSesion_Click_1(object sender, EventArgs e)
        {

        }

        private void pctKey_Click(object sender, EventArgs e)
        {

        }
    }
}            
        
