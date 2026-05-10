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
    public partial class Turkce_sozluk : Form
    {
        public Turkce_sozluk()
        {
            InitializeComponent();
        }

        private void deyimlerSözlükToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Deyim_sozluk Deyim_sozluk = new Deyim_sozluk();
            Deyim_sozluk.Show();
            this.Hide();
            timer1.Stop();
        }
    }
}
