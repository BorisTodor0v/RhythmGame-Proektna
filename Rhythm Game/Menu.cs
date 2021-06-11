using System;
using System.Windows.Forms;

namespace Rhythm_Game
{
    public partial class Menu : Form
    {
        private Game form2;
        public Menu()
        {
            InitializeComponent();
        }

        private void start_Click(object sender, EventArgs e)
        {
            //Zapocnuvanja na nova igra
            form2 = new Game();
            
            //Po zavrsuvanje na igrata se smestuva rezultatot vo listata od rezultati i
            //istiot se postavuva kako selectedIndex za da se povika funkcijata da go presmeta najvisokiot rezultat
            //
            //Rezultatite se zemaat samo ako igrata e zavrsena so 30 promaseni. Otkazuvanjeto na igrata preku isklucuvanje na prozorecot 
            //gi isfrla site dobieni poeni
            if (form2.ShowDialog() == DialogResult.OK)
            {
                scoreboard.Items.Add(form2.score);
                scoreboard.SelectedIndex = scoreboard.Items.Count - 1;
            }
            
        }

        //Se bara najgolemiot rezultat od listata na rezultati
        private void scoreboard_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Gi pominuva site Items vo listBox-ot i gi sporeduva so segasnata najgolema vrednost
            //Na pocetok, taa vrednost e postavena da bide 0
            double highest = 0;
            foreach (Double d in scoreboard.Items)
            {
                //Koga ke najde vrednost pogolema od segasnata najgolema, ja zema taa kako najgolema
                if (d > highest)
                {
                    highest = d;
                }
            }
            //Na kraj se pecati najgolemiot rezultat vo tekst box vo formata
            highscore.Text = highest.ToString();
        }
    }
}
