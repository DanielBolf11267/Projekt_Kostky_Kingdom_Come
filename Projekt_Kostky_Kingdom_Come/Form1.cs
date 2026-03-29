namespace Projekt_Kostky_Kingdom_Come
{
    public partial class Form1 : Form
    {
        string vybranyRezim = "";
        int sazka = 20;
        public Form1()
        {
            InitializeComponent();
        }

        // SOLO
        private void btnSolo_Click(object sender, EventArgs e)
        {
            vybranyRezim = "solo";
            lblRezim.Text = "Režim: SOLO";
        }

        // DUEL
        private void btnDuel_Click(object sender, EventArgs e)
        {
            vybranyRezim = "duel";
            lblRezim.Text = "Režim: DUEL";
        }

        // SÁZKA 20
        private void rb20_CheckedChanged(object sender, EventArgs e)
        {
            if (rb20.Checked)
                sazka = 20;
        }

        // SÁZKA 50
        private void rb50_CheckedChanged(object sender, EventArgs e)
        {
            if (rb50.Checked)
                sazka = 50;
        }

        // SÁZKA 100
        private void rb100_CheckedChanged(object sender, EventArgs e)
        {
            if (rb100.Checked)
                sazka = 100;
        }

        // SPUSTIT HRU
        private void btnStart_Click(object sender, EventArgs e)
        {
            if (vybranyRezim == "")
            {
                MessageBox.Show("Vyber režim hry!");
                return;
            }

            Form2 hra = new Form2();
            hra.Show();

            this.Hide();
        }

        // NÁPOVÌDA
        private void btnNapoveda_Click(object sender, EventArgs e)
        {
            Form3 napoveda = new Form3();
            napoveda.ShowDialog();
        }
    }
}
