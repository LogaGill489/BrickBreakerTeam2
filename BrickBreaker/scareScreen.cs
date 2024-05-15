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
    public partial class scareScreen : Form
    {
        public scareScreen()
        {
            InitializeComponent();
        }

        private void scareScreen_Load(object sender, EventArgs e)
        {
            SoundPlayer deathsudden = new SoundPlayer(Properties.Resources.deathsudden);
            deathsudden.Play();
        }
    }
}
