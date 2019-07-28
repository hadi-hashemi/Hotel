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
    public partial class frmAnaForm : Form
    {

        public int[] masa_durumu = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
        public int[] masa_ve_oda = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
        public int masa_no = -1;

        public SQLiteConnection sql_Baglanti = new SQLiteConnection("Data Source = HotelDB.db3; Version=3");


        public frmAnaForm()
        {
            InitializeComponent();            
        }

        public string kullanici_StripStatus_degis
        {
            get
            {
                return kullanici_StripStatus.Text;
            }
            set
            {
                kullanici_StripStatus.Text = value;
            }
        }

        public string departman_StripStatus_degis
        {
            get
            {
                return departman_StripStatus.Text;
            }
            set
            {
                departman_StripStatus.Text = value;
            }
        }

        private void frmAnaForm_Load(object sender, EventArgs e)
        {
            frmGiris frmGiris = new frmGiris();
            frmGiris.MdiParent = this;
            frmGiris.Show();
        }

        private void cikis_MenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void yonetim_MenuItem_Click(object sender, EventArgs e)
        {
            anaFormu_temizle();

            frmYonetici frmYonetici = new frmYonetici(this);
            frmYonetici.MdiParent = this;
            frmYonetici.Show();
        }

        private void rezervasyon_MenuItem_Click(object sender, EventArgs e)
        {
            anaFormu_temizle();

            frmMRezervasyon frmMGiris = new frmMRezervasyon(this);
            frmMGiris.MdiParent = this;
            frmMGiris.Show();
            frmMGiris.strKullanici = kullanici_StripStatus.Text;

            frmMGiris.oda_durumu(DateTime.Today, DateTime.Today);
        }

        private void m_giris_MenuItem_Click(object sender, EventArgs e)
        {
            anaFormu_temizle();

            frmChekIn frmMGiris = new frmChekIn(this);
            frmMGiris.MdiParent = this;
            frmMGiris.Show();
        }        

        private void m_cikis_MenuItem_Click(object sender, EventArgs e)
        {
            anaFormu_temizle();
            
            frmChekOut frmMCikis = new frmChekOut(this);
            frmMCikis.MdiParent = this;
            frmMCikis.Show();
        }

        private void restoran_MenuItem_Click(object sender, EventArgs e)
        {
            anaFormu_temizle();

            frmRestoran frmRestoran = new frmRestoran(this);
            frmRestoran.MdiParent = this;

            frmRestoran.Show();
        }

        public void anaFormu_temizle()
        {
            lbl1.Enabled = lbl_bildiri.Enabled = false;
            lbl2.Visible = dgv_bildiri.Visible = false;
        }

        public void anaFormu_geriGetir()
        {
            lbl1.Enabled = lbl_bildiri.Enabled = true;
            bildiriler();
        }
        
        private void bildiriler()
        {
            SQLiteCommand rezervasyon_sorgu = new SQLiteCommand("SELECT COUNT(*) AS sayi FROM rezervasyon WHERE g_trh < @g_trh AND durum = 'A' ", sql_Baglanti);
            rezervasyon_sorgu.Parameters.AddWithValue("@g_trh", DateTime.Today);

            SQLiteDataReader rezervasyon_sayi_Oku;

            sql_Baglanti.Open();
            rezervasyon_sayi_Oku = rezervasyon_sorgu.ExecuteReader();

            while (rezervasyon_sayi_Oku.Read())
            {
                if (Convert.ToInt32(rezervasyon_sayi_Oku["sayi"]) != 0)
                {
                    lbl_bildiri.Text = rezervasyon_sayi_Oku["sayi"].ToString();
                    lbl_bildiri.ForeColor = Color.Red;
                    lbl_bildiri.Font = new Font(lbl_bildiri.Font, FontStyle.Bold);
                }
                else
                {
                    lbl_bildiri.Text = "0";
                    lbl_bildiri.ForeColor = Color.Black;
                    lbl_bildiri.Font = new Font(lbl_bildiri.Font, FontStyle.Regular);
                }
            }

            rezervasyon_sayi_Oku.Close();
            sql_Baglanti.Close();
        }

        private void lbl_bildiri_Click(object sender, EventArgs e)
        {
            if (lbl_bildiri.Text != "0")
            {
                sql_Baglanti.Open();

                DataTable Sql_Tablo = new DataTable();

                string strSorgu = "SELECT m.m_tc_no, m_ad, m_soyad, m_tel, oda_no, g_trh, a_trh, hesap " +
                                  "FROM musteri m " +
                                  "INNER JOIN rezervasyon r ON  m.m_tc_no = r.m_tc_no AND g_trh < @g_trh AND durum = 'A' ";

                SQLiteCommand sorgula = new SQLiteCommand(strSorgu, sql_Baglanti);
                sorgula.Parameters.AddWithValue("@g_trh", DateTime.Today);

                SQLiteDataAdapter sanal_tablo = new SQLiteDataAdapter(sorgula);

                sanal_tablo.Fill(Sql_Tablo);

                lbl2.Visible = true;

                dgv_bildiri.Visible = true;
                dgv_bildiri.DataSource = Sql_Tablo;
                dgv_bildiri.Columns["g_trh"].DefaultCellStyle.ForeColor = Color.Red;

                sql_Baglanti.Close();
            }
        }
    }
}
