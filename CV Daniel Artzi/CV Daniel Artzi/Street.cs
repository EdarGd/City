using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV_Daniel_Artzi
{
    public class Street
    {
        private string Name;
        private static int streets = 0;
        private int StreetCodeNow;
        private int Order;

        private int CityCode;

        public Street(string Name, int Order, int CityCode)
        {
            this.Name = Name;
            this.StreetCodeNow = streets;
            streets++;
            this.Order = Order;
            this.CityCode = CityCode;
        }

        public string StreetName
        {
            get { return Name; }
            set { Name = value; }
        }

        public int StreetOrder
        {
            get { return Order; }
            set { Order = value; }
        }

        public int CityCodeNow
        {
            get { return CityCode; }
            set { CityCode = value; }
        }

        public int GetStreetCodeNow()
        { return StreetCodeNow; }



    }
}
