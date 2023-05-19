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
        private int pos;
        private int contEsperaSigPreg;
        private int numAciertos;
        private int comodinesGastados;
        private int tiempoJugado;
        private int contPreJuego;
        private string urlImagen;
        private Partida partidaActual;


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
            numAciertos = 0;
            comodinesGastados = 0;
            tiempoJugado = 0;
            contPreJuego = 10;
            tiempoPregunta = false;
            this.usuario = usuario;
            this.numPreguntas = numPreguntas;
            numPreguntaAct = 1;
            pregunta = new Pregunta();
            todasPreguntas = pregunta.GetPreguntas(numPreguntas, tematica);
            

            this.numPreguntas = todasPreguntas["data"].Count();
            pos = 0;
            urlImagen = "";
            Console.WriteLine(this.numPreguntas);
        }

        private void relojPartida_Tick(object sender, EventArgs e) {
            if (contPreJuego == 0 && !tiempoPregunta) {
                picPreguntaResp.Visible = true;
                lblPregunta.Visible = true;
                lblResp1.Visible = true;
                lblResp2.Visible = true;
                lblResp3.Visible = true;
                lblResp4.Visible = true;
                lblNumPregunta.Text = "Pregunta " + numPreguntaAct;
                lblTiempoRest.Visible = true;
                picFotoPregunta.Image = Properties.Resources.logo_definitivo2;
                cont = int.Parse(todasPreguntas["data"][pos]["tiempo"].ToString());
                contPreJuego = 10;
                tiempoPregunta = true;
            } else if (cont == 0 && tiempoPregunta) {
                sigPregunta();
                
            }

            if (tiempoPregunta) {
                if (cont > 9) {
                    lblTiempoRest.Text = "00:" + cont;
                }else {
                    lblTiempoRest.Text = "00:0" + cont;
                }
            } else {
                if (contPreJuego > 9) {
                    lblTiempoRest.Text = "00:" + contPreJuego;
                } else {
                    lblTiempoRest.Text = "00:0" + contPreJuego;
                }
            }
            //Console.WriteLine(cont);
            if (tiempoPregunta)
            {
                cont--;
            }
            else 
            {
                contPreJuego--;
            }
        }

        public void sigPregunta() {
            relojPartida.Stop();
            lblSigPregunta.Visible = true;
            lblPregunta.Visible = false;
            lblResp1.Visible = false;
            lblResp2.Visible = false;
            lblResp3.Visible = false;
            lblResp4.Visible = false;
            picPreguntaResp.Visible = false;
            picFotoPregunta.Image = Properties.Resources.cartel;
            lblExplicacionRespCorrecta.Text = "Explicación: "+todasPreguntas["data"][pos]["descripcion"].ToString();
            pos++;
            if (pos >= numPreguntas)
            {
                /*Hacer Formulario de final de partida*/
                this.Close();
            }
            else 
            {
                lblPregunta.Text = todasPreguntas["data"][pos]["pregunta"].ToString();
                lblResp1.Text = todasPreguntas["data"][pos]["respuesta1"]["respuesta"].ToString();
                lblResp2.Text = todasPreguntas["data"][pos]["respuesta2"]["respuesta"].ToString();
                lblResp3.Text = todasPreguntas["data"][pos]["respuesta3"]["respuesta"].ToString();
                lblResp4.Text = todasPreguntas["data"][pos]["respuesta4"]["respuesta"].ToString();
                lblResp1.Tag = todasPreguntas["data"][pos]["respuesta1"]["correcta"].ToString();
                lblResp2.Tag = todasPreguntas["data"][pos]["respuesta2"]["correcta"].ToString();
                lblResp3.Tag = todasPreguntas["data"][pos]["respuesta3"]["correcta"].ToString();
                lblResp4.Tag = todasPreguntas["data"][pos]["respuesta4"]["correcta"].ToString();
                contEsperaSigPreg = 10;
                relojEsperarSigPregunta.Start();
            }
            
        }


        private void JugarPartida_Load(object sender, EventArgs e) {
            if (numPreguntas <= 0)
            {
                JugarPartida_FormClosing(null, null);
            }
            lblPregunta.Text = todasPreguntas["data"][pos]["pregunta"].ToString();
            lblResp1.Text = todasPreguntas["data"][pos]["respuesta1"]["respuesta"].ToString();
            lblResp2.Text = todasPreguntas["data"][pos]["respuesta2"]["respuesta"].ToString();
            lblResp3.Text = todasPreguntas["data"][pos]["respuesta3"]["respuesta"].ToString();
            lblResp4.Text = todasPreguntas["data"][pos]["respuesta4"]["respuesta"].ToString();
            lblResp1.Tag = todasPreguntas["data"][pos]["respuesta1"]["correcta"].ToString();
            lblResp2.Tag = todasPreguntas["data"][pos]["respuesta2"]["correcta"].ToString();
            lblResp3.Tag = todasPreguntas["data"][pos]["respuesta3"]["correcta"].ToString();
            lblResp4.Tag = todasPreguntas["data"][pos]["respuesta4"]["correcta"].ToString();
            urlImagen = "http://192.168.0.84/PaginaReto3Dam1/images/logo-definitivo.png";
            picFotoPregunta.LoadAsync(@""+urlImagen);
            cont = int.Parse(todasPreguntas["data"][pos]["tiempo"].ToString());
            relojPartida.Start();
        }

        private void lblResp1_Click_1(object sender, EventArgs e)
        {
            Label lblSender = (Label)sender;
                if (lblSender.Tag.ToString() == "True")
                {
                    lblSender.ForeColor = Color.Green;
                    puntuacion = puntuacion + (100 * cont * Convert.ToInt32(todasPreguntas["data"][pos]["dificultad"].ToString()));
                    lblPuntuacion.Text = puntuacion + " Pts";
                    numAciertos++;
                }
                else
                {
                    lblSender.ForeColor = Color.Red;
                    if (picCorazon3.Tag.ToString() == "Full")
                    {
                        picCorazon3.BackgroundImage = Properties.Resources.corazonVacio;
                        picCorazon3.Tag = "Vacío";
                    }
                    else if (picCorazon2.Tag.ToString() == "Full")
                    {
                        picCorazon2.BackgroundImage = Properties.Resources.corazonVacio;
                        picCorazon2.Tag = "Vacío";
                    }
                    else if (picCorazon1.Tag.ToString() == "Full")
                    {
                        picCorazon1.BackgroundImage = Properties.Resources.corazonVacio;
                        picCorazon1.Tag = "Vacío";
                    }
                    relojPartida.Stop();
                }
                tiempoJugado += int.Parse(todasPreguntas["data"][pos]["tiempo"].ToString()) - cont;
                sigPregunta();
        }

        private void relojEsperarSigPregunta_Tick(object sender, EventArgs e) {
            if (contEsperaSigPreg > 9) {
                lblTiempoRest.Text = "00:" + contEsperaSigPreg;
            } else {
                lblTiempoRest.Text = "00:0" + contEsperaSigPreg;
            }
            if (contEsperaSigPreg == 0) {
                urlImagen = "logo-definitivo.png";
                lblSigPregunta.Visible = false;
                picFotoPregunta.LoadAsync(@"http://192.168.0.84/paginaReto3Dam1/images/" + urlImagen);
                lblResp1.ForeColor = Color.White;
                lblResp2.ForeColor = Color.White;
                lblResp3.ForeColor = Color.White;
                lblResp4.ForeColor = Color.White;
                lblExplicacionRespCorrecta.Visible = false;
                numPreguntaAct++;
                tiempoPregunta = false;
                relojPartida.Start();
                relojEsperarSigPregunta.Stop();
            }
            contEsperaSigPreg--;
        }

        private void JugarPartida_FormClosing(object sender, FormClosingEventArgs e) {
            relojPartida.Stop();
            relojEsperarSigPregunta.Stop();
            partidaActual = new Partida(usuario.Id, puntuacion, numAciertos, DateTime.Today, comodinesGastados, numPreguntaAct, tiempoJugado);
            new Finalpartida(menuPrincipal, partidaActual);
            this.Dispose();
        }

    }
}
