using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace TP1practicas
{
    public partial class ReestablecerContraseña : Form
    {
        private string usuario;
        public ReestablecerContraseña(string usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }

        private void ReestablecerContraseña_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnReestablecer_Click(object sender, EventArgs e)
        {
            string password1 = txtConfirm.Text;
            string password2 = txtConfirm2.Text;

            DialogResult Resultado;
            ConsultaGen consulta = new ConsultaGen();

            if (string.IsNullOrEmpty(txtConfirm.Text) || string.IsNullOrEmpty(txtConfirm2.Text))
            {
                MessageBox.Show("¡Debe completar todos los campos!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtConfirm.Text != txtConfirm2.Text)
            {
                MessageBox.Show("¡Las contraseñas deben ser iguales!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (password1.Length < 6 || password2.Length < 6)
            {
                MessageBox.Show("La contraseña no puede ser menor a 6 caracteres", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtConfirm.Text == txtConfirm2.Text)
            {
                try
                {
                    bool resultado = consulta.RestablecerPass(password1, usuario);
                    if (resultado)
                    {
                        txtConfirm.Clear(); txtConfirm2.Clear();
                        Resultado = MessageBox.Show("¡Se ha restablecido su contraseña exitosamente!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (Resultado == DialogResult.OK)
                        {
                            InicioSesion iniciosesion = new InicioSesion();
                            iniciosesion.Show();
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("¡Ocurrio un error no se pudo restablecer la contreña!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Se produjo un ERROR al conectar a la base de datos", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RecuperoContraseña recupero = new RecuperoContraseña();
            recupero.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pcbMostrar_Click(object sender, EventArgs e)
        {
            pcbOcultar.BringToFront();
            txtConfirm.PasswordChar = '\0';
        }
        private void pcbOcultar_Click_1(object sender, EventArgs e)
        {
            pcbMostrar.BringToFront();
            txtConfirm.PasswordChar = '*';
        }

        private void pcbMostrar1_Click_1(object sender, EventArgs e)
        {
            pcbOcultar1.BringToFront();
            txtConfirm2.PasswordChar = '\0';
        }

        private void pcbOcultar1_Click_1(object sender, EventArgs e)
        {
            pcbMostrar1.BringToFront();
            txtConfirm2.PasswordChar = '*';
        }
        private void txtConfirm_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtConfirm2_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
