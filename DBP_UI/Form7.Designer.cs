
namespace DBP_UI
{
    partial class Doctor
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
            this.DoRecord_button = new System.Windows.Forms.Button();
            this.DODoctorName_textBox = new System.Windows.Forms.TextBox();
            this.DODoctorName_label = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Depratments_avaliable_names = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.Departments = new System.Windows.Forms.ListBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DoRecord_button
            // 
            this.DoRecord_button.BackColor = System.Drawing.Color.Teal;
            this.DoRecord_button.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoRecord_button.ForeColor = System.Drawing.Color.Ivory;
            this.DoRecord_button.Location = new System.Drawing.Point(79, 106);
            this.DoRecord_button.Margin = new System.Windows.Forms.Padding(2);
            this.DoRecord_button.Name = "DoRecord_button";
            this.DoRecord_button.Size = new System.Drawing.Size(132, 42);
            this.DoRecord_button.TabIndex = 94;
            this.DoRecord_button.Text = "Add Record";
            this.DoRecord_button.UseVisualStyleBackColor = false;
            this.DoRecord_button.Click += new System.EventHandler(this.DoRecord_button_Click);
            // 
            // DODoctorName_textBox
            // 
            this.DODoctorName_textBox.Location = new System.Drawing.Point(79, 58);
            this.DODoctorName_textBox.Margin = new System.Windows.Forms.Padding(2);
            this.DODoctorName_textBox.Name = "DODoctorName_textBox";
            this.DODoctorName_textBox.Size = new System.Drawing.Size(132, 20);
            this.DODoctorName_textBox.TabIndex = 93;
            // 
            // DODoctorName_label
            // 
            this.DODoctorName_label.AutoSize = true;
            this.DODoctorName_label.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DODoctorName_label.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.DODoctorName_label.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DODoctorName_label.Location = new System.Drawing.Point(76, 42);
            this.DODoctorName_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DODoctorName_label.Name = "DODoctorName_label";
            this.DODoctorName_label.Size = new System.Drawing.Size(90, 14);
            this.DODoctorName_label.TabIndex = 92;
            this.DODoctorName_label.Text = "Doctor Name";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 23);
            this.button1.TabIndex = 97;
            this.button1.Text = "<-";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Depratments_avaliable_names
            // 
            this.Depratments_avaliable_names.FormattingEnabled = true;
            this.Depratments_avaliable_names.Location = new System.Drawing.Point(290, 26);
            this.Depratments_avaliable_names.Name = "Depratments_avaliable_names";
            this.Depratments_avaliable_names.Size = new System.Drawing.Size(132, 43);
            this.Depratments_avaliable_names.TabIndex = 125;
            this.Depratments_avaliable_names.SelectedIndexChanged += new System.EventHandler(this.Depratments_avaliable_names_SelectedIndexChanged);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkRed;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.Control;
            this.button3.Location = new System.Drawing.Point(290, 169);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(135, 24);
            this.button3.TabIndex = 124;
            this.button3.Text = "Delete Selected";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Departments
            // 
            this.Departments.FormattingEnabled = true;
            this.Departments.HorizontalScrollbar = true;
            this.Departments.Location = new System.Drawing.Point(290, 106);
            this.Departments.Name = "Departments";
            this.Departments.Size = new System.Drawing.Size(134, 56);
            this.Departments.TabIndex = 123;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Teal;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.Control;
            this.button4.Location = new System.Drawing.Point(290, 76);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(135, 23);
            this.button4.TabIndex = 122;
            this.button4.Text = "Add Department ";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(287, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 14);
            this.label1.TabIndex = 121;
            this.label1.Text = "Departments";
            // 
            // Doctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(437, 208);
            this.Controls.Add(this.Depratments_avaliable_names);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Departments);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DoRecord_button);
            this.Controls.Add(this.DODoctorName_textBox);
            this.Controls.Add(this.DODoctorName_label);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Doctor";
            this.Text = "Doctor";
            this.Load += new System.EventHandler(this.Doctor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DoRecord_button;
        private System.Windows.Forms.TextBox DODoctorName_textBox;
        private System.Windows.Forms.Label DODoctorName_label;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox Depratments_avaliable_names;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox Departments;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
    }
}