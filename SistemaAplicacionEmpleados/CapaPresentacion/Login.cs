using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Login : Form
    {
        ChequearConexion checkCN = new ChequearConexion();
        public Login()
        {
            InitializeComponent();
        }

        private void gunaImageButtonSalir_Click(object sender, EventArgs e)
        {
            checkCN.desconectarDB();
            this.Close();

        }

        private void gunaButtonIniciarSesion_Click_1(object sender, EventArgs e)
        {
            string usuario = gunaLineTextBoxUsuario.Text;
            string contrasena = gunaLineTextBoxContrasena.Text;
            int r = checkCN.ChequearLogin(usuario, contrasena);

            if (r == 1)
            {
                this.Hide();    // oculto el formulario Login
                PanelAdmi formPanelAdmi = new PanelAdmi();
                formPanelAdmi.Show();
                
            }
            else MessageBox.Show("VALORES INCORRECTOS");

            
            //string user = TextBoxUser.Text;
            //MessageBox.Show(string.Format(user));
        }
    }
}
