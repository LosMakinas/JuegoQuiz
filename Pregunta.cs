using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JuegoQuizzReto {
    public class Pregunta {

        private Newtonsoft.Json.Linq.JObject todasPreguntas;
        private Newtonsoft.Json.Linq.JObject todasPreguntasFol;
        private Newtonsoft.Json.Linq.JObject todasPreguntasIngles;

        public Pregunta() {
            GetItems();
            GetPreguntasIngles();
            GetPreguntasFol();
        }
        public void GetItems() {
            var url = $"http://192.168.0.97:8080/api/preguntas";
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "application/json";
            request.Accept = "application/json";

            try {
                using (WebResponse response = request.GetResponse()) {
                    using (Stream strReader = response.GetResponseStream()) {
                        if (strReader == null) return;
                        using (StreamReader objReader = new StreamReader(strReader)) {
                            string responseBody = objReader.ReadToEnd();
                            todasPreguntas = (Newtonsoft.Json.Linq.JObject)Newtonsoft.Json.JsonConvert.DeserializeObject(responseBody);
                        }
                    }
                }
            } catch (WebException ex) {
                Console.WriteLine(ex.Message);
                return;
            }
        }

        public void GetPreguntasIngles() {
            var url = $"http://192.168.0.97:8080/api/preguntasIngles";
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "application/json";
            request.Accept = "application/json";

            try {
                using (WebResponse response = request.GetResponse()) {
                    using (Stream strReader = response.GetResponseStream()) {
                        if (strReader == null) return;
                        using (StreamReader objReader = new StreamReader(strReader)) {
                            string responseBody = objReader.ReadToEnd();
                            todasPreguntasIngles = (Newtonsoft.Json.Linq.JObject)Newtonsoft.Json.JsonConvert.DeserializeObject(responseBody);
                        }
                    }
                }
            } catch (WebException ex) {
                Console.WriteLine(ex.Message);
                return;
            }
        }

        public void GetPreguntasFol() {
            var url = $"http://192.168.0.97:8080/api/preguntasFol";
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "application/json";
            request.Accept = "application/json";

            try {
                using (WebResponse response = request.GetResponse()) {
                    using (Stream strReader = response.GetResponseStream()) {
                        if (strReader == null) return;
                        using (StreamReader objReader = new StreamReader(strReader)) {
                            string responseBody = objReader.ReadToEnd();
                            todasPreguntasFol = (Newtonsoft.Json.Linq.JObject)Newtonsoft.Json.JsonConvert.DeserializeObject(responseBody);
                        }
                    }
                }
            } catch (WebException ex) {
                Console.WriteLine(ex.Message);
                return;
            }
        }

        public Newtonsoft.Json.Linq.JObject TodasPreguntas {
            set { todasPreguntas = value; }
            get { return todasPreguntas; }
        }

    }
}
