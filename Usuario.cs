using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoQuizzReto {
    public class Usuario {

        private int id;
        private string nombreUsu;
        private string pass;

        public Usuario(int id, string nombreUsu, string pass) {
            this.id = id;
            this.nombreUsu = nombreUsu;
            this.pass = pass;
        }

        public int Id { 
            set{ id = value; }
            get{ return this.id; }
        }
        public string NombreUsu {
            set { nombreUsu = value; }
            get { return this.nombreUsu; }
        }
        public string Pass {
            set { pass = value; }
            get { return this.pass; }
        }
    }
}
