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
        private int puntuacion, puntuacionContador;
        private Partida partidaPasada;
        private int sum;

        public Finalpartida(MenuPrincipal menuPrincipal, Partida partidaPasada)
        {
            InitializeComponent();
            this.menuPrincipal = menuPrincipal;
            this.partidaPasada = partidaPasada;
            this.puntuacion = partidaPasada.Puntuacion;
            this.Show();
            puntuacionContador = 0;
            sum = 0;
            relojPunts.Start();
        }

        private void Finalpartida_Click(object sender, EventArgs e)
        {
            relojPunts.Stop();
            btnSalir.Visible = true;
            lblPuntuacion.Text = puntuacion + " Puntos";
            new BaseDatos().insertarPuntuacion(partidaPasada);
        }

        private void lblPuntuacion_Click(object sender, EventArgs e)
        {
            relojPunts.Stop();
            btnSalir.Visible = true;
            lblPuntuacion.Text = puntuacion + " Puntos";
            new BaseDatos().insertarPuntuacion(partidaPasada);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void relojPunts_Tick(object sender, EventArgs e)
        {
            if (puntuacion > 0)
            {
                if (puntuacion > 1000 && puntuacion < 5000)
                {
                    sum = 10;
                }
                else if (puntuacion < 1000)
                {
                    sum = 1;
                }
                else if (puntuacion > 5000)
                {
                    sum = 100;
                }
            }
            
            puntuacionContador += sum;
            if (puntuacionContador == puntuacion)
            {
                new BaseDatos().insertarPuntuacion(partidaPasada);
                btnSalir.Visible = true;
                relojPunts.Stop();
            }
            
            lblPuntuacion.Text = puntuacionContador + " Puntos";
            
        }

        private void Finalpartida_FormClosing(object sender, FormClosingEventArgs e)
        {
            menuPrincipal.Show();
        }
    }
}
