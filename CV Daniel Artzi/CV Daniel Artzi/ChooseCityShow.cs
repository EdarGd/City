using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CV_Daniel_Artzi
{
    public partial class ChooseCityShow : UserControl
    {
        public ChooseCityShow()
        {
            InitializeComponent();
        }

        Show parent;

        private void ChooseCityShow_Load(object sender, EventArgs e)
        {
            parent = this.Parent as Show;
            List<City> cities = parent.CityList;
            if (cities.Count == 0)
            {
                MessageBox.Show("Oh no, there are no more cities !");
                return;
            }
            Cities.DataSource = cities;
            Cities.ValueMember = "cityName";
            Cities.DisplayMember = "cityName";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            City city = Cities.SelectedItem as City;
            if (city != null)
            {
                int cityCode = city.getCityCodeNow();
                parent.SetStreetsShow(cityCode);
            }
        }
    }
}
