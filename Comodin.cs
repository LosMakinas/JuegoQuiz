using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoQuizzReto
{
    
    public class Comodin
    {
        private String tipoComodin;
        private String descripcion;
        private String imagen;
        private int cantidad;
        private int puntuacion;

        public Comodin(String tipoComodin, String descripcion, String imagen, int cantidad, int puntuacion)
        {
            this.tipoComodin = tipoComodin;
            this.descripcion = descripcion;
            this.imagen = imagen;
            this.cantidad = cantidad;
            this.puntuacion = puntuacion;
        }

        public string TipoComodin { get => tipoComodin; set => tipoComodin = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Imagen { get => imagen; set => imagen = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public int Puntuacion { get => puntuacion; set => puntuacion = value; }
    }
}
