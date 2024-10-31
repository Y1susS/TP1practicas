using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TP1practicas
{
    internal class ConsultaGen : Conexion
    {

        private OleDbCommand miComando;
        private OleDbDataAdapter dataAdapter;
        private DataTable dataTable;

        public Usuario ValidarUsuario(string usuario, string contraseña)
        {
            Usuario usuarioValido = null;
            try
            {
                Conectar();
                string Consulta = "SELECT tipo FROM Tabla1 WHERE usuario = ? AND contraseña = ?";

                miComando = new OleDbCommand(Consulta, conectarBase);
                miComando.Parameters.AddWithValue("@usuario", usuario);
                miComando.Parameters.AddWithValue("@contraseña", contraseña);

                var tipo = miComando.ExecuteScalar();

                if (tipo != null)
                {
                    usuarioValido = new Usuario(usuario, contraseña, tipo.ToString());
                }

            }
            catch (Exception ex)
            {
                
                throw new Exception("Error al validar usuario: " + ex.Message);
            }
            finally
            {
                Desconectar();
            }
            return usuarioValido;
        }

        public bool AgregarUsuario(string usuario, string contraseña, string email)
        {
            try
            {
                Conectar();
                string Consulta = "INSERT INTO Tabla1 (usuario, contraseña, correo_electronico ) VALUES (?, ?, ?)";
                miComando = new OleDbCommand(Consulta, conectarBase);
                miComando.Parameters.AddWithValue("?", usuario);
                miComando.Parameters.AddWithValue("?", contraseña);
                miComando.Parameters.AddWithValue("?", email);

                int result = miComando.ExecuteNonQuery();
                return result > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar usuario: " + ex.Message);
            }
            finally
            {
                Desconectar();
            }
        }

        public bool ValidarUsuarioMail(string usuario, string mail)
        {
            try
            {
                Conectar();
                string Consulta = "SELECT COUNT (*) FROM Tabla1 WHERE usuario = ? AND correo_electronico = ?";

                miComando = new OleDbCommand(Consulta, conectarBase);
                miComando.Parameters.AddWithValue("@usuario", usuario);
                miComando.Parameters.AddWithValue("@correo_electronico", mail);

                int resultado = (int)miComando.ExecuteScalar();
                return resultado > 0;

            }
            catch (Exception ex)
            {

                throw new Exception("Error al validar usuario y/o correo: " + ex.Message);
            }
            finally
            {
                Desconectar();
            }
        }

        public bool RestablecerPass(string contraseña, string usuario)
        {
            try
            {
                Conectar();
                string Consulta = "UPDATE Tabla1 SET contraseña = ? WHERE usuario = ?";
                miComando = new OleDbCommand(Consulta, conectarBase);
                miComando.Parameters.AddWithValue("?", contraseña);
                miComando.Parameters.AddWithValue("?", usuario);

                int result = miComando.ExecuteNonQuery();
                return result > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al restablecer la contraseña: " + ex.Message);
            }
            finally
            {
                Desconectar();
            }
        }
    }
}
