﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace word.page
{
    public partial class select : Form
    {
        public select()
        {
            InitializeComponent();
        }

        private void btnMySelf_Click(object sender, EventArgs e)
        {
            wordMySelf word = new wordMySelf();
          
            word.Show();
            this.Hide();
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            wordRandom word = new wordRandom();
            word.Show();
            this.Hide();

        }

        private void pcbPowerOff_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
