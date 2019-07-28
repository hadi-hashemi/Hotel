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
    public partial class frmChekIn : Form
    {
        frmAnaForm frmAnaForm = new frmAnaForm();

        public frmChekIn(frmAnaForm frmAnaForm)
        {
            InitializeComponent();
            this.frmAnaForm = frmAnaForm;
        }

        public frmChekIn()
        {
            // TODO: Complete member initialization
        }

        private void frmChekIn_Load(object sender, EventArgs e)
        {
            GridView_doldur();
        }

        private void frmChekIn_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmAnaForm.anaFormu_geriGetir();
        }

        public void GridView_doldur()
        {
            frmAnaForm.sql_Baglanti.Open();

            DataTable Sql_Tablo = new DataTable();

            string strSorgu = "SELECT m.m_tc_no, m_ad, m_soyad, m_tel, oda_no, g_trh, a_trh, hesap " +
                              "FROM musteri m " +
                              "INNER JOIN rezervasyon r ON m.m_tc_no = r.m_tc_no AND durum = 'A' ORDER BY g_trh ";

            SQLiteCommand sorgula = new SQLiteCommand(strSorgu, frmAnaForm.sql_Baglanti);

            SQLiteDataAdapter sanal_tablo = new SQLiteDataAdapter(sorgula);

            sanal_tablo.Fill(Sql_Tablo);

            dgv_chekin.DataSource = Sql_Tablo;

            frmAnaForm.sql_Baglanti.Close();
        }

        private void dgv_chekin_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmAnaForm.sql_Baglanti.Open();

            SQLiteCommand oda_durum_degistir = new SQLiteCommand("UPDATE rezervasyon SET durum = 'C' WHERE m_tc_no = @m_tc_no AND oda_no = @oda_no AND g_trh = @g_trh AND a_trh = @a_trh ", frmAnaForm.sql_Baglanti);
            oda_durum_degistir.Parameters.AddWithValue("@m_tc_no", dgv_chekin.CurrentRow.Cells["m_tc_no"].Value.ToString());
            oda_durum_degistir.Parameters.AddWithValue("@oda_no", dgv_chekin.CurrentRow.Cells["oda_no"].Value.ToString());
            oda_durum_degistir.Parameters.AddWithValue("@g_trh", DateTime.Parse(dgv_chekin.CurrentRow.Cells["g_trh"].Value.ToString()));
            oda_durum_degistir.Parameters.AddWithValue("@a_trh", DateTime.Parse(dgv_chekin.CurrentRow.Cells["a_trh"].Value.ToString()));


            oda_durum_degistir.ExecuteNonQuery();

            frmAnaForm.sql_Baglanti.Close();

            SQLiteCommand tc_sorgula = new SQLiteCommand("SELECT m_ad, m_cin FROM musteri WHERE m_tc_no = @m_tc_no", frmAnaForm.sql_Baglanti);
            tc_sorgula.Parameters.AddWithValue("@m_tc_no", dgv_chekin.CurrentRow.Cells["m_tc_no"].Value.ToString());

            SQLiteDataReader cinsiyet_Oku;

            frmAnaForm.sql_Baglanti.Open();
            cinsiyet_Oku = tc_sorgula.ExecuteReader();

            while (cinsiyet_Oku.Read())
            {
                if (cinsiyet_Oku["m_cin"].ToString() == "Erkek")
                {
                    MessageBox.Show(cinsiyet_Oku["m_ad"].ToString() + " Beyin chek-ini yapıldı", "Tebrikler", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (cinsiyet_Oku["m_cin"].ToString() == "Kadın")
                {
                    MessageBox.Show(cinsiyet_Oku["m_ad"].ToString() + " Hanımın chek-ini yapıldı", "Tebrikler", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            cinsiyet_Oku.Close();
            frmAnaForm.sql_Baglanti.Close();

            GridView_doldur();
        }
    }
}
