using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CV_Daniel_Artzi
{
    public class HelpFuncs
    {
        public static void createOrderList(Form form, ComboBox NumDisplay, string kindList)
        {
            Add parent = form as Add;
            NumDisplay.Items.Clear();
            NumDisplay.Items.Add(1);
            if (kindList == "city")
            {
                if (parent.CityList.Count > 0)
                {
                    for (int i = 0; i < parent.CityList.Count; i++)
                    {
                        NumDisplay.Items.Add(i + 2);
                    }
                }
            }
            else
            {
                if (parent.CityStreet.Count > 0)
                {
                    for (int i = 0; i < parent.CityStreet.Count; i++)
                    {
                        NumDisplay.Items.Add(i + 2);
                    }
                }
            }


            NumDisplay.SelectedIndex = 0;
        }

        public static void Create_FlowLayoutPanel_FromItems(object[] uItems, string kindOfShow, FlowLayoutPanel flowLayoutPanel)
        {
            if (uItems != null && uItems.Length > 0)
            {
                if (flowLayoutPanel.Controls.Count > 0)
                    flowLayoutPanel.Controls.Clear();
                if (uItems is UCity[] && kindOfShow == "cities")
                {
                    foreach (UCity u in uItems)
                    {
                        flowLayoutPanel.Controls.Add(u);
                    }
                }

                else if (uItems is UStreet[] && kindOfShow == "streets")
                {
                    foreach (UStreet u in uItems)
                    {
                        flowLayoutPanel.Controls.Add(u);
                    }
                }
            }
        }
    }
}
