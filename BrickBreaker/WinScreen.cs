﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrickBreaker
{
    public partial class WinScreen : UserControl
    {
        public WinScreen()
        {
            InitializeComponent();
            this.Size = Screen.PrimaryScreen.Bounds.Size;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1.ChangeScreen(this, new MenuScreen());
        }
    }
}
