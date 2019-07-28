namespace Hadi_Hotel
{
    partial class frmSiparis
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_hesap = new System.Windows.Forms.Button();
            this.lbl_m_soyad = new System.Windows.Forms.Label();
            this.lbl_m_ad = new System.Windows.Forms.Label();
            this.cmb_oda = new System.Windows.Forms.ComboBox();
            this.btn_siparis = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dt_saat = new System.Windows.Forms.DateTimePicker();
            this.dt_trh = new System.Windows.Forms.DateTimePicker();
            this.lbl_toplam_tutar = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_siparis = new System.Windows.Forms.DataGridView();
            this.sayi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urun = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tutar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_yemek = new System.Windows.Forms.TextBox();
            this.cmb_grp = new System.Windows.Forms.ComboBox();
            this.dgv_ymk = new System.Windows.Forms.DataGridView();
            this.y_ad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.y_fiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_siparis)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ymk)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_hesap);
            this.groupBox2.Controls.Add(this.lbl_m_soyad);
            this.groupBox2.Controls.Add(this.lbl_m_ad);
            this.groupBox2.Controls.Add(this.cmb_oda);
            this.groupBox2.Controls.Add(this.btn_siparis);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.dt_saat);
            this.groupBox2.Controls.Add(this.dt_trh);
            this.groupBox2.Controls.Add(this.lbl_toplam_tutar);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dgv_siparis);
            this.groupBox2.Location = new System.Drawing.Point(300, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(354, 367);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // btn_hesap
            // 
            this.btn_hesap.Location = new System.Drawing.Point(142, 311);
            this.btn_hesap.Name = "btn_hesap";
            this.btn_hesap.Size = new System.Drawing.Size(100, 50);
            this.btn_hesap.TabIndex = 14;
            this.btn_hesap.Text = "Hesap";
            this.btn_hesap.UseVisualStyleBackColor = true;
            this.btn_hesap.Click += new System.EventHandler(this.btn_hesap_Click);
            // 
            // lbl_m_soyad
            // 
            this.lbl_m_soyad.AutoSize = true;
            this.lbl_m_soyad.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_m_soyad.Location = new System.Drawing.Point(226, 30);
            this.lbl_m_soyad.Name = "lbl_m_soyad";
            this.lbl_m_soyad.Size = new System.Drawing.Size(14, 16);
            this.lbl_m_soyad.TabIndex = 13;
            this.lbl_m_soyad.Text = "-";
            // 
            // lbl_m_ad
            // 
            this.lbl_m_ad.AutoSize = true;
            this.lbl_m_ad.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_m_ad.Location = new System.Drawing.Point(99, 30);
            this.lbl_m_ad.Name = "lbl_m_ad";
            this.lbl_m_ad.Size = new System.Drawing.Size(14, 16);
            this.lbl_m_ad.TabIndex = 12;
            this.lbl_m_ad.Text = "-";
            // 
            // cmb_oda
            // 
            this.cmb_oda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_oda.FormattingEnabled = true;
            this.cmb_oda.Location = new System.Drawing.Point(6, 25);
            this.cmb_oda.Name = "cmb_oda";
            this.cmb_oda.Size = new System.Drawing.Size(70, 26);
            this.cmb_oda.TabIndex = 11;
            this.cmb_oda.SelectedIndexChanged += new System.EventHandler(this.cmb_oda_SelectedIndexChanged);
            // 
            // btn_siparis
            // 
            this.btn_siparis.Location = new System.Drawing.Point(248, 311);
            this.btn_siparis.Name = "btn_siparis";
            this.btn_siparis.Size = new System.Drawing.Size(100, 50);
            this.btn_siparis.TabIndex = 9;
            this.btn_siparis.Text = "Sipariş";
            this.btn_siparis.UseVisualStyleBackColor = true;
            this.btn_siparis.Click += new System.EventHandler(this.btn_siparis_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(10, 345);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 14);
            this.label5.TabIndex = 8;
            this.label5.Text = "Saat:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(6, 317);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 14);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tarih:";
            // 
            // dt_saat
            // 
            this.dt_saat.Enabled = false;
            this.dt_saat.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dt_saat.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dt_saat.Location = new System.Drawing.Point(50, 339);
            this.dt_saat.Name = "dt_saat";
            this.dt_saat.Size = new System.Drawing.Size(85, 22);
            this.dt_saat.TabIndex = 6;
            // 
            // dt_trh
            // 
            this.dt_trh.Enabled = false;
            this.dt_trh.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dt_trh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_trh.Location = new System.Drawing.Point(50, 311);
            this.dt_trh.Name = "dt_trh";
            this.dt_trh.Size = new System.Drawing.Size(85, 22);
            this.dt_trh.TabIndex = 5;
            // 
            // lbl_toplam_tutar
            // 
            this.lbl_toplam_tutar.AutoSize = true;
            this.lbl_toplam_tutar.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_toplam_tutar.Location = new System.Drawing.Point(245, 274);
            this.lbl_toplam_tutar.Name = "lbl_toplam_tutar";
            this.lbl_toplam_tutar.Size = new System.Drawing.Size(43, 18);
            this.lbl_toplam_tutar.TabIndex = 4;
            this.lbl_toplam_tutar.Text = "0,00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(322, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "TL";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 274);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Toplam Tutar:";
            // 
            // dgv_siparis
            // 
            this.dgv_siparis.AllowUserToAddRows = false;
            this.dgv_siparis.AllowUserToDeleteRows = false;
            this.dgv_siparis.AllowUserToResizeColumns = false;
            this.dgv_siparis.AllowUserToResizeRows = false;
            this.dgv_siparis.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_siparis.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_siparis.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_siparis.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_siparis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_siparis.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sayi,
            this.urun,
            this.tutar});
            this.dgv_siparis.Location = new System.Drawing.Point(6, 57);
            this.dgv_siparis.Name = "dgv_siparis";
            this.dgv_siparis.ReadOnly = true;
            this.dgv_siparis.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_siparis.RowHeadersVisible = false;
            this.dgv_siparis.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv_siparis.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_siparis.Size = new System.Drawing.Size(342, 204);
            this.dgv_siparis.TabIndex = 1;
            // 
            // sayi
            // 
            this.sayi.DataPropertyName = "sayi";
            this.sayi.HeaderText = "Miktar";
            this.sayi.Name = "sayi";
            this.sayi.ReadOnly = true;
            this.sayi.Width = 70;
            // 
            // urun
            // 
            this.urun.DataPropertyName = "y_ad";
            this.urun.HeaderText = "Ürün";
            this.urun.Name = "urun";
            this.urun.ReadOnly = true;
            this.urun.Width = 200;
            // 
            // tutar
            // 
            this.tutar.DataPropertyName = "tutar";
            this.tutar.HeaderText = "Tutar";
            this.tutar.Name = "tutar";
            this.tutar.ReadOnly = true;
            this.tutar.Width = 70;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_yemek);
            this.groupBox1.Controls.Add(this.cmb_grp);
            this.groupBox1.Controls.Add(this.dgv_ymk);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 367);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // txt_yemek
            // 
            this.txt_yemek.Location = new System.Drawing.Point(146, 25);
            this.txt_yemek.Name = "txt_yemek";
            this.txt_yemek.Size = new System.Drawing.Size(130, 26);
            this.txt_yemek.TabIndex = 2;
            this.txt_yemek.TextChanged += new System.EventHandler(this.txt_yemek_TextChanged);
            // 
            // cmb_grp
            // 
            this.cmb_grp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_grp.FormattingEnabled = true;
            this.cmb_grp.Items.AddRange(new object[] {
            ""});
            this.cmb_grp.Location = new System.Drawing.Point(6, 25);
            this.cmb_grp.Name = "cmb_grp";
            this.cmb_grp.Size = new System.Drawing.Size(130, 26);
            this.cmb_grp.TabIndex = 3;
            this.cmb_grp.SelectedIndexChanged += new System.EventHandler(this.cmb_grp_SelectedIndexChanged);
            // 
            // dgv_ymk
            // 
            this.dgv_ymk.AllowUserToAddRows = false;
            this.dgv_ymk.AllowUserToDeleteRows = false;
            this.dgv_ymk.AllowUserToResizeColumns = false;
            this.dgv_ymk.AllowUserToResizeRows = false;
            this.dgv_ymk.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_ymk.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_ymk.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_ymk.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_ymk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ymk.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.y_ad,
            this.y_fiyat});
            this.dgv_ymk.Location = new System.Drawing.Point(6, 57);
            this.dgv_ymk.Name = "dgv_ymk";
            this.dgv_ymk.ReadOnly = true;
            this.dgv_ymk.RowHeadersVisible = false;
            this.dgv_ymk.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv_ymk.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ymk.Size = new System.Drawing.Size(271, 304);
            this.dgv_ymk.TabIndex = 1;
            this.dgv_ymk.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ymk_CellDoubleClick);
            // 
            // y_ad
            // 
            this.y_ad.DataPropertyName = "y_ad";
            this.y_ad.HeaderText = "Alt Ürün";
            this.y_ad.Name = "y_ad";
            this.y_ad.ReadOnly = true;
            this.y_ad.Width = 200;
            // 
            // y_fiyat
            // 
            this.y_fiyat.DataPropertyName = "y_fiyat";
            this.y_fiyat.HeaderText = "Fiyat";
            this.y_fiyat.Name = "y_fiyat";
            this.y_fiyat.ReadOnly = true;
            this.y_fiyat.Width = 70;
            // 
            // frmSiparis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 393);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimizeBox = false;
            this.Name = "frmSiparis";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sipariş";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmSiparis_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_siparis)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ymk)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl_m_soyad;
        private System.Windows.Forms.Label lbl_m_ad;
        private System.Windows.Forms.ComboBox cmb_oda;
        private System.Windows.Forms.Button btn_siparis;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dt_saat;
        private System.Windows.Forms.DateTimePicker dt_trh;
        private System.Windows.Forms.Label lbl_toplam_tutar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_siparis;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_yemek;
        private System.Windows.Forms.ComboBox cmb_grp;
        private System.Windows.Forms.DataGridView dgv_ymk;
        private System.Windows.Forms.DataGridViewTextBoxColumn y_ad;
        private System.Windows.Forms.DataGridViewTextBoxColumn y_fiyat;
        private System.Windows.Forms.Button btn_hesap;
        private System.Windows.Forms.DataGridViewTextBoxColumn sayi;
        private System.Windows.Forms.DataGridViewTextBoxColumn urun;
        private System.Windows.Forms.DataGridViewTextBoxColumn tutar;
    }
}