
namespace DBP_UI
{
    partial class Bed
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
            this.BRecord_button = new System.Windows.Forms.Button();
            this.DDName_textBox = new System.Windows.Forms.TextBox();
            this.BBedID_label = new System.Windows.Forms.Label();
            this.DDno_textBox = new System.Windows.Forms.TextBox();
            this.BRoomNo_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BRecord_button
            // 
            this.BRecord_button.BackColor = System.Drawing.Color.Teal;
            this.BRecord_button.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BRecord_button.ForeColor = System.Drawing.Color.Ivory;
            this.BRecord_button.Location = new System.Drawing.Point(110, 438);
            this.BRecord_button.Name = "BRecord_button";
            this.BRecord_button.Size = new System.Drawing.Size(234, 52);
            this.BRecord_button.TabIndex = 88;
            this.BRecord_button.Text = "Add Record";
            this.BRecord_button.UseVisualStyleBackColor = false;
            // 
            // DDName_textBox
            // 
            this.DDName_textBox.Location = new System.Drawing.Point(110, 123);
            this.DDName_textBox.Name = "DDName_textBox";
            this.DDName_textBox.Size = new System.Drawing.Size(175, 22);
            this.DDName_textBox.TabIndex = 87;
            // 
            // BBedID_label
            // 
            this.BBedID_label.AutoSize = true;
            this.BBedID_label.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BBedID_label.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.BBedID_label.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BBedID_label.Location = new System.Drawing.Point(107, 103);
            this.BBedID_label.Name = "BBedID_label";
            this.BBedID_label.Size = new System.Drawing.Size(57, 17);
            this.BBedID_label.TabIndex = 86;
            this.BBedID_label.Text = "Bed ID";
            // 
            // DDno_textBox
            // 
            this.DDno_textBox.Location = new System.Drawing.Point(110, 283);
            this.DDno_textBox.Name = "DDno_textBox";
            this.DDno_textBox.Size = new System.Drawing.Size(175, 22);
            this.DDno_textBox.TabIndex = 85;
            // 
            // BRoomNo_label
            // 
            this.BRoomNo_label.AutoSize = true;
            this.BRoomNo_label.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BRoomNo_label.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.BRoomNo_label.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BRoomNo_label.Location = new System.Drawing.Point(107, 263);
            this.BRoomNo_label.Name = "BRoomNo_label";
            this.BRoomNo_label.Size = new System.Drawing.Size(117, 17);
            this.BRoomNo_label.TabIndex = 84;
            this.BRoomNo_label.Text = "Room Number";
            // 
            // Bed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1145, 740);
            this.Controls.Add(this.BRecord_button);
            this.Controls.Add(this.DDName_textBox);
            this.Controls.Add(this.BBedID_label);
            this.Controls.Add(this.DDno_textBox);
            this.Controls.Add(this.BRoomNo_label);
            this.Name = "Bed";
            this.Text = "Bed";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BRecord_button;
        private System.Windows.Forms.TextBox DDName_textBox;
        private System.Windows.Forms.Label BBedID_label;
        private System.Windows.Forms.TextBox DDno_textBox;
        private System.Windows.Forms.Label BRoomNo_label;
    }
}