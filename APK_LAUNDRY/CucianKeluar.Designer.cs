
namespace APK_LAUNDRY
{
    partial class CucianKeluar
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btback = new System.Windows.Forms.Button();
            this.btrefresh = new System.Windows.Forms.Button();
            this.bthpusmua = new System.Windows.Forms.Button();
            this.bthapus = new System.Windows.Forms.Button();
            this.btcari = new System.Windows.Forms.Button();
            this.txcari = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvcuciankeluar = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcuciankeluar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 20);
            this.label1.TabIndex = 81;
            this.label1.Text = "CUCIAN YANG SUDAH DIAMBIL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(362, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 20);
            this.label2.TabIndex = 80;
            this.label2.Text = "CUCIAN KELUAR";
            // 
            // btback
            // 
            this.btback.Location = new System.Drawing.Point(2, 2);
            this.btback.Name = "btback";
            this.btback.Size = new System.Drawing.Size(91, 42);
            this.btback.TabIndex = 79;
            this.btback.Text = "Back";
            this.btback.UseVisualStyleBackColor = true;
            this.btback.Click += new System.EventHandler(this.btback_Click);
            // 
            // btrefresh
            // 
            this.btrefresh.Location = new System.Drawing.Point(615, 97);
            this.btrefresh.Name = "btrefresh";
            this.btrefresh.Size = new System.Drawing.Size(91, 42);
            this.btrefresh.TabIndex = 78;
            this.btrefresh.Text = "Refresh";
            this.btrefresh.UseVisualStyleBackColor = true;
            // 
            // bthpusmua
            // 
            this.bthpusmua.Location = new System.Drawing.Point(615, 145);
            this.bthpusmua.Name = "bthpusmua";
            this.bthpusmua.Size = new System.Drawing.Size(177, 42);
            this.bthpusmua.TabIndex = 77;
            this.bthpusmua.Text = "Hapus semua";
            this.bthpusmua.UseVisualStyleBackColor = true;
            // 
            // bthapus
            // 
            this.bthapus.Location = new System.Drawing.Point(712, 97);
            this.bthapus.Name = "bthapus";
            this.bthapus.Size = new System.Drawing.Size(80, 42);
            this.bthapus.TabIndex = 76;
            this.bthapus.Text = "Hapus";
            this.bthapus.UseVisualStyleBackColor = true;
            // 
            // btcari
            // 
            this.btcari.Location = new System.Drawing.Point(262, 101);
            this.btcari.Name = "btcari";
            this.btcari.Size = new System.Drawing.Size(91, 42);
            this.btcari.TabIndex = 75;
            this.btcari.Text = "Cari";
            this.btcari.UseVisualStyleBackColor = true;
            // 
            // txcari
            // 
            this.txcari.Location = new System.Drawing.Point(156, 109);
            this.txcari.Name = "txcari";
            this.txcari.Size = new System.Drawing.Size(100, 26);
            this.txcari.TabIndex = 74;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 20);
            this.label6.TabIndex = 73;
            this.label6.Text = "Id cucian masuk";
            // 
            // dgvcuciankeluar
            // 
            this.dgvcuciankeluar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcuciankeluar.Location = new System.Drawing.Point(27, 193);
            this.dgvcuciankeluar.Name = "dgvcuciankeluar";
            this.dgvcuciankeluar.RowHeadersWidth = 62;
            this.dgvcuciankeluar.RowTemplate.Height = 28;
            this.dgvcuciankeluar.Size = new System.Drawing.Size(837, 323);
            this.dgvcuciankeluar.TabIndex = 72;
            // 
            // CucianKeluar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 528);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btback);
            this.Controls.Add(this.btrefresh);
            this.Controls.Add(this.bthpusmua);
            this.Controls.Add(this.bthapus);
            this.Controls.Add(this.btcari);
            this.Controls.Add(this.txcari);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvcuciankeluar);
            this.Name = "CucianKeluar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CucianKeluar";
            ((System.ComponentModel.ISupportInitialize)(this.dgvcuciankeluar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btback;
        private System.Windows.Forms.Button btrefresh;
        private System.Windows.Forms.Button bthpusmua;
        private System.Windows.Forms.Button bthapus;
        private System.Windows.Forms.Button btcari;
        private System.Windows.Forms.TextBox txcari;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvcuciankeluar;
    }
}