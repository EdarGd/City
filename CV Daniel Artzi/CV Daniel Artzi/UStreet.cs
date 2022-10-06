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
    public partial class UStreet : UserControl
    {
        public UStreet()
        {
            InitializeComponent();
        }

        #region Properties

        private string streetName;
        private int streetCode;
        private int streetOrder;
        private int cityCode;

        #endregion

        [Category("Custom Props")]
        public string StreetName
        {
            get { return streetName; }
            set { streetName = value; Name.Text = value; }
        }

        [Category("Custom Props")]
        public int StreetCode
        {
            get { return streetCode; }
            set { streetCode = value; Code.Text = value.ToString(); }
        }
        [Category("Custom Props")]
        public int StreetOrder
        {
            get { return streetOrder; }
            set { streetOrder = value; NumDisplay.Text = value.ToString(); }
        }

        [Category("Custom Props")]
        public int CityCode
        {
            get { return cityCode; }
            set { cityCode = value; }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
