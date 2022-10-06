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
    public partial class AddCity : UserControl
    {
        public AddCity()
        {
            InitializeComponent();
        }

        private void NameCity_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't letter or control like del key
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        Add parent;
        private void AddCity_Load(object sender, EventArgs e)
        {
            HelpFuncs.createOrderList(this.Parent as Add, NumDisplay, "city");
            parent = this.Parent as Add;
        }

        public void AddNewCityFromUC()
        {
            string cityName = NameCity.Text;
            int cityOrder = NumDisplay.SelectedIndex;
            City city = new City(cityName, cityOrder);
            parent.addToList("city", city);
            HelpFuncs.createOrderList(this.Parent as Add, NumDisplay, "city");
        }

        //private void createOrderLists()
        //{
        //    parent = this.Parent as Add;
        //    NumDisplay.Items.Clear();
        //    NumDisplay.Items.Add(1);
        //    if (parent.CityList.Count > 0)
        //    {
        //        for (int i = 0; i < parent.CityList.Count; i++)
        //        {
        //            NumDisplay.Items.Add(i + 2);
        //        }
        //    }

        //    NumDisplay.SelectedIndex = 0;
        //}
    }
}
