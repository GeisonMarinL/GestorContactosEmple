using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace GestorContactos
{
    internal class conexion
    {
        private string cadenaConexion = "Data Source=localhost;Initial Catalog=directorio_telefonico;User ID=Geison;Password=981015";
        public MySqlConnection Conexion { get; set; }

        public conexion()
        {
            Conexion = new MySqlConnection(cadenaConexion);
        }

        public bool ProbarConexion()
        {
            try
            {
                Conexion.Open();
                Conexion.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
