using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System;

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

    internal void closeCon()
    {
        // Implementación para cerrar la conexión
        if (con != null && con.State == System.Data.ConnectionState.Open)
        {
            con.Close();
        }
    }

    internal MySqlDataReader MakeQuery(string query)
    {
        MySqlDataReader reader = null;
        try
        {
            if (con.State != System.Data.ConnectionState.Open)
            {
                con.Open();
            }

            MySqlCommand cmd = new MySqlCommand(query, con);
            reader = cmd.ExecuteReader(); // Devuelve el lector sin cerrarlo
        }
        catch (MySqlException ex)
        {
            MessageBox.Show("Error al ejecutar la consulta: " + ex.Message);
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error general: " + ex.Message);
        }

        return reader;
    }
}
