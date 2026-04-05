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
        bool prvniHod = true;

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
                kostky[i] = 0; // žádné kostky před prvním hodem
            }

            ZobrazKostky();
        }
        // 🎲 HOD
        
        private void btnHodit_Click(object sender, EventArgs e)
        {
            // první hod hráče v kole nemusí mít vybranou žádnou kostku
            if (!prvniHod) // pokud je to první hod, nepřekážej
                prvniHod = true; // označíme, že první hod už proběhl

            int pocetKostek = 0;

            for (int i = 0; i < 6; i++)
                if (!vybrane[i])
                    pocetKostek++;

            if (pocetKostek == 0)
            {
                // reset když hráč vybral všechny kostky
                for (int i = 0; i < 6; i++)
                    vybrane[i] = false;

                pocetKostek = 6;
            }

            // hod kostkami, které ještě nebyly vybrány
            for (int i = 0; i < 6; i++)
            {
                if (!vybrane[i])
                    kostky[i] = r.Next(1, 7);
            }

            ZobrazKostky();

            // vybereme pouze kostky z aktuálního hodu
            int[] aktualniHod = kostky
                .Select((k, i) => new { Hod = k, Vybrano = vybrane[i] })
                .Where(x => !x.Vybrano)
                .Select(x => x.Hod)
                .ToArray();

            // body z aktuálního hodu
            int bodyHodu = SpocitejBodyHodu(aktualniHod);

            // přičti body aktuálního hodu do kola
            bodyKolo += bodyHodu;
            lblBodyZaKolo.Text = "Body za kolo: " + bodyKolo;

            // kontrola, zda padla výherní kostka nebo kombinace
            if (!JeVyhra() && bodyHodu == 0)
            {
                MessageBox.Show("❌ Nevyherní hod! Ztrácíš body z kola, je na řadě druhý hráč.");
                KonecTahu(); // předání tahu druhému hráči
                prvniHod = false; // reset pro další kolo
            }
        }

        // 🧠 kontrola výhry

        bool JeVyhra()
        {
            // výherní hod = alespoň 1, 5 nebo 3+ stejná čísla
            int[] pocet = new int[7];
            for (int i = 0; i < 6; i++)
                pocet[kostky[i]]++;

            if (pocet[1] > 0 || pocet[5] > 0)
                return true;

            if (pocet.Any(x => x >= 3))
                return true;

            // postupky
            int[] hodiny = kostky.OrderBy(x => x).ToArray();
            if (hodiny.Distinct().Count() >= 5)
                return true;

            return false;
        }

        // 🖼️ ZOBRAZENÍ        

        void ZobrazKostky()
        {
            for (int i = 0; i < 6; i++)
            {
                pb[i].BorderStyle = vybrane[i] ? BorderStyle.Fixed3D : BorderStyle.None;

                if (kostky[i] > 0)
                {
                    // složka "kostky" musí být ve stejné složce jako exe
                    string cesta = System.IO.Path.Combine(Application.StartupPath, "kostky", "kostka" + kostky[i] + ".png");
                    if (System.IO.File.Exists(cesta))
                    {
                        pb[i].Image = Image.FromFile(cesta);
                    }
                    else
                    {
                        pb[i].Image = null; // pokud obrázek neexistuje
                        MessageBox.Show("Chybí obrázek: " + cesta);
                    }
                }
                else
                {
                    pb[i].Image = null;
                }

                pb[i].Refresh();
            }
        }
        
        void VyberKostku(int index, PictureBox pb)
        {
            // pokud je již vybraná, odklikneme ji
            if (vybrane[index])
            {
                vybrane[index] = false;
                pb.BorderStyle = BorderStyle.None;

                SpocitejBody(); // přepočítat body
                return;
            }

            vybrane[index] = true;
            pb.BorderStyle = BorderStyle.Fixed3D;

            SpocitejBody(); // přepočítat body
        }
        // 🧮 body
        
        private void SpocitejBody()
        {
            int body = 0;
            int[] pocet = new int[7];

            for (int i = 0; i < 6; i++)
            {
                if (vybrane[i])
                    pocet[kostky[i]]++;
            }

            // kombinace 3 a více stejných
            for (int i = 1; i <= 6; i++)
            {
                if (pocet[i] >= 3)
                {
                    int zaklad = (i == 1) ? 1000 : i * 100;

                    if (pocet[i] == 3) body += zaklad;
                    else if (pocet[i] == 4) body += zaklad * 2;
                    else if (pocet[i] == 5) body += zaklad * 4;
                    else if (pocet[i] == 6) body += zaklad * 8;

                    // odpočítáme jednotlivé body 1 a 5, které jsou součástí kombinace
                    if (i == 1) pocet[1] -= Math.Min(pocet[1], 3);
                    else if (i == 5) pocet[5] -= Math.Min(pocet[5], 3);
                }
            }

            // jednotky a pětky (zbylé)
            body += pocet[1] * 100;
            body += pocet[5] * 50;

            // postupky
            int[] hodiny = kostky.Where((k, idx) => vybrane[idx]).OrderBy(x => x).ToArray();
            if (hodiny.Length >= 5)
            {
                if (hodiny.SequenceEqual(new int[] { 1, 2, 3, 4, 5 }))
                    body += 500;
                else if (hodiny.SequenceEqual(new int[] { 2, 3, 4, 5, 6 }))
                    body += 750;
                else if (hodiny.SequenceEqual(new int[] { 1, 2, 3, 4, 5, 6 }))
                    body += 1500;
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
        
        int SpocitejBodyHodu(int[] hod)
        {
            int body = 0;
            int[] pocet = new int[7];

            // spočítat počet jednotlivých čísel v aktuálním hodu
            for (int i = 0; i < hod.Length; i++)
                pocet[hod[i]]++;

            // kombinace 3 a více stejných čísel
            for (int i = 1; i <= 6; i++)
            {
                if (pocet[i] >= 3)
                {
                    int zaklad = (i == 1) ? 1000 : i * 100;

                    if (pocet[i] == 3) body += zaklad;
                    else if (pocet[i] == 4) body += zaklad * 2;
                    else if (pocet[i] == 5) body += zaklad * 4;
                    else if (pocet[i] == 6) body += zaklad * 8;

                    // odečti jednotky a pětky pouze pro body, ale ne pro postupky
                    if (i == 1) pocet[1] -= Math.Min(pocet[1], 3);
                    else if (i == 5) pocet[5] -= Math.Min(pocet[5], 3);
                }
            }

            // body za zbylé 1 a 5
            body += pocet[1] * 100;
            body += pocet[5] * 50;

            // postupky (z celého aktuálního hodu, bez odečtu)
            int[] hodiny = hod.OrderBy(x => x).ToArray();
            if (hodiny.Length >= 5)
            {
                if (hodiny.SequenceEqual(new int[] { 1, 2, 3, 4, 5 }))
                    body += 500;
                else if (hodiny.SequenceEqual(new int[] { 2, 3, 4, 5, 6 }))
                    body += 750;
                else if (hodiny.SequenceEqual(new int[] { 1, 2, 3, 4, 5, 6 }))
                    body += 1500;
            }

            return body;
        }
    }
}
