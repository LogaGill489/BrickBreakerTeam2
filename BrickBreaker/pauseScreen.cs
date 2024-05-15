using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace BrickBreaker
{
    public partial class pauseScreen : Form
    {
        public pauseScreen()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //If endbutton is clicked
            SoundPlayer strt = new SoundPlayer(Properties.Resources.bttn);
            strt.Play();
            Application.Exit();
        }
    }
}
