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
    public partial class Show : Form
    {
        List<City> cityList;
        List<Street> streetList;

        // create function to delegate
        //public ShowStreets showStreets;

        public Show(string kindOfShow, List<City> cityList, List<Street> streetList)
        {
            InitializeComponent();
            this.cityList = cityList;
            this.streetList = streetList;
            uCity1.Hide();
            uStreet1.Hide();
            flowLayoutPanel1.Hide();
            chooseCityShow1.Hide();
            switch (kindOfShow)
            {
                case "showCities":
                    int itemsCount = cityList.Count;
                    UCity[] cities = new UCity[itemsCount];
                    int iCity = 0;
                    foreach (City city in cityList)
                    {
                        cities[iCity] = new UCity();
                        cities[iCity].CityName = city.CityName;
                        cities[iCity].CityCode = city.getCityCodeNow();
                        cities[iCity].CityOrder = city.CityOrder;
                        iCity++;

                    }
                    flowLayoutPanel1.Show();
                    HelpFuncs.Create_FlowLayoutPanel_FromItems(cities, "cities", flowLayoutPanel1);
                    break;

                case "showStreets":
                    chooseCityShow1.Show();


                    //chooseCity1.Show();
                    break;
            }




        }

        //        private void Create_FlowLayoutPanel_FromItems(object [] items)
        //        {
        //            Type valueType = items.GetType();
        //            if(valueType.IsArray)
        //            {
        //                if ( && )
        //                {

        //                }
        //}
        //            }

        //        }


        //}

        public void SetStreetsShow(int codeCityShow)
        {
            chooseCityShow1.Hide();
            int streetCount = streetList.Count;
            UStreet[] streets = new UStreet[streetCount];
            int iStreet = 0;
            foreach (Street street in streetList)
            {
                if (street.CityCodeNow == codeCityShow)
                {
                    streets[iStreet] = new UStreet();
                    streets[iStreet].StreetName = street.StreetName;
                    streets[iStreet].StreetCode = street.GetStreetCodeNow();
                    streets[iStreet].StreetOrder = street.StreetOrder;
                }

                iStreet++;

            }

            HelpFuncs.Create_FlowLayoutPanel_FromItems(streets, "streets", flowLayoutPanel1);
            flowLayoutPanel1.Show();
        }

        public List<City> CityList
        {
            get { return cityList; }
        }

        public List<Street> CityStreet
        {
            get { return streetList; }
        }

    }
}
