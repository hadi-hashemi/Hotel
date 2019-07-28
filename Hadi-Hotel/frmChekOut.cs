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
    public partial class frmChekOut : Form
    {

        frmAnaForm frmAnaForm = new frmAnaForm();

        public frmChekOut(frmAnaForm frmAnaForm)
        {
            InitializeComponent();
            this.frmAnaForm = frmAnaForm;
        }

        public frmChekOut()
        {
            // TODO: Complete member initialization
        }

        private void frmMCikis_Load(object sender, EventArgs e)
        {
            GridView_doldur("A");
            GridView_doldur("C");
        }

        private void frmMCikis_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmAnaForm.anaFormu_geriGetir();
        }

        public void GridView_doldur(string durum)
        {
            frmAnaForm.sql_Baglanti.Open();

            DataTable Sql_Tablo = new DataTable();

            string strSorgu = "SELECT m.m_tc_no, m_ad, m_soyad, m_tel, oda_no, g_trh, a_trh, hesap " +
                              "FROM musteri m " +
                              "INNER JOIN rezervasyon r ON m.m_tc_no = r.m_tc_no AND durum = @durum ORDER BY g_trh ";

            SQLiteCommand sorgula = new SQLiteCommand(strSorgu, frmAnaForm.sql_Baglanti);
            sorgula.Parameters.AddWithValue("@durum", durum);

            SQLiteDataAdapter sanal_tablo = new SQLiteDataAdapter(sorgula);

            sanal_tablo.Fill(Sql_Tablo);

            if (durum == "C")
            {
                dgv_cekin.DataSource = Sql_Tablo;
            }
            else if (durum == "A")
            {
                dgv_nocekin.DataSource = Sql_Tablo;
            }            

            frmAnaForm.sql_Baglanti.Close();
        }

        private void dgv_cekin_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmAnaForm.sql_Baglanti.Open();

            SQLiteCommand oda_durum_degistir = new SQLiteCommand("UPDATE rezervasyon SET durum = 'P' WHERE m_tc_no = @m_tc_no AND oda_no = @oda_no AND g_trh = @g_trh AND a_trh = @a_trh ", frmAnaForm.sql_Baglanti);
            oda_durum_degistir.Parameters.AddWithValue("@m_tc_no", dgv_cekin.CurrentRow.Cells["m_tc_no"].Value.ToString());
            oda_durum_degistir.Parameters.AddWithValue("@oda_no", dgv_cekin.CurrentRow.Cells["oda_no"].Value.ToString());
            oda_durum_degistir.Parameters.AddWithValue("@g_trh", DateTime.Parse(dgv_cekin.CurrentRow.Cells["g_trh"].Value.ToString()));
            oda_durum_degistir.Parameters.AddWithValue("@a_trh", DateTime.Parse(dgv_cekin.CurrentRow.Cells["a_trh"].Value.ToString()));


            oda_durum_degistir.ExecuteNonQuery();

            frmAnaForm.sql_Baglanti.Close();

            GridView_doldur("C");
        }

        private void dgv_nocekin_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult cvp = MessageBox.Show("Seçilen rezervasyonu iptal etmek istediğinizden emin misiniz?", "Rezervasyonu iptali", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (cvp == DialogResult.Yes)
            {
                frmAnaForm.sql_Baglanti.Open();

                SQLiteCommand oda_durum_degistir = new SQLiteCommand("UPDATE rezervasyon SET durum = 'P' WHERE m_tc_no = @m_tc_no AND oda_no = @oda_no AND g_trh = @g_trh AND a_trh = @a_trh ", frmAnaForm.sql_Baglanti);
                oda_durum_degistir.Parameters.AddWithValue("@m_tc_no", dgv_nocekin.CurrentRow.Cells["n_m_tc_no"].Value.ToString());
                oda_durum_degistir.Parameters.AddWithValue("@oda_no", dgv_nocekin.CurrentRow.Cells["n_oda_no"].Value.ToString());
                oda_durum_degistir.Parameters.AddWithValue("@g_trh", DateTime.Parse(dgv_nocekin.CurrentRow.Cells["n_g_trh"].Value.ToString()));
                oda_durum_degistir.Parameters.AddWithValue("@a_trh", DateTime.Parse(dgv_nocekin.CurrentRow.Cells["n_a_trh"].Value.ToString()));


                oda_durum_degistir.ExecuteNonQuery();

                frmAnaForm.sql_Baglanti.Close();

                GridView_doldur("A");
            }            
        }
    }
}
