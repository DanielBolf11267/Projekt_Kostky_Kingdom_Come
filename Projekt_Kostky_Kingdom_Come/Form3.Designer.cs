namespace Projekt_Kostky_Kingdom_Come
{
    partial class Form3
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            btnZpet = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            textBox1.Location = new Point(300, 40);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(400, 50);
            textBox1.TabIndex = 0;
            textBox1.Text = "VÝHERNÍ KOMBINACE";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 12F);
            textBox2.Location = new Point(200, 120);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(300, 250);
            textBox2.TabIndex = 1;
            textBox2.Text = "Výherní kostky\r\n1 = 100 bodů\r\n5 = 50 bodů\r\n\r\n3x stejně:\r\n1 = 1000\r\n2 = 200\r\n3 = 300\r\n4 = 400\r\n5 = 500\r\n6 = 600\r\n";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 12F);
            textBox3.Location = new Point(500, 120);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(300, 250);
            textBox3.TabIndex = 2;
            textBox3.Text = "Příklad pro srozumitelnost:\r\n3×2 = 200\r\n4×2 = 200 × 2 = 400\r\n5×2 = 400 × 2 = 800\r\n6×2 = 800 × 2 = 1600\r\n\r\nPostupky\r\n1,2,3,4,5 = 500\r\n2,3,4,5,6 = 750\r\n1,2,3,4,5,6 = 1500";
            // 
            // btnZpet
            // 
            btnZpet.Font = new Font("Segoe UI", 18F);
            btnZpet.Location = new Point(400, 400);
            btnZpet.Name = "btnZpet";
            btnZpet.Size = new Size(200, 50);
            btnZpet.TabIndex = 3;
            btnZpet.Text = "ZPĚT";
            btnZpet.UseVisualStyleBackColor = true;
            btnZpet.Click += btnZpet_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 561);
            Controls.Add(btnZpet);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button btnZpet;
    }
}