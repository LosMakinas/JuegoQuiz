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
        private int contPregCor;
        private bool lblActivos; 
        private string urlImagen;
        private int posArray;
        private int oldPosArray;
        private Partida partidaActual;
        private List<Comodin> arrayComodin;
        private List<Comodin> arrayComodinObtenido;
        private Dictionary<string, PictureBox> dicPic;
        private Dictionary<string, Label> diclbl;
        private Dictionary<string, int> dicInt;
        private Dictionary<Label, PictureBox> dicLblDic;
        private Random rnd;


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
            contPregCor = 3;
            contPreJuego = 5;
            tiempoPregunta = false;
            lblActivos = false;
            this.usuario = usuario;
            this.numPreguntas = numPreguntas;
            numPreguntaAct = 1;
            pregunta = new Pregunta();
            todasPreguntas = pregunta.GetPreguntas(numPreguntas, tematica);
            arrayComodin = new List<Comodin>();
            arrayComodinObtenido = new List<Comodin>();
            dicPic = new Dictionary<string, PictureBox>()
            {
                {"50/50", picCom50},
                {"pista", picExplCom},
                {"pasar pregunta", picComSaltar}
            };
            diclbl = new Dictionary<string, Label>()
            {
                {"50/50", lbl50},
                {"pista", lblPista},
                {"pasar pregunta", lblSiguiente}
            };
            dicInt = new Dictionary<string, int>()
            {
                {"50/50", 0},
                {"pista", 0},
                {"pasar pregunta", 0}
            };
            dicLblDic = new Dictionary<Label, PictureBox>()
            {
                {lbl50, picCom50},
                {lblPista, picExplCom},
                {lblSiguiente, picComSaltar}
            };
            this.numPreguntas = todasPreguntas["data"].Count();
            pos = 0;
            rnd = new Random();
            urlImagen = "";
            Console.WriteLine(this.numPreguntas);
        }

        private void relojPartida_Tick(object sender, EventArgs e) {
            if (contPreJuego == 0 && !tiempoPregunta) {
                estadoLabels(true);
                picPreguntaResp.Visible = true;
                lblPregunta.Visible = true;
                lblResp1.Visible = true;
                lblResp2.Visible = true;
                lblResp3.Visible = true;
                lblResp4.Visible = true;
                lblNumPregunta.Text = "Pregunta " + (pos + 1);
                lblTiempoRest.Visible = true;
                picFotoPregunta.Image = Properties.Resources.logo_definitivo2;
                cont = int.Parse(todasPreguntas["data"][pos]["tiempo"].ToString());
                contPreJuego = 10;
                tiempoPregunta = true;
            } else if (cont == 0 && tiempoPregunta) {
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
                    JugarPartida_FormClosing(null, null);
                }
                tiempoPregunta = false;
                ColorLabels();
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
            /*
            lblSigPregunta.Visible = true;
            
            lblPregunta.Visible = false;
            
            lblResp1.Visible = false;
            lblResp2.Visible = false;
            lblResp3.Visible = false;
            lblResp4.Visible = false;
            
            picPreguntaResp.Visible = false;
            
            picFotoPregunta.Image = Properties.Resources.cartel;
            */

            lblActivos = false;
            lblExplicacionRespCorrecta.Text = "Explicación: "+todasPreguntas["data"][pos]["descripcion"].ToString();
            //System.Threading.Thread.Sleep(5000);
            relojPreguntasCor.Start();
            
        }


        private void JugarPartida_Load(object sender, EventArgs e) {
            if (numPreguntas <= 0)
            {
                JugarPartida_FormClosing(null, null);
            }
            Newtonsoft.Json.Linq.JArray arrayPregs = new Newtonsoft.Json.Linq.JArray();
            Newtonsoft.Json.Linq.JToken[] arrayPregsRand;
            for (int i = 1; i < 5; i++)
            {
                arrayPregs.Add(todasPreguntas["data"][pos]["respuesta" + i]);
            }
            arrayPregsRand = arrayPregs.OrderBy(x => rnd.Next()).ToArray();
            lblPregunta.Text = todasPreguntas["data"][pos]["pregunta"].ToString();
            /*
            lblResp1.Text = todasPreguntas["data"][pos]["respuesta1"]["respuesta"].ToString();
            lblResp2.Text = todasPreguntas["data"][pos]["respuesta2"]["respuesta"].ToString();
            lblResp3.Text = todasPreguntas["data"][pos]["respuesta3"]["respuesta"].ToString();
            lblResp4.Text = todasPreguntas["data"][pos]["respuesta4"]["respuesta"].ToString();
            
            lblResp1.Tag = todasPreguntas["data"][pos]["respuesta1"]["correcta"].ToString();
            lblResp2.Tag = todasPreguntas["data"][pos]["respuesta2"]["correcta"].ToString();
            lblResp3.Tag = todasPreguntas["data"][pos]["respuesta3"]["correcta"].ToString();
            lblResp4.Tag = todasPreguntas["data"][pos]["respuesta4"]["correcta"].ToString();
            */
            lblResp1.Text = arrayPregsRand[0]["respuesta"].ToString();
            lblResp2.Text = arrayPregsRand[1]["respuesta"].ToString();
            lblResp3.Text = arrayPregsRand[2]["respuesta"].ToString();
            lblResp4.Text = arrayPregsRand[3]["respuesta"].ToString();

            lblResp1.Tag = arrayPregsRand[0]["correcta"].ToString();
            lblResp2.Tag = arrayPregsRand[1]["correcta"].ToString();
            lblResp3.Tag = arrayPregsRand[2]["correcta"].ToString();
            lblResp4.Tag = arrayPregsRand[3]["correcta"].ToString();

            urlImagen = todasPreguntas["data"][pos]["imagen"].ToString();

           /* 
            string[] subsUrl = urlImagen.Split('/');

            subsUrl[0] = subsUrl[0].ToLower();

            StringBuilder strBuild = new StringBuilder();

            for (int i = 0; i < subsUrl.Length; i++)
            {
                if (i == subsUrl.Length - 1)
                {
                    strBuild.Append(subsUrl[i]);
                }
                else
                {
                    strBuild.Append(subsUrl[i] + "/");
                }
            }

            urlImagen = strBuild.ToString();

            if (string.IsNullOrEmpty(urlImagen))
            {
                urlImagen = ""; 
            }
            */
            //Console.WriteLine("http://192.168.0.76/gitPaginaReto/P-ginaWeb/" + urlImagen);

            try
            {
                picFotoPregunta.LoadAsync(@"http://192.168.0.76/gitPaginaReto/P-ginaWeb/" + urlImagen);
            }
            catch (Exception)
            {
                picFotoPregunta.Image = Properties.Resources.logo_definitivo;
            }


            cont = int.Parse(todasPreguntas["data"][pos]["tiempo"].ToString());
            Newtonsoft.Json.Linq.JToken todosComodines = todasPreguntas["data"][pos]["comodines"];
            int lengthPreg = todosComodines.Count();
            for (int i = 0; i < lengthPreg; i++)
            {
                arrayComodin.Add(new Comodin(todosComodines[i]["tipo"].ToString(), todosComodines[i]["descripcion"].ToString(), todosComodines[i]["imagen"].ToString(), int.Parse(todosComodines[i]["cantidad"].ToString()), int.Parse(todosComodines[i]["puntuacion"].ToString())));
            }
            lblActivos = true;
            relojPartida.Start();
        }

        private void lblResp1_Click_1(object sender, EventArgs e)
        {
            if (lblActivos == false)
            {
                return;
            }
            ColorLabels();
            Label lblSender = (Label)sender;
            tiempoPregunta = false;
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
                        JugarPartida_FormClosing(null, null);
                    }
                    relojPartida.Stop();
                }

                if (pos+1 >= numPreguntas)
                {
                    JugarPartida_FormClosing(null, null);
                    relojPartida.Stop();
                }
            tiempoJugado += int.Parse(todasPreguntas["data"][pos]["tiempo"].ToString()) - cont;
            sigPregunta();
        }

        private void relojEsperarSigPregunta_Tick(object sender, EventArgs e) {
            
            if (contEsperaSigPreg == 9)
            {
                tiempoPregunta = false;
                oldPosArray = -1;
                posArray = new Random().Next(arrayComodin.Count());
                Comodin comodinObtenido = arrayComodin[posArray];
                
                int probComodin = new Random().Next(0, 10);

                do
                {
                    posArray = new Random().Next(arrayComodin.Count());
                } while (oldPosArray != -1 && posArray == oldPosArray);

                if (comodinObtenido.Cantidad > 0)
                {
                    comodinObtenido.Cantidad = comodinObtenido.Cantidad - 1;
                    //Console.WriteLine(posArray);
                    //Console.WriteLine(arrayComodin[posArray]);
                    arrayComodin[posArray].Cantidad = arrayComodin[posArray].Cantidad - 1;
                    dicInt[arrayComodin[posArray].TipoComodin] = dicInt[arrayComodin[posArray].TipoComodin] + 1;
                    picComodin.Load(@"http://192.168.0.76/gitPaginaReto/P-ginaWeb/" + comodinObtenido.Imagen);
                    picComodin.Visible = true;
                    //Console.WriteLine("http://192.168.0.76/gitPaginaReto/P-ginaWeb/" + comodinObtenido.Imagen);
                    lblSigPregunta.Text = arrayComodin[posArray].Descripcion;
                    lblComodin.Text = arrayComodin[posArray].TipoComodin;
                    dicPic[arrayComodin[posArray].TipoComodin].Visible = true;
                    diclbl[arrayComodin[posArray].TipoComodin].Visible = true;
                    diclbl[arrayComodin[posArray].TipoComodin].Text = "x" + dicInt[arrayComodin[posArray].TipoComodin];
                    oldPosArray = posArray;
                }
                
            }
            if (contEsperaSigPreg > 9) {
                lblTiempoRest.Text = "00:" + contEsperaSigPreg;
            } else {
                lblTiempoRest.Text = "00:0" + contEsperaSigPreg;
            }
            if (contEsperaSigPreg == 0) {
                picComodin.Visible = false;
                lblSigPregunta.Visible = false;
                lblSigPregunta.Text = "";
                //picFotoPregunta.Load(@"http://192.168.0.76/gitPaginaReto/P-ginaWeb/" + urlImagen);
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
            relojPreguntasCor.Stop();
            relojPartida.Stop();
            relojEsperarSigPregunta.Stop();
            partidaActual = new Partida(usuario.Id, puntuacion, numAciertos, DateTime.Today, comodinesGastados, numPreguntaAct, tiempoJugado);
            new Finalpartida(menuPrincipal, partidaActual);
            this.Dispose();
        }

        private void relojPreguntasCor_Tick(object sender, EventArgs e)
        {
            if (contPregCor > 9)
            {
                lblTiempoRest.Text = "00:" + contPregCor;
            }
            else
            {
                lblTiempoRest.Text = "00:0" + contPregCor;
            }

            

            if (contPregCor <= 0)
            {
                if (pos >= numPreguntas)
                {
                    this.Close();
                }
                else 
                {
                    pos++;
                    cargarPregunta();
                    relojPreguntasCor.Stop();
                }

            }
            contPregCor--;
        }

        private void ColorLabels()
        {
            var labels = this.Controls.OfType<Label>().Where(c => c.Name.StartsWith("lblResp")).ToList();
            foreach (Label lblaux in labels)
            {
                if (lblaux.Tag.ToString() == "True")
                {
                    
                    lblaux.ForeColor = Color.Lime;
                }
                else 
                {
                    lblaux.ForeColor = Color.Red;
                }
            }
        }

        private void picCom50_Click(object sender, EventArgs e)
        {
            if (tiempoPregunta)
            {
                int conRed = 0;
                var labels = this.Controls.OfType<Label>().Where(c => c.Name.StartsWith("lblResp")).ToList();
                for (int i = 0; i < labels.Count(); i++)
                {
                    if (conRed >= 2)
                    {
                        dicInt["50/50"] = (int.Parse(lbl50.Text.Substring(1)) - 1);
                        lbl50.Text = "x" + dicInt["50/50"];
                        if (dicInt["50/50"] == 0)
                        {
                            dicLblDic[lbl50].Visible = false;
                            lbl50.Visible = false;
                        }
                        return;
                    }
                    if (labels[i].Tag.ToString() != "True")
                    {

                        labels[i].ForeColor = Color.Red;
                        conRed++;
                    }
                }
                comodinesGastados++;
            }
        }

        private void picComSaltar_Click(object sender, EventArgs e)
        {
            if (tiempoPregunta)
            {
                if (pos+1 >= numPreguntas)
                {
                    this.Close();
                }
                else 
                {
                    dicInt["pasar pregunta"] = dicInt["pasar pregunta"] - 1;
                    lblSiguiente.Text = "x" + dicInt["pasar pregunta"];
                    if (dicInt["pasar pregunta"] == 0)
                    {
                        dicLblDic[lblSiguiente].Visible = false;
                        lblSiguiente.Visible = false;
                    }
                    pos++;
                    ColorLabels();
                    lblExplicacionRespCorrecta.Text = "Explicación: " + todasPreguntas["data"][pos]["descripcion"].ToString();
                    sigPregunta();
                }
            }
        }

        private void picExplCom_Click(object sender, EventArgs e)
        {
            if (tiempoPregunta)
            {
                dicInt["pista"] = dicInt["pista"] - 1;
                lblPista.Text = "x" + dicInt["pista"];
                if (dicInt["pista"] == 0)
                {
                    dicLblDic[lblPista].Visible = false;
                    lblPista.Visible = false;
                }
                lblExplicacionRespCorrecta.Text = "Explicación: " + todasPreguntas["data"][pos]["descripcion"].ToString();
                lblExplicacionRespCorrecta.Visible = true;
            }
        }

        private void cargarPregunta()
        {
            estadoLabels(false);
            lblResp1.ForeColor = Color.White;
            lblResp2.ForeColor = Color.White;
            lblResp3.ForeColor = Color.White;
            lblResp4.ForeColor = Color.White;
            lblActivos = true;
            Newtonsoft.Json.Linq.JArray arrayPregs = new Newtonsoft.Json.Linq.JArray();
            Newtonsoft.Json.Linq.JToken[] arrayPregsRand;
            for (int i = 1; i < 5; i++)
            {
                arrayPregs.Add(todasPreguntas["data"][pos]["respuesta" + i]);
            }
            arrayPregsRand = arrayPregs.OrderBy(x => rnd.Next()).ToArray();
            lblPregunta.Text = todasPreguntas["data"][pos]["pregunta"].ToString();
            /*
            lblResp1.Text = todasPreguntas["data"][pos]["respuesta1"]["respuesta"].ToString();
            lblResp2.Text = todasPreguntas["data"][pos]["respuesta2"]["respuesta"].ToString();
            lblResp3.Text = todasPreguntas["data"][pos]["respuesta3"]["respuesta"].ToString();
            lblResp4.Text = todasPreguntas["data"][pos]["respuesta4"]["respuesta"].ToString();

            lblResp1.Tag = todasPreguntas["data"][pos]["respuesta1"]["correcta"].ToString();
            lblResp2.Tag = todasPreguntas["data"][pos]["respuesta2"]["correcta"].ToString();
            lblResp3.Tag = todasPreguntas["data"][pos]["respuesta3"]["correcta"].ToString();
            lblResp4.Tag = todasPreguntas["data"][pos]["respuesta4"]["correcta"].ToString();
            */
            lblResp1.Text = arrayPregsRand[0]["respuesta"].ToString();
            lblResp2.Text = arrayPregsRand[1]["respuesta"].ToString();
            lblResp3.Text = arrayPregsRand[2]["respuesta"].ToString();
            lblResp4.Text = arrayPregsRand[3]["respuesta"].ToString();

            lblResp1.Tag = arrayPregsRand[0]["correcta"].ToString();
            lblResp2.Tag = arrayPregsRand[1]["correcta"].ToString();
            lblResp3.Tag = arrayPregsRand[2]["correcta"].ToString();
            lblResp4.Tag = arrayPregsRand[3]["correcta"].ToString();

            urlImagen = todasPreguntas["data"][pos]["imagen"].ToString();
            /*
            string[] subsUrl = urlImagen.Split('/');

            subsUrl[0] = subsUrl[0].ToLower();

            StringBuilder strBuild = new StringBuilder();

            for (int i = 0; i < subsUrl.Length; i++)
            {
                if (i == subsUrl.Length - 1)
                {
                    strBuild.Append(subsUrl[i]);
                }
                else 
                {
                    strBuild.Append(subsUrl[i] + "/");
                }
            }
            
            urlImagen = strBuild.ToString();

            if (string.IsNullOrEmpty(urlImagen))
            {
                urlImagen = "";
            }
            */
            //Console.WriteLine("http://192.168.0.76/gitPaginaReto/P-ginaWeb/" + urlImagen);

            try
            {
                picFotoPregunta.LoadAsync(@"http://192.168.0.76/gitPaginaReto/P-ginaWeb/" + urlImagen);
            }
            catch (Exception)
            {
                picFotoPregunta.Image = Properties.Resources.logo_definitivo;
            }
            

            

            contEsperaSigPreg = 10;
            contPregCor = 10;
            relojEsperarSigPregunta.Start();
        }

        private void estadoLabels(bool estado)
        {
            lblSigPregunta.Visible = !estado;

            lblPregunta.Visible = estado;

            lblResp1.Visible = estado;
            lblResp2.Visible = estado;
            lblResp3.Visible = estado;
            lblResp4.Visible = estado;

            picPreguntaResp.Visible = estado;
        }

    }
}