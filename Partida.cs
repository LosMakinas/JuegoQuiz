using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoQuizzReto
{    
    public class Partida
    {
        private int idUsuario;
        private int puntuacion;
        private int numAciertos;
        private int comodinesGastados;
        private int tirada;
        private int tiempoJugado;
        private DateTime fecha;
        public Partida(int idUsuario, int puntuacion, int numAciertos, DateTime fecha ,int comodinesGastados, int tirada, int tiempoJugado)
        {
            this.IdUsuario = idUsuario;
            this.Puntuacion = puntuacion;
            this.NumAciertos = numAciertos;
            this.Fecha = fecha;
            this.ComodinesGastados = comodinesGastados;
            this.Tirada = tirada;
            this.TiempoJugado = tiempoJugado;
        }

        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public int Puntuacion { get => puntuacion; set => puntuacion = value; }
        public int NumAciertos { get => numAciertos; set => numAciertos = value; }
        public int ComodinesGastados { get => comodinesGastados; set => comodinesGastados = value; }
        public int Tirada { get => tirada; set => tirada = value; }
        public int TiempoJugado { get => tiempoJugado; set => tiempoJugado = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
    }
}
