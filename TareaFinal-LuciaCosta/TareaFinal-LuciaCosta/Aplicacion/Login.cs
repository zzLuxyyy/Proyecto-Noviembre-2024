using System;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using TareaFinal_LuciaCosta.Aplicacion;
using TareaFinal_LuciaCosta.Logica;

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
            string usuario = textuser.Text.Trim();
            string contrasenia = textpass.Text.Trim();

            // Validación de campos vacíos
            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contrasenia))
            {
                MessageBox.Show("Por favor, ingrese usuario y contraseña.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

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
                MessageBox.Show("Usuario o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show(
                "Dirígete al funcionario más cercano y pídele un cambio de contraseña.",
                "Contraseña Olvidada",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        /////////////////////////////// PERMITE MOVER LA PANTALLA FLOTANTE /////////////////////////////

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hwnd, int wmsg, int wparam, int lparam);

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

        private void textpass_Enter(object sender, EventArgs e)
        {
            textpass.UseSystemPasswordChar = true; // Oculta la contraseña de la interfaz
        }

        private void Login_Load(object sender, EventArgs e)
        {
            // Inicializa las opciones del ComboBox para los idiomas
            comboBox1.Items.Add("Español");
            comboBox1.Items.Add("Inglés");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                string selectedLanguage = comboBox1.SelectedItem.ToString();
                if (selectedLanguage.Equals("Español"))
                {
                    Thread.CurrentThread.CurrentCulture = new CultureInfo("es-UY");
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("es-UY");
                }
                else if (selectedLanguage.Equals("Inglés"))
                {
                    Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
                }

                refreshForm();
            }
        }

        private void refreshForm()
        {
            // Guarda el estado del formulario actual
            var previousControls = this.Controls;

            // Limpia el formulario
            this.Controls.Clear();
            InitializeComponent();

            // Actualiza los textos con las cadenas traducidas
            labelUsuario.Text = Res.Res.labelUsuario;
            labelContrasenia.Text = Res.Res.labelContrasenia;
            btn_ingresar.Text = Res.Res.btn_ingresar;
            linkLabel1.Text = Res.Res.linkLabel1;

            // Rellena las opciones del ComboBox si no están añadidas aún
            if (comboBox1.Items.Count == 0)
            {
                comboBox1.Items.Add("Español");
                comboBox1.Items.Add("Inglés");
            }
        }
    }
}
