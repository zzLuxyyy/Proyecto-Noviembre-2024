using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TareaFinal_LuciaCosta.Logica;

namespace TareaFinal_LuciaCosta.Aplicacion
{
    public partial class Menu1 : Form
    {

        private UsuarioControlador uc = new UsuarioControlador();

        private MySqlConnection con;
        string connectionString = "server=localhost;database=tareafinal-luciacosta;uid=root;pwd=;";
       
        public Menu1()
        {
            InitializeComponent();
            tabla.MultiSelect = false;
            tabla.ColumnCount = 1;
            tabla.Columns[0].Name = "Usuario";
            tabla.Columns[0].Width = 100;
            uc.bdcargarUsuarios();
        }

        private void btn_buscarUsuario_Click(object sender, EventArgs e)
        {
            Usuario u = uc.findUsuario(text_user.Text);
            if (u != null)
            {
                tabla.Rows.Add(u.toObject());
            }
            else
            {
                MessageBox.Show("Usuario no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            string nombreUsuario = txtNombreUsuario.Text;
            string contrasenia = txtContrasenia.Text;

            UsuarioControlador controlador1 = new UsuarioControlador();
            controlador1.addUsuario(nombreUsuario, contrasenia);
        }

        private void panel15_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Menu1_Load(object sender, EventArgs e)
        {

        }
    }
}
