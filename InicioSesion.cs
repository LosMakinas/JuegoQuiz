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
        public InicioSesion()
        {
            InitializeComponent();
        }

        private void btnIniarSesion_Click(object sender, EventArgs e) {
            MessageBox.Show("Hola");
        }

        private void btnIniarSesion_MouseLeave(object sender, EventArgs e) {
            btnIniarSesion.ForeColor = Color.White;
        }

        private void btnIniarSesion_MouseEnter(object sender, EventArgs e) {
            btnIniarSesion.ForeColor = Color.Black;
        }
    }
}
