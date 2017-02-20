﻿using FluxMath.Interfaces.Electronica;
using FluxMath.Interfaces.Informacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FluxMath {
  public partial class MainWindow : Form {
    public MainWindow() {
      InitializeComponent();
    }

    private void herramientasToolStripMenuItem_Click(object sender, EventArgs e) {

    }

    private void ohmToolStripMenuItem_Click(object sender, EventArgs e) {
      Ohm o = new Ohm();
      o.MdiParent = this;
      o.Show();
    }

    private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e) {
      Acercade a = new Acercade();
      a.ShowDialog();
    }
  }
}
