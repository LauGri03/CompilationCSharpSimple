﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Compilation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(CCompilateur.build("build", textBox1.Text, false));
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(CCompilateur.build("build", textBox1.Text, true));
            
        }

        private void compileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(CCompilateur.build("build", textBox1.Text, false));
        }

        private void runToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(CCompilateur.build("build", textBox1.Text, true));
        }
    }
}
