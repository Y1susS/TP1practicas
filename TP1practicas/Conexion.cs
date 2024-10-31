using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1practicas
{
    internal class Conexion
    {
        //cadena de conexión
        private string cadena = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|Usuariosalgoritmos.accdb;";
        protected OleDbConnection conectarBase;
        public Conexion()
        {
            conectarBase = new OleDbConnection(cadena) ;
        }

        protected void Conectar()
        {
            if (conectarBase.State == System.Data.ConnectionState.Closed)
            conectarBase.Open();
        }

        protected void Desconectar()
        {
            if (conectarBase.State == System.Data.ConnectionState.Open)
                conectarBase.Close();
        }
    }
}
