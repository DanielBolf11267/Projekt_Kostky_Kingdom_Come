using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_Kostky_Kingdom_Come
{
    public partial class Form2 : Form
    {
        Random random = new Random();

        int[] kostky = new int[6];
        bool[] vybrane = new bool[6];

        int bodyZaKolo = 0;
        int celkoveBody = 0;

        PictureBox[] pb;
        public Form2()
        {
            InitializeComponent();

            pb = new PictureBox[]
            {
                pictureBox1, pictureBox2, pictureBox3,
                pictureBox4, pictureBox5, pictureBox6
            };

            for (int i = 0; i < 6; i++)
            {
                pb[i].Tag = i;
                pb[i].Click += pictureBox_Click;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 6; i++)
            {
                kostky[i] = 1;
            }

            ZobrazKostky();
        }
        // 🎲 HOD
        private void btnHodit_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 6; i++)
            {
                if (!vybrane[i])
                {
                    kostky[i] = random.Next(1, 7);
                }
            }

            ZobrazKostky();

            if (!ExistujeVyhra())
            {
                MessageBox.Show("Nevyhrál jsi žádnou kombinaci!");

                bodyZaKolo = 0;
                lblBodyZaKolo.Text = "Body za kolo: 0";

                for (int i = 0; i < 6; i++)
                {
                    vybrane[i] = false;
                }

                ZobrazKostky();
            }
        }

        // 🧠 kontrola výhry
        private bool ExistujeVyhra()
        {
            int[] pocet = new int[7];

            for (int i = 0; i < 6; i++)
            {
                if (!vybrane[i])
                    pocet[kostky[i]]++;
            }

            if (pocet[1] > 0 || pocet[5] > 0)
                return true;

            for (int i = 1; i <= 6; i++)
            {
                if (pocet[i] >= 3)
                    return true;
            }

            return false;
        }

        // 🖼️ ZOBRAZENÍ
        private void ZobrazKostky()
        {
            for (int i = 0; i < 6; i++)
            {
                pb[i].Image = Image.FromFile($"kostky/kostka_{kostky[i]}.png");

                if (vybrane[i])
                    pb[i].BackColor = Color.LightGreen;
                else
                    pb[i].BackColor = Color.Transparent;
            }
        }

        // 🖱️ kliknutí na kostku
        private void pictureBox_Click(object sender, EventArgs e)
        {
            PictureBox box = sender as PictureBox;
            int index = (int)box.Tag;

            vybrane[index] = !vybrane[index];

            ZobrazKostky();
            SpocitejBody();
        }

        // 🧮 body
        private void SpocitejBody()
        {
            int body = 0;
            int[] pocet = new int[7];

            for (int i = 0; i < 6; i++)
            {
                if (vybrane[i])
                {
                    pocet[kostky[i]]++;
                }
            }

            body += pocet[1] * 100;
            body += pocet[5] * 50;

            for (int i = 1; i <= 6; i++)
            {
                if (pocet[i] >= 3)
                {
                    if (i == 1)
                        body += 1000;
                    else
                        body += i * 100;
                }
            }

            bodyZaKolo = body;
            lblBodyZaKolo.Text = "Body za kolo: " + bodyZaKolo;
        }

        // 💰 konec tahu
        private void btnKonecTahu_Click(object sender, EventArgs e)
        {
            celkoveBody += bodyZaKolo;
            lblCelkoveBody.Text = "Celkem: " + celkoveBody;

            bodyZaKolo = 0;

            for (int i = 0; i < 6; i++)
            {
                vybrane[i] = false;
            }

            lblBodyZaKolo.Text = "Body za kolo: 0";

            ZobrazKostky();
        }
    }
}
