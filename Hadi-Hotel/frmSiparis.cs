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
    public partial class frmSiparis : Form
    {
        
        frmAnaForm frmAnaForm = new frmAnaForm();

        public frmSiparis(frmAnaForm frmAnaForm)
        {
            InitializeComponent();
            this.frmAnaForm = frmAnaForm;
        }

        public frmSiparis()
        {
            // TODO: Complete member initialization
        }

        private void frmSiparis_Load(object sender, EventArgs e)
        {            
            Combobox_oda_doldur();
            Combobox_grup_doldur();
            GridView_yemek_doldur();

            if (frmAnaForm.masa_ve_oda[frmAnaForm.masa_no] != 0)
            {
                cmb_oda.Text = frmAnaForm.masa_ve_oda[frmAnaForm.masa_no].ToString();
            }

            if (cmb_oda.Text != string.Empty)
            {
                dgv_siparis_doldur(cmb_oda.Text);
                toplam_tutar();
            }
        }

        private void Combobox_oda_doldur()
        {
            SQLiteCommand oda_Listele = new SQLiteCommand("SELECT oda_no FROM rezervasyon  WHERE durum = 'C'", frmAnaForm.sql_Baglanti);
            SQLiteDataReader listeden_Oku;

            frmAnaForm.sql_Baglanti.Open();
            listeden_Oku = oda_Listele.ExecuteReader();

            while (listeden_Oku.Read())
            {
                cmb_oda.Items.Add(listeden_Oku["oda_no"].ToString());
            }

            listeden_Oku.Close();
            frmAnaForm.sql_Baglanti.Close();
        }

        public void GridView_yemek_doldur()
        {
            frmAnaForm.sql_Baglanti.Open();

            DataTable Sql_Tablo = new DataTable();

            SQLiteCommand sorgula = new SQLiteCommand("SELECT * FROM yemek", frmAnaForm.sql_Baglanti);

            SQLiteDataAdapter sanal_tablo = new SQLiteDataAdapter(sorgula);

            sanal_tablo.Fill(Sql_Tablo);

            dgv_ymk.DataSource = Sql_Tablo;

            frmAnaForm.sql_Baglanti.Close();
        }

        private void Combobox_grup_doldur()
        {
            SQLiteCommand grup_Listele = new SQLiteCommand("SELECT DISTINCT y_grp FROM yemek", frmAnaForm.sql_Baglanti);
            SQLiteDataReader listeden_Oku;

            frmAnaForm.sql_Baglanti.Open();
            listeden_Oku = grup_Listele.ExecuteReader();

            while (listeden_Oku.Read())
            {
                cmb_grp.Items.Add(listeden_Oku["y_grp"].ToString());
            }

            listeden_Oku.Close();
            frmAnaForm.sql_Baglanti.Close();
        }

        private void GridView_yemek_filtrele()
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dgv_ymk.DataSource;
            bs.Filter = "y_ad like '%" + txt_yemek.Text + "%' and y_grp like '%" + cmb_grp.Text + "%'";

            dgv_ymk.DataSource = bs;
        }

        private void cmb_oda_SelectedIndexChanged(object sender, EventArgs e)
        {            
            frmAnaForm.sql_Baglanti.Open();

            SQLiteCommand ad_soyad_getir = new SQLiteCommand("SELECT m_ad, m_soyad FROM rezervasyon r, musteri m WHERE m.m_tc_no = r.m_tc_no AND durum = 'C' AND oda_no = @oda_no", frmAnaForm.sql_Baglanti);

            ad_soyad_getir.Parameters.AddWithValue("@oda_no", cmb_oda.SelectedItem.ToString());

            SQLiteDataReader ad_soyad_Oku = ad_soyad_getir.ExecuteReader();

            while (ad_soyad_Oku.Read())
            {
                lbl_m_ad.Text = ad_soyad_Oku["m_ad"].ToString();
                lbl_m_soyad.Text = ad_soyad_Oku["m_soyad"].ToString();
            }

            ad_soyad_Oku.Close();
            frmAnaForm.sql_Baglanti.Close();

            dgv_siparis_doldur(cmb_oda.Text);
            toplam_tutar();
        }

        private void cmb_grp_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridView_yemek_filtrele();
        }

        private void txt_yemek_TextChanged(object sender, EventArgs e)
        {
            GridView_yemek_filtrele();
        }

        private void btn_hesap_Click(object sender, EventArgs e)
        {
            frmAnaForm.sql_Baglanti.Open();

            SQLiteCommand oda_durum_degistir = new SQLiteCommand("UPDATE restoran SET durum = 'P' WHERE oda_no = @oda_no AND durum = 'A' ", frmAnaForm.sql_Baglanti);
            oda_durum_degistir.Parameters.AddWithValue("@oda_no", cmb_oda.Text);
            
            oda_durum_degistir.ExecuteNonQuery();
            frmAnaForm.sql_Baglanti.Close();

            frmAnaForm.masa_durumu[frmAnaForm.masa_no] = 0;
            frmAnaForm.masa_ve_oda[frmAnaForm.masa_no] = 0;
            this.Hide();
        }

        private void btn_siparis_Click(object sender, EventArgs e)
        {
            frmAnaForm.masa_durumu[frmAnaForm.masa_no] = 1;
            frmAnaForm.masa_ve_oda[frmAnaForm.masa_no] = Convert.ToInt32(cmb_oda.Text);
            this.Hide();
        }

        private void dgv_siparis_doldur(string oda)
        {
            frmAnaForm.sql_Baglanti.Open();

            DataTable Sql_Tablo = new DataTable();

            SQLiteCommand sorgula = new SQLiteCommand("SELECT sayi, y_ad, tutar FROM restoran WHERE ( oda_no = @oda_no ) AND ( durum = 'A' )", frmAnaForm.sql_Baglanti);
            sorgula.Parameters.AddWithValue("@oda_no", oda);

            SQLiteDataAdapter sanal_tablo = new SQLiteDataAdapter(sorgula);

            sanal_tablo.Fill(Sql_Tablo);

            dgv_siparis.DataSource = Sql_Tablo;

            frmAnaForm.sql_Baglanti.Close();
        }

        private void dgv_ymk_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (cmb_oda.Text != string.Empty)
            {
                string tc = "",
                        trh = "",
                         g_trh = "";

                frmAnaForm.sql_Baglanti.Open();

                SQLiteCommand oda_sorgula_rezervasyon = new SQLiteCommand("SELECT m_tc_no, oda_no, g_trh FROM rezervasyon WHERE ( oda_no = @oda_no ) AND ( durum = 'C' )", frmAnaForm.sql_Baglanti);
                oda_sorgula_rezervasyon.Parameters.AddWithValue("@oda_no", cmb_oda.Text);

                SQLiteDataReader oda_kayit_rezervasyon_Oku = oda_sorgula_rezervasyon.ExecuteReader();

                while (oda_kayit_rezervasyon_Oku.Read())
                {
                    tc = oda_kayit_rezervasyon_Oku["m_tc_no"].ToString();
                    g_trh = Convert.ToDateTime(oda_kayit_rezervasyon_Oku["g_trh"].ToString()).ToShortDateString();
                }

                oda_kayit_rezervasyon_Oku.Close();
                frmAnaForm.sql_Baglanti.Close();

                DateTime temp = Convert.ToDateTime(g_trh);
                g_trh = temp.Year + "-" + temp.Month + "-" + temp.Day;

                trh = DateTime.Today.Year + "-" + DateTime.Today.Month + "-" + DateTime.Today.Day;

                frmAnaForm.sql_Baglanti.Open();

                Boolean yemek_var_mı = false;
                int yemek_sayi = 0;
                int yemek_fiyat = 0;

                SQLiteCommand yemek_sorgula = new SQLiteCommand("SELECT * FROM restoran WHERE oda_no = @oda_no AND durum = 'A' AND y_ad = @y_ad", frmAnaForm.sql_Baglanti);
                yemek_sorgula.Parameters.AddWithValue("@oda_no", cmb_oda.Text);
                yemek_sorgula.Parameters.AddWithValue("@y_ad", dgv_ymk.CurrentRow.Cells["y_ad"].Value.ToString());

                SQLiteDataReader yemek_sayi_oku = yemek_sorgula.ExecuteReader();

                while (yemek_sayi_oku.Read())
                {
                        yemek_sayi = Convert.ToInt32(yemek_sayi_oku["sayi"].ToString());
                        yemek_fiyat = Convert.ToInt32(yemek_sayi_oku["tutar"].ToString());
                        yemek_var_mı = true;
                }

                oda_kayit_rezervasyon_Oku.Close();
                frmAnaForm.sql_Baglanti.Close();

                if (!yemek_var_mı)
                {
                    frmAnaForm.sql_Baglanti.Open();

                    SQLiteCommand yemek_listesi_ekle = new SQLiteCommand("INSERT INTO restoran(m_tc_no, oda_no, g_trh, y_ad, k_id, trh, saat, sayi, tutar, durum) "
                                                                       + "VALUES (@m_tc_no, @oda_no, @g_trh, @y_ad, @k_id, @trh, @saat, '1', @tutar, 'A')", frmAnaForm.sql_Baglanti);

                    yemek_listesi_ekle.Parameters.AddWithValue("@m_tc_no", tc);
                    yemek_listesi_ekle.Parameters.AddWithValue("@oda_no", cmb_oda.Text);
                    yemek_listesi_ekle.Parameters.AddWithValue("@g_trh", g_trh);
                    yemek_listesi_ekle.Parameters.AddWithValue("@y_ad", dgv_ymk.CurrentRow.Cells["y_ad"].Value.ToString());
                    yemek_listesi_ekle.Parameters.AddWithValue("@k_id", frmAnaForm.kullanici_StripStatus.Text);
                    yemek_listesi_ekle.Parameters.AddWithValue("@trh", trh);
                    yemek_listesi_ekle.Parameters.AddWithValue("@saat", DateTime.Now.ToLongTimeString());
                    yemek_listesi_ekle.Parameters.AddWithValue("@tutar", dgv_ymk.CurrentRow.Cells["y_fiyat"].Value.ToString());

                    yemek_listesi_ekle.ExecuteNonQuery();

                    frmAnaForm.sql_Baglanti.Close();
                }
                else
                {
                    int yemek_birim_fiyat = (yemek_fiyat / yemek_sayi);
                    
                    frmAnaForm.sql_Baglanti.Open();

                    SQLiteCommand oda_durum_degistir = new SQLiteCommand("UPDATE restoran SET sayi = @sayi, tutar = @tutar WHERE oda_no = @oda_no AND y_ad = @y_ad AND durum = 'A' ", frmAnaForm.sql_Baglanti);
                    oda_durum_degistir.Parameters.AddWithValue("@oda_no", cmb_oda.Text);
                    oda_durum_degistir.Parameters.AddWithValue("@y_ad", dgv_ymk.CurrentRow.Cells["y_ad"].Value.ToString());
                    oda_durum_degistir.Parameters.AddWithValue("@sayi", (yemek_sayi + 1).ToString());
                    oda_durum_degistir.Parameters.AddWithValue("@tutar", (yemek_fiyat + yemek_birim_fiyat).ToString());

                    oda_durum_degistir.ExecuteNonQuery();

                    frmAnaForm.sql_Baglanti.Close();
                }

                dgv_siparis_doldur(cmb_oda.Text);
                toplam_tutar();
            }
        }

        private void toplam_tutar()
        {
            int toplam = 0;

            for (int i = 0; i < dgv_siparis.Rows.Count; ++i)
            {
                toplam += Convert.ToInt32(dgv_siparis.Rows[i].Cells[2].Value);
            }
            
            lbl_toplam_tutar.Text = toplam.ToString();
        }
    }
}