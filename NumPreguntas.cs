﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JuegoQuizzReto {
    public partial class NumPreguntas : Form {

        private MenuPrincipal menu;
        private Usuario usuario;

        public NumPreguntas(MenuPrincipal menu, Usuario usuario) {
            InitializeComponent();
            this.menu = menu;
            this.usuario = usuario;
        }

        private void crearPartida(object sender, EventArgs e) {

        }
    }
}
