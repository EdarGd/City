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
    //point to function
    public delegate void add();
    public partial class Add : Form
    {
        // create function to delegate
        public add addItem;

        // list of the current city and street
        List<City> cityList;
        List<Street> streetList;

        public Add(string kindOfAdd, List<City> cityList, List<Street> streetList)
        {
            InitializeComponent();

            this.cityList = cityList;
            this.streetList = streetList;

            addCity1.Hide();
            addStreet1.Hide();
            switch (kindOfAdd)
            {
                case "addCity":
                    addCity1.Show();
                    break;

                case "addStreet":
                    addStreet1.Show();
                    break;
            }
        }

        private void addStreet1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Check if have functions => We'll only want one function to run
            if (this.addItem != null)
            {
                this.addItem = null;
            }

            // Check which kind of UC add open
            if (addCity1.IsHandleCreated)
            {
                this.addItem += new add(addCity1.AddNewCityFromUC);
            }
            else
            {
                this.addItem += new add(addStreet1.AddNewStreetFromUC);
            }
            this.addItem();
        }

        public List<City> CityList
        {
            get { return cityList; }
        }

        public List<Street> CityStreet
        {
            get { return streetList; }
        }

        public void addToList(string kindList, object item)
        {
            if (kindList == "city")
            {
                foreach (City city in cityList)
                {
                    if (city.CityName == (item as City).CityName)
                    {
                        MessageBox.Show($"You cannot create a city with a name that already exists - {city.CityName}");
                        return;
                    }

                    else if (city.CityOrder == (item as City).CityOrder)
                    {
                        MessageBox.Show($"You cannot create a city with a city order that already exists - {city.CityOrder + 1}");
                        return;
                    }
                }
                this.cityList.Add(item as City);
            }
            else
            {
                foreach (Street street in streetList)
                {
                    if (street.StreetName == (item as Street).StreetName)
                    {
                        //check not have the same city code like the another
                        if (street.CityCodeNow == (item as Street).CityCodeNow)
                        {
                            MessageBox.Show($"You cannot create a street with the same name in the same city - {street.StreetName} in {street.CityCodeNow}");
                            return;
                        }
                    }

                    else if (street.StreetOrder == (item as Street).StreetOrder)
                    {
                        MessageBox.Show($"You cannot create a street with a street order that already exists - {street.StreetOrder + 1}");
                        return;
                    }
                }
                this.streetList.Add(item as Street);
            }
            MessageBox.Show("Add successfully!");
        }
    }
}
