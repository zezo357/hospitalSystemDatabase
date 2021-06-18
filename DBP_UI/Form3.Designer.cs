
namespace DBP_UI
{
    partial class Department
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
            this.DRecord_button = new System.Windows.Forms.Button();
            this.DDName_textBox = new System.Windows.Forms.TextBox();
            this.Height_label = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.Button();
            this.Depratments_avaliable_names = new System.Windows.Forms.ListBox();
            this.HDName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DRecord_button
            // 
            this.DRecord_button.BackColor = System.Drawing.Color.Teal;
            this.DRecord_button.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DRecord_button.ForeColor = System.Drawing.Color.Ivory;
            this.DRecord_button.Location = new System.Drawing.Point(50, 97);
            this.DRecord_button.Margin = new System.Windows.Forms.Padding(2);
            this.DRecord_button.Name = "DRecord_button";
            this.DRecord_button.Size = new System.Drawing.Size(132, 42);
            this.DRecord_button.TabIndex = 83;
            this.DRecord_button.Text = "Add Record";
            this.DRecord_button.UseVisualStyleBackColor = false;
            this.DRecord_button.Click += new System.EventHandler(this.DRecord_button_Click);
            // 
            // DDName_textBox
            // 
            this.DDName_textBox.Location = new System.Drawing.Point(50, 52);
            this.DDName_textBox.Margin = new System.Windows.Forms.Padding(2);
            this.DDName_textBox.Name = "DDName_textBox";
            this.DDName_textBox.Size = new System.Drawing.Size(132, 20);
            this.DDName_textBox.TabIndex = 82;
            // 
            // Height_label
            // 
            this.Height_label.AutoSize = true;
            this.Height_label.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Height_label.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Height_label.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Height_label.Location = new System.Drawing.Point(47, 12);
            this.Height_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Height_label.Name = "Height_label";
            this.Height_label.Size = new System.Drawing.Size(128, 14);
            this.Height_label.TabIndex = 81;
            this.Height_label.Text = "Department Name";
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(12, 12);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(28, 29);
            this.Back.TabIndex = 84;
            this.Back.Text = "<-";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Depratments_avaliable_names
            // 
            this.Depratments_avaliable_names.FormattingEnabled = true;
            this.Depratments_avaliable_names.Location = new System.Drawing.Point(222, 30);
            this.Depratments_avaliable_names.Name = "Depratments_avaliable_names";
            this.Depratments_avaliable_names.Size = new System.Drawing.Size(150, 121);
            this.Depratments_avaliable_names.TabIndex = 120;
            // 
            // HDName
            // 
            this.HDName.AutoSize = true;
            this.HDName.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HDName.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.HDName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HDName.Location = new System.Drawing.Point(219, 9);
            this.HDName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.HDName.Name = "HDName";
            this.HDName.Size = new System.Drawing.Size(93, 14);
            this.HDName.TabIndex = 119;
            this.HDName.Text = "Departments";
            // 
            // Department
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(384, 164);
            this.Controls.Add(this.Depratments_avaliable_names);
            this.Controls.Add(this.HDName);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.DRecord_button);
            this.Controls.Add(this.DDName_textBox);
            this.Controls.Add(this.Height_label);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Department";
            this.Text = "Department";
            this.Load += new System.EventHandler(this.Department_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DRecord_button;
        private System.Windows.Forms.TextBox DDName_textBox;
        private System.Windows.Forms.Label Height_label;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.ListBox Depratments_avaliable_names;
        private System.Windows.Forms.Label HDName;
    }
}