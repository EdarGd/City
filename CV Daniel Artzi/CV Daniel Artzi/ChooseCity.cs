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
    public partial class ChooseCity : UserControl
    {
        public ChooseCity()
        {
            InitializeComponent();
        }

        Show parent;
        private void ChooseCity_Load(object sender, EventArgs e)
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
    }
}
