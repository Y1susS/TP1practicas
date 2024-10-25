using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1practicas
{
    public partial class InicioSesion : Form
    {
       

        public InicioSesion()
        {
            InitializeComponent();
        }

        private void lnkolvidocontraseña_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lnkolvidocontraseña.TabStop = true;
            RecuperoContraseña recuperocontra = new RecuperoContraseña();
            recuperocontra.Show();
            this.Hide();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            string contraseña = txtContraseña.Text;
           
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contraseña = txtContraseña.Text;
            ConsultaGen consulta = new ConsultaGen();
            Usuario usuarioValido = consulta.ValidarUsuario(usuario, contraseña);

            if (string.IsNullOrEmpty(txtUsuario.Text) || string.IsNullOrEmpty(txtContraseña.Text))
            {
                MessageBox.Show("¡No completó nombre de usuario y/o contraseña", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (contraseña.Length < 6)
                {
                MessageBox.Show("La contraseña no puede ser menor a 6 caracteres", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            else
            {
                try
                {
                    if (usuarioValido != null)
                    {
                        if (usuarioValido.Tipo == "administrador")
                        {
                            WelcomeAdmin bienvenidaAdmin = new WelcomeAdmin();
                            bienvenidaAdmin.Show();
                            
                        }
                        else
                        {
                            WelcomeUser bienvenidaUsuario = new WelcomeUser();
                            bienvenidaUsuario.Show();
                            
                        }
                        this.Hide();
                        
                    }
                    else
                    {
                        MessageBox.Show("¡Nombre de usuario y/o contraseña no validos!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Se produjo un ERROR al conectar a la base de datos", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void lnkCrearCuenta_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmRegistro Registro = new FrmRegistro();
            Registro.Show();
            this.Hide();

        }

        private void lblTexto_Click(object sender, EventArgs e)
        {

        }

        private void InicioSesion_Load(object sender, EventArgs e)
        {

        }

        private void lnkOlvidoUsuario_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void pcbMostrar_Click(object sender, EventArgs e)
        {
            pcbOcultar.BringToFront();
            txtContraseña.PasswordChar = '\0';
        }

        private void pcbOcultar_Click(object sender, EventArgs e)
        {
            pcbMostrar.BringToFront();
            txtContraseña.PasswordChar = '*';
        }

        private void lnkolvidocontraseña_TabStopChanged(object sender, EventArgs e)
        {

        }
        //private void Validar_Credenciales(string usuario, string contraseña)
        //{
        //    string Cadena = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|Usuariosalgoritmos.accdb";

        //    using (OleDbConnection conectarBase = new OleDbConnection(Cadena))
        //    {
        //        try
        //        {
        //            conectarBase.Open();
        //            string Consulta = "SELECT COUNT (*) FROM Tabla1 WHERE usuario = ? AND contraseña = ?";

        //            using (OleDbCommand miComando = new OleDbCommand(Consulta, conectarBase))
        //            {
        //                miComando.Parameters.AddWithValue("@usuario", usuario);

        //                miComando.Parameters.AddWithValue("@contraseña", contraseña);

        //                int resultado = (int)miComando.ExecuteScalar();
        //                if (resultado > 0)
        //                {
        //                    MessageBox.Show("¡Inicio de sesión exitoso!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //                    lblLeyenda.Visible = false;
        //                    txtUsuario.Clear(); txtContraseña.Clear();
        //                }
        //                else
        //                {
        //                    MessageBox.Show("¡Nombre de usuario y/o contraseña no validos!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //                }
        //            }

        //        }
        //        catch (Exception)
        //        {
        //            MessageBox.Show("Se produjo un ERROR al conectar a la base de datos", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

        //        }


        //    }
        //}

    }
    
}
