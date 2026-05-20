namespace impiccato2Grafica
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Titolo = new Label();
            buttonCibi = new Button();
            buttonAnimali = new Button();
            buttonSport = new Button();
            labelCategoria = new Label();
            labelDifficolta = new Label();
            buttonFacile = new Button();
            buttonMedio = new Button();
            buttonDifficile = new Button();
            buttonStart = new Button();
            labelParolaNascosta = new Label();
            labelParola = new Label();
            textBoxInserimento = new TextBox();
            labelInserisciLettera = new Label();
            buttonInserisci = new Button();
            textBoxParola = new TextBox();
            buttonInserisciParola = new Button();
            labelInserisciParola = new Label();
            labelVincita = new Label();
            labelParolaSbagliata = new Label();
            pictureBoxTesta = new PictureBox();
            pictureBoxCorda = new PictureBox();
            pictureBoxCorpo = new PictureBox();
            pictureBoxSopra = new PictureBox();
            pictureBoxBraccioD = new PictureBox();
            pictureBoxGambaD = new PictureBox();
            pictureBoxBraccioS = new PictureBox();
            pictureBoxGambaS = new PictureBox();
            buttonJolly = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTesta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCorda).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCorpo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSopra).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBraccioD).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxGambaD).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBraccioS).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxGambaS).BeginInit();
            SuspendLayout();
            // 
            // Titolo
            // 
            Titolo.AutoSize = true;
            Titolo.Font = new Font("Showcard Gothic", 24.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Titolo.Location = new Point(311, 12);
            Titolo.Name = "Titolo";
            Titolo.Size = new Size(198, 42);
            Titolo.TabIndex = 0;
            Titolo.Text = "Impiccato";
            // 
            // buttonCibi
            // 
            buttonCibi.Font = new Font("Showcard Gothic", 33.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonCibi.Location = new Point(31, 236);
            buttonCibi.Name = "buttonCibi";
            buttonCibi.Size = new Size(181, 102);
            buttonCibi.TabIndex = 2;
            buttonCibi.Text = "Cibi";
            buttonCibi.UseVisualStyleBackColor = true;
            buttonCibi.Click += buttonCibi_Click;
            // 
            // buttonAnimali
            // 
            buttonAnimali.Font = new Font("Showcard Gothic", 30F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonAnimali.Location = new Point(317, 234);
            buttonAnimali.Name = "buttonAnimali";
            buttonAnimali.Size = new Size(192, 102);
            buttonAnimali.TabIndex = 3;
            buttonAnimali.Text = "animali";
            buttonAnimali.UseVisualStyleBackColor = true;
            buttonAnimali.Click += buttonAnimali_Click;
            // 
            // buttonSport
            // 
            buttonSport.Font = new Font("Showcard Gothic", 33.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonSport.Location = new Point(610, 234);
            buttonSport.Name = "buttonSport";
            buttonSport.Size = new Size(178, 102);
            buttonSport.TabIndex = 4;
            buttonSport.Text = "sport";
            buttonSport.UseVisualStyleBackColor = true;
            buttonSport.Click += buttonSport_Click;
            // 
            // labelCategoria
            // 
            labelCategoria.AutoSize = true;
            labelCategoria.Font = new Font("Showcard Gothic", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelCategoria.ForeColor = Color.DarkRed;
            labelCategoria.Location = new Point(153, 110);
            labelCategoria.Name = "labelCategoria";
            labelCategoria.Size = new Size(537, 60);
            labelCategoria.TabIndex = 5;
            labelCategoria.Text = "Scegli la categoria:";
            // 
            // labelDifficolta
            // 
            labelDifficolta.AutoSize = true;
            labelDifficolta.Font = new Font("Showcard Gothic", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelDifficolta.Location = new Point(153, 110);
            labelDifficolta.Name = "labelDifficolta";
            labelDifficolta.Size = new Size(544, 60);
            labelDifficolta.TabIndex = 6;
            labelDifficolta.Text = "Scegli la difficoltà:";
            labelDifficolta.Visible = false;
            // 
            // buttonFacile
            // 
            buttonFacile.Font = new Font("Showcard Gothic", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonFacile.Location = new Point(31, 234);
            buttonFacile.Name = "buttonFacile";
            buttonFacile.Size = new Size(181, 104);
            buttonFacile.TabIndex = 7;
            buttonFacile.Text = "facile";
            buttonFacile.UseVisualStyleBackColor = true;
            buttonFacile.Visible = false;
            buttonFacile.Click += buttonFacile_Click;
            // 
            // buttonMedio
            // 
            buttonMedio.Font = new Font("Showcard Gothic", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonMedio.Location = new Point(317, 234);
            buttonMedio.Name = "buttonMedio";
            buttonMedio.Size = new Size(192, 104);
            buttonMedio.TabIndex = 8;
            buttonMedio.Text = "medio";
            buttonMedio.UseVisualStyleBackColor = true;
            buttonMedio.Visible = false;
            buttonMedio.Click += buttonMedio_Click;
            // 
            // buttonDifficile
            // 
            buttonDifficile.Font = new Font("Showcard Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonDifficile.Location = new Point(610, 234);
            buttonDifficile.Name = "buttonDifficile";
            buttonDifficile.Size = new Size(178, 102);
            buttonDifficile.TabIndex = 9;
            buttonDifficile.Text = "Difficile";
            buttonDifficile.UseVisualStyleBackColor = true;
            buttonDifficile.Visible = false;
            buttonDifficile.Click += buttonDifficile_Click;
            // 
            // buttonStart
            // 
            buttonStart.Font = new Font("Showcard Gothic", 32.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonStart.Location = new Point(327, 164);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(166, 64);
            buttonStart.TabIndex = 10;
            buttonStart.Text = "START";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Visible = false;
            buttonStart.Click += buttonStart_Click;
            // 
            // labelParolaNascosta
            // 
            labelParolaNascosta.AutoSize = true;
            labelParolaNascosta.Location = new Point(369, 356);
            labelParolaNascosta.Name = "labelParolaNascosta";
            labelParolaNascosta.Size = new Size(0, 15);
            labelParolaNascosta.TabIndex = 11;
            // 
            // labelParola
            // 
            labelParola.AutoSize = true;
            labelParola.Font = new Font("Showcard Gothic", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelParola.Location = new Point(153, 280);
            labelParola.Name = "labelParola";
            labelParola.Size = new Size(0, 60);
            labelParola.TabIndex = 12;
            // 
            // textBoxInserimento
            // 
            textBoxInserimento.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxInserimento.Location = new Point(533, 185);
            textBoxInserimento.Name = "textBoxInserimento";
            textBoxInserimento.Size = new Size(100, 39);
            textBoxInserimento.TabIndex = 13;
            textBoxInserimento.Visible = false;
            // 
            // labelInserisciLettera
            // 
            labelInserisciLettera.AutoSize = true;
            labelInserisciLettera.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelInserisciLettera.Location = new Point(533, 153);
            labelInserisciLettera.Name = "labelInserisciLettera";
            labelInserisciLettera.Size = new Size(151, 17);
            labelInserisciLettera.TabIndex = 14;
            labelInserisciLettera.Text = "Inserisci la lettera:";
            labelInserisciLettera.Visible = false;
            // 
            // buttonInserisci
            // 
            buttonInserisci.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonInserisci.Location = new Point(654, 185);
            buttonInserisci.Name = "buttonInserisci";
            buttonInserisci.Size = new Size(101, 38);
            buttonInserisci.TabIndex = 15;
            buttonInserisci.Text = "Inserisci";
            buttonInserisci.UseVisualStyleBackColor = true;
            buttonInserisci.Visible = false;
            buttonInserisci.Click += buttonInserisci_Click;
            // 
            // textBoxParola
            // 
            textBoxParola.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxParola.Location = new Point(533, 313);
            textBoxParola.Name = "textBoxParola";
            textBoxParola.Size = new Size(100, 37);
            textBoxParola.TabIndex = 16;
            textBoxParola.Visible = false;
            // 
            // buttonInserisciParola
            // 
            buttonInserisciParola.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonInserisciParola.Location = new Point(654, 313);
            buttonInserisciParola.Name = "buttonInserisciParola";
            buttonInserisciParola.Size = new Size(101, 41);
            buttonInserisciParola.TabIndex = 17;
            buttonInserisciParola.Text = "Inserisci";
            buttonInserisciParola.UseVisualStyleBackColor = true;
            buttonInserisciParola.Visible = false;
            buttonInserisciParola.Click += buttonInserisciParola_Click;
            // 
            // labelInserisciParola
            // 
            labelInserisciParola.AutoSize = true;
            labelInserisciParola.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelInserisciParola.Location = new Point(533, 278);
            labelInserisciParola.Name = "labelInserisciParola";
            labelInserisciParola.Size = new Size(146, 17);
            labelInserisciParola.TabIndex = 18;
            labelInserisciParola.Text = "Inserisci la parola:";
            labelInserisciParola.Visible = false;
            // 
            // labelVincita
            // 
            labelVincita.AutoSize = true;
            labelVincita.Font = new Font("Showcard Gothic", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelVincita.Location = new Point(259, 74);
            labelVincita.Name = "labelVincita";
            labelVincita.Size = new Size(438, 79);
            labelVincita.TabIndex = 19;
            labelVincita.Text = "Hai vinto!!!";
            labelVincita.Visible = false;
            // 
            // labelParolaSbagliata
            // 
            labelParolaSbagliata.AutoSize = true;
            labelParolaSbagliata.Font = new Font("Showcard Gothic", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelParolaSbagliata.Location = new Point(238, 74);
            labelParolaSbagliata.Name = "labelParolaSbagliata";
            labelParolaSbagliata.Size = new Size(565, 46);
            labelParolaSbagliata.TabIndex = 20;
            labelParolaSbagliata.Text = "Parola sbagliata riprova!!";
            labelParolaSbagliata.Visible = false;
            // 
            // pictureBoxTesta
            // 
            pictureBoxTesta.BackColor = SystemColors.Control;
            pictureBoxTesta.Image = Properties.Resources.testa;
            pictureBoxTesta.Location = new Point(90, 57);
            pictureBoxTesta.Name = "pictureBoxTesta";
            pictureBoxTesta.Size = new Size(122, 77);
            pictureBoxTesta.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxTesta.TabIndex = 21;
            pictureBoxTesta.TabStop = false;
            pictureBoxTesta.Visible = false;
            // 
            // pictureBoxCorda
            // 
            pictureBoxCorda.Image = Properties.Resources.corpo2;
            pictureBoxCorda.Location = new Point(90, 24);
            pictureBoxCorda.Name = "pictureBoxCorda";
            pictureBoxCorda.Size = new Size(122, 30);
            pictureBoxCorda.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxCorda.TabIndex = 22;
            pictureBoxCorda.TabStop = false;
            pictureBoxCorda.Visible = false;
            // 
            // pictureBoxCorpo
            // 
            pictureBoxCorpo.Image = Properties.Resources.corpo2;
            pictureBoxCorpo.Location = new Point(90, 136);
            pictureBoxCorpo.Name = "pictureBoxCorpo";
            pictureBoxCorpo.Size = new Size(122, 70);
            pictureBoxCorpo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxCorpo.TabIndex = 23;
            pictureBoxCorpo.TabStop = false;
            pictureBoxCorpo.Visible = false;
            // 
            // pictureBoxSopra
            // 
            pictureBoxSopra.Image = Properties.Resources.png_clipart_line_angle_font_line_angle_rectangle;
            pictureBoxSopra.Location = new Point(-9, -1);
            pictureBoxSopra.Name = "pictureBoxSopra";
            pictureBoxSopra.Size = new Size(172, 30);
            pictureBoxSopra.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxSopra.TabIndex = 24;
            pictureBoxSopra.TabStop = false;
            pictureBoxSopra.Visible = false;
            // 
            // pictureBoxBraccioD
            // 
            pictureBoxBraccioD.Image = Properties.Resources.orizzontaleS;
            pictureBoxBraccioD.Location = new Point(55, 134);
            pictureBoxBraccioD.Name = "pictureBoxBraccioD";
            pictureBoxBraccioD.Size = new Size(92, 70);
            pictureBoxBraccioD.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxBraccioD.TabIndex = 25;
            pictureBoxBraccioD.TabStop = false;
            pictureBoxBraccioD.Visible = false;
            // 
            // pictureBoxGambaD
            // 
            pictureBoxGambaD.Image = Properties.Resources.orizzontaleS;
            pictureBoxGambaD.Location = new Point(52, 203);
            pictureBoxGambaD.Name = "pictureBoxGambaD";
            pictureBoxGambaD.Size = new Size(98, 70);
            pictureBoxGambaD.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxGambaD.TabIndex = 26;
            pictureBoxGambaD.TabStop = false;
            pictureBoxGambaD.Visible = false;
            // 
            // pictureBoxBraccioS
            // 
            pictureBoxBraccioS.Image = Properties.Resources.Gemini_Generated_Image_ccph77ccph77ccph;
            pictureBoxBraccioS.Location = new Point(153, 133);
            pictureBoxBraccioS.Name = "pictureBoxBraccioS";
            pictureBoxBraccioS.Size = new Size(92, 70);
            pictureBoxBraccioS.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxBraccioS.TabIndex = 27;
            pictureBoxBraccioS.TabStop = false;
            pictureBoxBraccioS.Visible = false;
            // 
            // pictureBoxGambaS
            // 
            pictureBoxGambaS.Image = Properties.Resources.Gemini_Generated_Image_ccph77ccph77ccph;
            pictureBoxGambaS.Location = new Point(152, 202);
            pictureBoxGambaS.Name = "pictureBoxGambaS";
            pictureBoxGambaS.Size = new Size(92, 70);
            pictureBoxGambaS.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxGambaS.TabIndex = 28;
            pictureBoxGambaS.TabStop = false;
            pictureBoxGambaS.Visible = false;
            // 
            // buttonJolly
            // 
            buttonJolly.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonJolly.Location = new Point(533, 380);
            buttonJolly.Name = "buttonJolly";
            buttonJolly.Size = new Size(100, 40);
            buttonJolly.TabIndex = 29;
            buttonJolly.Text = "Jolly";
            buttonJolly.UseVisualStyleBackColor = true;
            buttonJolly.Visible = false;
            buttonJolly.Click += buttonJolly_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(861, 432);
            Controls.Add(buttonJolly);
            Controls.Add(pictureBoxGambaS);
            Controls.Add(pictureBoxBraccioD);
            Controls.Add(pictureBoxBraccioS);
            Controls.Add(pictureBoxCorpo);
            Controls.Add(pictureBoxGambaD);
            Controls.Add(pictureBoxSopra);
            Controls.Add(pictureBoxTesta);
            Controls.Add(pictureBoxCorda);
            Controls.Add(labelParolaSbagliata);
            Controls.Add(labelVincita);
            Controls.Add(labelInserisciParola);
            Controls.Add(buttonInserisciParola);
            Controls.Add(textBoxParola);
            Controls.Add(buttonInserisci);
            Controls.Add(labelInserisciLettera);
            Controls.Add(textBoxInserimento);
            Controls.Add(labelParola);
            Controls.Add(labelParolaNascosta);
            Controls.Add(buttonStart);
            Controls.Add(buttonDifficile);
            Controls.Add(buttonMedio);
            Controls.Add(buttonFacile);
            Controls.Add(labelDifficolta);
            Controls.Add(labelCategoria);
            Controls.Add(buttonSport);
            Controls.Add(buttonAnimali);
            Controls.Add(buttonCibi);
            Controls.Add(Titolo);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBoxTesta).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCorda).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCorpo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSopra).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBraccioD).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxGambaD).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBraccioS).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxGambaS).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Titolo;
        private Button buttonCibi;
        private Button buttonAnimali;
        private Button buttonSport;
        private Label labelCategoria;
        private Label labelDifficolta;
        private Button buttonFacile;
        private Button buttonMedio;
        private Button buttonDifficile;
        private Button buttonStart;
        private Label labelParolaNascosta;
        private Label labelParola;
        private TextBox textBoxInserimento;
        private Label labelInserisciLettera;
        private Button buttonInserisci;
        private TextBox textBoxParola;
        private Button buttonInserisciParola;
        private Label labelInserisciParola;
        private Label labelVincita;
        private Label labelParolaSbagliata;
        private PictureBox pictureBoxTesta;
        private PictureBox pictureBoxCorda;
        private PictureBox pictureBoxCorpo;
        private PictureBox pictureBoxSopra;
        private PictureBox pictureBoxBraccioD;
        private PictureBox pictureBoxGambaD;
        private PictureBox pictureBoxBraccioS;
        private PictureBox pictureBoxGambaS;
        private Button buttonJolly;
    }
}
