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
    public partial class frmGiris : Form
    {

        frmAnaForm frmAnaForm = new frmAnaForm();
        
        public frmGiris()
        {
            InitializeComponent();
        }

        private void frmGiris_Load(object sender, EventArgs e)
        {
            kullanici_Combobox_item();
        }
        
        private void cmb_id_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_pass.Focus();
        }

        private void txt_pass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                girilen_sifre_Karsilastir();
            }
        }

        private void kullanici_Combobox_item()
        {
            SQLiteCommand kullanici_Listele = new SQLiteCommand("SELECT k_id FROM kullanici", frmAnaForm.sql_Baglanti);

            frmAnaForm.sql_Baglanti.Open();
            SQLiteDataReader listeden_Oku = kullanici_Listele.ExecuteReader();

            while (listeden_Oku.Read())
            {
                if (listeden_Oku["k_id"].ToString() != "-")
                {
                    cmb_id.Items.Add(listeden_Oku["k_id"].ToString());
                }
            }

            listeden_Oku.Close();
            frmAnaForm.sql_Baglanti.Close();
        }

        private void girilen_sifre_Karsilastir()
        {

            SQLiteCommand sifre_Getir = new SQLiteCommand("SELECT k_pass, k_dep FROM kullanici WHERE k_id = @k_id", frmAnaForm.sql_Baglanti);
            sifre_Getir.Parameters.AddWithValue("@k_id", cmb_id.SelectedItem.ToString());

            frmAnaForm.sql_Baglanti.Open();
            SQLiteDataReader sifre_Oku = sifre_Getir.ExecuteReader();

            while (sifre_Oku.Read())
            {
                if (sifre_Oku["k_pass"].ToString() == txt_pass.Text)
                {
                    frmAnaForm frmAna = ParentForm as frmAnaForm;
                    frmAna.kullanici_StripStatus_degis = cmb_id.SelectedItem.ToString();

                    departman(sifre_Oku["k_dep"].ToString());

                    this.Hide();
                }
                else
                {
                    txt_pass.Text = "";
                }
            }

            sifre_Oku.Close();
            frmAnaForm.sql_Baglanti.Close();
        }

        private void departman(string strDep)
        {
            frmAnaForm frmAna = ParentForm as frmAnaForm;
            
            switch (strDep)
            {
                case "Resepsiyon":
                    frmAna.departman_StripStatus_degis = strDep;
                    frmAna.rezervasyon_MenuItem.Enabled = true;
                    frmAna.m_giris_MenuItem.Enabled = true;
                    frmAna.m_cikis_MenuItem.Enabled = true;
                    frmAna.anaFormu_geriGetir();
                    break;

                case "Restoran":
                    frmAna.departman_StripStatus_degis = strDep;
                    frmAna.restoran_MenuItem.Enabled = true;
                    break;

                case "Yonetim":
                    frmAna.departman_StripStatus_degis = strDep;
                    frmAna.yonetim_MenuItem.Enabled = true;
                    break;
            }
        }
    }
}
