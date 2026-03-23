namespace Projekt_Kostky_Kingdom_Come
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblNazev = new Label();
            lblSazka = new Label();
            bntSolo = new Button();
            btnDuel = new Button();
            btnStart = new Button();
            rb20 = new RadioButton();
            rb50 = new RadioButton();
            rb100 = new RadioButton();
            btnNapoveda = new Button();
            lblRezim = new Label();
            SuspendLayout();
            // 
            // lblNazev
            // 
            lblNazev.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            lblNazev.Location = new Point(250, 40);
            lblNazev.Name = "lblNazev";
            lblNazev.Size = new Size(300, 60);
            lblNazev.TabIndex = 0;
            lblNazev.Text = "KOSTKY";
            lblNazev.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSazka
            // 
            lblSazka.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lblSazka.Location = new Point(270, 310);
            lblSazka.Name = "lblSazka";
            lblSazka.Size = new Size(100, 30);
            lblSazka.TabIndex = 1;
            lblSazka.Text = "Sázka:";
            lblSazka.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // bntSolo
            // 
            bntSolo.Location = new Point(300, 120);
            bntSolo.Name = "bntSolo";
            bntSolo.Size = new Size(200, 60);
            bntSolo.TabIndex = 2;
            bntSolo.Text = "SOLO";
            bntSolo.UseVisualStyleBackColor = true;
            // 
            // btnDuel
            // 
            btnDuel.Location = new Point(300, 190);
            btnDuel.Name = "btnDuel";
            btnDuel.Size = new Size(200, 60);
            btnDuel.TabIndex = 3;
            btnDuel.Text = "DUEL";
            btnDuel.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(300, 420);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(200, 40);
            btnStart.TabIndex = 4;
            btnStart.Text = "SPUSTIT HRU";
            btnStart.UseVisualStyleBackColor = true;
            // 
            // rb20
            // 
            rb20.AutoSize = true;
            rb20.Location = new Point(270, 350);
            rb20.Name = "rb20";
            rb20.Size = new Size(37, 19);
            rb20.TabIndex = 5;
            rb20.TabStop = true;
            rb20.Text = "20";
            rb20.UseVisualStyleBackColor = true;
            // 
            // rb50
            // 
            rb50.AutoSize = true;
            rb50.Location = new Point(360, 350);
            rb50.Name = "rb50";
            rb50.Size = new Size(37, 19);
            rb50.TabIndex = 6;
            rb50.TabStop = true;
            rb50.Text = "50";
            rb50.UseVisualStyleBackColor = true;
            // 
            // rb100
            // 
            rb100.AutoSize = true;
            rb100.Location = new Point(450, 350);
            rb100.Name = "rb100";
            rb100.Size = new Size(43, 19);
            rb100.TabIndex = 7;
            rb100.TabStop = true;
            rb100.Text = "100";
            rb100.UseVisualStyleBackColor = true;
            // 
            // btnNapoveda
            // 
            btnNapoveda.Location = new Point(300, 480);
            btnNapoveda.Name = "btnNapoveda";
            btnNapoveda.Size = new Size(200, 40);
            btnNapoveda.TabIndex = 8;
            btnNapoveda.Text = "NÁPOVĚDA";
            btnNapoveda.UseVisualStyleBackColor = true;
            // 
            // lblRezim
            // 
            lblRezim.Location = new Point(350, 270);
            lblRezim.Name = "lblRezim";
            lblRezim.Size = new Size(100, 23);
            lblRezim.TabIndex = 9;
            lblRezim.Text = "Režim:";
            lblRezim.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(784, 561);
            Controls.Add(lblRezim);
            Controls.Add(btnNapoveda);
            Controls.Add(rb100);
            Controls.Add(rb50);
            Controls.Add(rb20);
            Controls.Add(btnStart);
            Controls.Add(btnDuel);
            Controls.Add(bntSolo);
            Controls.Add(lblSazka);
            Controls.Add(lblNazev);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNazev;
        private Label lblSazka;
        private Button bntSolo;
        private Button btnDuel;
        private Button btnStart;
        private RadioButton rb20;
        private RadioButton rb50;
        private RadioButton rb100;
        private Button btnNapoveda;
        private Label lblRezim;
    }
}
