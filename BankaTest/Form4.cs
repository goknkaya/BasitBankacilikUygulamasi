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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-9BQMHRG\SQLEXPRESS;Initial Catalog=DbBankaTest;Integrated Security=True");

        private void Form4_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select TBL1.AD + ' ' + TBL1.SOYAD as 'GONDEREN', TBL2.AD + ' ' + TBL2.SOYAD as 'ALICI', TUTAR From TBLHAREKET inner join TBLKISILER as TBL1 on TBLHAREKET.GONDEREN = TBL1.HESAPNO inner join TBLKISILER as TBL2 on TBLHAREKET.ALICI = TBL2.HESAPNO", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;


        }
    }
}
