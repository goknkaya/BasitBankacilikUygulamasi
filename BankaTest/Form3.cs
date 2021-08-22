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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-9BQMHRG\SQLEXPRESS;Initial Catalog=DbBankaTest;Integrated Security=True");

        private void btnKaydol_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Insert into TBLKISILER (AD,SOYAD,TC,TELEFON,HESAPNO,SIFRE) values (@p1,@p2,@p3,@p4,@p5,@p6)", con);
                cmd.Parameters.AddWithValue("@p1", txtAD.Text);
                cmd.Parameters.AddWithValue("@p2", txtSOYAD.Text);
                cmd.Parameters.AddWithValue("@p3", maskTCKN.Text);
                cmd.Parameters.AddWithValue("@p4", maskTEL.Text);
                cmd.Parameters.AddWithValue("@p5", maskHESAP.Text);
                cmd.Parameters.AddWithValue("@p6", txtPAROLA.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Kayıt başarılı");
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen tüm bilgilerin doldurulduğundan emin olunuz");
            }
            
        }

        private void btnHesap_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int sayi = rnd.Next(100000,1000000);
            maskHESAP.Text = sayi.ToString();
            
            con.Open();
            SqlCommand cmd = new SqlCommand("Select HESAPNO from TBLKISILER",con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (maskHESAP.Text == dr[0].ToString())
                {
                    MessageBox.Show("Tanımlanan hesap numarası sistemde bulunmaktadır, lütfen yeniden numara oluşturunuz.");
                }
            }
            
            con.Close();
        }
    }
}
