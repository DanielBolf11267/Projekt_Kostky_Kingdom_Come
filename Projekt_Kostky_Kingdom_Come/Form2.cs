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
        Random r = new Random();

        int[] kostky = new int[6];
        bool[] vybrane = new bool[6];

        int bodyKolo = 0;
        int celkoveBody = 0;
        int bodyHrac1 = 0;
        int bodyHrac2 = 0;

        int aktivniHrac = 1;

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
            int pocetKostek = 0;

            for (int i = 0; i < 6; i++)
            {
                if (!vybrane[i])
                    pocetKostek++;
            }

            if (pocetKostek == 0)
            {
                // reset když vybral všechny
                for (int i = 0; i < 6; i++)
                    vybrane[i] = false;

                pocetKostek = 6;
            }

            for (int i = 0; i < 6; i++)
            {
                if (!vybrane[i])
                    kostky[i] = r.Next(1, 7);
            }

            ZobrazKostky();

            if (!JeVyhra())
            {
                MessageBox.Show("❌ Nevyherní hod! Ztrácíš body z kola.");

                bodyKolo = 0;
                lblBodyZaKolo.Text = "Body za kolo: 0";

                KonecTahu();
            }
        }

        // 🧠 kontrola výhry
        bool JeVyhra()
        {
            for (int i = 0; i < 6; i++)
            {
                if (!vybrane[i] && (kostky[i] == 1 || kostky[i] == 5))
                    return true;
            }

            return false;
        }

        // 🖼️ ZOBRAZENÍ
        void ZobrazKostky()
        {
            pictureBox1.BorderStyle = BorderStyle.None;
            pictureBox2.BorderStyle = BorderStyle.None;
            pictureBox3.BorderStyle = BorderStyle.None;
            pictureBox4.BorderStyle = BorderStyle.None;
            pictureBox5.BorderStyle = BorderStyle.None;
            pictureBox6.BorderStyle = BorderStyle.None;

            pictureBox1.Refresh();
            pictureBox2.Refresh();
            pictureBox3.Refresh();
            pictureBox4.Refresh();
            pictureBox5.Refresh();
            pictureBox6.Refresh();
        }

        // 🖱️ kliknutí na kostku
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            VyberKostku(0, pictureBox1);
        }

        void VyberKostku(int index, PictureBox pb)
        {
            if (vybrane[index])
                return;

            if (kostky[index] == 1)
            {
                bodyKolo += 100;
            }
            else if (kostky[index] == 5)
            {
                bodyKolo += 50;
            }
            else
            {
                return;
            }

            vybrane[index] = true;
            pb.BorderStyle = BorderStyle.Fixed3D;

            lblBodyZaKolo.Text = "Body za kolo: " + bodyKolo;
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

            bodyKolo = body;
            lblBodyZaKolo.Text = "Body za kolo: " + bodyKolo;
        }

        // 💰 konec tahu
        private void btnKonecTahu_Click(object sender, EventArgs e)
        {
            if (aktivniHrac == 1)
            {
                bodyHrac1 += bodyKolo;
                lblHrac1.Text = "Hráč 1: " + bodyHrac1;
                aktivniHrac = 2;
            }
            else
            {
                bodyHrac2 += bodyKolo;
                lblHrac2.Text = "Hráč 2: " + bodyHrac2;
                aktivniHrac = 1;
            }

            bodyKolo = 0;
            lblBodyZaKolo.Text = "Body za kolo: 0";

            KonecTahu();
        }

        void KonecTahu()
        {
            for (int i = 0; i < 6; i++)
            {
                vybrane[i] = false;
                kostky[i] = 0;
            }

            ZobrazKostky();
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            PictureBox kliknuty = sender as PictureBox;
            int index = (int)kliknuty.Tag;

            VyberKostku(index, kliknuty);
        }
    }
}
