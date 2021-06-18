
namespace DBP_UI
{
    partial class FindnearestHospital
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
            this.Areas = new System.Windows.Forms.ListBox();
            this.Area_label = new System.Windows.Forms.Label();
            this.Hospitals = new System.Windows.Forms.ListBox();
            this.HName_label = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Areas
            // 
            this.Areas.FormattingEnabled = true;
            this.Areas.Location = new System.Drawing.Point(12, 66);
            this.Areas.Name = "Areas";
            this.Areas.Size = new System.Drawing.Size(174, 186);
            this.Areas.TabIndex = 113;
            this.Areas.SelectedIndexChanged += new System.EventHandler(this.Areas_SelectedIndexChanged);
            // 
            // Area_label
            // 
            this.Area_label.AutoSize = true;
            this.Area_label.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Area_label.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Area_label.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Area_label.Location = new System.Drawing.Point(9, 47);
            this.Area_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Area_label.Name = "Area_label";
            this.Area_label.Size = new System.Drawing.Size(39, 14);
            this.Area_label.TabIndex = 111;
            this.Area_label.Text = "Area";
            // 
            // Hospitals
            // 
            this.Hospitals.FormattingEnabled = true;
            this.Hospitals.Location = new System.Drawing.Point(205, 66);
            this.Hospitals.Name = "Hospitals";
            this.Hospitals.Size = new System.Drawing.Size(250, 186);
            this.Hospitals.TabIndex = 115;
            // 
            // HName_label
            // 
            this.HName_label.AutoSize = true;
            this.HName_label.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HName_label.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.HName_label.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HName_label.Location = new System.Drawing.Point(202, 51);
            this.HName_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.HName_label.Name = "HName_label";
            this.HName_label.Size = new System.Drawing.Size(103, 14);
            this.HName_label.TabIndex = 114;
            this.HName_label.Text = "Hospital Name";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(36, 24);
            this.button2.TabIndex = 118;
            this.button2.Text = "<-";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FindnearestHospital
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(509, 264);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Hospitals);
            this.Controls.Add(this.HName_label);
            this.Controls.Add(this.Areas);
            this.Controls.Add(this.Area_label);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FindnearestHospital";
            this.Text = "Find nearest Hospital";
            this.Load += new System.EventHandler(this.FindnearestHospital_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Areas;
        private System.Windows.Forms.Label Area_label;
        private System.Windows.Forms.ListBox Hospitals;
        private System.Windows.Forms.Label HName_label;
        private System.Windows.Forms.Button button2;
    }
}