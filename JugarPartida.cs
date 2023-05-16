using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace JuegoQuizzReto {
    public partial class JugarPartida : Form {

        private MenuPrincipal menuPrincipal;
        private Usuario usuario;
        private int cont, puntuacion;
        private bool tiempoPregunta;
        private int numPreguntas, numPreguntaAct;
        private Pregunta pregunta;
        private Newtonsoft.Json.Linq.JObject todasPreguntas;
        private int[] numPreguntasAnt;
        private Random r;
        private int pos;
        private int contEsperaSigPreg;
        private string urlImagen;

        public JugarPartida(MenuPrincipal menuPrincipal, String tematica,Usuario usuario, int numPreguntas) {
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
            tiempoPregunta = false;
            this.usuario = usuario;
            this.numPreguntas = numPreguntas;
            numPreguntaAct = 1;
            pregunta = new Pregunta();
            if (tematica == "Ingles") {
                todasPreguntas = pregunta.TodasPreguntasIngles;
            } else if (tematica == "Fol") {
                todasPreguntas = pregunta.TodasPreguntasFol;
            }
            r = new Random();
            pos = 0;
            numPreguntasAnt = new int[numPreguntas];
            urlImagen = "";
        }

        private void relojPartida_Tick(object sender, EventArgs e) {
            if (cont == 0 && !tiempoPregunta) {
                picPreguntaResp.Visible = true;
                lblPregunta.Visible = true;
                lblResp1.Visible = true;
                lblResp2.Visible = true;
                lblResp3.Visible = true;
                lblResp4.Visible = true;
                lblNumPregunta.Text = "Pregunta " + numPreguntaAct;
                lblTiempoRest.Visible = true;
                picFotoPregunta.Image = Properties.Resources.logo_definitivo2;
                cont = 30;
                tiempoPregunta = true;
            } else if (cont == 0 && tiempoPregunta) {
                sigPregunta();
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

        public void sigPregunta() {
            lblSigPregunta.Visible = true;
            lblPregunta.Visible = false;
            lblResp1.Visible = false;
            lblResp2.Visible = false;
            lblResp3.Visible = false;
            lblResp4.Visible = false;
            picPreguntaResp.Visible = false;
            picFotoPregunta.Image = Properties.Resources.cartel;
            lblExplicacionRespCorrecta.Text = "Explicación: "+todasPreguntas["data"][numPreguntasAnt[pos]]["descripcion"].ToString();
            pos++;
            lblPregunta.Text = todasPreguntas["data"][numPreguntasAnt[pos]]["pregunta"].ToString();
            lblResp1.Text = todasPreguntas["data"][numPreguntasAnt[pos]]["respuestas"][0]["respuesta1"].ToString();
            lblResp2.Text = todasPreguntas["data"][numPreguntasAnt[pos]]["respuestas"][1]["respuesta2"].ToString();
            lblResp3.Text = todasPreguntas["data"][numPreguntasAnt[pos]]["respuestas"][2]["respuesta3"].ToString();
            lblResp4.Text = todasPreguntas["data"][numPreguntasAnt[pos]]["respuestas"][3]["respuesta4"].ToString();
            if (todasPreguntas["data"][numPreguntasAnt[pos]]["respuestas"][0]["correcta"].ToString() == "true") {
                lblResp1.Tag = "Verdadera";
                lblResp2.Tag = "Falsa";
                lblResp3.Tag = "Falsa";
                lblResp4.Tag = "Falsa";
            } else if (todasPreguntas["data"][numPreguntasAnt[pos]]["respuestas"][1]["correcta"].ToString() == "true") {
                lblResp1.Tag = "Falsa";
                lblResp2.Tag = "Verdadera";
                lblResp3.Tag = "Falsa";
                lblResp4.Tag = "Falsa";
            } else if (todasPreguntas["data"][numPreguntasAnt[pos]]["respuestas"][2]["correcta"].ToString() == "true") {
                lblResp1.Tag = "Falsa";
                lblResp2.Tag = "Falsa";
                lblResp3.Tag = "Verdadera";
                lblResp4.Tag = "Falsa";
            } else {
                lblResp1.Tag = "Falsa";
                lblResp2.Tag = "Falsa";
                lblResp3.Tag = "Falsa";
                lblResp4.Tag = "Verdadera";
            }
            contEsperaSigPreg = 10;
            relojEsperarSigPregunta.Start();
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
            sigPregunta();
        }

        private void lblResp2_Click(object sender, EventArgs e) {
            if (comprobarRespCorrecta(lblResp2.Tag.ToString())) {
                lblResp2.ForeColor = Color.Green;
            } else {
                lblResp2.ForeColor = Color.Red;
                if (picCorazon3.Tag.ToString() == "Full") {
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
            sigPregunta();
        }

        private void lblResp3_Click(object sender, EventArgs e) {
            if (comprobarRespCorrecta(lblResp3.Tag.ToString())) {
                lblResp3.ForeColor = Color.Green;
            } else {
                lblResp3.ForeColor = Color.Red;
                if (picCorazon3.Tag.ToString() == "Full") {
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
            sigPregunta();
        }

        private void lblResp4_Click(object sender, EventArgs e) {
            if (comprobarRespCorrecta(lblResp4.Tag.ToString())) {
                lblResp4.ForeColor = Color.Green;
            } else {
                lblResp4.ForeColor = Color.Red;
                if (picCorazon3.Tag.ToString() == "Full") {
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
            sigPregunta();
        }

        private void JugarPartida_Load(object sender, EventArgs e) {

            for(int i = 0; i < 3; i++) {
                int numero;
                bool repetido;
                do {
                    repetido = false;
                    numero = r.Next(0, todasPreguntas["data"].Count());
                    for(int  j = 0; j < i+1; j++) {
                        if(numero == numPreguntasAnt[j]) {
                            repetido = true;
                            break;
                        }
                    }
                } while (repetido);
                numPreguntasAnt[i] = numero;
            }
            lblPregunta.Text = todasPreguntas["data"][numPreguntasAnt[pos]]["pregunta"].ToString();
            lblResp1.Text = todasPreguntas["data"][numPreguntasAnt[pos]]["respuestas"][0]["respuesta1"].ToString();
            lblResp2.Text = todasPreguntas["data"][numPreguntasAnt[pos]]["respuestas"][1]["respuesta2"].ToString();
            lblResp3.Text = todasPreguntas["data"][numPreguntasAnt[pos]]["respuestas"][2]["respuesta3"].ToString();
            lblResp4.Text = todasPreguntas["data"][numPreguntasAnt[pos]]["respuestas"][3]["respuesta4"].ToString();
            urlImagen ="logo-definitivo.png";
            picFotoPregunta.LoadAsync(@"http://192.168.0.84/paginaReto3Dam1/images/" + urlImagen);
            relojPartida.Start();
        }

        private void relojEsperarSigPregunta_Tick(object sender, EventArgs e) {
            if (contEsperaSigPreg > 9) {
                lblTiempoRest.Text = "00:" + cont;
            } else {
                lblTiempoRest.Text = "00:0" + cont;
            }
            if (contEsperaSigPreg == 0) {
                urlImagen = "logo-definitivo.png";
                picFotoPregunta.LoadAsync(@"http://192.168.0.84/paginaReto3Dam1/images/" + urlImagen);
                lblResp1.ForeColor = DefaultForeColor;
                lblResp2.ForeColor = DefaultForeColor;
                lblResp3.ForeColor = DefaultForeColor;
                lblResp4.ForeColor = DefaultForeColor;
                lblExplicacionRespCorrecta.Visible = false;
                numPreguntaAct++;
                relojEsperarSigPregunta.Stop();
                relojPartida.Start();
            }
            contEsperaSigPreg--;
        }

        private void JugarPartida_FormClosing(object sender, FormClosingEventArgs e) {
            menuPrincipal.InicioSesion.Dispose();
        }

        public bool comprobarRespCorrecta(String tag) {
            if (tag == "Verdadera") {
                relojPartida.Stop();
                puntuacion = puntuacion+(100 * cont * Convert.ToInt32(todasPreguntas["data"][numPreguntasAnt[pos]]["dificultad"].ToString()));
                lblPuntuacion.Text = puntuacion + " Pts";
                return true;
            }
            return false;
        }
    }
}
