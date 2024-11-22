using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TareaFinal_LuciaCosta.Logica
{
    internal class UsuarioControlador
    {
        private readonly string connectionString = "server=localhost;database=tareafinal-luciacosta;uid=root;pwd=;";
        private List<Usuario> Usuarios;

        public UsuarioControlador()
        {
            this.Usuarios = new List<Usuario>();    
        }
        public void bdcargarUsuarios()
        {
            ConexionDB con = new ConexionDB();
            MySqlDataReader reader = con.MakeQuery("SELECT * from USUARIO");

            // Limpia la lista Usuarios para evitar duplicados al recargar
            this.Usuarios.Clear();

            while (reader.Read())
            {

                // Evitar duplicados comprobando si el usuario ya está en la lista antes de agregarlo
                string nombreUsuario = Convert.ToString(reader["NOMBRE_USUARIO"]);
                if (this.Usuarios.Any(u => u.user == nombreUsuario))
                {
                    // usuario ya existe, omitir
                    continue;
                }

                this.addUsuario(
                    Convert.ToString(reader["NOMBRE_USUARIO"]),
                    Convert.ToString(reader["CONTRASENIA"])
                );
            }

            con.closeCon();
        }
        public void addUsuario(string nombreUsuario, string contrasenia)
        {
            // Verificar si el cliente ya está en la lista para evitar duplicación
            if (this.Usuarios.Any(u => u.user == nombreUsuario))
            {
                return;
            }

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    string checkQuery = "SELECT COUNT(*) FROM USUARIO WHERE NOMBRE_USUARIO = @NombreUsuario";
                    using (MySqlCommand checkCmd = new MySqlCommand(checkQuery, con))
                    {
                        checkCmd.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);
                        int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                        if (count > 0)
                        {
                            MessageBox.Show("El usuario ya ha sido agregado a la base de datos.");
                            return;
                        }
                    }

                    string query = @"INSERT INTO USUARIO (NOMBRE_USUARIO, CONTRASENIA)
                             VALUES (@NombreUsuario, @Contrasenia)";

                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);
                        cmd.Parameters.AddWithValue("@Contrasenia", contrasenia);

                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                }
            }
        }

        public List<Usuario> getUsuarios()
        {
            return this.Usuarios;
        }

        public Usuario findUsuario(string NOMBRE_USUARIO)
        {
            return this.Usuarios.Find(x => x.user.Contains(NOMBRE_USUARIO));
        }

        public bool RegistrarUsuario(Usuario usuario)
        {
            if (Usuarios.Any(u => u.user == usuario.user))
            {
                MessageBox.Show("El cliente ya existe en la base de datos.");
                return false;
            }

            addUsuario(
                usuario.user,
                usuario.pass
            );

            return true;
        }
        public string getMD5(string str)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] fromData = Encoding.UTF8.GetBytes(str);
            byte[] targetData = md5.ComputeHash(fromData);
            string byte2String = null;
            for (int i = 0; i < targetData.Length; i++)
            {
                byte2String += targetData[i].ToString("x2");
            }
            return byte2String;
        }
    }
}
