using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using WMPLib;

namespace BrickBreaker
{
    public partial class MenuScreen : UserControl
    {
        public MenuScreen()
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

        private void playButton_Click(object sender, EventArgs e)
        {
            SoundPlayer cont = new SoundPlayer(Properties.Resources.bttn);
            cont.Play();
            Cursor.Hide();
            // Goes to the game screen
            GameScreen gs = new GameScreen();
            Form form = this.FindForm();

            form.Controls.Add(gs);
            form.Controls.Remove(this);

            gs.Location = new Point((form.Width - gs.Width) / 2, (form.Height - gs.Height) / 2);

        }

  

        private void MenuScreen_Load(object sender, EventArgs e)
        {
            Cursor.Show();
            // While menu screen is entered 
            SoundPlayer menuidle = new SoundPlayer(Properties.Resources.genericidle);
            // Play after deathscream, and during menu
            menuidle.Play();
        }

        private void MenuScreen_Load_1(object sender, EventArgs e)
        {

        }
    }
}
