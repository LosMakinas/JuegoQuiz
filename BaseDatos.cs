using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace JuegoQuizzReto {
    public class BaseDatos {

        private MySqlConnectionStringBuilder builder;
        private MySqlConnection cn;
        private MySqlCommand cmd;
        private MySqlDataReader reader;

        public BaseDatos() {
            builder = new MySqlConnectionStringBuilder();
            builder.Server = "192.168.0.76";
            builder.Database = "PhotoPlay";
            builder.UserID = "LosMakinas";
            builder.Password = "Almi123";
            cn = new MySqlConnection(builder.ToString());
            cn.Open();
            cmd = new MySqlCommand();
            cmd.Connection = cn;
        }
        public int obtenerUsuario(string nombreUsu, string pass) {
            String strSent;
            strSent = "SELECT idUsuario FROM usuario WHERE nombreUsuario='"+nombreUsu+"' AND pass='"+pass+"'";
            cmd.CommandText = strSent;
            if (reader != null) {
                reader.Close();
            }
            reader = cmd.ExecuteReader();
            while (reader.Read()) {
                return reader.GetInt32(0);
            }
            return 0;
        }

        public void insertarPuntuacion(Partida partida)
        {
            if (partida.Puntuacion <= 0)
            {
                return;
            }
            string strInsertSql = "INSERT INTO puntuacion (puntuacion, numAciertos, fecha, comodinesGastados, tirada, tiempoJugado, idUsuario) VALUES ("+partida.Puntuacion+ ", "+partida.NumAciertos+ ", CURDATE(), " + partida.ComodinesGastados+ ", "+partida.Tirada+ ", "+partida.TiempoJugado+ ", "+partida.IdUsuario+")";
            MySqlCommand com = new MySqlCommand(strInsertSql, cn);
            com.ExecuteNonQuery();
        }

        public MySqlDataReader obtenerPuntuacion()
        {
            string strQuery = "select puntuacion.*, usuario.nombreUsuario FROM puntuacion INNER JOIN usuario ON usuario.idUsuario = puntuacion.idUsuario";
            using (MySqlCommand com = new MySqlCommand(strQuery, cn))
            {
                MySqlDataReader reader = com.ExecuteReader();
                return reader;
            }
            return null;
        }

        public MySqlDataReader obtenerMaxOCantidadPuntuacion(string maxOCant)
        {
            string strQuery = "";
            if (maxOCant == "MaxPunt")
            {
                strQuery = "SELECT MAX(puntuacion), usuario.nombreUsuario FROM puntuacion INNER JOIN usuario ON usuario.idUsuario = puntuacion.idUsuario";
            }
            else if (maxOCant == "PartidasJug")
            {
                strQuery = "SELECT idUsuario, nombreUsuario, (SELECT COUNT(*) FROM puntuacion WHERE idUsuario = usuario.idUsuario) AS totalPuntuaciones FROM usuario";
            }
            else {
                return null;
            }
            
            
            using (MySqlCommand com = new MySqlCommand(strQuery, cn))
            {
                MySqlDataReader reader = com.ExecuteReader();
                return reader;
            }
            return null;
        }

        public MySqlDataReader obtenerPuntuacionQuery(String tabla, String AscDesc)
        {
            string strQuery = "select puntuacion.*, usuario.nombreUsuario FROM puntuacion INNER JOIN usuario ON usuario.idUsuario = puntuacion.idUsuario ORDER BY "+ tabla +" " + AscDesc;
            using (MySqlCommand com = new MySqlCommand(strQuery, cn))
            {
                MySqlDataReader reader = com.ExecuteReader();
                return reader;
            }
            return null;
        }

        public void ResetProgess(int idUsuario)
        {
            string strNonQuery = "call resetProgress("+idUsuario+")";
            using (MySqlCommand com = new MySqlCommand(strNonQuery, cn))
            {
                com.ExecuteNonQuery();
                return;
            }
        }
    }
}
