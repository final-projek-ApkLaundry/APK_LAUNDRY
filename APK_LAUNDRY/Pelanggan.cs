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

namespace APK_LAUNDRY
{
    public partial class Pelanggan : Form
    {
        public Pelanggan()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-CJNVJPUI;Initial Catalog=Laundry.v2;Integrated Security=True");

        private void showdata()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Konsumen", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvkonsumen.DataSource = dt;
            con.Close();
        }
        private void btback_Click(object sender, EventArgs e)
        {
            Form1 fom = new Form1();
            this.Hide();
            fom.Show();
        }

        private void Pelanggan_Load(object sender, EventArgs e)
        {
            showdata();
        }

        private void bttambah_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Konsumen values (@Id_pelanggan,@Nama,@Alamat,@No_hp)", con);
            cmd.Parameters.AddWithValue("@Id_pelanggan", txid.Text);
            cmd.Parameters.AddWithValue("@Nama", txnama.Text);
            cmd.Parameters.AddWithValue("@Alamat", txalamat.Text);
            cmd.Parameters.AddWithValue("@No_hp", txnohp.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("pelanggan berhasil ditambah");
            showdata();
        }
    }
}
