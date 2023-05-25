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

        public Finalpartida(MenuPrincipal menuPrincipal, Partida partidaPasada, JugarPartida jugarPartida)
        {
            InitializeComponent();
            this.menuPrincipal = menuPrincipal;
            this.partidaPasada = partidaPasada;
            this.puntuacion = partidaPasada.Puntuacion;
            this.Show();
            puntuacionContador = 0;
            sum = 0;
            relojPunts.Start();
            jugarPartida.Dispose();
        }

        private void Finalpartida_Click(object sender, EventArgs e)
        {
            finalCont();
        }

        private void lblPuntuacion_Click(object sender, EventArgs e)
        {
            finalCont();
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
                finalCont();
            }
            
            lblPuntuacion.Text = puntuacionContador + " Puntos";
            
        }

        private void Finalpartida_FormClosing(object sender, FormClosingEventArgs e)
        {

            menuPrincipal.Show();
        }

        private void btnSalir_MouseEnter(object sender, EventArgs e) {
            btnSalir.ForeColor = Color.White;
        }

        private void btnSalir_MouseLeave(object sender, EventArgs e) {
            btnSalir.ForeColor = Color.Black;
        }

        private void finalCont() 
        {
            relojPunts.Stop();
            btnSalir.Visible = true;
            lblPuntuacion.Text = puntuacion + " Puntos";
            new BaseDatos().insertarPuntuacion(partidaPasada);
        }
    }
}
