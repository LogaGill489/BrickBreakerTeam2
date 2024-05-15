using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMPLib;
using System.Media;
using BrickBreaker.Properties;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using System.Xml;
using System.Diagnostics;

namespace BrickBreaker
{
    public class Sound
    {
        public void Main(string[] args, object sender, Block b, Paddle p, Ball ball, List<Block> blocks)
        {

            // Create a list to hold audio clips
            List<SoundPlayer> audioClips = new List<SoundPlayer>();

            // Added audioclips
            audioClips.Add(new SoundPlayer(Properties.Resources.Idlemusic1));
            audioClips.Add(new SoundPlayer(Properties.Resources.Idlemusic2));
            audioClips.Add(new SoundPlayer(Properties.Resources.Idlemusic3));
            audioClips.Add(new SoundPlayer(Properties.Resources.Idlemusic4));
            audioClips.Add(new SoundPlayer(Properties.Resources.Idlemusic6));
            audioClips.Add(new SoundPlayer(Properties.Resources.Idlemusic11));


            // When booting up a new level
            if (blocks.Count == 0)
            {
                // Create randgen
                Random rnd = new Random();
                int idlesounds = rnd.Next(audioClips.Count);
                SoundPlayer idle = audioClips[idlesounds];

                idle.Stop();
                idle.Play();
            }

            //If button clicked

            //If purchasebutton is clicked
            SoundPlayer HvaNgla = new SoundPlayer(Properties.Resources.HvaNgla);
            //HvaNgla.Play();

        }

        // While within location

        public void Shopload(ShopScreen shopScreen)
        {
            // While shop is entered
            SoundPlayer shopidle = new SoundPlayer(Properties.Resources.shopidle);
            shopidle.PlayLooping();
        }
        public void Scareload(scareScreen scareScreen)
        {
            // While deathscreen is entered
            SoundPlayer deathsudden = new SoundPlayer(Properties.Resources.deathsudden);
            deathsudden.Play();
        }
        public void Menuload(MenuScreen menuScreen)
        {
            // While menu screen is entered 
            SoundPlayer menuidle = new SoundPlayer(Properties.Resources.genericidle);
            // Play after deathscream, and during menu
            menuidle.Play();
        }

        // Powerups collected

        // Ask Logan - why is the Debuff not present?
        void Powerups(Paddle p, Debuff d)
        {
            // If whiteboy
            if (d.debuff == 1)
            {
            }
            // if hindupeace
            if (d.debuff == 2)
            {
            }
            // If freaky
            if (d.debuff == 3)
            {
            }
            // If blessingofwar (Use it for what it's for)
            if (d.debuff == 4)
            {
            }
        }

    }
}


