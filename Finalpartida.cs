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
    public partial class Finalpartida : Form
    {
        private MenuPrincipal menuPrincipal;
        private int puntuacion, puntuacionContador, numAciertos, tirada;
        private int idUsuario;

        public Finalpartida(MenuPrincipal menuPrincipal, Partida partidaPasada)
        {
            InitializeComponent();
            this.menuPrincipal = menuPrincipal;
            this.puntuacion = partidaPasada.Puntuacion;
            this.idUsuario = partidaPasada.IdUsuario;
            this.numAciertos = partidaPasada.NumAciertos;
            this.tirada = partidaPasada.Tirada;
            this.Show();
            puntuacionContador = 0;
            relojPunts.Start();
        }

        private void Finalpartida_Click(object sender, EventArgs e)
        {

        }

        private void lblPuntuacion_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void relojPunts_Tick(object sender, EventArgs e)
        {
            if (puntuacionContador == puntuacion)
            {
                btnSalir.Visible = true;
                relojPunts.Stop();
            }
            lblPuntuacion.Text = puntuacionContador + " Puntos";
            puntuacionContador++;
        }

        private void Finalpartida_FormClosing(object sender, FormClosingEventArgs e)
        {
            menuPrincipal.Show();
        }
    }
}
