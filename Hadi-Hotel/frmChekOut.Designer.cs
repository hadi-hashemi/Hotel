namespace Hadi_Hotel
{
    partial class frmChekOut
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
            this.grp_dgv = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_nocekin = new System.Windows.Forms.DataGridView();
            this.n_m_tc_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.n_m_ad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.n_m_soyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.n_m_tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.n_oda_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.n_g_trh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.n_a_trh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.n_hesap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_cekin = new System.Windows.Forms.DataGridView();
            this.m_tc_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_ad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_soyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oda_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.g_trh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.a_trh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hesap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grp_dgv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nocekin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cekin)).BeginInit();
            this.SuspendLayout();
            // 
            // grp_dgv
            // 
            this.grp_dgv.Controls.Add(this.label2);
            this.grp_dgv.Controls.Add(this.label1);
            this.grp_dgv.Controls.Add(this.dgv_nocekin);
            this.grp_dgv.Controls.Add(this.dgv_cekin);
            this.grp_dgv.Location = new System.Drawing.Point(12, 12);
            this.grp_dgv.Name = "grp_dgv";
            this.grp_dgv.Size = new System.Drawing.Size(1225, 552);
            this.grp_dgv.TabIndex = 1;
            this.grp_dgv.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(6, 312);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(277, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Chek-in yapılmamış rezervasyonlar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Chek-in yapılmış rezervasyonlar";
            // 
            // dgv_nocekin
            // 
            this.dgv_nocekin.AllowUserToAddRows = false;
            this.dgv_nocekin.AllowUserToDeleteRows = false;
            this.dgv_nocekin.AllowUserToResizeColumns = false;
            this.dgv_nocekin.AllowUserToResizeRows = false;
            this.dgv_nocekin.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_nocekin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_nocekin.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_nocekin.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_nocekin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_nocekin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.n_m_tc_no,
            this.n_m_ad,
            this.n_m_soyad,
            this.n_m_tel,
            this.n_oda_no,
            this.n_g_trh,
            this.n_a_trh,
            this.n_hesap});
            this.dgv_nocekin.Location = new System.Drawing.Point(6, 346);
            this.dgv_nocekin.Name = "dgv_nocekin";
            this.dgv_nocekin.ReadOnly = true;
            this.dgv_nocekin.RowHeadersVisible = false;
            this.dgv_nocekin.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv_nocekin.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_nocekin.Size = new System.Drawing.Size(1213, 200);
            this.dgv_nocekin.TabIndex = 3;
            this.dgv_nocekin.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_nocekin_CellDoubleClick);
            // 
            // n_m_tc_no
            // 
            this.n_m_tc_no.DataPropertyName = "m_tc_no";
            this.n_m_tc_no.HeaderText = "TC";
            this.n_m_tc_no.MaxInputLength = 11;
            this.n_m_tc_no.Name = "n_m_tc_no";
            this.n_m_tc_no.ReadOnly = true;
            this.n_m_tc_no.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.n_m_tc_no.Width = 150;
            // 
            // n_m_ad
            // 
            this.n_m_ad.DataPropertyName = "m_ad";
            this.n_m_ad.HeaderText = "Ad";
            this.n_m_ad.Name = "n_m_ad";
            this.n_m_ad.ReadOnly = true;
            this.n_m_ad.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.n_m_ad.Width = 170;
            // 
            // n_m_soyad
            // 
            this.n_m_soyad.DataPropertyName = "m_soyad";
            this.n_m_soyad.HeaderText = "Soyad";
            this.n_m_soyad.Name = "n_m_soyad";
            this.n_m_soyad.ReadOnly = true;
            this.n_m_soyad.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.n_m_soyad.Width = 170;
            // 
            // n_m_tel
            // 
            this.n_m_tel.DataPropertyName = "m_tel";
            this.n_m_tel.HeaderText = "Tel";
            this.n_m_tel.Name = "n_m_tel";
            this.n_m_tel.ReadOnly = true;
            this.n_m_tel.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.n_m_tel.Width = 175;
            // 
            // n_oda_no
            // 
            this.n_oda_no.DataPropertyName = "oda_no";
            this.n_oda_no.HeaderText = "Oda";
            this.n_oda_no.Name = "n_oda_no";
            this.n_oda_no.ReadOnly = true;
            this.n_oda_no.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // n_g_trh
            // 
            this.n_g_trh.DataPropertyName = "g_trh";
            this.n_g_trh.HeaderText = "Giriş";
            this.n_g_trh.Name = "n_g_trh";
            this.n_g_trh.ReadOnly = true;
            this.n_g_trh.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.n_g_trh.Width = 150;
            // 
            // n_a_trh
            // 
            this.n_a_trh.DataPropertyName = "a_trh";
            this.n_a_trh.HeaderText = "Çıkış";
            this.n_a_trh.Name = "n_a_trh";
            this.n_a_trh.ReadOnly = true;
            this.n_a_trh.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.n_a_trh.Width = 150;
            // 
            // n_hesap
            // 
            this.n_hesap.DataPropertyName = "hesap";
            this.n_hesap.HeaderText = "Hesap";
            this.n_hesap.Name = "n_hesap";
            this.n_hesap.ReadOnly = true;
            this.n_hesap.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.n_hesap.Width = 150;
            // 
            // dgv_cekin
            // 
            this.dgv_cekin.AllowUserToAddRows = false;
            this.dgv_cekin.AllowUserToDeleteRows = false;
            this.dgv_cekin.AllowUserToResizeColumns = false;
            this.dgv_cekin.AllowUserToResizeRows = false;
            this.dgv_cekin.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_cekin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_cekin.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_cekin.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_cekin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cekin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.m_tc_no,
            this.m_ad,
            this.m_soyad,
            this.m_tel,
            this.oda_no,
            this.g_trh,
            this.a_trh,
            this.hesap});
            this.dgv_cekin.Location = new System.Drawing.Point(6, 66);
            this.dgv_cekin.Name = "dgv_cekin";
            this.dgv_cekin.ReadOnly = true;
            this.dgv_cekin.RowHeadersVisible = false;
            this.dgv_cekin.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv_cekin.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_cekin.Size = new System.Drawing.Size(1213, 200);
            this.dgv_cekin.TabIndex = 0;
            this.dgv_cekin.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_cekin_CellDoubleClick);
            // 
            // m_tc_no
            // 
            this.m_tc_no.DataPropertyName = "m_tc_no";
            this.m_tc_no.HeaderText = "TC";
            this.m_tc_no.MaxInputLength = 11;
            this.m_tc_no.Name = "m_tc_no";
            this.m_tc_no.ReadOnly = true;
            this.m_tc_no.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.m_tc_no.Width = 150;
            // 
            // m_ad
            // 
            this.m_ad.DataPropertyName = "m_ad";
            this.m_ad.HeaderText = "Ad";
            this.m_ad.Name = "m_ad";
            this.m_ad.ReadOnly = true;
            this.m_ad.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.m_ad.Width = 170;
            // 
            // m_soyad
            // 
            this.m_soyad.DataPropertyName = "m_soyad";
            this.m_soyad.HeaderText = "Soyad";
            this.m_soyad.Name = "m_soyad";
            this.m_soyad.ReadOnly = true;
            this.m_soyad.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.m_soyad.Width = 170;
            // 
            // m_tel
            // 
            this.m_tel.DataPropertyName = "m_tel";
            this.m_tel.HeaderText = "Tel";
            this.m_tel.Name = "m_tel";
            this.m_tel.ReadOnly = true;
            this.m_tel.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.m_tel.Width = 175;
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
            this.g_trh.Width = 150;
            // 
            // a_trh
            // 
            this.a_trh.DataPropertyName = "a_trh";
            this.a_trh.HeaderText = "Çıkış";
            this.a_trh.Name = "a_trh";
            this.a_trh.ReadOnly = true;
            this.a_trh.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.a_trh.Width = 150;
            // 
            // hesap
            // 
            this.hesap.DataPropertyName = "hesap";
            this.hesap.HeaderText = "Hesap";
            this.hesap.Name = "hesap";
            this.hesap.ReadOnly = true;
            this.hesap.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.hesap.Width = 150;
            // 
            // frmChekOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1249, 576);
            this.Controls.Add(this.grp_dgv);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimizeBox = false;
            this.Name = "frmChekOut";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chek-out";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMCikis_FormClosed);
            this.Load += new System.EventHandler(this.frmMCikis_Load);
            this.grp_dgv.ResumeLayout(false);
            this.grp_dgv.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nocekin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cekin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_dgv;
        private System.Windows.Forms.DataGridView dgv_cekin;
        private System.Windows.Forms.DataGridView dgv_nocekin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn n_m_tc_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn n_m_ad;
        private System.Windows.Forms.DataGridViewTextBoxColumn n_m_soyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn n_m_tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn n_oda_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn n_g_trh;
        private System.Windows.Forms.DataGridViewTextBoxColumn n_a_trh;
        private System.Windows.Forms.DataGridViewTextBoxColumn n_hesap;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_tc_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_ad;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_soyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn oda_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn g_trh;
        private System.Windows.Forms.DataGridViewTextBoxColumn a_trh;
        private System.Windows.Forms.DataGridViewTextBoxColumn hesap;
    }
}