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
    public partial class Deyim_sozluk : Form
    {
        public Deyim_sozluk()
        {
            InitializeComponent();
        }

        private void türkçeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            anasayfa anasayfa = new anasayfa();
            anasayfa.Show();
            this.Hide();
            timer1.Stop();
        }
    }
}
