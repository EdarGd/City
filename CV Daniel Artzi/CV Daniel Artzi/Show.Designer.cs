namespace CV_Daniel_Artzi
{
    partial class Show
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.uStreet1 = new CV_Daniel_Artzi.UStreet();
            this.uCity1 = new CV_Daniel_Artzi.UCity();
            this.chooseCityShow1 = new CV_Daniel_Artzi.ChooseCityShow();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(30, 23);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(450, 195);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // uStreet1
            // 
            this.uStreet1.CityCode = 0;
            this.uStreet1.Location = new System.Drawing.Point(100, 12);
            this.uStreet1.Name = "uStreet1";
            this.uStreet1.Size = new System.Drawing.Size(337, 134);
            this.uStreet1.StreetCode = 0;
            this.uStreet1.StreetName = null;
            this.uStreet1.StreetOrder = 0;
            this.uStreet1.TabIndex = 1;
            // 
            // uCity1
            // 
            this.uCity1.CityCode = 0;
            this.uCity1.CityName = null;
            this.uCity1.CityOrder = 0;
            this.uCity1.Location = new System.Drawing.Point(30, 59);
            this.uCity1.Name = "uCity1";
            this.uCity1.Size = new System.Drawing.Size(432, 111);
            this.uCity1.TabIndex = 0;
            // 
            // chooseCityShow1
            // 
            this.chooseCityShow1.Location = new System.Drawing.Point(3, 3);
            this.chooseCityShow1.Name = "chooseCityShow1";
            this.chooseCityShow1.Size = new System.Drawing.Size(242, 172);
            this.chooseCityShow1.TabIndex = 4;
            // 
            // Show
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 246);
            this.Controls.Add(this.chooseCityShow1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.uStreet1);
            this.Controls.Add(this.uCity1);
            this.Name = "Show";
            this.Text = "Show";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private UCity uCity1;
        private UStreet uStreet1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private ChooseCityShow chooseCityShow1;
    }
}