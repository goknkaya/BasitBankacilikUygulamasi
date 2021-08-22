using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BankaTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-9BQMHRG\SQLEXPRESS;Initial Catalog=DbBankaTest;Integrated Security=True");

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3 fr = new Form3();
            fr.Show();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select AD, SOYAD, TC, TELEFON from TBLKISILER where HESAPNO = @p1 and SIFRE = @p2",con);
            cmd.Parameters.AddWithValue("@p1", maskHesap.Text);
            cmd.Parameters.AddWithValue("@p2", txtParola.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Form2 fr = new Form2();
                fr.adSoyad = dr[0]+" "+dr[1];
                fr.TCKN = dr[2].ToString();
                fr.hesap = maskHesap.Text;
                fr.tel = dr[3].ToString();
                fr.Show();
            }
            else
            {
                MessageBox.Show("Bilgiler hatalı");
            }
            con.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            maskHesap.Focus();
        }
    }
}
