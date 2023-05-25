using MySql.Data.MySqlClient;
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
    public partial class Marcador : Form
    {
        private MenuPrincipal menuPrincipal;
        private BaseDatos baseDatos;
        private Dictionary<String, String> dicCombo;
        public Marcador(MenuPrincipal menuPrincipal)
        {
            InitializeComponent();
            this.menuPrincipal = menuPrincipal;
            dicCombo = new Dictionary<String, String>()
            {
                {"Puntuacion", "puntuacion"},
                {"Tirada", "tirada"},
                {"Aciertos", "numAciertos"},
                {"Tiempo", "numAciertos"},
                {"Ascendiente", "ASC"},
                {"Descendiente", "DESC"},
                {"Maxima Puntuacion", "MaxPunt"},
                {"Partidas Jugadas", "PartidasJug"}
            };
            baseDatos = new BaseDatos();
        }



        private void Marcador_FormClosing(object sender, FormClosingEventArgs e)
        {
            menuPrincipal.Show();
        }

        private void Marcador_Load(object sender, EventArgs e)
        {
            boxCampos.SelectedIndex = 0;
            boxAscDesc.SelectedIndex = 0;
            boxEspeciales.SelectedIndex = 0;
            lstPuntuaciones.Items.Clear();
            MySqlDataReader reader = baseDatos.obtenerPuntuacion();
            while (reader.Read())
            {
                TimeSpan t = TimeSpan.FromSeconds(int.Parse(reader["tiempoJugado"].ToString()));

                string answer = string.Format("{0:D2}h:{1:D2}m:{2:D2}s:{3:D3}ms",
                                t.Hours,
                                t.Minutes,
                                t.Seconds,
                                t.Milliseconds);
                lstPuntuaciones.Items.Add(" Puntuacion: " +reader["puntuacion"] + " Usuario: " + reader["nombreUsuario"] + " Rondas Jugadas: " + reader["tirada"] + " Numero de aciertos: " + reader["numAciertos"] + " Tiempo Jugado: " + answer);
            }
            reader.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (boxCampos.SelectedIndex == 0 || boxAscDesc.SelectedIndex == 0)
            {
                return;
            }
            MySqlDataReader reader = baseDatos.obtenerPuntuacionQuery(dicCombo[boxCampos.SelectedItem.ToString()], dicCombo[boxAscDesc.SelectedItem.ToString()]);
            lstPuntuaciones.Items.Clear();
            
            while (reader.Read())
            {
                TimeSpan t = TimeSpan.FromSeconds(int.Parse(reader["tiempoJugado"].ToString()));

                string answer = string.Format("{0:D2}h:{1:D2}m:{2:D2}s:{3:D3}ms",
                                t.Hours,
                                t.Minutes,
                                t.Seconds,
                                t.Milliseconds);
                lstPuntuaciones.Items.Add(" Puntuacion: " + reader["puntuacion"] + " Usuario: " + reader["nombreUsuario"] + " Rondas Jugadas: " + reader["tirada"] + " Numero de aciertos: " + reader["numAciertos"] + " Tiempo Jugado: " + answer);
            }
            reader.Close();
        }

        private void boxEspeciales_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (boxEspeciales.SelectedIndex != 0)
            {
                boxCampos.SelectedIndex = 0;
                boxAscDesc.SelectedIndex = 0;
                boxCampos.Enabled = false;
                boxAscDesc.Enabled = false;
                btnBuscar.Enabled = false;
                btnBuscarEspecial.Visible = true;
            }
            else 
            {
                boxCampos.Enabled = true;
                boxAscDesc.Enabled = true;
                btnBuscar.Enabled = true;
                btnBuscarEspecial.Visible = false;
            }
        }

        private void btnBuscarEspecial_Click(object sender, EventArgs e)
        {
            if (boxCampos.SelectedIndex != 0 || boxAscDesc.SelectedIndex != 0)
            {
                return;
            }

            MySqlDataReader reader = baseDatos.obtenerMaxOCantidadPuntuacion(dicCombo[boxEspeciales.SelectedItem.ToString()]);
            lstPuntuaciones.Items.Clear();

            while (reader.Read())
            {
                if (dicCombo[boxEspeciales.SelectedItem.ToString()] == "MaxPunt")
                {
                    lstPuntuaciones.Items.Add(" Puntuacion: " + reader["MAX(puntuacion)"] + " Usuario: " + reader["nombreUsuario"]);
                } else if (dicCombo[boxEspeciales.SelectedItem.ToString()] == "PartidasJug")
                {
                    lstPuntuaciones.Items.Add(" Cantidad de Puntuaciones: " + reader["totalPuntuaciones"] + " Usuario: " + reader["nombreUsuario"]);
                }
                
            }
            reader.Close();
        }
    }
}
