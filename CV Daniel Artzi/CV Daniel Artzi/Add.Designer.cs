namespace CV_Daniel_Artzi
{
    partial class Add
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
            this.button1 = new System.Windows.Forms.Button();
            this.addStreet1 = new CV_Daniel_Artzi.AddStreet();
            this.addCity1 = new CV_Daniel_Artzi.AddCity();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(19, 185);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(231, 24);
            this.button1.TabIndex = 2;
            this.button1.Text = "הוסף";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // addStreet1
            // 
            this.addStreet1.Location = new System.Drawing.Point(19, 15);
            this.addStreet1.Name = "addStreet1";
            this.addStreet1.Size = new System.Drawing.Size(237, 151);
            this.addStreet1.TabIndex = 4;
            this.addStreet1.Load += new System.EventHandler(this.addStreet1_Load);
            // 
            // addCity1
            // 
            this.addCity1.Location = new System.Drawing.Point(19, 40);
            this.addCity1.Name = "addCity1";
            this.addCity1.Size = new System.Drawing.Size(231, 126);
            this.addCity1.TabIndex = 3;
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(262, 241);
            this.Controls.Add(this.addStreet1);
            this.Controls.Add(this.addCity1);
            this.Controls.Add(this.button1);
            this.Name = "Add";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Add";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private AddCity addCity1;
        private AddStreet addStreet1;
    }
}