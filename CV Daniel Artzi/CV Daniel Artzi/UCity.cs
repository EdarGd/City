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
    public partial class UCity : UserControl
    {

        public UCity()
        {
            InitializeComponent();
        }


        #region Properties

        private string cityName;
        private int cityOrder;
        private int cityCode;

        #endregion

        private void Name_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        [Category("Custom Props")]
        public string CityName
        {
            get { return cityName; }
            set { cityName = value; Name.Text = value; }
        }

        [Category("Custom Props")]
        public int CityOrder
        {
            get { return cityOrder; }
            set { cityOrder = value; NumDisplay.Text = value.ToString(); }
        }
        [Category("Custom Props")]
        public int CityCode
        {
            get { return cityCode; }
            set { cityCode = value; Code.Text = value.ToString(); }
        }
    }
}
