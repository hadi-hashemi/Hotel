using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Hadi_Hotel
{
    public partial class frmGridView : Form
    {
        frmAnaForm frmAnaForm = new frmAnaForm();
        public frmMRezervasyon frmMGiris = new frmMRezervasyon();
        
        public frmGridView()
        {
            InitializeComponent();
        }

        public void GridView_doldur()
        {            
            frmAnaForm.sql_Baglanti.Open();

            DataTable Sql_Tablo = new DataTable();

            SQLiteCommand sorgula = new SQLiteCommand(frmMGiris.strSorgu[0], frmAnaForm.sql_Baglanti);
            sorgula.Parameters.AddWithValue(frmMGiris.strSorgu[1], frmMGiris.strSorgu[2]);

            SQLiteDataAdapter sanal_tablo = new SQLiteDataAdapter(sorgula);

            sanal_tablo.Fill(Sql_Tablo);

            dgv.DataSource = Sql_Tablo;

            frmAnaForm.sql_Baglanti.Close();
        }

        private void btn_iptal_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            frmMGiris.txt_m_tc.Text = dgv.CurrentRow.Cells["m_tc_no"].Value.ToString();
            frmMGiris.txt_m_ad.Text = dgv.CurrentRow.Cells["m_ad"].Value.ToString();
            frmMGiris.txt_m_soyad.Text = dgv.CurrentRow.Cells["m_soyad"].Value.ToString();
            frmMGiris.cmb_cin.Text = dgv.CurrentRow.Cells["m_cin"].Value.ToString();
            frmMGiris.txt_m_tel.Text = dgv.CurrentRow.Cells["m_tel"].Value.ToString();

            this.Hide();
        }
    }
}
