namespace Hadi_Hotel
{
    partial class frmGiris
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
            this.lblp = new System.Windows.Forms.Label();
            this.lblk = new System.Windows.Forms.Label();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.cmb_id = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblp
            // 
            this.lblp.AutoSize = true;
            this.lblp.Location = new System.Drawing.Point(82, 98);
            this.lblp.Name = "lblp";
            this.lblp.Size = new System.Drawing.Size(42, 18);
            this.lblp.TabIndex = 13;
            this.lblp.Text = "Şifre:";
            // 
            // lblk
            // 
            this.lblk.AutoSize = true;
            this.lblk.Location = new System.Drawing.Point(35, 41);
            this.lblk.Name = "lblk";
            this.lblk.Size = new System.Drawing.Size(89, 18);
            this.lblk.TabIndex = 12;
            this.lblk.Text = "Kullanıcı adı:";
            // 
            // txt_pass
            // 
            this.txt_pass.Location = new System.Drawing.Point(130, 95);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(251, 26);
            this.txt_pass.TabIndex = 11;
            this.txt_pass.UseSystemPasswordChar = true;
            this.txt_pass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_pass_KeyPress);
            // 
            // cmb_id
            // 
            this.cmb_id.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_id.FormattingEnabled = true;
            this.cmb_id.Location = new System.Drawing.Point(130, 38);
            this.cmb_id.Name = "cmb_id";
            this.cmb_id.Size = new System.Drawing.Size(251, 26);
            this.cmb_id.TabIndex = 10;
            this.cmb_id.SelectedIndexChanged += new System.EventHandler(this.cmb_id_SelectedIndexChanged);
            // 
            // frmGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 161);
            this.ControlBox = false;
            this.Controls.Add(this.lblp);
            this.Controls.Add(this.lblk);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.cmb_id);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmGiris";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş";
            this.Load += new System.EventHandler(this.frmGiris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblp;
        private System.Windows.Forms.Label lblk;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.ComboBox cmb_id;
    }
}