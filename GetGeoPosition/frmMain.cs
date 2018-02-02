using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GetGeoPosition
{
    public partial class frmMain : Form
    {
        Rootobject rootobject;
        public frmMain()
        {
            InitializeComponent();
            LoadSettings();
        }

        private void LoadSettings()
        {
            Settings.LoadSettings();
        }

        private void btn_settings_Click(object sender, EventArgs e)
        {
            frmSettings frmSettings = new frmSettings();
            frmSettings.ShowDialog();
            LoadSettings();
        }

        private void btn_get_geo_position_Click(object sender, EventArgs e)
        {
            string street = txt_street.Text;
            string area = txt_area.Text;
            string city = txt_city.Text;
            string postal = txt_postal_code.Text;

            string urlbuild = string.Format($"{Settings.url}{street}+{area}+{city}+{postal}&key={Settings.api_key}");

            GetGeo(urlbuild);
        }

        private async void GetGeo(string url)
        {
            using (HttpClient http = new HttpClient())
            {
                using (HttpResponseMessage resp = await http.GetAsync(url))
                {
                    using (HttpContent content = resp.Content)
                    {
                        string json = await content.ReadAsStringAsync();
                        if(content.ReadAsStringAsync().IsCompleted)
                        {
                            JsonParse(json);
                        }
                    }
                }

            }
        }

        private void JsonParse(string json)
        {
            rootobject = Newtonsoft.Json.JsonConvert.DeserializeObject<Rootobject>(json);
            ShowInUI();
        }

        private void ShowInUI()
        {
            txt_lat.Text = rootobject.results[0].geometry.location.lat.ToString();
            txt_long.Text = rootobject.results[0].geometry.location.lng.ToString();
        }
    }
}
