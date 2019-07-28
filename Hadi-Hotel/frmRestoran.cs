using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Hadi_Hotel
{
    public partial class frmRestoran : Form
    {        
        private frmAnaForm frmAnaForm;
        
        public frmRestoran(frmAnaForm frmAnaForm)
        {
            InitializeComponent();
            this.frmAnaForm = frmAnaForm;
        }

        public frmRestoran()
        {
            // TODO: Complete member initialization
        }

        private void frmRestoran_Load(object sender, EventArgs e)
        {
            masa_durum(frmAnaForm.masa_durumu);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            masa_durum(frmAnaForm.masa_durumu);
        }

        private void siparis_al(int masa_no)
        {
            frmAnaForm.masa_no = masa_no;
            frmSiparis frmSiparis = new frmSiparis(frmAnaForm);
            frmSiparis.Show();            
        }

        public void masa_durum(int[] masadurumu)
        {
            int[] masa_durumu = masadurumu;

            for (int i = 0; i < masa_durumu.Length; i++)
            {
                switch (i)
                {
                    case 0:

                        if (masa_durumu[0] == 0)
                        {
                            btn_masa_1.BackgroundImage = Properties.Resources.bm;
                        }
                        else
                        {
                            btn_masa_1.BackgroundImage = Properties.Resources.dm;
                        }
                        break;

                    case 1:

                        if (masa_durumu[1] == 0)
                        {
                            btn_masa_2.BackgroundImage = Properties.Resources.bm;
                        }
                        else
                        {
                            btn_masa_2.BackgroundImage = Properties.Resources.dm;
                        }
                        break;

                    case 2:

                        if (masa_durumu[2] == 0)
                        {
                            btn_masa_3.BackgroundImage = Properties.Resources.bm;
                        }
                        else
                        {
                            btn_masa_3.BackgroundImage = Properties.Resources.dm;
                        }
                        break;

                    case 3:

                        if (masa_durumu[3] == 0)
                        {
                            btn_masa_4.BackgroundImage = Properties.Resources.bm;
                        }
                        else
                        {
                            btn_masa_4.BackgroundImage = Properties.Resources.dm;
                        }
                        break;

                    case 4:

                        if (masa_durumu[4] == 0)
                        {
                            btn_masa_5.BackgroundImage = Properties.Resources.bm;
                        }
                        else
                        {
                            btn_masa_5.BackgroundImage = Properties.Resources.dm;
                        }
                        break;

                    case 5:

                        if (masa_durumu[5] == 0)
                        {
                            btn_masa_6.BackgroundImage = Properties.Resources.bm;
                        }
                        else
                        {
                            btn_masa_6.BackgroundImage = Properties.Resources.dm;
                        }
                        break;

                    case 6:

                        if (masa_durumu[6] == 0)
                        {
                            btn_masa_7.BackgroundImage = Properties.Resources.bm;
                        }
                        else
                        {
                            btn_masa_7.BackgroundImage = Properties.Resources.dm;
                        }
                        break;

                    case 7:

                        if (masa_durumu[7] == 0)
                        {
                            btn_masa_8.BackgroundImage = Properties.Resources.bm;
                        }
                        else
                        {
                            btn_masa_8.BackgroundImage = Properties.Resources.dm;
                        }
                        break;

                    case 8:

                        if (masa_durumu[8] == 0)
                        {
                            btn_masa_9.BackgroundImage = Properties.Resources.bm;
                        }
                        else
                        {
                            btn_masa_9.BackgroundImage = Properties.Resources.dm;
                        }
                        break;

                    case 9:

                        if (masa_durumu[9] == 0)
                        {
                            btn_masa_10.BackgroundImage = Properties.Resources.bm;
                        }
                        else
                        {
                            btn_masa_10.BackgroundImage = Properties.Resources.dm;
                        }
                        break;

                    case 10:

                        if (masa_durumu[10] == 0)
                        {
                            btn_masa_11.BackgroundImage = Properties.Resources.bm;
                        }
                        else
                        {
                            btn_masa_11.BackgroundImage = Properties.Resources.dm;
                        }
                        break;

                    case 11:

                        if (masa_durumu[11] == 0)
                        {
                            btn_masa_12.BackgroundImage = Properties.Resources.bm;
                        }
                        else
                        {
                            btn_masa_12.BackgroundImage = Properties.Resources.dm;
                        }
                        break;

                    case 12:

                        if (masa_durumu[12] == 0)
                        {
                            btn_masa_13.BackgroundImage = Properties.Resources.bm;
                        }
                        else
                        {
                            btn_masa_13.BackgroundImage = Properties.Resources.dm;
                        }
                        break;

                    case 13:

                        if (masa_durumu[13] == 0)
                        {
                            btn_masa_14.BackgroundImage = Properties.Resources.bm;
                        }
                        else
                        {
                            btn_masa_14.BackgroundImage = Properties.Resources.dm;
                        }
                        break;

                    case 14:

                        if (masa_durumu[14] == 0)
                        {
                            btn_masa_15.BackgroundImage = Properties.Resources.bm;
                        }
                        else
                        {
                            btn_masa_15.BackgroundImage = Properties.Resources.dm;
                        }
                        break;

                    case 15:

                        if (masa_durumu[15] == 0)
                        {
                            btn_masa_16.BackgroundImage = Properties.Resources.bm;
                        }
                        else
                        {
                            btn_masa_16.BackgroundImage = Properties.Resources.dm;
                        }
                        break;

                    case 16:

                        if (masa_durumu[16] == 0)
                        {
                            btn_masa_17.BackgroundImage = Properties.Resources.bm;
                        }
                        else
                        {
                            btn_masa_17.BackgroundImage = Properties.Resources.dm;
                        }
                        break;

                    case 17:

                        if (masa_durumu[17] == 0)
                        {
                            btn_masa_18.BackgroundImage = Properties.Resources.bm;
                        }
                        else
                        {
                            btn_masa_18.BackgroundImage = Properties.Resources.dm;
                        }
                        break;

                    case 18:

                        if (masa_durumu[18] == 0)
                        {
                            btn_masa_19.BackgroundImage = Properties.Resources.bm;
                        }
                        else
                        {
                            btn_masa_19.BackgroundImage = Properties.Resources.dm;
                        }
                        break;

                    case 19:

                        if (masa_durumu[19] == 0)
                        {
                            btn_masa_20.BackgroundImage = Properties.Resources.bm;
                        }
                        else
                        {
                            btn_masa_20.BackgroundImage = Properties.Resources.dm;
                        }
                        break;
                }

            }
        }

        private void btn_masa_1_Click(object sender, EventArgs e)
        {
            siparis_al(0);
        }

        private void btn_masa_2_Click(object sender, EventArgs e)
        {
            siparis_al(1);
        }

        private void btn_masa_3_Click(object sender, EventArgs e)
        {
            siparis_al(2);
        }

        private void btn_masa_4_Click(object sender, EventArgs e)
        {
            siparis_al(3);
        }

        private void btn_masa_5_Click(object sender, EventArgs e)
        {
            siparis_al(4);
        }

        private void btn_masa_6_Click(object sender, EventArgs e)
        {
            siparis_al(5);
        }

        private void btn_masa_7_Click(object sender, EventArgs e)
        {
            siparis_al(6);
        }

        private void btn_masa_8_Click(object sender, EventArgs e)
        {
            siparis_al(7);
        }

        private void btn_masa_9_Click(object sender, EventArgs e)
        {
            siparis_al(8);
        }

        private void btn_masa_10_Click(object sender, EventArgs e)
        {
            siparis_al(9);
        }

        private void btn_masa_11_Click(object sender, EventArgs e)
        {
            siparis_al(10);
        }

        private void btn_masa_12_Click(object sender, EventArgs e)
        {
            siparis_al(11);
        }

        private void btn_masa_13_Click(object sender, EventArgs e)
        {
            siparis_al(12);
        }

        private void btn_masa_14_Click(object sender, EventArgs e)
        {
            siparis_al(13);
        }

        private void btn_masa_15_Click(object sender, EventArgs e)
        {
            siparis_al(14);
        }

        private void btn_masa_16_Click(object sender, EventArgs e)
        {
            siparis_al(15);
        }

        private void btn_masa_17_Click(object sender, EventArgs e)
        {
            siparis_al(16);
        }

        private void btn_masa_18_Click(object sender, EventArgs e)
        {
            siparis_al(17);
        }

        private void btn_masa_19_Click(object sender, EventArgs e)
        {
            siparis_al(18);
        }

        private void btn_masa_20_Click(object sender, EventArgs e)
        {
            siparis_al(19);
        }

        
    }
}
