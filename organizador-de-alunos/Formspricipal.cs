﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace organizador_de_alunos
{
    public partial class Formspricipal : Form
    {
        public Formspricipal()
        {
            InitializeComponent();
        }

        private void estudanteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void inserirEstudanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInserirEstudante inserirEstudante= new FormInserirEstudante();
            inserirEstudante.Show(this);
        }
    }
}
