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
    public partial class JugarPartida : Form {

        private MenuPrincipal menuPrincipal;
        private int cont, puntuacion;
        private Random rPuntuacion;
        private bool tiempoPregunta;

        public JugarPartida(MenuPrincipal menuPrincipal) {
            InitializeComponent();
            this.menuPrincipal = menuPrincipal;
            picPreguntaResp.Visible = false;
            lblResp1.Visible = false;
            lblResp2.Visible = false;
            lblResp3.Visible = false;
            lblResp4.Visible = false;
            lblPregunta.Visible = false;
            cont = 10;
            puntuacion = 0;
            rPuntuacion = new Random();
            tiempoPregunta = false;
        }

        private void relojPartida_Tick(object sender, EventArgs e) {
            if (cont == 0 && !tiempoPregunta) {
                picPreguntaResp.Visible = true;
                lblPregunta.Visible = true;
                lblResp1.Visible = true;
                lblResp2.Visible = true;
                lblResp3.Visible = true;
                lblResp4.Visible = true;
                lblTiempoRest.Visible = true;
                cont = 30;
                tiempoPregunta = true;
            } else if (cont == 0 && tiempoPregunta) {
                lblResp1.Visible = false;
                lblResp2.Visible = false;
                lblResp3.Visible = false;
                lblResp4.Visible = false;
                relojPartida.Stop();
            }

            if (tiempoPregunta) {
                if (cont > 9) {
                    lblTiempoRest.Text = "00:" + cont;
                }else {
                    lblTiempoRest.Text = "00:0" + cont;
                }
            } else {
                if (cont > 9) {
                    lblTiempoRest.Text = "00:" + cont;
                } else {
                    lblTiempoRest.Text = "00:0" + cont;
                }
            }
            cont--;
        }

        private void lblResp1_Click(object sender, EventArgs e) {
            if (comprobarRespCorrecta(lblResp1.Tag.ToString())) {
                lblResp1.ForeColor = Color.Green;
            } else {
                lblResp1.ForeColor = Color.Red;
                if(picCorazon3.Tag.ToString() == "Full") {
                    picCorazon3.BackgroundImage = Properties.Resources.corazonVacio;
                    picCorazon3.Tag = "Vacío";
                } else if (picCorazon2.Tag.ToString() == "Full") {
                    picCorazon2.BackgroundImage = Properties.Resources.corazonVacio;
                    picCorazon2.Tag = "Vacío";
                } else if (picCorazon1.Tag.ToString() == "Full") {
                    picCorazon1.BackgroundImage = Properties.Resources.corazonVacio;
                    picCorazon1.Tag = "Vacío";
                }
                relojPartida.Stop();
            }
        }

        private void lblResp2_Click(object sender, EventArgs e) {
            if (comprobarRespCorrecta(lblResp2.Tag.ToString())) {
                lblResp2.ForeColor = Color.Green;
            } else {
                lblResp2.ForeColor = Color.Red;
                relojPartida.Stop();
            }
        }

        private void lblResp3_Click(object sender, EventArgs e) {
            if (comprobarRespCorrecta(lblResp3.Tag.ToString())) {
                lblResp3.ForeColor = Color.Green;
            } else {
                lblResp3.ForeColor = Color.Red;
                relojPartida.Stop();
            }
        }

        private void lblResp4_Click(object sender, EventArgs e) {
            if (comprobarRespCorrecta(lblResp4.Tag.ToString())) {
                lblResp4.ForeColor = Color.Green;
            } else {
                lblResp4.ForeColor = Color.Red;
                relojPartida.Stop();
            }
        }

        private void JugarPartida_Load(object sender, EventArgs e) {
            relojPartida.Start();
        }

        private void JugarPartida_FormClosing(object sender, FormClosingEventArgs e) {
            menuPrincipal.InicioSesion.Dispose();
        }

        public bool comprobarRespCorrecta(String tag) {
            if (tag == "Verdadera") {
                relojPartida.Stop();
                puntuacion += rPuntuacion.Next(100, 501) * cont * 2;/*Aquí iría el nivel de dificultad del 1-3 (El 2 es de ejemplo)*/
                lblPuntuacion.Text = puntuacion + " Pts";
                return true;
            }
            return false;
        }
    }
}
