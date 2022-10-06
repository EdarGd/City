namespace CV_Daniel_Artzi
{
    partial class AddStreet
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Cities = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.NameStreet = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.NumDisplay = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Cities
            // 
            this.Cities.FormattingEnabled = true;
            this.Cities.Location = new System.Drawing.Point(3, 72);
            this.Cities.Name = "Cities";
            this.Cities.Size = new System.Drawing.Size(121, 21);
            this.Cities.TabIndex = 4;
            this.Cities.SelectionChangeCommitted += new System.EventHandler(this.Cities_SelectionChangeCommitted);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Info;
            this.label4.Font = new System.Drawing.Font("ROG Fonts", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(141, 18);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(88, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "שם הרחוב :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Info;
            this.label5.Font = new System.Drawing.Font("ROG Fonts", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(139, 115);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(90, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "סדר הצגה :";
            // 
            // NameStreet
            // 
            this.NameStreet.Location = new System.Drawing.Point(3, 20);
            this.NameStreet.Name = "NameStreet";
            this.NameStreet.Size = new System.Drawing.Size(120, 20);
            this.NameStreet.TabIndex = 8;
            this.NameStreet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NameStreet_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Info;
            this.label6.Font = new System.Drawing.Font("ROG Fonts", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Location = new System.Drawing.Point(151, 70);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(78, 18);
            this.label6.TabIndex = 12;
            this.label6.Text = "שם העיר :";
            // 
            // NumDisplay
            // 
            this.NumDisplay.FormattingEnabled = true;
            this.NumDisplay.Location = new System.Drawing.Point(2, 112);
            this.NumDisplay.Name = "NumDisplay";
            this.NumDisplay.Size = new System.Drawing.Size(121, 21);
            this.NumDisplay.TabIndex = 13;
            // 
            // AddStreet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.NumDisplay);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.NameStreet);
            this.Controls.Add(this.Cities);
            this.Name = "AddStreet";
            this.Size = new System.Drawing.Size(237, 151);
            this.Load += new System.EventHandler(this.AddStreet_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox Cities;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NameStreet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox NumDisplay;
    }
}
