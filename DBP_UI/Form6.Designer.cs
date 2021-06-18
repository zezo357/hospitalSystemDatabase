
namespace DBP_UI
{
    partial class BILL
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
            this.BiRecord_button = new System.Windows.Forms.Button();
            this.BiBiLL_Price_label = new System.Windows.Forms.Label();
            this.BiPatientName_label = new System.Windows.Forms.Label();
            this.Search = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.patientName = new System.Windows.Forms.Label();
            this.Bill_Price = new System.Windows.Forms.Label();
            this.Treatments = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BiRecord_button
            // 
            this.BiRecord_button.BackColor = System.Drawing.Color.Teal;
            this.BiRecord_button.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BiRecord_button.ForeColor = System.Drawing.Color.Ivory;
            this.BiRecord_button.Location = new System.Drawing.Point(496, 38);
            this.BiRecord_button.Margin = new System.Windows.Forms.Padding(2);
            this.BiRecord_button.Name = "BiRecord_button";
            this.BiRecord_button.Size = new System.Drawing.Size(90, 62);
            this.BiRecord_button.TabIndex = 94;
            this.BiRecord_button.Text = "Create bill";
            this.BiRecord_button.UseVisualStyleBackColor = false;
            this.BiRecord_button.Click += new System.EventHandler(this.BiRecord_button_Click);
            // 
            // BiBiLL_Price_label
            // 
            this.BiBiLL_Price_label.AutoSize = true;
            this.BiBiLL_Price_label.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BiBiLL_Price_label.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.BiBiLL_Price_label.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BiBiLL_Price_label.Location = new System.Drawing.Point(337, 73);
            this.BiBiLL_Price_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BiBiLL_Price_label.Name = "BiBiLL_Price_label";
            this.BiBiLL_Price_label.Size = new System.Drawing.Size(79, 14);
            this.BiBiLL_Price_label.TabIndex = 89;
            this.BiBiLL_Price_label.Text = "BiLL Price :";
            // 
            // BiPatientName_label
            // 
            this.BiPatientName_label.AutoSize = true;
            this.BiPatientName_label.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BiPatientName_label.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.BiPatientName_label.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BiPatientName_label.Location = new System.Drawing.Point(337, 10);
            this.BiPatientName_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BiPatientName_label.Name = "BiPatientName_label";
            this.BiPatientName_label.Size = new System.Drawing.Size(107, 14);
            this.BiPatientName_label.TabIndex = 88;
            this.BiPatientName_label.Text = "Patient Name : ";
            this.BiPatientName_label.Click += new System.EventHandler(this.BiPatientID_label_Click);
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(63, 57);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(132, 42);
            this.Search.TabIndex = 95;
            this.Search.Text = "SearchByID";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.SearchByID_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(63, 26);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 20);
            this.textBox1.TabIndex = 97;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(60, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 14);
            this.label1.TabIndex = 96;
            this.label1.Text = "Patient ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(2, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(44, 26);
            this.button1.TabIndex = 99;
            this.button1.Text = "<-";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(337, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 14);
            this.label2.TabIndex = 100;
            this.label2.Text = "Days : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(394, 37);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 14);
            this.label3.TabIndex = 101;
            // 
            // patientName
            // 
            this.patientName.AutoSize = true;
            this.patientName.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientName.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.patientName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.patientName.Location = new System.Drawing.Point(448, 10);
            this.patientName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.patientName.Name = "patientName";
            this.patientName.Size = new System.Drawing.Size(0, 14);
            this.patientName.TabIndex = 104;
            // 
            // Bill_Price
            // 
            this.Bill_Price.AutoSize = true;
            this.Bill_Price.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bill_Price.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Bill_Price.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Bill_Price.Location = new System.Drawing.Point(420, 73);
            this.Bill_Price.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Bill_Price.Name = "Bill_Price";
            this.Bill_Price.Size = new System.Drawing.Size(0, 14);
            this.Bill_Price.TabIndex = 106;
            // 
            // Treatments
            // 
            this.Treatments.FormattingEnabled = true;
            this.Treatments.Location = new System.Drawing.Point(211, 25);
            this.Treatments.Name = "Treatments";
            this.Treatments.Size = new System.Drawing.Size(120, 82);
            this.Treatments.TabIndex = 107;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(208, 8);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 14);
            this.label4.TabIndex = 108;
            this.label4.Text = "TreatMents";
            // 
            // BILL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(597, 111);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Treatments);
            this.Controls.Add(this.Bill_Price);
            this.Controls.Add(this.patientName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.BiRecord_button);
            this.Controls.Add(this.BiBiLL_Price_label);
            this.Controls.Add(this.BiPatientName_label);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BILL";
            this.Text = "BILL";
            this.Load += new System.EventHandler(this.BILL_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BiRecord_button;
        private System.Windows.Forms.Label BiBiLL_Price_label;
        private System.Windows.Forms.Label BiPatientName_label;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label patientName;
        private System.Windows.Forms.Label Bill_Price;
        private System.Windows.Forms.ListBox Treatments;
        private System.Windows.Forms.Label label4;
    }
}