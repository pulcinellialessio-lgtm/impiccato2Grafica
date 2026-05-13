namespace impiccato2Grafica
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        string riga;
        int num = 0;

        public Form1()
        {
            InitializeComponent();

        }

        private void buttonCibi_Click(object sender, EventArgs e)
        {
            List<string> cibi = new List<string>(File.ReadAllLines("parole_impiccato_aggiornato.csv"));
            cibi.RemoveAt(0);

            num = rnd.Next(0, cibi.Count);
            riga = cibi[num];

            labelDifficolta.Visible = true;
            buttonFacile.Visible = true;
            buttonMedio.Visible = true;
            buttonDifficile.Visible = true;
        }

        private void buttonAnimali_Click(object sender, EventArgs e)
        {
            List<string> cibi = new List<string>(File.ReadAllLines("parole_impiccato_aggiornato.csv"));
            cibi.RemoveAt(0);

            num = rnd.Next(0, cibi.Count);
            riga = cibi[num];

            labelDifficolta.Visible = true;
            buttonFacile.Visible = true;
            buttonMedio.Visible = true;
            buttonDifficile.Visible = true;
        }

        private void buttonSport_Click(object sender, EventArgs e)
        {
            List<string> cibi = new List<string>(File.ReadAllLines("parole_impiccato_aggiornato.csv"));
            cibi.RemoveAt(0);

            num = rnd.Next(0, cibi.Count);
            riga = cibi[num];

            labelDifficolta.Visible = true;
            buttonFacile.Visible = true;
            buttonMedio.Visible = true;
            buttonDifficile.Visible = true;
        }

        private void buttonFacile_Click(object sender, EventArgs e)
        {

        }
    }
}
