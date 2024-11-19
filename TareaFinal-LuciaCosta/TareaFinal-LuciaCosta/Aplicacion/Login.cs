using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TareaFinal_LuciaCosta.Logica;
using System.Runtime.InteropServices;
using TareaFinal_LuciaCosta.Aplicacion;

namespace TareaFinal_LuciaCosta
{
    public partial class Login : Form
    {
        ConexionDB conexion = new ConexionDB();
        public Login()
        {
            InitializeComponent();
        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            string usuario = textuser.Text;
            string contrasenia = textpass.Text;

            if (conexion.usuario(usuario, contrasenia))
            {
                // Crear una instancia del formulario Menu1
                Menu1 menu = new Menu1();

                // Manejar el evento FormClosed para cerrar la aplicación
                menu.FormClosed += (s, args) => this.Close();

                // Mostrar el formulario Menu1
                menu.Show();

                // Ocultar el formulario de inicio de sesión
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos." + MessageBoxButtons.OK);
            }
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //MessageBox.Show("Dirígete al funcionario más cercano y pídele un cambio de contraseña.", "Contraseña Olvidada" );
            MessageBox.Show("Dirígete al funcionario más cercano y pídele un cambio de contraseña.", "Contraseña Olvidada!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        /////////////////////////////// PERMITE MOVER LA PANTALLA FLOTANTE /////////////////////////////

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Login_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////
    }
}
