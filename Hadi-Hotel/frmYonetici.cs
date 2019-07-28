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
    public partial class frmYonetici : Form
    {

        private frmAnaForm frmAnaForm;

        public frmYonetici(frmAnaForm frmAnaForm)
        {
            InitializeComponent();
            this.frmAnaForm = frmAnaForm;
        }

        public frmYonetici()
        {
            // TODO: Complete member initialization
        }
    }
}
