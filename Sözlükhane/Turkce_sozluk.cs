using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Sözlükhane
{
    public partial class Turkce_sozluk : Form
    {
        private string connectionString;
        public Turkce_sozluk()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["SozlukhaneConnectionString"].ConnectionString;
        }

        private void deyimlerSözlükToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Deyim_sozluk Deyim_sozluk = new Deyim_sozluk();
            Deyim_sozluk.Show();
            this.Hide();
            timer1.Stop();
        }

        private void Turkce_sozluk_Load(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_select_Table_turkce_sozluk", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        DataTable dt = new DataTable();
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        connection.Open();
                        da.Fill(dt);
                        dataGridView1.DataSource = dt;
                        label4.Text = dataGridView1.Rows.Count.ToString() + " adet kayıt bulundu";
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Hata = " + ex.Message);
            }
        }

        private void btn_select_Click(object sender, EventArgs e)
        {
            
        }

        private void txt_kelime_TextChanged(object sender, EventArgs e)
        {
  
            string ara = txt_kelime.Text;

            SqlConnection baglanti = new SqlConnection("Server=localhost; Database=SozlukDb; Integrated Security=True;");

            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("SELECT * FROM turkce_sozluk WHERE kelime LIKE @kelime", baglanti);
                komut.Parameters.AddWithValue("@kelime", ara + "%");
                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                label4.Text = dataGridView1.Rows.Count.ToString() + " adet kayıt bulundu";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
        }
    }
}
