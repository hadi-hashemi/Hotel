namespace Hadi_Hotel
{
    partial class frmGridView
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
            this.btn_iptal = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.m_tc_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_ad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_soyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_cin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_iptal
            // 
            this.btn_iptal.Location = new System.Drawing.Point(564, 174);
            this.btn_iptal.Name = "btn_iptal";
            this.btn_iptal.Size = new System.Drawing.Size(102, 41);
            this.btn_iptal.TabIndex = 5;
            this.btn_iptal.Text = "İptal";
            this.btn_iptal.UseVisualStyleBackColor = true;
            this.btn_iptal.Click += new System.EventHandler(this.btn_iptal_Click);
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.m_tc_no,
            this.m_ad,
            this.m_soyad,
            this.m_cin,
            this.m_tel});
            this.dgv.Location = new System.Drawing.Point(13, 9);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersVisible = false;
            this.dgv.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(654, 159);
            this.dgv.TabIndex = 4;
            this.dgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellDoubleClick);
            // 
            // m_tc_no
            // 
            this.m_tc_no.DataPropertyName = "m_tc_no";
            this.m_tc_no.HeaderText = "TC";
            this.m_tc_no.Name = "m_tc_no";
            this.m_tc_no.ReadOnly = true;
            // 
            // m_ad
            // 
            this.m_ad.DataPropertyName = "m_ad";
            this.m_ad.HeaderText = "Ad";
            this.m_ad.Name = "m_ad";
            this.m_ad.ReadOnly = true;
            this.m_ad.Width = 150;
            // 
            // m_soyad
            // 
            this.m_soyad.DataPropertyName = "m_soyad";
            this.m_soyad.HeaderText = "Soyad";
            this.m_soyad.Name = "m_soyad";
            this.m_soyad.ReadOnly = true;
            this.m_soyad.Width = 150;
            // 
            // m_cin
            // 
            this.m_cin.DataPropertyName = "m_cin";
            this.m_cin.HeaderText = "Cinsiyet";
            this.m_cin.Name = "m_cin";
            this.m_cin.ReadOnly = true;
            this.m_cin.Width = 110;
            // 
            // m_tel
            // 
            this.m_tel.DataPropertyName = "m_tel";
            this.m_tel.HeaderText = "Telefon";
            this.m_tel.Name = "m_tel";
            this.m_tel.ReadOnly = true;
            this.m_tel.Width = 150;
            // 
            // frmGridView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 225);
            this.ControlBox = false;
            this.Controls.Add(this.btn_iptal);
            this.Controls.Add(this.dgv);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmGridView";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteriler";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_iptal;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_tc_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_ad;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_soyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_cin;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_tel;
    }
}