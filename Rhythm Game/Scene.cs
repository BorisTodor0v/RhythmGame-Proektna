using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Rhythm_Game
{
    public class Scene
    {
        //Posebni listi za objektite koi ke se kreiraat, imenuvani spored kopceto koe treba da se klikne
        public List<Note> left = new List<Note>();
        public List<Note> up = new List<Note>();
        public List<Note> right = new List<Note>();
        public List<Note> down = new List<Note>();

        //Random promenliva koj ke odreduva kakov objekt ke se kreira
        Random noteGenerator = new Random();

        //Promenlivi koi go cuvaat brojot na daden vid na pogodoci

        //Broj na sovrseni pogodoci
        public int perfect { get; set; }
        //Broj na dobri pogodoci
        public int good { get; set; }
        //Broj na losi pogodoci
        public int bad { get; set; }
        //Broj na promaseni
        public int miss { get; set; }


        //Inicijalizacija na promenlivite na 0
        public Scene()
        {
            perfect = 0;
            good = 0;
            bad = 0;
            miss = 0;
        }

        //Funkcija za presmetka na krajniot rezultat. Minimalna vrednost na rezultatot e 0
        public double score()
        {
            double tmp = (perfect*1.5)+(good*1)+(bad*0.5)-(miss*0.5);
            if(tmp >= 0)
            {
                return tmp;
            } else
            {
                return 0;
            }
        }

        //Kreiranje na novi objekti
        public void AddNote()
        {
            //Prethodno deklariranata random promenliva ima opseg na vrednosti od 0 do 3. Sekoj broj soodvetstvuva na odreden tip na objekt
            //
            // Broj | Boja na objektot | Strelka so koja se pogoduva
            //   0  |      Zelena      | Levo
            //   1  |      Crvena      | Gore
            //   2  |       Sina       | Dole
            //   3  |       Zolta      | Desno
            switch (noteGenerator.Next(4))
            {
                case (0):
                    {
                        left.Add(new Note(new Point(80, -200), Color.Green));
                        break;
                    }
                case (1):
                    {
                        up.Add(new Note(new Point(236, -200), Color.Red));
                        break;
                    }
                case (2):
                    {
                        down.Add(new Note(new Point(392, -200), Color.Blue));
                        break;
                    }
                case (3):
                    {
                        right.Add(new Note(new Point(548, -200), Color.Yellow));
                        break;
                    }
            }
        }
        

        //Iscrtuvanje na site objekti od listite
        public void draw(Graphics g)
        {
            foreach(Note n in left)
            {
                n.draw(g);
            }
            foreach (Note n in up)
            {
                n.draw(g);
            }
            foreach (Note n in down)
            {
                n.draw(g);
            }
            foreach (Note n in right)
            {
                n.draw(g);
            }
        }

        //Dvizenje na site objekti od listite
        public void move()
        {
            foreach(Note n in left)
            {
                n.move();
            }
            foreach (Note n in up)
            {
                n.move();
            }
            foreach (Note n in down)
            {
                n.move();
            }
            foreach (Note n in right)
            {
                n.move();
            }
        }

        //Funkcija za proverka na promasen objekt
        public void missed()
        {
            //Proveruva dali nekoj objekt gi pominal strelkite. Za ova se koristi funkcija bidejki ako e promasena strelkata, toa znaci ne e kliknato i nemoze so klik nastan da se proveri
            for(int i=left.Count-1; i>=0; i--)
            {
                if (left[i].miss())
                {
                    left.RemoveAt(i);
                    miss += 1;
                }
            }
            for (int i = up.Count - 1; i >= 0; i--)
            {
                if (up[i].miss())
                {
                    up.RemoveAt(i);
                    miss += 1;
                }
            }
            for (int i = down.Count - 1; i >= 0; i--)
            {
                if (down[i].miss())
                {
                    down.RemoveAt(i);
                    miss += 1;
                }
            }
            for (int i = right.Count - 1; i >= 0; i--)
            {
                if (right[i].miss())
                {
                    right.RemoveAt(i);
                    miss += 1;
                }
            }
        }
    }
}
