﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_BlindScanner
{
    public partial class Buscador : Form
    {
        public Buscador()
        {
            InitializeComponent();
        }

        private void Buscador_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnvolver_Click(object sender, EventArgs e)
        {
            this.Close();
            MENU menu = new MENU();
            menu.Show();
        }
    }
}
