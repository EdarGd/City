namespace CV_Daniel_Artzi
{
    partial class ChooseCity
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
            this.button1 = new System.Windows.Forms.Button();
            this.Cities = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.Font = new System.Drawing.Font("ROG Fonts", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Info;
            this.button1.Location = new System.Drawing.Point(46, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(208, 28);
            this.button1.TabIndex = 2;
            this.button1.Text = "הצג ";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Cities
            // 
            this.Cities.FormattingEnabled = true;
            this.Cities.Location = new System.Drawing.Point(88, 72);
            this.Cities.Name = "Cities";
            this.Cities.Size = new System.Drawing.Size(121, 21);
            this.Cities.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "בחר עיר מהרשימה\r\n כדי להציג את הרחובות";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ChooseCity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Cities);
            this.Controls.Add(this.label1);
            this.Name = "ChooseCity";
            this.Size = new System.Drawing.Size(291, 152);
            this.Load += new System.EventHandler(this.ChooseCity_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox Cities;
        private System.Windows.Forms.Label label1;
    }
}
