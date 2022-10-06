using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV_Daniel_Artzi
{
    public class City
    {

        #region Properties
        private static int citiyCount = 0;
        private int cityCodeNow = 0;
        //private readonly string cityName;
        //private readonly int cityOrder;

        private string cityName;
        private int cityOrder;

        #endregion
        public string CityName
        {
            get { return cityName; }
            set { cityName = value; }
        }

        public int CityOrder
        {
            get { return cityOrder; }
            set { cityOrder = value; }
        }
        public City(string cityName, int cityOrder)
        {
            this.cityName = cityName;
            citiyCount++;
            this.cityOrder = cityOrder;
            this.cityCodeNow = citiyCount;
        }


        public int getCityCodeNow()
        {
            return cityCodeNow;
        }

    }
}
