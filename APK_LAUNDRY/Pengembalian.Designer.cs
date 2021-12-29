
namespace APK_LAUNDRY
{
    partial class Pengembalian
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btrefresh = new System.Windows.Forms.Button();
            this.btcari = new System.Windows.Forms.Button();
            this.txcari = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btdikembalikan = new System.Windows.Forms.Button();
            this.dgvpengembalian = new System.Windows.Forms.DataGridView();
            this.tglkeluar = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.txidcm = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btback = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpengembalian)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(359, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 20);
            this.label4.TabIndex = 95;
            this.label4.Text = "PENGEMBALIAN CUCIAN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(250, 20);
            this.label3.TabIndex = 94;
            this.label3.Text = "CUCIAN YANG BELUM DIAMBIL";
            // 
            // btrefresh
            // 
            this.btrefresh.Location = new System.Drawing.Point(201, 145);
            this.btrefresh.Name = "btrefresh";
            this.btrefresh.Size = new System.Drawing.Size(91, 42);
            this.btrefresh.TabIndex = 93;
            this.btrefresh.Text = "Refresh";
            this.btrefresh.UseVisualStyleBackColor = true;
            // 
            // btcari
            // 
            this.btcari.Location = new System.Drawing.Point(816, 185);
            this.btcari.Name = "btcari";
            this.btcari.Size = new System.Drawing.Size(78, 34);
            this.btcari.TabIndex = 92;
            this.btcari.Text = "Cari";
            this.btcari.UseVisualStyleBackColor = true;
            // 
            // txcari
            // 
            this.txcari.Location = new System.Drawing.Point(710, 189);
            this.txcari.Name = "txcari";
            this.txcari.Size = new System.Drawing.Size(100, 26);
            this.txcari.TabIndex = 91;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(659, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 90;
            this.label2.Text = "Cari :";
            // 
            // btdikembalikan
            // 
            this.btdikembalikan.Location = new System.Drawing.Point(64, 145);
            this.btdikembalikan.Name = "btdikembalikan";
            this.btdikembalikan.Size = new System.Drawing.Size(122, 42);
            this.btdikembalikan.TabIndex = 89;
            this.btdikembalikan.Text = "Dikembalikan";
            this.btdikembalikan.UseVisualStyleBackColor = true;
            // 
            // dgvpengembalian
            // 
            this.dgvpengembalian.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvpengembalian.Location = new System.Drawing.Point(50, 225);
            this.dgvpengembalian.Name = "dgvpengembalian";
            this.dgvpengembalian.RowHeadersWidth = 62;
            this.dgvpengembalian.RowTemplate.Height = 28;
            this.dgvpengembalian.Size = new System.Drawing.Size(844, 318);
            this.dgvpengembalian.TabIndex = 88;
            // 
            // tglkeluar
            // 
            this.tglkeluar.CustomFormat = "dd-MM-yyyy";
            this.tglkeluar.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tglkeluar.Location = new System.Drawing.Point(694, 70);
            this.tglkeluar.Name = "tglkeluar";
            this.tglkeluar.Size = new System.Drawing.Size(200, 26);
            this.tglkeluar.TabIndex = 87;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(690, 47);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(134, 20);
            this.label13.TabIndex = 86;
            this.label13.Text = "Tgl pengembalian";
            // 
            // txidcm
            // 
            this.txidcm.Location = new System.Drawing.Point(192, 92);
            this.txidcm.Name = "txidcm";
            this.txidcm.Size = new System.Drawing.Size(100, 26);
            this.txidcm.TabIndex = 85;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 84;
            this.label1.Text = "Id cucian masuk";
            // 
            // btback
            // 
            this.btback.Location = new System.Drawing.Point(3, 1);
            this.btback.Name = "btback";
            this.btback.Size = new System.Drawing.Size(91, 42);
            this.btback.TabIndex = 83;
            this.btback.Text = "Back";
            this.btback.UseVisualStyleBackColor = true;
            this.btback.Click += new System.EventHandler(this.btback_Click);
            // 
            // Pengembalian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 555);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btrefresh);
            this.Controls.Add(this.btcari);
            this.Controls.Add(this.txcari);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btdikembalikan);
            this.Controls.Add(this.dgvpengembalian);
            this.Controls.Add(this.tglkeluar);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txidcm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btback);
            this.Name = "Pengembalian";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pengembalian";
            ((System.ComponentModel.ISupportInitialize)(this.dgvpengembalian)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btrefresh;
        private System.Windows.Forms.Button btcari;
        private System.Windows.Forms.TextBox txcari;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btdikembalikan;
        private System.Windows.Forms.DataGridView dgvpengembalian;
        private System.Windows.Forms.DateTimePicker tglkeluar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txidcm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btback;
    }
}