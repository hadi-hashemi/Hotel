namespace Hadi_Hotel
{
    partial class frmChekIn
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
            this.dgv_chekin = new System.Windows.Forms.DataGridView();
            this.m_tc_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_ad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_soyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oda_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.g_trh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.a_trh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hesap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_chekin)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_chekin
            // 
            this.dgv_chekin.AllowUserToAddRows = false;
            this.dgv_chekin.AllowUserToDeleteRows = false;
            this.dgv_chekin.AllowUserToResizeColumns = false;
            this.dgv_chekin.AllowUserToResizeRows = false;
            this.dgv_chekin.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_chekin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_chekin.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_chekin.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_chekin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_chekin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.m_tc_no,
            this.m_ad,
            this.m_soyad,
            this.m_tel,
            this.oda_no,
            this.g_trh,
            this.a_trh,
            this.hesap});
            this.dgv_chekin.Location = new System.Drawing.Point(12, 12);
            this.dgv_chekin.Name = "dgv_chekin";
            this.dgv_chekin.ReadOnly = true;
            this.dgv_chekin.RowHeadersVisible = false;
            this.dgv_chekin.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv_chekin.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_chekin.Size = new System.Drawing.Size(932, 213);
            this.dgv_chekin.TabIndex = 10;
            this.dgv_chekin.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_chekin_CellDoubleClick);
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
            // frmChekIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 236);
            this.Controls.Add(this.dgv_chekin);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimizeBox = false;
            this.Name = "frmChekIn";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chek-in";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmChekIn_FormClosed);
            this.Load += new System.EventHandler(this.frmChekIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_chekin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_chekin;
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