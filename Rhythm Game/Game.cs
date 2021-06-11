using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rhythm_Game
{
    public partial class Game : Form
    {
        //Rezultat od igrata, se presmetuva otkako ke zavrsi igrata (Brojot na promaseni objekti = 30
        public double score { get; set; }
        //Promenliva koja ke koristi pri generiranjeto na novi objekti. 
        private int elapsed { get; set; }
        public Scene scene;
        public Game()
        {
            //Inicijalizacija na promenlivi
            InitializeComponent();
            elapsed = 0;
            scene = new Scene();
            perfectLabel.Text = String.Format("Совршени: {0}", scene.perfect);
            goodLabel.Text = String.Format("Добри: {0}", scene.good);
            badLabel.Text = String.Format("Лоши: {0}", scene.bad);
            missLabel.Text = String.Format("Промашени: {0}", scene.miss);
            DoubleBuffered = true;
            moveTimer.Interval = 20;
            gameTimer.Enabled = true;
            gameTimer.Interval = 100;
            moveTimer.Enabled = true;
        }

        //Nastan za proverka na pogodok posle sekoj klik na strelkite na tastaturata
        //Funkcionira takasto se zema Y koordinatata na objektite koi pagjaat i spored taa vrednost se odreduva tipot na pogodokot
        //  Tip na pogodok | Interval vo koj treba da bide Y koordinatata za toj pogodok
        //       Los       | [590, 630] ili (730, 770)
        //      Dobar      | (630, 660] ili (700, 730]
        //     Sovrsen     | (660, 700]
        //---------------------------------------------
        //Za site vrednosti nad 770 se smeta kako promaseno. Ovaa proverka se vrsi vo posebna funkcija koja se povikuva so nastan Tick na timer,
        //bidejki ostanatite proverki se vrsat na nastan Keydown na formata.
        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            //Za proverka na sekoj tip na pogodok se otstranuva objektot od listata na objekti i se dodava +1 vo promenlivata koja go cuva brojot na soodvetni pogodoci
            switch (e.KeyCode)
            {
                //Pritisnata strelka levo
                case Keys.Left:
                    {

                        for (int i = scene.left.Count-1; i >= 0; i--)
                        {
                            if ((scene.left[i].center.Y >= 590 && scene.left[i].center.Y <= 630)||(scene.left[i].center.Y > 730 && scene.left[i].center.Y < 770))
                            {
                                //Los pogodok
                                scene.left.RemoveAt(i);
                                scene.bad += 1;
                                break;
                            } else if ((scene.left[i].center.Y > 630 && scene.left[i].center.Y <= 660) || (scene.left[i].center.Y >700 && scene.left[i].center.Y <= 730))
                            {
                                //Dobar pogodok
                                scene.left.RemoveAt(i);
                                scene.good += 1;
                                break;
                            } else if ((scene.left[i].center.Y > 660 && scene.left[i].center.Y <= 700))
                            {
                                //Sovrsen pogodok
                                scene.left.RemoveAt(i);
                                scene.perfect += 1;
                                break;
                            }
                        }
                        break;
                    }
                //Pritisnata strelka gore
                case Keys.Up:
                    {
                        for (int i = scene.up.Count - 1; i >= 0; i--)
                        {
                            if ((scene.up[i].center.Y >= 590 && scene.up[i].center.Y <= 630) || (scene.up[i].center.Y > 730 && scene.up[i].center.Y < 770))
                            {
                                //Los pogodok
                                scene.up.RemoveAt(i);
                                scene.bad += 1;
                                break;
                            }
                            else if ((scene.up[i].center.Y > 630 && scene.up[i].center.Y <= 660) || (scene.up[i].center.Y > 700 && scene.up[i].center.Y <= 730))
                            {
                                //Dobar pogodok
                                scene.up.RemoveAt(i);
                                scene.good += 1;
                                break;
                            }
                            else if ((scene.up[i].center.Y > 660 && scene.up[i].center.Y <= 700))
                            {
                                //Sovrsen pogodok
                                scene.up.RemoveAt(i);
                                scene.perfect += 1;
                                break;
                            }
                        }
                        break;
                    }
                //Pritisnata strelka dole
                case Keys.Down:
                    {
                        for (int i = scene.down.Count - 1; i >= 0; i--)
                        {
                            if ((scene.down[i].center.Y >= 590 && scene.down[i].center.Y <= 630) || (scene.down[i].center.Y > 730 && scene.down[i].center.Y <= 770))
                            {
                                //Los pogodok
                                scene.down.RemoveAt(i);
                                scene.bad += 1;
                                break;
                            }
                            else if ((scene.down[i].center.Y > 630 && scene.down[i].center.Y <= 660) || (scene.down[i].center.Y > 700 && scene.down[i].center.Y <= 730))
                            {
                                //Dobar pogodok
                                scene.down.RemoveAt(i);
                                scene.good += 1;
                                break;
                            }
                            else if ((scene.down[i].center.Y > 660 && scene.down[i].center.Y <= 700))
                            {
                                //Sovrsen pogodok
                                scene.down.RemoveAt(i);
                                scene.perfect += 1;
                                break;
                            }
                        }
                        break;
                    }
                //Pritisnata strelka desno
                case Keys.Right:
                    {
                        for (int i = scene.right.Count - 1; i >= 0; i--)
                        {
                            if ((scene.right[i].center.Y >= 590 && scene.right[i].center.Y <= 630) || (scene.right[i].center.Y > 730 && scene.right[i].center.Y <= 770))
                            {
                                //Los pogodok
                                scene.right.RemoveAt(i);
                                scene.bad += 1;
                                break;
                            }
                            else if ((scene.right[i].center.Y > 630 && scene.right[i].center.Y <= 660) || (scene.right[i].center.Y > 700 && scene.right[i].center.Y <= 730))
                            {
                                //Dobar pogodok
                                scene.right.RemoveAt(i);
                                scene.good += 1;
                                break;
                            }
                            else if ((scene.right[i].center.Y > 660 && scene.right[i].center.Y <= 700))
                            {
                                //Sovrsen pogodok
                                scene.right.RemoveAt(i);
                                scene.perfect += 1;
                                break;
                            }
                        }
                        break;
                    }
            }
        }

        //Iscrtuvanje na site objekti vo formata
        private void Form2_Paint(object sender, PaintEventArgs e)
        {
            scene.draw(e.Graphics);
        }

        //Tajmer koj gi dvizi objektite vo formata
        //Posle odredeno vreme, intervalot na tajmerot se namaluva i objektite ke se dvizat pobrzo
        private void timer1_Tick(object sender, EventArgs e)
        {
            scene.move();
            Invalidate();
        }

        //Tajmer so koj se kreiraat novi objekti, osvezuvaat stringovi i proveruva za promaseni
        //Posle odredeno vreme, intervalot na tajmerot se namaluva i pocesto se kreiraat novi objekti
        private void gameTimer_Tick(object sender, EventArgs e)
        {   //Se dodeka nema 30 promaseni objekti, da prodolzi igrata. Vo sprotivno, da se prekine i da se iskluci formata so igrata
            if (scene.miss < 30)
            {
                //Proveruva za promaseni, bidejki nemoze so klik da se proverat
                scene.missed();
                //Osvezuvanje na labelite vo status bar
                perfectLabel.Text = String.Format("Совршени: {0}", scene.perfect);
                goodLabel.Text = String.Format("Добри: {0}", scene.good);
                badLabel.Text = String.Format("Лоши: {0}", scene.bad);
                missLabel.Text = String.Format("Промашени: {0}", scene.miss);
                //Kreiranje na objekti koi ke pagjaat od vrvot na prozorecot
                if (elapsed % 7 == 0)
                {
                    scene.AddNote();
                }
                if (elapsed % 29 == 0)
                {
                    scene.AddNote();
                }
                elapsed += 1;
                //Posle odredeno vreme da se zgolemi brzinata na pagjanje i cestotata na pravenje novi objekti
                if (elapsed % 230 == 0)
                {
                    if (moveTimer.Interval > 15) { moveTimer.Interval -= 1; }
                    if (gameTimer.Interval > 50) { gameTimer.Interval -= 10; }
                }
            } else
            //Koga ke zavrsi igrata (30 promaseni) - Se isklucuva prozorecot i se prakja rezultatot na formata za da se smesti vo ListBox so rezultati
            {
                gameTimer.Enabled = false;
                moveTimer.Enabled = false;
                score = scene.score();
                MessageBox.Show(String.Format("Играта е завршена - ваш резултат: {0}", score));
                DialogResult = DialogResult.OK;
            }
        }
    }
}
