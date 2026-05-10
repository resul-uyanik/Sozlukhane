using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sözlükhane
{
    public partial class icon : Form
    {
        public icon()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Turkce_sozluk anasayfa = new Turkce_sozluk();
            anasayfa.Show();
            this.Hide();
            timer1.Stop();
        }

        int sayac = 0;
        private void timer2_Tick(object sender, EventArgs e)
        {
            sayac++;
            if (sayac == 1) this.BackColor = Color.Yellow;
            if (sayac == 1) pictureBox2.BackColor = Color.Yellow;
            if (sayac == 1) pictureBox3.BackColor = Color.Yellow;
            if (sayac == 2) this.BackColor = Color.Blue;
            if (sayac == 2) pictureBox2.BackColor = Color.Blue;
            if (sayac == 2) pictureBox3.BackColor = Color.Blue;
            if (sayac == 3) this.BackColor = Color.YellowGreen;
            if (sayac == 3) pictureBox2.BackColor = Color.YellowGreen;
            if (sayac == 3) pictureBox3.BackColor = Color.YellowGreen;
            if (sayac == 4) this.BackColor = Color.Violet;
            if (sayac == 4) pictureBox2.BackColor = Color.Violet;
            if (sayac == 4) pictureBox3.BackColor = Color.Violet;
            if (sayac == 4) sayac = 0;
        }
    }
}
