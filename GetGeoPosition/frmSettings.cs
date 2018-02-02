using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GetGeoPosition
{
    public partial class frmSettings : Form
    {
        public frmSettings()
        {
            InitializeComponent();
            LoadSettings();
        }

        private void LoadSettings()
        {
            Settings.LoadSettings();
            txt_url.Text = Settings.url;
            txt_api_key.Text = Settings.api_key;

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            Settings.url = txt_url.Text;
            Settings.api_key = txt_api_key.Text;
            Settings.SaveSettings();
        }
    }
}
