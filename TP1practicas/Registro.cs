using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1practicas
{
    public partial class FrmRegistro : Form
    {

        // CREAMOS LISTA PERSONAS
        public FrmRegistro()
        {
            InitializeComponent();
            //INICIALIZAMOS LA LISTA
        }

        private void btnCrearCuenta_Click(object sender, EventArgs e)
        {
            string hombre = rdbHombre.Text;
            string mujer = rdbMujer.Text;
            string Otro = rdbOtro.Text;
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string usuario = txtNombreDeUsuario.Text;
            string dni = mskDni.Text;
            string email = txtEmail.Text;
            string contraseña1 = txtContraseña1.Text;
            string contraseña2 = txtContraseña2.Text;
            DialogResult Resultado;
            ConsultaGen consulta = new ConsultaGen();

            string password1 = txtContraseña1.Text;
            string password2 = txtContraseña2.Text;

            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtApellido.Text) ||
                string.IsNullOrEmpty(txtNombreDeUsuario.Text) || !mskDni.MaskCompleted || string.IsNullOrEmpty(txtEmail.Text)
                || string.IsNullOrEmpty(txtContraseña1.Text) || string.IsNullOrEmpty(txtContraseña2.Text) ||
                !rdbHombre.Checked && !rdbMujer.Checked && !rdbOtro.Checked)
            {
                MessageBox.Show("¡No completó algún campo!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (string.IsNullOrEmpty(txtContraseña1.Text) || string.IsNullOrEmpty(txtContraseña2.Text))
            {
                MessageBox.Show("¡Debe completar todos los campos!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtContraseña1.Text != txtContraseña2.Text)
            {
                MessageBox.Show("¡Las contraseñas deben ser iguales!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (password1.Length < 6 || password2.Length < 6)
            {
                MessageBox.Show("La contraseña no puede ser menor a 6 caracteres", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    bool resultado = consulta.AgregarUsuario(usuario, contraseña1, email);
                    if (resultado)
                    {
                        txtNombre.Clear(); txtApellido.Clear(); txtNombreDeUsuario.Clear(); mskDni.Clear(); txtEmail.Clear(); txtContraseña1.Clear(); txtContraseña2.Clear();
                        Resultado = MessageBox.Show("¡Su cuenta se ha creado exitosamente! \n Presione en OK para volver al menú de inicio", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (Resultado == DialogResult.OK)
                        {
                            InicioSesion iniciosesion = new InicioSesion();
                            iniciosesion.Show();
                            this.Close();
                        }
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

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs nptNombre)
        {
            if (Char.IsLetter(nptNombre.KeyChar))
            {
                nptNombre.Handled = false;
            }
            else if (Char.IsSeparator(nptNombre.KeyChar))
            {
                nptNombre.Handled = false;
            }
            else if (Char.IsControl(nptNombre.KeyChar))
            {
                nptNombre.Handled = false;
            }
            else
            {
                nptNombre.Handled = true;
            }
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs nptApellido)
        {
            if (Char.IsLetter(nptApellido.KeyChar))
            {
                nptApellido.Handled = false;
            }
            else if (Char.IsSeparator(nptApellido.KeyChar))
            {
                nptApellido.Handled = false;
            }
            else if (Char.IsControl(nptApellido.KeyChar))
            {
                nptApellido.Handled = false;
            }
            else
            {
                nptApellido.Handled = true;
            }
        }

        private void FrmRegistro_Load(object sender, EventArgs e)
        {

        }

        private void btnCrearCuenta_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void btnCerrar3_Click(object sender, EventArgs e)
        {
            InicioSesion iniciosesion = new InicioSesion();
            iniciosesion.Show();
            this.Close();
        }

        private void btnMinizar3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lblContraseña1_Click(object sender, EventArgs e)
        {

        }

        private void pcbMostrar_Click(object sender, EventArgs e)
        {
            pcbOcultar.BringToFront();
            txtContraseña1.PasswordChar = '\0';
        }

        private void pcbOcultar_Click(object sender, EventArgs e)
        {
            pcbMostrar.BringToFront();
            txtContraseña1.PasswordChar = '*';

        }

        private void pcbMostrar1_Click(object sender, EventArgs e)
        {
            pcbOcultar1.BringToFront();
            txtContraseña2.PasswordChar = '\0';
        }

        private void pcbOcultar1_Click(object sender, EventArgs e)
        {
            pcbMostrar1.BringToFront();
            txtContraseña2.PasswordChar = '*';
        }

        private void grpGenero_Enter(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtContraseña1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblLeyenda_Click_1(object sender, EventArgs e)
        {

        }

        //private void registroUsuario(string usuario, string contraseña1, string email)
        //{
        //    DialogResult Resultado;
        //    string Cadena = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|Usuariosalgoritmos.accdb";

        //    using (OleDbConnection conectarBase = new OleDbConnection(Cadena))
        //    {
        //        try
        //        {
        //            string Consulta = "INSERT INTO Tabla1 (usuario, contraseña, correo_electronico) VALUES (?, ?, ?)";
        //            conectarBase.Open();
        //            using (OleDbCommand miComando = new OleDbCommand(Consulta, conectarBase))
        //            {
        //                miComando.Parameters.AddWithValue("@usuario", usuario);

        //                miComando.Parameters.AddWithValue("@contraseña", contraseña1);

        //                miComando.Parameters.AddWithValue("@correo_electronico", email);


        //                int resultado = miComando.ExecuteNonQuery();
        //                if (resultado > 0)
        //                {
        //                    txtNombre.Clear(); txtApellido.Clear(); txtNombreDeUsuario.Clear(); mskDni.Clear(); txtEmail.Clear(); txtContraseña1.Clear(); txtContraseña2.Clear();
        //                    Resultado = MessageBox.Show("¡Su cuenta se ha creado exitosamente! \n Presione en OK para volver al menú", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //                    if (Resultado == DialogResult.OK)
        //                    {
        //                        InicioSesion iniciosesion = new InicioSesion();
        //                        iniciosesion.Show();
        //                        this.Close();
        //                    }
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
