using Org.BouncyCastle.Bcpg.OpenPgp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JuegoQuizzReto {
    public partial class MenuPrincipal : Form {

        private Usuario usuario;
        private InicioSesion inicioSesion;
        private JugarPartida jugarPartida;
        private NumPreguntas numPreguntas;

        public MenuPrincipal(Usuario usuario, InicioSesion sesion) {
            InitializeComponent();
            this.usuario = usuario;
            inicioSesion = sesion;
        }
        private void btnSalir_Click(object sender, EventArgs e) {
            inicioSesion.Dispose();
        }

        private void MenuPrincipal_FormClosing(object sender, FormClosingEventArgs e) {
            inicioSesion.Dispose();
        }

        private void btnJugar_MouseEnter(object sender, EventArgs e) {
            btnJugar.ForeColor = Color.Black;
        }

        private void btnModificaciones_MouseEnter(object sender, EventArgs e) {
            btnDesbloqueables.ForeColor = Color.Black;
        }

        private void btnMarcador_MouseEnter(object sender, EventArgs e) {
            btnMarcador.ForeColor = Color.Black;
        }

        private void btnMarcador_MouseLeave(object sender, EventArgs e) {
            btnMarcador.ForeColor = Color.White;
        }

        private void btnModificaciones_MouseLeave(object sender, EventArgs e) {
            btnDesbloqueables.ForeColor = Color.White;
        }

        private void btnJugar_MouseLeave(object sender, EventArgs e) {
            btnJugar.ForeColor = Color.White;
        }

        private void btnJugar_Click(object sender, EventArgs e) {
            numPreguntas = new NumPreguntas(this, usuario);
            numPreguntas.Visible = true;
            this.Hide();
        }

        public InicioSesion InicioSesion{
            set { inicioSesion = value; }
            get { return inicioSesion; }
        }
    }
}
