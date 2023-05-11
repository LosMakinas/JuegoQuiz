using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
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
    }
}
