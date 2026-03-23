namespace Projekt_Kostky_Kingdom_Come
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblHrac1 = new Label();
            lblHrac2 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            lblBodyZaKolo = new Label();
            lblCelkoveBody = new Label();
            btnHodit = new Button();
            btnKonecTahu = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // lblHrac1
            // 
            lblHrac1.Font = new Font("Segoe UI", 18F);
            lblHrac1.ImageAlign = ContentAlignment.BottomLeft;
            lblHrac1.Location = new Point(50, 20);
            lblHrac1.Name = "lblHrac1";
            lblHrac1.Size = new Size(300, 30);
            lblHrac1.TabIndex = 0;
            lblHrac1.Text = "Hráč 1: 0";
            // 
            // lblHrac2
            // 
            lblHrac2.Font = new Font("Segoe UI", 18F);
            lblHrac2.Location = new Point(650, 20);
            lblHrac2.Name = "lblHrac2";
            lblHrac2.Size = new Size(300, 30);
            lblHrac2.TabIndex = 1;
            lblHrac2.Text = "Hráč 2: 0";
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(200, 150);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(80, 80);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(300, 150);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(80, 80);
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(400, 150);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(80, 80);
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Location = new Point(500, 150);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(80, 80);
            pictureBox4.TabIndex = 5;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Location = new Point(600, 150);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(80, 80);
            pictureBox5.TabIndex = 6;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Location = new Point(700, 150);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(80, 80);
            pictureBox6.TabIndex = 7;
            pictureBox6.TabStop = false;
            // 
            // lblBodyZaKolo
            // 
            lblBodyZaKolo.Font = new Font("Segoe UI", 18F);
            lblBodyZaKolo.Location = new Point(350, 270);
            lblBodyZaKolo.Name = "lblBodyZaKolo";
            lblBodyZaKolo.Size = new Size(300, 30);
            lblBodyZaKolo.TabIndex = 8;
            lblBodyZaKolo.Text = "Body za kolo: 0";
            // 
            // lblCelkoveBody
            // 
            lblCelkoveBody.Font = new Font("Segoe UI", 18F);
            lblCelkoveBody.Location = new Point(350, 310);
            lblCelkoveBody.Name = "lblCelkoveBody";
            lblCelkoveBody.Size = new Size(300, 30);
            lblCelkoveBody.TabIndex = 9;
            lblCelkoveBody.Text = "Celkem: 0";
            // 
            // btnHodit
            // 
            btnHodit.Location = new Point(300, 400);
            btnHodit.Name = "btnHodit";
            btnHodit.Size = new Size(150, 60);
            btnHodit.TabIndex = 10;
            btnHodit.Text = "HODIT";
            btnHodit.UseVisualStyleBackColor = true;
            // 
            // btnKonecTahu
            // 
            btnKonecTahu.Location = new Point(550, 400);
            btnKonecTahu.Name = "btnKonecTahu";
            btnKonecTahu.Size = new Size(150, 60);
            btnKonecTahu.TabIndex = 11;
            btnKonecTahu.Text = "UKONČIT TAH";
            btnKonecTahu.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.pozadi1;
            ClientSize = new Size(984, 561);
            Controls.Add(btnKonecTahu);
            Controls.Add(btnHodit);
            Controls.Add(lblCelkoveBody);
            Controls.Add(lblBodyZaKolo);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(lblHrac2);
            Controls.Add(lblHrac1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblHrac1;
        private Label lblHrac2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private Label lblBodyZaKolo;
        private Label lblCelkoveBody;
        private Button btnHodit;
        private Button btnKonecTahu;
    }
}