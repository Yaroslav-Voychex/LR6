using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лабораторна_6
{
    public partial class fTown : Form
    {
        public TheTown TheTown;
        public fTown(TheTown t)
        {
            TheTown = t;
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            TheTown.Name = tbModel.Text.Trim();
            TheTown.Country = tbCountry.Text.Trim();
            TheTown.Type = tbType.Text.Trim();
            TheTown.Printing = tbPrinting.Text;
            TheTown.Warranty = double.Parse(tbWarranty.Text.Trim());
            TheTown.Price = double.Parse(tbPrice.Text.Trim());
            TheTown.Wifi = chbWifi.Checked;
            TheTown.Color = chbColor.Checked;
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void fTown_Load(object sender, EventArgs e)
        {
            if (TheTown != null)
            {
                tbModel.Text = TheTown.Name;
                tbCountry.Text = TheTown.Country;
                tbType.Text = TheTown.Type;
                tbPrinting.Text =  TheTown.Printing;
                tbWarranty.Text = TheTown.Warranty.ToString("0");
                tbPrice.Text = TheTown.Price.ToString("0.00");
                chbWifi.Checked = TheTown.Wifi;
                chbColor.Checked = TheTown.Color;
            }
        }
    }
}
