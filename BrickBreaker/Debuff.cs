using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Media;

namespace BrickBreaker
{
    public class Debuff
    {
        SoundPlayer pantera = new SoundPlayer(Properties.Resources.pantera);
        SoundPlayer freaky = new SoundPlayer(Properties.Resources.freaky);
        SoundPlayer swirleffect = new SoundPlayer(Properties.Resources.swirleffect);
        SoundPlayer crakka = new SoundPlayer(Properties.Resources.crakka);

        public int debuff;
        public int x, y;
        int speedUp;

        public Debuff(int _debuff, int _x, int _y)
        {
            debuff = _debuff;
            x = _x;
            y = _y;

        }

        public void Spawn()
        {
            speedUp = speedUp + 2;
            
            double temp = 0.155 * ( 2 ^ speedUp);

            y += Convert.ToInt16(temp);
        }

        public void PaddleCollision(Paddle p, Debuff d)
        {
            Rectangle DebuffRec = new Rectangle(d.x, d.y, 10, 10);
            Rectangle paddleRec = new Rectangle(p.x, p.y, p.width, p.height);

            if (DebuffRec.IntersectsWith(paddleRec))
            {
                GameScreen.debuffCollected = true;
                GameScreen.SDC = d;

                // if whiteboy
                if (d.debuff == 1)
                {
                    crakka.Play();
                    GameScreen.dB1 = true;
                }
                // if swirl/mirror
                if(d.debuff == 2)
                {
                    swirleffect.Play();
                    GameScreen.dB2 = true;
                }
                // if Freaky
                if(d.debuff == 3)
                {
                    freaky.Play();
                    GameScreen.dB3 = true;
                }
                // If vines
                if(d.debuff == 4)
                {
                    GameScreen.dB4 = true;
                }
                // If splitter
                if(d.debuff == 5)
                {
                    GameScreen.dB5 = true;
                }
            }
        }
    }
}
