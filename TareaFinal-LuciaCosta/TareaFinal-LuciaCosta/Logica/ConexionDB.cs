using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TareaFinal_LuciaCosta.Logica
{
    internal class ConexionDB
    {
        private readonly string connectionString = "server=localhost;database=tareafinal-luciacosta;uid=root;pwd=;";
        private MySqlConnection con;

        public ConexionDB()
        {
            con = new MySqlConnection(connectionString);
        }
        public bool usuario(string nombre_usuario, string contrasenia)
        {
            bool isValid = false;

            try
            {
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();
                    string query = "SELECT COUNT(1) FROM usuario WHERE NOMBRE_USUARIO=@nombreUsuario AND CONTRASENIA=@contrasenia";
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@nombreUsuario", nombre_usuario);
                        cmd.Parameters.AddWithValue("@contrasenia", contrasenia);  // Considera el uso de hashing para mayor seguridad
                       

                        int count = Convert.ToInt32(cmd.ExecuteScalar());

                        isValid = (count > 0);
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al verificar las credenciales: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error general: " + ex.Message);
            }

            return isValid;
        }

    }
}
