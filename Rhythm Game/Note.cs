using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Rhythm_Game
{
    public class Note
    {
        //Radius na objektot. Ednakov na sirinata na slikite so strelkite vo Form2
        public readonly int radius = 150;
        //Koordinati na objektot
        public Point center { get; set; }
        //Boja na objektot
        public Color color;

        //Konstruktor koj prima koordinati i boja
        public Note(Point p, Color c)
        {
            center = p;
            color = c;
        }

        //Funkcija za dvizenje na objektot
        public void move()
        {
            center = new Point(center.X, center.Y + 10);
        }

        //Funkcija za crtanje na objektot
        public void draw(Graphics g)
        {
            Brush b = new SolidBrush(color);
            g.FillEllipse(b, center.X, center.Y, radius, radius);
            b.Dispose();
        }

        //Proverka za promasen. Kako promasen se smeta objektot cija Y koordinata e pogolema od 770
        //Za taa vrednost e promasena strelkata i objektot se naogja nadvor od ramkite na formata
        public bool miss()
        {
            return this.center.Y > 770;
        }

    }
}
