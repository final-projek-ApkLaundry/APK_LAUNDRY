﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APK_LAUNDRY
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Pelanggan pel = new Pelanggan();
            this.Hide();
            pel.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            CucianMasuk cm = new CucianMasuk();
            this.Hide();
            cm.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Pengembalian pm = new Pengembalian();
            this.Hide();
            pm.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Pencuci pc = new Pencuci();
            this.Hide();
            pc.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Harga hg = new Harga();
            this.Hide();
            hg.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            CucianKeluar ck = new CucianKeluar();
            this.Hide();
            ck.Show();
        }
    }
}
