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
    public partial class AddStreet : UserControl
    {
        public AddStreet()
        {
            InitializeComponent();
        }

        private void NameStreet_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't letter or control like del key
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        Add parent;

        private void AddStreet_Load(object sender, EventArgs e)
        {
            HelpFuncs.createOrderList(this.Parent as Add, NumDisplay, "street");
            parent = this.Parent as Add;
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

        private void Cities_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        public void AddNewStreetFromUC()
        {

            City city = Cities.SelectedItem as City;
            if (city != null)
            {
                string streetName = NameStreet.Text;
                int streetOrder = NumDisplay.SelectedIndex;
                int cityCode = city.getCityCodeNow();
                Street street = new Street(streetName, streetOrder, cityCode);
                parent.addToList("street", street);
                HelpFuncs.createOrderList(this.Parent as Add, NumDisplay, "street");
            }
        }
    }
}
