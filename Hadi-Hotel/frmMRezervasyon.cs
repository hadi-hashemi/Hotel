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
    public partial class frmMRezervasyon : Form
    {

        public frmAnaForm frmAnaForm = new frmAnaForm();
        public frmGridView frmGridView;
        public string strKullanici;

        public string[] strSorgu = new string[3];

        public frmMRezervasyon(frmAnaForm frmAnaForm)
        {
            InitializeComponent();
            this.frmAnaForm = frmAnaForm;
        }

        public frmMRezervasyon()
        {
            // TODO: Complete member initialization
        }

        private void frmMRezervasyon_Load(object sender, EventArgs e)
        {
            dateTime_Giris.Value = DateTime.Today;
            dateTime_Cikis.Value = DateTime.Today;
        }

        private void frmMRezervasyon_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmAnaForm.anaFormu_geriGetir();
        }
        
        private void txt_m_tc_TextChanged(object sender, EventArgs e)
        {
            lbl_r_tc.Text = txt_m_tc.Text;
        }

        private void txt_m_tc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                txt_m_ad.Focus();
                
                if (btn_kaydet_durum())
                {
                    btn_kaydet.Enabled = true;
                }
            }
        }

        private void txt_m_ad_TextChanged(object sender, EventArgs e)
        {
            lbl_r_ad.Text = txt_m_ad.Text;
        }

        private void txt_m_ad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                txt_m_soyad.Focus();

                if (btn_kaydet_durum())
                {
                    btn_kaydet.Enabled = true;
                }
            }
        }

        private void txt_m_ad_Leave(object sender, EventArgs e)
        {
            if (txt_m_ad.Text != "")
            {
                txt_m_ad.Text = txt_m_ad.Text.Trim();
                txt_m_ad.Text = txt_m_ad.Text.Substring(0, 1).ToUpper() + txt_m_ad.Text.Substring(1).ToLower();
            }
        }

        private void txt_m_soyad_TextChanged(object sender, EventArgs e)
        {
            lbl_r_soyad.Text = txt_m_soyad.Text;
        }

        private void txt_m_soyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                txt_m_tel.Focus();

                if (btn_kaydet_durum())
                {
                    btn_kaydet.Enabled = true;
                }
            }
        }

        private void txt_m_soyad_Leave(object sender, EventArgs e)
        {
            if (txt_m_soyad.Text != "")
            {
                txt_m_soyad.Text = txt_m_soyad.Text.Trim();
                txt_m_soyad.Text = txt_m_soyad.Text.Substring(0, 1).ToUpper() + txt_m_soyad.Text.Substring(1).ToLower();
            }
        }

        private void txt_m_tel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                txt_m_adres.Focus();
            }
        }

        private void dateTime_Giris_ValueChanged(object sender, EventArgs e)
        {
            if (dateTime_Giris.Value < DateTime.Today)
            {
                dateTime_Giris.Value = DateTime.Today;
            }

            lbl_r_g_g.Text = dateTime_Giris.Value.Day.ToString();
            lbl_r_g_a.Text = dateTime_Giris.Value.Month.ToString();
            lbl_r_g_y.Text = dateTime_Giris.Value.Year.ToString();

            if (Convert.ToInt32(lbl_r_g_g.Text) < 10)
            {
                lbl_r_g_g.Text = "0" + lbl_r_g_g.Text;
            }

            if (Convert.ToInt32(lbl_r_g_a.Text) < 10)
            {
                lbl_r_g_a.Text = "0" + lbl_r_g_a.Text;
            }

            if (btn_kaydet_durum())
            {
                btn_kaydet.Enabled = true;
            }
        }

        private void dateTime_Cikis_ValueChanged(object sender, EventArgs e)
        {
            if (dateTime_Cikis.Value < dateTime_Giris.Value)
            {
                dateTime_Cikis.Value = dateTime_Giris.Value;
            }

            lbl_r_c_g.Text = dateTime_Cikis.Value.Day.ToString();
            lbl_r_c_a.Text = dateTime_Cikis.Value.Month.ToString();
            lbl_r_c_y.Text = dateTime_Cikis.Value.Year.ToString();

            if (Convert.ToInt32(lbl_r_c_g.Text) < 10)
            {
                lbl_r_c_g.Text = "0" + lbl_r_c_g.Text;
            }

            if (Convert.ToInt32(lbl_r_c_a.Text) < 10)
            {
                lbl_r_c_a.Text = "0" + lbl_r_c_a.Text;
            }

            if (btn_kaydet_durum())
            {
                btn_kaydet.Enabled = true;
            }
        }

        private Boolean btn_kaydet_durum()
        {
            if (lbl_r_tc.Text != string.Empty && lbl_r_ad.Text != string.Empty && lbl_r_soyad.Text != string.Empty && lbl_r_oda.Text != string.Empty
                                               && lbl_r_g_g.Text != string.Empty && lbl_r_g_a.Text != string.Empty && lbl_r_g_y.Text != string.Empty
                                               && lbl_r_c_g.Text != string.Empty && lbl_r_c_a.Text != string.Empty && lbl_r_c_y.Text != string.Empty)
            {
                return true;
            }
            return false;
        }
        
        private void oda101_Click(object sender, EventArgs e)
        {
            if (oda101.BackColor == Color.Green)
            {
                lbl_r_oda.Text = "101";

                if (btn_kaydet_durum())
                {
                    btn_kaydet.Enabled = true;
                }
            }
        }

        private void oda102_Click(object sender, EventArgs e)
        {
            if (oda102.BackColor == Color.Green)
            {
                lbl_r_oda.Text = "102";

                if (btn_kaydet_durum())
                {
                    btn_kaydet.Enabled = true;
                }
            }
        }

        private void oda103_Click(object sender, EventArgs e)
        {
            if (oda103.BackColor == Color.Green)
            {
                lbl_r_oda.Text = "103";

                if (btn_kaydet_durum())
                {
                    btn_kaydet.Enabled = true;
                }
            }
        }

        private void oda104_Click(object sender, EventArgs e)
        {
            if (oda104.BackColor == Color.Green)
            {
                lbl_r_oda.Text = "104";

                if (btn_kaydet_durum())
                {
                    btn_kaydet.Enabled = true;
                }
            }
        }

        private void oda201_Click(object sender, EventArgs e)
        {
            if (oda201.BackColor == Color.Green)
            {
                lbl_r_oda.Text = "201";

                if (btn_kaydet_durum())
                {
                    btn_kaydet.Enabled = true;
                }
            }
        }

        private void oda202_Click(object sender, EventArgs e)
        {
            if (oda202.BackColor == Color.Green)
            {
                lbl_r_oda.Text = "202";

                if (btn_kaydet_durum())
                {
                    btn_kaydet.Enabled = true;
                }
            }
        }

        private void oda203_Click(object sender, EventArgs e)
        {
            if (oda203.BackColor == Color.Green)
            {
                lbl_r_oda.Text = "203";

                if (btn_kaydet_durum())
                {
                    btn_kaydet.Enabled = true;
                }
            }
        }

        private void oda204_Click(object sender, EventArgs e)
        {
            if (oda204.BackColor == Color.Green)
            {
                lbl_r_oda.Text = "204";

                if (btn_kaydet_durum())
                {
                    btn_kaydet.Enabled = true;
                }
            }
        }

        private void oda301_Click(object sender, EventArgs e)
        {
            if (oda301.BackColor == Color.Green)
            {
                lbl_r_oda.Text = "301";

                if (btn_kaydet_durum())
                {
                    btn_kaydet.Enabled = true;
                }
            }
        }

        private void oda302_Click(object sender, EventArgs e)
        {
            if (oda302.BackColor == Color.Green)
            {
                lbl_r_oda.Text = "302";

                if (btn_kaydet_durum())
                {
                    btn_kaydet.Enabled = true;
                }
            }
        }

        private void oda303_Click(object sender, EventArgs e)
        {
            if (oda303.BackColor == Color.Green)
            {
                lbl_r_oda.Text = "303";

                if (btn_kaydet_durum())
                {
                    btn_kaydet.Enabled = true;
                }
            }
        }

        private void oda304_Click(object sender, EventArgs e)
        {
            if (oda304.BackColor == Color.Green)
            {
                lbl_r_oda.Text = "304";

                if (btn_kaydet_durum())
                {
                    btn_kaydet.Enabled = true;
                }
            }
        }

        private void oda401_Click(object sender, EventArgs e)
        {
            if (oda401.BackColor == Color.Green)
            {
                lbl_r_oda.Text = "401";

                if (btn_kaydet_durum())
                {
                    btn_kaydet.Enabled = true;
                }
            }
        }

        private void oda402_Click(object sender, EventArgs e)
        {
            if (oda402.BackColor == Color.Green)
            {
                lbl_r_oda.Text = "402";

                if (btn_kaydet_durum())
                {
                    btn_kaydet.Enabled = true;
                }
            }
        }

        private void oda403_Click(object sender, EventArgs e)
        {
            if (oda403.BackColor == Color.Green)
            {
                lbl_r_oda.Text = "403";

                if (btn_kaydet_durum())
                {
                    btn_kaydet.Enabled = true;
                }
            }
        }

        private void oda404_Click(object sender, EventArgs e)
        {
            if (oda404.BackColor == Color.Green)
            {
                lbl_r_oda.Text = "404";

                if (btn_kaydet_durum())
                {
                    btn_kaydet.Enabled = true;
                }
            }
        }

        private void oda501_Click(object sender, EventArgs e)
        {
            if (oda501.BackColor == Color.Green)
            {
                lbl_r_oda.Text = "501";

                if (btn_kaydet_durum())
                {
                    btn_kaydet.Enabled = true;
                }
            }
        }

        private void oda502_Click(object sender, EventArgs e)
        {
            if (oda502.BackColor == Color.Green)
            {
                lbl_r_oda.Text = "502";

                if (btn_kaydet_durum())
                {
                    btn_kaydet.Enabled = true;
                }
            }
        }

        private void oda503_Click(object sender, EventArgs e)
        {
            if (oda503.BackColor == Color.Green)
            {
                lbl_r_oda.Text = "503";

                if (btn_kaydet_durum())
                {
                    btn_kaydet.Enabled = true;
                }
            }
        }

        private void oda504_Click(object sender, EventArgs e)
        {
            if (oda504.BackColor == Color.Green)
            {
                lbl_r_oda.Text = "504";

                if (btn_kaydet_durum())
                {
                    btn_kaydet.Enabled = true;
                }
            }
        }

        private void lbl_oda_filtrele_Click(object sender, EventArgs e)
        {
            oda_durumu(dateTime_Giris.Value, dateTime_Cikis.Value);

            oda101.Enabled = oda102.Enabled = oda103.Enabled = oda104.Enabled = true;
            oda201.Enabled = oda202.Enabled = oda203.Enabled = oda204.Enabled = true;
            oda301.Enabled = oda302.Enabled = oda303.Enabled = oda304.Enabled = true;
            oda401.Enabled = oda402.Enabled = oda403.Enabled = oda404.Enabled = true;
            oda501.Enabled = oda502.Enabled = oda503.Enabled = oda504.Enabled = true;
        }

        private void lbl_oda_filtrele_MouseMove(object sender, MouseEventArgs e)
        {
            lbl_oda_filtrele.ForeColor = Color.DarkGreen;
        }

        private void lbl_oda_filtrele_MouseLeave(object sender, EventArgs e)
        {
            lbl_oda_filtrele.ForeColor = Color.Green;
        }
        
        private void btn_tc_bul_Click(object sender, EventArgs e)
        {
            SQLiteCommand tc_sorgula_musteri = new SQLiteCommand("SELECT * FROM musteri WHERE m_tc_no = @m_tc_no ", frmAnaForm.sql_Baglanti);
            tc_sorgula_musteri.Parameters.AddWithValue("@m_tc_no", txt_m_tc.Text);

            SQLiteDataReader tc_Oku;

            frmAnaForm.sql_Baglanti.Open();
            tc_Oku = tc_sorgula_musteri.ExecuteReader();

            while (tc_Oku.Read())
            {
                txt_m_ad.Text = tc_Oku["m_ad"].ToString();
                txt_m_soyad.Text = tc_Oku["m_soyad"].ToString();
                txt_m_tel.Text = tc_Oku["m_tel"].ToString();
                cmb_cin.Text = tc_Oku["m_cin"].ToString();
            }

            tc_Oku.Close();
            frmAnaForm.sql_Baglanti.Close();
        }

        private void btn_ad_bul_Click(object sender, EventArgs e)
        {
            strSorgu[0] = "SELECT * FROM Musteri WHERE m_ad LIKE @m_ad";
            strSorgu[1] = "@m_ad";
            strSorgu[2] = "%" + txt_m_ad.Text + "%";

            frmGridView = new frmGridView();
            frmGridView.frmMGiris = this;

            frmGridView.Show();

            frmGridView.GridView_doldur();
        }

        private void btn_soyad_bul_Click(object sender, EventArgs e)
        {
            strSorgu[0] = "SELECT * FROM Musteri WHERE m_soyad LIKE @m_soyad";
            strSorgu[1] = "@m_soyad";
            strSorgu[2] = "%" + txt_m_soyad.Text + "%";

            frmGridView = new frmGridView();
            frmGridView.frmMGiris = this;

            frmGridView.Show();

            frmGridView.GridView_doldur();
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            int fiyat = oda_fiyat(lbl_r_oda.Text);
            
            Boolean tc_musteride_eklimi = false,
                    rezervasyon_var_mi = false;

            SQLiteCommand tc_sorgula = new SQLiteCommand("SELECT COUNT(m_tc_no) AS sayi  FROM musteri WHERE m_tc_no = @m_tc_no", frmAnaForm.sql_Baglanti);
            tc_sorgula.Parameters.AddWithValue("@m_tc_no", txt_m_tc.Text);

            SQLiteDataReader tc_kayit_Oku;

            frmAnaForm.sql_Baglanti.Open();
            tc_kayit_Oku = tc_sorgula.ExecuteReader();

            while (tc_kayit_Oku.Read())
            {
                if (Convert.ToInt16(tc_kayit_Oku["sayi"]) == 1)
                {
                    tc_musteride_eklimi = true;
                }
            }

            tc_kayit_Oku.Close();
            frmAnaForm.sql_Baglanti.Close();

            if (tc_musteride_eklimi)
            {
                SQLiteCommand tc_sorgula_rezervasyon = new SQLiteCommand("SELECT m_tc_no, g_trh, a_trh FROM rezervasyon WHERE ( m_tc_no = @m_tc_no ) AND ( durum = 'A' OR durum = 'C' )", frmAnaForm.sql_Baglanti);
                tc_sorgula_rezervasyon.Parameters.AddWithValue("@m_tc_no", txt_m_tc.Text);

                SQLiteDataReader tc_kayit_rezervasyon_Oku;

                frmAnaForm.sql_Baglanti.Open();
                tc_kayit_rezervasyon_Oku = tc_sorgula_rezervasyon.ExecuteReader();

                while (tc_kayit_rezervasyon_Oku.Read())
                {
                    if ((Convert.ToDateTime(tc_kayit_rezervasyon_Oku["g_trh"]) > dateTime_Cikis.Value) || (Convert.ToDateTime(tc_kayit_rezervasyon_Oku["a_trh"]) < dateTime_Giris.Value))
                    {
                        //rezervasyon_var_mi = false;
                    }
                    else
                    {
                        rezervasyon_var_mi = true;
                    }
                }

                if (rezervasyon_var_mi)
                {
                    MessageBox.Show(txt_m_tc.Text + " TC’nolu müşteri için bu tarihler arasında bir rezervasyon mevcuttur.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                tc_kayit_rezervasyon_Oku.Close();
                frmAnaForm.sql_Baglanti.Close();
            }
            else
            {
                frmAnaForm.sql_Baglanti.Open();

                SQLiteCommand musteri_ekle = new SQLiteCommand("INSERT INTO musteri(m_tc_no, m_ad, m_soyad, m_cin, m_tel) "
                                                                   + "VALUES (@m_tc_no, @m_ad, @m_soyad, @m_cin, @m_tel)", frmAnaForm.sql_Baglanti);

                musteri_ekle.Parameters.AddWithValue("@m_tc_no", txt_m_tc.Text);
                musteri_ekle.Parameters.AddWithValue("@m_ad", txt_m_ad.Text);
                musteri_ekle.Parameters.AddWithValue("@m_soyad", txt_m_soyad.Text);
                musteri_ekle.Parameters.AddWithValue("@m_cin", cmb_cin.Text);
                musteri_ekle.Parameters.AddWithValue("@m_tel", txt_m_tel.Text);

                musteri_ekle.ExecuteNonQuery();

                frmAnaForm.sql_Baglanti.Close();
            }

            if (!rezervasyon_var_mi)
            {
                frmAnaForm.sql_Baglanti.Open();

                SQLiteCommand rezervasyon_ekle = new SQLiteCommand("INSERT INTO rezervasyon(m_tc_no, oda_no, g_trh, a_trh, hesap, k_id_r, k_id_g, k_id_c, durum)"
                                                           + "VALUES (@m_tc_no, @oda_no, @g_trh, @a_trh, @hesap, @k_id_r, @k_id_g, @k_id_c, @durum)", frmAnaForm.sql_Baglanti);

                string gt = lbl_r_g_y.Text + "-" + lbl_r_g_a.Text + "-" + lbl_r_g_g.Text;
                string ct = lbl_r_c_y.Text + "-" + lbl_r_c_a.Text + "-" + lbl_r_c_g.Text;

                rezervasyon_ekle.Parameters.AddWithValue("@m_tc_no", txt_m_tc.Text);
                rezervasyon_ekle.Parameters.AddWithValue("@oda_no", lbl_r_oda.Text);
                rezervasyon_ekle.Parameters.AddWithValue("@g_trh", gt);
                rezervasyon_ekle.Parameters.AddWithValue("@a_trh", ct);
                rezervasyon_ekle.Parameters.AddWithValue("@hesap", fiyat + (fiyat * (dateTime_Cikis.Value.Subtract(dateTime_Giris.Value)).Days));
                rezervasyon_ekle.Parameters.AddWithValue("@k_id_r", strKullanici);

                if (dateTime_Giris.Value == DateTime.Today)
                {
                    rezervasyon_ekle.Parameters.AddWithValue("@durum", "C");
                    rezervasyon_ekle.Parameters.AddWithValue("@k_id_g", strKullanici);
                    rezervasyon_ekle.Parameters.AddWithValue("@k_id_c", "-");
                }
                else
                {
                    rezervasyon_ekle.Parameters.AddWithValue("@durum", "A");
                    rezervasyon_ekle.Parameters.AddWithValue("@k_id_g", "-");
                    rezervasyon_ekle.Parameters.AddWithValue("@k_id_c", "-");
                }

                if (rezervasyon_ekle.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Rezervasyon başarıyla kaydedildi", "Tebrikler", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txt_m_tc.Text = txt_m_ad.Text = txt_m_soyad.Text = txt_m_tel.Text = txt_m_adres.Text = "";
                    cmb_cin.Text = cmb_il.Text = "";

                    dateTime_Giris.Value = DateTime.Today;
                    dateTime_Cikis.Value = DateTime.Today;

                    lbl_r_g_g.Text = lbl_r_g_a.Text = lbl_r_c_g.Text = lbl_r_c_a.Text = "";
                    lbl_r_g_y.Text = lbl_r_c_y.Text = "";
                    lbl_r_oda.Text = "";
                }

                frmAnaForm.sql_Baglanti.Close();
            }
        }

        private int oda_fiyat(string oda_no)
        {
            int fiyat = 0;
            
            SQLiteCommand oda_fiyat_sorgula = new SQLiteCommand("SELECT o_fiyat FROM oda WHERE oda_no = @oda_no ", frmAnaForm.sql_Baglanti);
            oda_fiyat_sorgula.Parameters.AddWithValue("@oda_no", oda_no);

            SQLiteDataReader fiyat_Oku;

            frmAnaForm.sql_Baglanti.Open();
            fiyat_Oku = oda_fiyat_sorgula.ExecuteReader();

            while (fiyat_Oku.Read())
            {
                fiyat = Convert.ToInt32(fiyat_Oku["o_fiyat"].ToString());
            }

            fiyat_Oku.Close();
            frmAnaForm.sql_Baglanti.Close();
            
            return fiyat;
        }

        public void oda_durumu(DateTime bg, DateTime bc)
        {
            int[] intOdalar_durum = new int[20];


            string strSorgu = "SELECT oda_no " +                    // o tarihde DOLU odaları getirir //
                              "FROM rezervasyon " +
                              "WHERE oda_no IN ( SELECT oda_no " +
                                                    "FROM rezervasyon " +
                                                    "WHERE ( durum = 'A' OR durum = 'C' ) AND ( g_trh <= @bg AND a_trh >= @bg OR g_trh <= @bc AND a_trh >= @bc OR g_trh >= @bg AND a_trh <= @bc ) ) GROUP BY oda_no ";

            SQLiteCommand oda_Listele = new SQLiteCommand(strSorgu, frmAnaForm.sql_Baglanti);
            oda_Listele.Parameters.AddWithValue("@bg", bg);
            oda_Listele.Parameters.AddWithValue("@bc", bc);

            SQLiteDataReader oda_oku;

            frmAnaForm.sql_Baglanti.Open();
            oda_oku = oda_Listele.ExecuteReader();

            while (oda_oku.Read())
            {
                switch (oda_oku["oda_no"].ToString())
                {
                    case "101":
                        intOdalar_durum[0] = 1;
                        break;

                    case "102":
                        intOdalar_durum[1] = 1;
                        break;

                    case "103":
                        intOdalar_durum[2] = 1;
                        break;

                    case "104":
                        intOdalar_durum[3] = 1;
                        break;
                    case "201":
                        intOdalar_durum[4] = 1;
                        break;

                    case "202":
                        intOdalar_durum[5] = 1;
                        break;

                    case "203":
                        intOdalar_durum[6] = 1;
                        break;

                    case "204":
                        intOdalar_durum[7] = 1;
                        break;

                    case "301":
                        intOdalar_durum[8] = 1;
                        break;

                    case "302":
                        intOdalar_durum[9] = 1;
                        break;

                    case "303":
                        intOdalar_durum[10] = 1;
                        break;

                    case "304":
                        intOdalar_durum[11] = 1;
                        break;

                    case "401":
                        intOdalar_durum[12] = 1;
                        break;

                    case "402":
                        intOdalar_durum[13] = 1;
                        break;

                    case "403":
                        intOdalar_durum[14] = 1;
                        break;

                    case "404":
                        intOdalar_durum[15] = 1;
                        break;

                    case "501":
                        intOdalar_durum[16] = 1;
                        break;

                    case "502":
                        intOdalar_durum[17] = 1;
                        break;

                    case "503":
                        intOdalar_durum[18] = 1;
                        break;

                    case "504":
                        intOdalar_durum[19] = 1;
                        break;
                }
            }
            frmAnaForm.sql_Baglanti.Close();

            if (intOdalar_durum[0] == 0) // 101
            {
                oda101.BackColor = Color.Green;
            }
            else
            {
                oda101.BackColor = Color.Red;
            }

            if (intOdalar_durum[1] == 0) // 102
            {
                oda102.BackColor = Color.Green;
            }
            else
            {
                oda102.BackColor = Color.Red;
            }

            if (intOdalar_durum[2] == 0) // 103
            {
                oda103.BackColor = Color.Green;
            }
            else
            {
                oda103.BackColor = Color.Red;
            }

            if (intOdalar_durum[3] == 0) // 104
            {
                oda104.BackColor = Color.Green;
            }
            else
            {
                oda104.BackColor = Color.Red;
            }

            if (intOdalar_durum[4] == 0) // 201
            {
                oda201.BackColor = Color.Green;
            }
            else
            {
                oda201.BackColor = Color.Red;
            }

            if (intOdalar_durum[5] == 0) // 202
            {
                oda202.BackColor = Color.Green;
            }
            else
            {
                oda202.BackColor = Color.Red;
            }

            if (intOdalar_durum[6] == 0) // 203
            {
                oda203.BackColor = Color.Green;
            }
            else
            {
                oda203.BackColor = Color.Red;
            }

            if (intOdalar_durum[7] == 0) // 204
            {
                oda204.BackColor = Color.Green;
            }
            else
            {
                oda204.BackColor = Color.Red;
            }

            if (intOdalar_durum[8] == 0) // 301
            {
                oda301.BackColor = Color.Green;
            }
            else
            {
                oda301.BackColor = Color.Red;
            }

            if (intOdalar_durum[9] == 0) // 302
            {
                oda302.BackColor = Color.Green;
            }
            else
            {
                oda302.BackColor = Color.Red;
            }

            if (intOdalar_durum[10] == 0) // 303
            {
                oda303.BackColor = Color.Green;
            }
            else
            {
                oda303.BackColor = Color.Red;
            }

            if (intOdalar_durum[11] == 0) // 304
            {
                oda304.BackColor = Color.Green;
            }
            else
            {
                oda304.BackColor = Color.Red;
            }

            if (intOdalar_durum[12] == 0) // 401
            {
                oda401.BackColor = Color.Green;
            }
            else
            {
                oda401.BackColor = Color.Red;
            }

            if (intOdalar_durum[13] == 0) // 402
            {
                oda402.BackColor = Color.Green;
            }
            else
            {
                oda402.BackColor = Color.Red;
            }

            if (intOdalar_durum[14] == 0) // 403
            {
                oda403.BackColor = Color.Green;
            }
            else
            {
                oda403.BackColor = Color.Red;
            }

            if (intOdalar_durum[15] == 0) // 404
            {
                oda404.BackColor = Color.Green;
            }
            else
            {
                oda404.BackColor = Color.Red;
            }

            if (intOdalar_durum[16] == 0) // 501
            {
                oda501.BackColor = Color.Green;
            }
            else
            {
                oda501.BackColor = Color.Red;
            }

            if (intOdalar_durum[17] == 0) // 502
            {
                oda502.BackColor = Color.Green;
            }
            else
            {
                oda502.BackColor = Color.Red;
            }

            if (intOdalar_durum[18] == 0) // 503
            {
                oda503.BackColor = Color.Green;
            }
            else
            {
                oda503.BackColor = Color.Red;
            }

            if (intOdalar_durum[19] == 0) // 504
            {
                oda504.BackColor = Color.Green;
            }
            else
            {
                oda504.BackColor = Color.Red;
            }
        }
    }
}
