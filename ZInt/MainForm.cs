﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PreComp;
using Runner;
using System.Threading;

namespace ZInt
{
    public partial class FMain : Form
    {
        public FMain()
        {
            InitializeComponent();
        }

        static void ProcMess()
        {
            Application.DoEvents();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Console Cons = new Console();
            Cons.Visible = true;

            //string sCode  - OUR CODE

           // Runing Run = new Runing(Cons.stdIO, sCode.Split('\n').ToList<string>());
            Runing Run = new Runing(Cons.stdIO, "Code.zpc");
            Run.ProcMess += new ProcessMessages(ProcMess);
            Thread T = new Thread(Run.Run);
            Cons.CurThread = T;
            T.Start();
        }


        private void FMain_Load(object sender, EventArgs e)
        {
        }
    }

}
