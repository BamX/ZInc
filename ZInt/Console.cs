﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ZInt
{
    public partial class Console : Form
    {
        public StdIO stdIO;

        public Console()
        {
            InitializeComponent();
            stdIO = new StdIO(textBox1, richTextBox1);
        }

        private void haltToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        
    }
}