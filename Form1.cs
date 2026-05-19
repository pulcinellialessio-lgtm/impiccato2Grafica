namespace impiccato2Grafica
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        string riga, ParolaNascosta, trattini = "";
        int num = 0;
        string[] rigaSplit;
        char[] parolaNascostaArray;

        public void visible()
        {
            labelDifficolta.Visible = true;
            buttonFacile.Visible = true;
            buttonMedio.Visible = true;
            buttonDifficile.Visible = true;
        }

        public void invisible()
        {
            labelDifficolta.Visible = false;
            buttonFacile.Visible = false;
            buttonMedio.Visible = false;
            buttonDifficile.Visible = false;

            labelCategoria.Visible = false;
            buttonCibi.Visible = false;
            buttonAnimali.Visible = false;
            buttonSport.Visible = false;

            buttonStart.Visible = true;
        }
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

            visible();
        }

        private void buttonAnimali_Click(object sender, EventArgs e)
        {
            List<string> animali = new List<string>(File.ReadAllLines("animali.csv"));
            animali.RemoveAt(0);

            num = rnd.Next(0, animali.Count);
            riga = animali[num];

            visible();
        }

        private void buttonSport_Click(object sender, EventArgs e)
        {
            List<string> sport = new List<string>(File.ReadAllLines("sport.csv"));
            sport.RemoveAt(0);

            num = rnd.Next(0, sport.Count);
            riga = sport[num];

            visible();
        }

        private void buttonFacile_Click(object sender, EventArgs e)
        {
            rigaSplit = riga.Split(',');
            ParolaNascosta = rigaSplit[0];

            invisible();
        }

        private void buttonMedio_Click(object sender, EventArgs e)
        {
            rigaSplit = riga.Split(',');
            ParolaNascosta = rigaSplit[1];

            invisible();
        }

        private void buttonDifficile_Click(object sender, EventArgs e)
        {
            rigaSplit = riga.Split(',');
            ParolaNascosta = rigaSplit[2];

            invisible();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            buttonStart.Visible = false;
            textBoxInserimento.Visible = true;
            labelInserisciLettera.Visible = true;
            buttonInserisci.Visible = true;

            textBoxParola.Visible = true;
            labelInserisciParola.Visible = true;
            buttonInserisciParola.Visible = true;

            ParolaNascosta.ToLower();

            for (int i = 0; i < ParolaNascosta.Length; i++)
            {
                trattini += "-";
            }

            labelParola.Text = trattini;
        }

        private void buttonInserisci_Click(object sender, EventArgs e)
        {
            char[] trattiniArray = trattini.ToCharArray();
            parolaNascostaArray = ParolaNascosta.ToCharArray();

            char lettera = Convert.ToChar(textBoxInserimento.Text);

            for (int i = 0; i < parolaNascostaArray.Length; i++)
            {
                if (lettera == parolaNascostaArray[i])
                {
                    trattiniArray[i] = lettera;
                }
            }

            trattini = new string(trattiniArray);
            labelParola.Text = trattini;
        }

        private void textBoxParola_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonInserisciParola_Click(object sender, EventArgs e)
        {
            string Parola = textBoxParola.Text;
            char[] ParolaUguale = Parola.ToCharArray();
            bool uguale = true;

            for (int i = 0; i < parolaNascostaArray.Length; i++)
            {
                if (parolaNascostaArray[i] != ParolaUguale[i])
                {
                    uguale = false;
                }
            }

            if (uguale == true)
            {
                labelVincita.Visible = true;
                textBoxInserimento.Visible = false;
                labelInserisciLettera.Visible = false;
                buttonInserisci.Visible = false;

                textBoxParola.Visible = false;
                labelInserisciParola.Visible = false;
                buttonInserisciParola.Visible = false;

                labelParola.Visible = false;
            }
            else
            {
                labelParolaSbagliata.Visible = true;
            }
        }
    }
}
