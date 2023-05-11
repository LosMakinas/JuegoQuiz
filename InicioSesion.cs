using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JuegoQuizzReto
{
    public partial class InicioSesion : Form
    {
        private MenuPrincipal menu;
        private Usuario usuario;
        private BaseDatos bd;
        private int ancho, alto;

        public InicioSesion()
        {
            InitializeComponent();
            bd = new BaseDatos();
        }

        private void btnIniarSesion_Click(object sender, EventArgs e) {
            int id = bd.obtenerUsuario(txtNombreUsu.Text.Trim(), txtContra.Text.Trim());
            if (id == 0) {
                MessageBox.Show("El usuario o contraseña son incorrectos");
                return;
            } else {
                usuario = new Usuario(id, txtNombreUsu.Text.Trim(), txtContra.Text.Trim());
                menu = new MenuPrincipal(usuario, this);
                menu.Visible = true;
                this.Hide();
            }
        }

        private void btnIniarSesion_MouseLeave(object sender, EventArgs e) {
            btnIniarSesion.ForeColor = Color.White;
        }

        private void btnIniarSesion_MouseEnter(object sender, EventArgs e) {
            btnIniarSesion.ForeColor = Color.Black;
        }

        private void InicioSesion_Load(object sender, EventArgs e) {
            ancho = this.Width;
            alto = this.Height;
        }
    }
}
