namespace Hadi_Hotel
{
    partial class frmAnaForm
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
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.departman_StripStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.kullanici_StripStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cikis_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formlar_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rezervasyon_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.m_giris_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.m_cikis_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.restoran_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yardim_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_bildiri = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dgv_bildiri = new System.Windows.Forms.DataGridView();
            this.m_tc_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_ad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_soyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oda_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.g_trh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.a_trh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hesap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl2 = new System.Windows.Forms.Label();
            this.yonetim_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip.SuspendLayout();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bildiri)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel2,
            this.departman_StripStatus,
            this.toolStripStatusLabel1,
            this.kullanici_StripStatus});
            this.statusStrip.Location = new System.Drawing.Point(0, 655);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1300, 22);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(69, 17);
            this.toolStripStatusLabel2.Text = "Departman:";
            // 
            // departman_StripStatus
            // 
            this.departman_StripStatus.Name = "departman_StripStatus";
            this.departman_StripStatus.Size = new System.Drawing.Size(12, 17);
            this.departman_StripStatus.Text = "-";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(70, 17);
            this.toolStripStatusLabel1.Text = "  |  Kullanıcı:";
            // 
            // kullanici_StripStatus
            // 
            this.kullanici_StripStatus.Name = "kullanici_StripStatus";
            this.kullanici_StripStatus.Size = new System.Drawing.Size(12, 17);
            this.kullanici_StripStatus.Text = "-";
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.yonetim_MenuItem,
            this.formlar_MenuItem,
            this.yardim_MenuItem,
            this.lbl_bildiri,
            this.lbl1});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1300, 24);
            this.menuStrip.TabIndex = 5;
            this.menuStrip.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cikis_MenuItem});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // cikis_MenuItem
            // 
            this.cikis_MenuItem.Name = "cikis_MenuItem";
            this.cikis_MenuItem.Size = new System.Drawing.Size(152, 22);
            this.cikis_MenuItem.Text = "Cıkış";
            this.cikis_MenuItem.Click += new System.EventHandler(this.cikis_MenuItem_Click);
            // 
            // formlar_MenuItem
            // 
            this.formlar_MenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rezervasyon_MenuItem,
            this.toolStripMenuItem1,
            this.m_giris_MenuItem,
            this.m_cikis_MenuItem,
            this.toolStripMenuItem2,
            this.restoran_MenuItem});
            this.formlar_MenuItem.Name = "formlar_MenuItem";
            this.formlar_MenuItem.Size = new System.Drawing.Size(60, 20);
            this.formlar_MenuItem.Text = "Formlar";
            // 
            // rezervasyon_MenuItem
            // 
            this.rezervasyon_MenuItem.Enabled = false;
            this.rezervasyon_MenuItem.Name = "rezervasyon_MenuItem";
            this.rezervasyon_MenuItem.Size = new System.Drawing.Size(152, 22);
            this.rezervasyon_MenuItem.Text = "Rezervasyon";
            this.rezervasyon_MenuItem.Click += new System.EventHandler(this.rezervasyon_MenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 6);
            // 
            // m_giris_MenuItem
            // 
            this.m_giris_MenuItem.Enabled = false;
            this.m_giris_MenuItem.Name = "m_giris_MenuItem";
            this.m_giris_MenuItem.Size = new System.Drawing.Size(152, 22);
            this.m_giris_MenuItem.Text = "Chek-in";
            this.m_giris_MenuItem.Click += new System.EventHandler(this.m_giris_MenuItem_Click);
            // 
            // m_cikis_MenuItem
            // 
            this.m_cikis_MenuItem.Enabled = false;
            this.m_cikis_MenuItem.Name = "m_cikis_MenuItem";
            this.m_cikis_MenuItem.Size = new System.Drawing.Size(152, 22);
            this.m_cikis_MenuItem.Text = "Chek-out";
            this.m_cikis_MenuItem.Click += new System.EventHandler(this.m_cikis_MenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(149, 6);
            // 
            // restoran_MenuItem
            // 
            this.restoran_MenuItem.Enabled = false;
            this.restoran_MenuItem.Name = "restoran_MenuItem";
            this.restoran_MenuItem.Size = new System.Drawing.Size(152, 22);
            this.restoran_MenuItem.Text = "Restoran";
            this.restoran_MenuItem.Click += new System.EventHandler(this.restoran_MenuItem_Click);
            // 
            // yardim_MenuItem
            // 
            this.yardim_MenuItem.Name = "yardim_MenuItem";
            this.yardim_MenuItem.Size = new System.Drawing.Size(57, 20);
            this.yardim_MenuItem.Text = "Yardım";
            // 
            // lbl_bildiri
            // 
            this.lbl_bildiri.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.lbl_bildiri.Enabled = false;
            this.lbl_bildiri.Name = "lbl_bildiri";
            this.lbl_bildiri.Size = new System.Drawing.Size(25, 20);
            this.lbl_bildiri.Text = "0";
            this.lbl_bildiri.Click += new System.EventHandler(this.lbl_bildiri_Click);
            // 
            // lbl1
            // 
            this.lbl1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.lbl1.Enabled = false;
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(65, 20);
            this.lbl1.Text = "Bildiriler:";
            // 
            // dgv_bildiri
            // 
            this.dgv_bildiri.AllowUserToAddRows = false;
            this.dgv_bildiri.AllowUserToDeleteRows = false;
            this.dgv_bildiri.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_bildiri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_bildiri.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.m_tc_no,
            this.m_ad,
            this.m_soyad,
            this.m_tel,
            this.oda_no,
            this.g_trh,
            this.a_trh,
            this.hesap});
            this.dgv_bildiri.Location = new System.Drawing.Point(167, 126);
            this.dgv_bildiri.Name = "dgv_bildiri";
            this.dgv_bildiri.ReadOnly = true;
            this.dgv_bildiri.RowHeadersVisible = false;
            this.dgv_bildiri.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv_bildiri.Size = new System.Drawing.Size(932, 502);
            this.dgv_bildiri.TabIndex = 9;
            this.dgv_bildiri.Visible = false;
            // 
            // m_tc_no
            // 
            this.m_tc_no.DataPropertyName = "m_tc_no";
            this.m_tc_no.HeaderText = "TC";
            this.m_tc_no.MaxInputLength = 11;
            this.m_tc_no.Name = "m_tc_no";
            this.m_tc_no.ReadOnly = true;
            this.m_tc_no.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // m_ad
            // 
            this.m_ad.DataPropertyName = "m_ad";
            this.m_ad.HeaderText = "Ad";
            this.m_ad.Name = "m_ad";
            this.m_ad.ReadOnly = true;
            this.m_ad.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.m_ad.Width = 120;
            // 
            // m_soyad
            // 
            this.m_soyad.DataPropertyName = "m_soyad";
            this.m_soyad.HeaderText = "Soyad";
            this.m_soyad.Name = "m_soyad";
            this.m_soyad.ReadOnly = true;
            this.m_soyad.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.m_soyad.Width = 120;
            // 
            // m_tel
            // 
            this.m_tel.DataPropertyName = "m_tel";
            this.m_tel.HeaderText = "Tel";
            this.m_tel.Name = "m_tel";
            this.m_tel.ReadOnly = true;
            this.m_tel.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.m_tel.Width = 150;
            // 
            // oda_no
            // 
            this.oda_no.DataPropertyName = "oda_no";
            this.oda_no.HeaderText = "Oda";
            this.oda_no.MaxInputLength = 3;
            this.oda_no.Name = "oda_no";
            this.oda_no.ReadOnly = true;
            this.oda_no.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // g_trh
            // 
            this.g_trh.DataPropertyName = "g_trh";
            this.g_trh.HeaderText = "Giriş";
            this.g_trh.Name = "g_trh";
            this.g_trh.ReadOnly = true;
            this.g_trh.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.g_trh.Width = 120;
            // 
            // a_trh
            // 
            this.a_trh.DataPropertyName = "a_trh";
            this.a_trh.HeaderText = "Çıkış";
            this.a_trh.Name = "a_trh";
            this.a_trh.ReadOnly = true;
            this.a_trh.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.a_trh.Width = 120;
            // 
            // hesap
            // 
            this.hesap.DataPropertyName = "hesap";
            this.hesap.HeaderText = "Hesap";
            this.hesap.Name = "hesap";
            this.hesap.ReadOnly = true;
            this.hesap.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbl2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl2.Location = new System.Drawing.Point(396, 90);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(467, 18);
            this.lbl2.TabIndex = 11;
            this.lbl2.Text = "Giriş tarihi geçmiş ancak chek-in yapılmamış rezervasyonlar";
            this.lbl2.Visible = false;
            // 
            // yonetim_MenuItem
            // 
            this.yonetim_MenuItem.Enabled = false;
            this.yonetim_MenuItem.Name = "yonetim_MenuItem";
            this.yonetim_MenuItem.Size = new System.Drawing.Size(64, 20);
            this.yonetim_MenuItem.Text = "Yönetim";
            this.yonetim_MenuItem.Click += new System.EventHandler(this.yonetim_MenuItem_Click);
            // 
            // frmAnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 677);
            this.ControlBox = false;
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.dgv_bildiri);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAnaForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hadi Hashemi";
            this.Load += new System.EventHandler(this.frmAnaForm_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bildiri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        public System.Windows.Forms.ToolStripStatusLabel kullanici_StripStatus;
        public System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel departman_StripStatus;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem cikis_MenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem yardim_MenuItem;
        public System.Windows.Forms.ToolStripMenuItem formlar_MenuItem;
        public System.Windows.Forms.ToolStripMenuItem rezervasyon_MenuItem;
        public System.Windows.Forms.ToolStripMenuItem m_cikis_MenuItem;
        public System.Windows.Forms.ToolStripMenuItem restoran_MenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        public System.Windows.Forms.ToolStripMenuItem m_giris_MenuItem;
        private System.Windows.Forms.DataGridView dgv_bildiri;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.ToolStripMenuItem lbl_bildiri;
        private System.Windows.Forms.ToolStripMenuItem lbl1;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_tc_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_ad;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_soyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn oda_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn g_trh;
        private System.Windows.Forms.DataGridViewTextBoxColumn a_trh;
        private System.Windows.Forms.DataGridViewTextBoxColumn hesap;
        public System.Windows.Forms.ToolStripMenuItem yonetim_MenuItem;
    }
}

