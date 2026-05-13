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
            dateTimePicker1 = new DateTimePicker();
            buttonCibi = new Button();
            buttonAnimali = new Button();
            buttonSport = new Button();
            labelCategoria = new Label();
            labelDifficolta = new Label();
            buttonFacile = new Button();
            buttonMedio = new Button();
            buttonDifficile = new Button();
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
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(12, 12);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 1;
            // 
            // buttonCibi
            // 
            buttonCibi.Font = new Font("Showcard Gothic", 33.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonCibi.Location = new Point(31, 234);
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
            buttonFacile.Size = new Size(181, 102);
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
            buttonMedio.Size = new Size(192, 102);
            buttonMedio.TabIndex = 8;
            buttonMedio.Text = "medio";
            buttonMedio.UseVisualStyleBackColor = true;
            buttonMedio.Visible = false;
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
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonDifficile);
            Controls.Add(buttonMedio);
            Controls.Add(buttonFacile);
            Controls.Add(labelDifficolta);
            Controls.Add(labelCategoria);
            Controls.Add(buttonSport);
            Controls.Add(buttonAnimali);
            Controls.Add(buttonCibi);
            Controls.Add(dateTimePicker1);
            Controls.Add(Titolo);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Titolo;
        private DateTimePicker dateTimePicker1;
        private Button buttonCibi;
        private Button buttonAnimali;
        private Button buttonSport;
        private Label labelCategoria;
        private Label labelDifficolta;
        private Button buttonFacile;
        private Button buttonMedio;
        private Button buttonDifficile;
    }
}
