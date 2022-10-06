using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing;

namespace CV_Daniel_Artzi
{
    public partial class Program : Form
    {
        private MenuStrip menuStrip2;
        private ToolStripMenuItem צורToolStripMenuItem;
        private ToolStripMenuItem עירToolStripMenuItem;
        private ToolStripMenuItem רחובToolStripMenuItem;
        private ToolStripMenuItem הצגToolStripMenuItem;
        private ToolStripMenuItem עריםToolStripMenuItem;
        private ToolStripMenuItem רחובותלפיעירToolStripMenuItem;
        private ToolStripMenuItem יציאהToolStripMenuItem;

        private List<City> cityList;
        private List<Street> streetList;


        public Program()
        {
            InitializeComponent();
            cityList = new List<City>();
            streetList = new List<Street>();
        }
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Program());
        }

        private void InitializeComponent()
        {
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.צורToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.עירToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.רחובToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.הצגToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.עריםToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.רחובותלפיעירToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.יציאהToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.צורToolStripMenuItem,
            this.הצגToolStripMenuItem,
            this.יציאהToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip2.Size = new System.Drawing.Size(605, 24);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // צורToolStripMenuItem
            // 
            this.צורToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.עירToolStripMenuItem,
            this.רחובToolStripMenuItem});
            this.צורToolStripMenuItem.Image = global::CV_Daniel_Artzi.Properties.Resources.add;
            this.צורToolStripMenuItem.Name = "צורToolStripMenuItem";
            this.צורToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.צורToolStripMenuItem.Text = "צור";
            // 
            // עירToolStripMenuItem
            // 
            this.עירToolStripMenuItem.Name = "עירToolStripMenuItem";
            this.עירToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.עירToolStripMenuItem.Text = "עיר";
            this.עירToolStripMenuItem.Click += new System.EventHandler(this.עירToolStripMenuItem_Click);
            // 
            // רחובToolStripMenuItem
            // 
            this.רחובToolStripMenuItem.Name = "רחובToolStripMenuItem";
            this.רחובToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.רחובToolStripMenuItem.Text = "רחוב";
            this.רחובToolStripMenuItem.Click += new System.EventHandler(this.רחובToolStripMenuItem_Click);
            // 
            // הצגToolStripMenuItem
            // 
            this.הצגToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.עריםToolStripMenuItem,
            this.רחובותלפיעירToolStripMenuItem});
            this.הצגToolStripMenuItem.Image = global::CV_Daniel_Artzi.Properties.Resources.show;
            this.הצגToolStripMenuItem.Name = "הצגToolStripMenuItem";
            this.הצגToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.הצגToolStripMenuItem.Text = "הצג";
            // 
            // עריםToolStripMenuItem
            // 
            this.עריםToolStripMenuItem.Name = "עריםToolStripMenuItem";
            this.עריםToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.עריםToolStripMenuItem.Text = "ערים";
            this.עריםToolStripMenuItem.Click += new System.EventHandler(this.עריםToolStripMenuItem_Click);
            // 
            // רחובותלפיעירToolStripMenuItem
            // 
            this.רחובותלפיעירToolStripMenuItem.Name = "רחובותלפיעירToolStripMenuItem";
            this.רחובותלפיעירToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.רחובותלפיעירToolStripMenuItem.Text = "רחובות לפי עיר";
            this.רחובותלפיעירToolStripMenuItem.Click += new System.EventHandler(this.רחובותלפיעירToolStripMenuItem_Click);
            // 
            // יציאהToolStripMenuItem
            // 
            this.יציאהToolStripMenuItem.Image = global::CV_Daniel_Artzi.Properties.Resources.close;
            this.יציאהToolStripMenuItem.Name = "יציאהToolStripMenuItem";
            this.יציאהToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.יציאהToolStripMenuItem.Text = "יציאה";
            this.יציאהToolStripMenuItem.Click += new System.EventHandler(this.יציאהToolStripMenuItem_Click);
            // 
            // Program
            // 
            this.ClientSize = new System.Drawing.Size(605, 403);
            this.Controls.Add(this.menuStrip2);
            this.IsMdiContainer = true;
            this.Name = "Program";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Elad CRM App";
            this.Load += new System.EventHandler(this.Program_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void עירToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveFormsAndShow("add", "addCity");
        }

        private void רחובToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveFormsAndShow("add", "addStreet");
        }


        private void עריםToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveFormsAndShow("show", "showCities");
        }

        private void רחובותלפיעירToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveFormsAndShow("show", "showStreets");
        }

        private void RemoveFormsAndShow(string AddOrShowForm, string kindAddOrShow)
        {
            // We will go through the open forms and close any form that is not the main form
            // We can't do this in a loop for each
            //Since the transition will be destroyed at the first closing of Open Form
            //Go through the actual amount of Open Forms

            FormCollection FormsOpen = Application.OpenForms;
            for (int i = 0; i < FormsOpen.Count; i++)
            {
                if (FormsOpen[i].Name != "Program")
                    FormsOpen[i].Close();
            }

            // We will check what type of form we would like to show / add
            // And then what kind of add / show -> city / street 
            switch (AddOrShowForm)
            {
                case "add":
                    Add add = new Add(kindAddOrShow, this.cityList, this.streetList);
                    add.MdiParent = this;
                    add.Show();
                    add.Activate();
                    add.Location = new Point((this.Width - add.Width) / 2, 0);
                    break;

                case "show":
                    Show show = new Show(kindAddOrShow, this.cityList, this.streetList);
                    show.MdiParent = this;
                    show.Show();
                    show.Activate();
                    show.Location = new Point((this.Width - show.Width) / 2, 0);
                    break;
            }


        }

        private void יציאהToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public List<City> GetCityList()
        {
            return cityList;
        }
        public void addCityToList(City city)
        {
            cityList.Add(city);
        }


        public List<Street> GetStreetList()
        {
            return streetList;
        }
        public void addStreeToList(Street street)
        {
            streetList.Add(street);
        }

        private void Program_Load(object sender, EventArgs e)
        {
            MdiClient mdiClient;
            foreach (Control control in this.Controls)
            {
                if (control is MdiClient)
                {
                    mdiClient = (MdiClient)control;
                    mdiClient.BackColor = Color.LightSeaGreen;
                    mdiClient.BackgroundImage = Properties.Resources.back;
                    mdiClient.BackgroundImageLayout = ImageLayout.Center;
                }
            }
        }
    }
}
