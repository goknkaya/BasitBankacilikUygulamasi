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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public string adSoyad;
        public string TCKN;
        public string hesap;
        public string tel;

        private void Form2_Load(object sender, EventArgs e)
        {
            lblAdSoyad.Text = adSoyad;
            lblTCKN.Text = TCKN;
            lblHesapNo.Text = hesap;
            lblTelefon.Text = tel;
            MevcutBakiye();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-9BQMHRG\SQLEXPRESS;Initial Catalog=DbBankaTest;Integrated Security=True");

        private void btnGonder_Click(object sender, EventArgs e)
        {
            //Gönderilen hesabın para artışı
            con.Open();
            SqlCommand cmd = new SqlCommand("Update TBLHESAP set BAKIYE = BAKIYE + @p1 where HESAPNO = @p2",con);
            cmd.Parameters.AddWithValue("@p1",decimal.Parse(txtTutar.Text));
            cmd.Parameters.AddWithValue("@p2",maskHesap.Text);
            cmd.ExecuteNonQuery();
            con.Close();

            //Gönderen hesabın para azalışı
            con.Open();
            SqlCommand cmd2= new SqlCommand("Update TBLHESAP set BAKIYE = BAKIYE - @k1 where HESAPNO = @k2", con);
            cmd2.Parameters.AddWithValue("@k1", decimal.Parse(txtTutar.Text));
            cmd2.Parameters.AddWithValue("@k2", hesap);
            cmd2.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("İşlem başarılı");

            HareketDokum();
        }

        private void btnHareket_Click(object sender, EventArgs e)
        {
            Form4 fr = new Form4();
            fr.Show();
        }

        void HareketDokum()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert into TBLHAREKET (GONDEREN, ALICI, TUTAR) values (@p1, @p2, @p3)",con);
            cmd.Parameters.AddWithValue("@p1", hesap);
            cmd.Parameters.AddWithValue("@p2", maskHesap.Text);
            cmd.Parameters.AddWithValue("@p3", txtTutar.Text);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        void MevcutBakiye()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select BAKIYE from TBLHESAP where HESAPNO = @p1",con);
            cmd.Parameters.AddWithValue("@p1",hesap);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lblBakiye.Text = dr[0].ToString();
            }
            con.Close();
        }
    }
}
