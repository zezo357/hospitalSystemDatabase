
namespace DBP_UI
{
    partial class Patient
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
            this.PhoneNum_label = new System.Windows.Forms.Label();
            this.PRecord_button = new System.Windows.Forms.Button();
            this.HName_label = new System.Windows.Forms.Label();
            this.RoomNo_label = new System.Windows.Forms.Label();
            this.BedID_label = new System.Windows.Forms.Label();
            this.Blood_Type_label = new System.Windows.Forms.Label();
            this.DocID_label = new System.Windows.Forms.Label();
            this.Gender_label = new System.Windows.Forms.Label();
            this.PStatus_label = new System.Windows.Forms.Label();
            this.DaysNO_label = new System.Windows.Forms.Label();
            this.Area_label = new System.Windows.Forms.Label();
            this.Height_label = new System.Windows.Forms.Label();
            this.City_label = new System.Windows.Forms.Label();
            this.Weight_label = new System.Windows.Forms.Label();
            this.PLName_textBox = new System.Windows.Forms.TextBox();
            this.PFName_textBox = new System.Windows.Forms.TextBox();
            this.Age_label = new System.Windows.Forms.Label();
            this.LName_label = new System.Windows.Forms.Label();
            this.FName_label = new System.Windows.Forms.Label();
            this.PDisease_textBox = new System.Windows.Forms.TextBox();
            this.Disease_label = new System.Windows.Forms.Label();
            this.PTreatment_textBox = new System.Windows.Forms.TextBox();
            this.Treatment_label = new System.Windows.Forms.Label();
            this.Page_textBox = new System.Windows.Forms.NumericUpDown();
            this.PHeight_textBox = new System.Windows.Forms.NumericUpDown();
            this.PWeight_textBox = new System.Windows.Forms.NumericUpDown();
            this.AddPhoneNumber = new System.Windows.Forms.Button();
            this.WrittenPhoneNumber = new System.Windows.Forms.NumericUpDown();
            this.PhoneNumbers = new System.Windows.Forms.ListBox();
            this.DeleteSelectedPhoneNumber = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Diseases = new System.Windows.Forms.ListBox();
            this.Disease = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Treatments = new System.Windows.Forms.ListBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TreatmentPrice = new System.Windows.Forms.NumericUpDown();
            this.Rooms = new System.Windows.Forms.ListBox();
            this.Doctors = new System.Windows.Forms.ListBox();
            this.Beds = new System.Windows.Forms.ListBox();
            this.Cities = new System.Windows.Forms.ListBox();
            this.Areas = new System.Windows.Forms.ListBox();
            this.Hospitals = new System.Windows.Forms.ListBox();
            this.BloodType = new System.Windows.Forms.ListBox();
            this.Genders = new System.Windows.Forms.ListBox();
            this.PatientStatus = new System.Windows.Forms.ListBox();
            this.patientID_Label = new System.Windows.Forms.Label();
            this.PatientIDNum = new System.Windows.Forms.TextBox();
            this.Back = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.Page_textBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PHeight_textBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PWeight_textBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WrittenPhoneNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TreatmentPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // PhoneNum_label
            // 
            this.PhoneNum_label.AutoSize = true;
            this.PhoneNum_label.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneNum_label.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.PhoneNum_label.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PhoneNum_label.Location = new System.Drawing.Point(222, 295);
            this.PhoneNum_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PhoneNum_label.Name = "PhoneNum_label";
            this.PhoneNum_label.Size = new System.Drawing.Size(104, 14);
            this.PhoneNum_label.TabIndex = 78;
            this.PhoneNum_label.Text = "Phone Number";
            // 
            // PRecord_button
            // 
            this.PRecord_button.BackColor = System.Drawing.Color.Teal;
            this.PRecord_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PRecord_button.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PRecord_button.ForeColor = System.Drawing.Color.Ivory;
            this.PRecord_button.Location = new System.Drawing.Point(351, 469);
            this.PRecord_button.Margin = new System.Windows.Forms.Padding(2);
            this.PRecord_button.Name = "PRecord_button";
            this.PRecord_button.Size = new System.Drawing.Size(176, 42);
            this.PRecord_button.TabIndex = 76;
            this.PRecord_button.Text = "Add Record";
            this.PRecord_button.UseVisualStyleBackColor = false;
            this.PRecord_button.Click += new System.EventHandler(this.PRecord_button_Click);
            // 
            // HName_label
            // 
            this.HName_label.AutoSize = true;
            this.HName_label.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HName_label.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.HName_label.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HName_label.Location = new System.Drawing.Point(372, 203);
            this.HName_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.HName_label.Name = "HName_label";
            this.HName_label.Size = new System.Drawing.Size(103, 14);
            this.HName_label.TabIndex = 74;
            this.HName_label.Text = "Hospital Name";
            // 
            // RoomNo_label
            // 
            this.RoomNo_label.AutoSize = true;
            this.RoomNo_label.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomNo_label.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.RoomNo_label.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RoomNo_label.Location = new System.Drawing.Point(541, 202);
            this.RoomNo_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RoomNo_label.Name = "RoomNo_label";
            this.RoomNo_label.Size = new System.Drawing.Size(100, 14);
            this.RoomNo_label.TabIndex = 71;
            this.RoomNo_label.Text = "Room Number";
            // 
            // BedID_label
            // 
            this.BedID_label.AutoSize = true;
            this.BedID_label.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BedID_label.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.BedID_label.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BedID_label.Location = new System.Drawing.Point(698, 203);
            this.BedID_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BedID_label.Name = "BedID_label";
            this.BedID_label.Size = new System.Drawing.Size(47, 14);
            this.BedID_label.TabIndex = 70;
            this.BedID_label.Text = "Bed ID";
            // 
            // Blood_Type_label
            // 
            this.Blood_Type_label.AutoSize = true;
            this.Blood_Type_label.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Blood_Type_label.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Blood_Type_label.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Blood_Type_label.Location = new System.Drawing.Point(222, 111);
            this.Blood_Type_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Blood_Type_label.Name = "Blood_Type_label";
            this.Blood_Type_label.Size = new System.Drawing.Size(77, 14);
            this.Blood_Type_label.TabIndex = 68;
            this.Blood_Type_label.Text = "Blood Type";
            // 
            // DocID_label
            // 
            this.DocID_label.AutoSize = true;
            this.DocID_label.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DocID_label.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.DocID_label.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DocID_label.Location = new System.Drawing.Point(13, 288);
            this.DocID_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DocID_label.Name = "DocID_label";
            this.DocID_label.Size = new System.Drawing.Size(66, 14);
            this.DocID_label.TabIndex = 64;
            this.DocID_label.Text = "Doctor ID";
            // 
            // Gender_label
            // 
            this.Gender_label.AutoSize = true;
            this.Gender_label.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gender_label.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Gender_label.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Gender_label.Location = new System.Drawing.Point(371, 113);
            this.Gender_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Gender_label.Name = "Gender_label";
            this.Gender_label.Size = new System.Drawing.Size(54, 14);
            this.Gender_label.TabIndex = 63;
            this.Gender_label.Text = "Gender";
            // 
            // PStatus_label
            // 
            this.PStatus_label.AutoSize = true;
            this.PStatus_label.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PStatus_label.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.PStatus_label.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PStatus_label.Location = new System.Drawing.Point(223, 202);
            this.PStatus_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PStatus_label.Name = "PStatus_label";
            this.PStatus_label.Size = new System.Drawing.Size(101, 14);
            this.PStatus_label.TabIndex = 62;
            this.PStatus_label.Text = "Patient Status";
            // 
            // DaysNO_label
            // 
            this.DaysNO_label.AutoSize = true;
            this.DaysNO_label.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DaysNO_label.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.DaysNO_label.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DaysNO_label.Location = new System.Drawing.Point(13, 177);
            this.DaysNO_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DaysNO_label.Name = "DaysNO_label";
            this.DaysNO_label.Size = new System.Drawing.Size(95, 14);
            this.DaysNO_label.TabIndex = 60;
            this.DaysNO_label.Text = "Days Number";
            // 
            // Area_label
            // 
            this.Area_label.AutoSize = true;
            this.Area_label.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Area_label.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Area_label.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Area_label.Location = new System.Drawing.Point(698, 112);
            this.Area_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Area_label.Name = "Area_label";
            this.Area_label.Size = new System.Drawing.Size(39, 14);
            this.Area_label.TabIndex = 58;
            this.Area_label.Text = "Area";
            // 
            // Height_label
            // 
            this.Height_label.AutoSize = true;
            this.Height_label.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Height_label.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Height_label.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Height_label.Location = new System.Drawing.Point(701, 49);
            this.Height_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Height_label.Name = "Height_label";
            this.Height_label.Size = new System.Drawing.Size(51, 14);
            this.Height_label.TabIndex = 56;
            this.Height_label.Text = "Height";
            // 
            // City_label
            // 
            this.City_label.AutoSize = true;
            this.City_label.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.City_label.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.City_label.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.City_label.Location = new System.Drawing.Point(541, 112);
            this.City_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.City_label.Name = "City_label";
            this.City_label.Size = new System.Drawing.Size(34, 14);
            this.City_label.TabIndex = 54;
            this.City_label.Text = "City";
            // 
            // Weight_label
            // 
            this.Weight_label.AutoSize = true;
            this.Weight_label.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Weight_label.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Weight_label.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Weight_label.Location = new System.Drawing.Point(13, 114);
            this.Weight_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Weight_label.Name = "Weight_label";
            this.Weight_label.Size = new System.Drawing.Size(54, 14);
            this.Weight_label.TabIndex = 52;
            this.Weight_label.Text = "Weight";
            // 
            // PLName_textBox
            // 
            this.PLName_textBox.Location = new System.Drawing.Point(374, 67);
            this.PLName_textBox.Margin = new System.Windows.Forms.Padding(2);
            this.PLName_textBox.Name = "PLName_textBox";
            this.PLName_textBox.Size = new System.Drawing.Size(132, 20);
            this.PLName_textBox.TabIndex = 50;
            // 
            // PFName_textBox
            // 
            this.PFName_textBox.Location = new System.Drawing.Point(224, 66);
            this.PFName_textBox.Margin = new System.Windows.Forms.Padding(2);
            this.PFName_textBox.Name = "PFName_textBox";
            this.PFName_textBox.Size = new System.Drawing.Size(124, 20);
            this.PFName_textBox.TabIndex = 49;
            // 
            // Age_label
            // 
            this.Age_label.AutoSize = true;
            this.Age_label.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Age_label.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Age_label.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Age_label.Location = new System.Drawing.Point(540, 49);
            this.Age_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Age_label.Name = "Age_label";
            this.Age_label.Size = new System.Drawing.Size(31, 14);
            this.Age_label.TabIndex = 48;
            this.Age_label.Text = "Age";
            // 
            // LName_label
            // 
            this.LName_label.AutoSize = true;
            this.LName_label.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LName_label.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.LName_label.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LName_label.Location = new System.Drawing.Point(371, 51);
            this.LName_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LName_label.Name = "LName_label";
            this.LName_label.Size = new System.Drawing.Size(76, 14);
            this.LName_label.TabIndex = 47;
            this.LName_label.Text = "Last Name";
            // 
            // FName_label
            // 
            this.FName_label.AutoSize = true;
            this.FName_label.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FName_label.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.FName_label.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FName_label.Location = new System.Drawing.Point(222, 50);
            this.FName_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FName_label.Name = "FName_label";
            this.FName_label.Size = new System.Drawing.Size(80, 14);
            this.FName_label.TabIndex = 46;
            this.FName_label.Text = "First Name";
            // 
            // PDisease_textBox
            // 
            this.PDisease_textBox.Location = new System.Drawing.Point(374, 312);
            this.PDisease_textBox.Margin = new System.Windows.Forms.Padding(2);
            this.PDisease_textBox.Multiline = true;
            this.PDisease_textBox.Name = "PDisease_textBox";
            this.PDisease_textBox.Size = new System.Drawing.Size(132, 21);
            this.PDisease_textBox.TabIndex = 81;
            // 
            // Disease_label
            // 
            this.Disease_label.AutoSize = true;
            this.Disease_label.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Disease_label.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Disease_label.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Disease_label.Location = new System.Drawing.Point(369, 296);
            this.Disease_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Disease_label.Name = "Disease_label";
            this.Disease_label.Size = new System.Drawing.Size(55, 14);
            this.Disease_label.TabIndex = 80;
            this.Disease_label.Text = "Disease";
            // 
            // PTreatment_textBox
            // 
            this.PTreatment_textBox.Location = new System.Drawing.Point(542, 311);
            this.PTreatment_textBox.Margin = new System.Windows.Forms.Padding(2);
            this.PTreatment_textBox.Multiline = true;
            this.PTreatment_textBox.Name = "PTreatment_textBox";
            this.PTreatment_textBox.Size = new System.Drawing.Size(132, 21);
            this.PTreatment_textBox.TabIndex = 83;
            // 
            // Treatment_label
            // 
            this.Treatment_label.AutoSize = true;
            this.Treatment_label.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Treatment_label.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Treatment_label.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Treatment_label.Location = new System.Drawing.Point(537, 295);
            this.Treatment_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Treatment_label.Name = "Treatment_label";
            this.Treatment_label.Size = new System.Drawing.Size(79, 14);
            this.Treatment_label.TabIndex = 82;
            this.Treatment_label.Text = "Treatment";
            this.Treatment_label.Click += new System.EventHandler(this.Treatment_label_Click);
            // 
            // Page_textBox
            // 
            this.Page_textBox.Location = new System.Drawing.Point(542, 66);
            this.Page_textBox.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.Page_textBox.Name = "Page_textBox";
            this.Page_textBox.Size = new System.Drawing.Size(120, 20);
            this.Page_textBox.TabIndex = 85;
            // 
            // PHeight_textBox
            // 
            this.PHeight_textBox.Location = new System.Drawing.Point(704, 66);
            this.PHeight_textBox.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.PHeight_textBox.Name = "PHeight_textBox";
            this.PHeight_textBox.Size = new System.Drawing.Size(133, 20);
            this.PHeight_textBox.TabIndex = 86;
            // 
            // PWeight_textBox
            // 
            this.PWeight_textBox.Location = new System.Drawing.Point(12, 131);
            this.PWeight_textBox.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.PWeight_textBox.Name = "PWeight_textBox";
            this.PWeight_textBox.Size = new System.Drawing.Size(124, 20);
            this.PWeight_textBox.TabIndex = 87;
            // 
            // AddPhoneNumber
            // 
            this.AddPhoneNumber.BackColor = System.Drawing.Color.Teal;
            this.AddPhoneNumber.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPhoneNumber.ForeColor = System.Drawing.SystemColors.Control;
            this.AddPhoneNumber.Location = new System.Drawing.Point(224, 338);
            this.AddPhoneNumber.Name = "AddPhoneNumber";
            this.AddPhoneNumber.Size = new System.Drawing.Size(124, 23);
            this.AddPhoneNumber.TabIndex = 88;
            this.AddPhoneNumber.Text = "Add Phone Number";
            this.AddPhoneNumber.UseVisualStyleBackColor = false;
            this.AddPhoneNumber.Click += new System.EventHandler(this.AddPhoneNumber_Click);
            // 
            // WrittenPhoneNumber
            // 
            this.WrittenPhoneNumber.Location = new System.Drawing.Point(225, 312);
            this.WrittenPhoneNumber.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.WrittenPhoneNumber.Name = "WrittenPhoneNumber";
            this.WrittenPhoneNumber.Size = new System.Drawing.Size(123, 20);
            this.WrittenPhoneNumber.TabIndex = 89;
            // 
            // PhoneNumbers
            // 
            this.PhoneNumbers.FormattingEnabled = true;
            this.PhoneNumbers.HorizontalScrollbar = true;
            this.PhoneNumbers.Location = new System.Drawing.Point(225, 368);
            this.PhoneNumbers.Name = "PhoneNumbers";
            this.PhoneNumbers.Size = new System.Drawing.Size(123, 56);
            this.PhoneNumbers.TabIndex = 90;
            this.PhoneNumbers.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // DeleteSelectedPhoneNumber
            // 
            this.DeleteSelectedPhoneNumber.BackColor = System.Drawing.Color.DarkRed;
            this.DeleteSelectedPhoneNumber.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DeleteSelectedPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteSelectedPhoneNumber.ForeColor = System.Drawing.SystemColors.Control;
            this.DeleteSelectedPhoneNumber.Location = new System.Drawing.Point(225, 431);
            this.DeleteSelectedPhoneNumber.Name = "DeleteSelectedPhoneNumber";
            this.DeleteSelectedPhoneNumber.Size = new System.Drawing.Size(123, 23);
            this.DeleteSelectedPhoneNumber.TabIndex = 91;
            this.DeleteSelectedPhoneNumber.Text = "Delete Selected";
            this.DeleteSelectedPhoneNumber.UseVisualStyleBackColor = false;
            this.DeleteSelectedPhoneNumber.Click += new System.EventHandler(this.DeleteSelectedPhoneNumber_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkRed;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(374, 432);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 23);
            this.button1.TabIndex = 94;
            this.button1.Text = "Delete Selected";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Diseases
            // 
            this.Diseases.FormattingEnabled = true;
            this.Diseases.HorizontalScrollbar = true;
            this.Diseases.Location = new System.Drawing.Point(374, 369);
            this.Diseases.Name = "Diseases";
            this.Diseases.Size = new System.Drawing.Size(131, 56);
            this.Diseases.TabIndex = 93;
            // 
            // Disease
            // 
            this.Disease.BackColor = System.Drawing.Color.Teal;
            this.Disease.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Disease.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Disease.ForeColor = System.Drawing.SystemColors.Control;
            this.Disease.Location = new System.Drawing.Point(373, 339);
            this.Disease.Name = "Disease";
            this.Disease.Size = new System.Drawing.Size(132, 23);
            this.Disease.TabIndex = 92;
            this.Disease.Text = "Add Disease";
            this.Disease.UseVisualStyleBackColor = false;
            this.Disease.Click += new System.EventHandler(this.Disease_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkRed;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.Control;
            this.button3.Location = new System.Drawing.Point(609, 431);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(132, 24);
            this.button3.TabIndex = 97;
            this.button3.Text = "Delete Selected";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Treatments
            // 
            this.Treatments.FormattingEnabled = true;
            this.Treatments.HorizontalScrollbar = true;
            this.Treatments.Location = new System.Drawing.Point(609, 368);
            this.Treatments.Name = "Treatments";
            this.Treatments.Size = new System.Drawing.Size(131, 56);
            this.Treatments.TabIndex = 96;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Teal;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.Control;
            this.button4.Location = new System.Drawing.Point(609, 338);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(132, 23);
            this.button4.TabIndex = 95;
            this.button4.Text = "Add Treatment";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(674, 295);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 14);
            this.label1.TabIndex = 98;
            this.label1.Text = "Treatment Price";
            // 
            // TreatmentPrice
            // 
            this.TreatmentPrice.Location = new System.Drawing.Point(679, 312);
            this.TreatmentPrice.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.TreatmentPrice.Name = "TreatmentPrice";
            this.TreatmentPrice.Size = new System.Drawing.Size(131, 20);
            this.TreatmentPrice.TabIndex = 103;
            // 
            // Rooms
            // 
            this.Rooms.FormattingEnabled = true;
            this.Rooms.Location = new System.Drawing.Point(544, 218);
            this.Rooms.Name = "Rooms";
            this.Rooms.Size = new System.Drawing.Size(130, 56);
            this.Rooms.TabIndex = 105;
            this.Rooms.SelectedIndexChanged += new System.EventHandler(this.Rooms_SelectedIndexChanged);
            // 
            // Doctors
            // 
            this.Doctors.FormattingEnabled = true;
            this.Doctors.Location = new System.Drawing.Point(16, 305);
            this.Doctors.Name = "Doctors";
            this.Doctors.Size = new System.Drawing.Size(132, 56);
            this.Doctors.TabIndex = 106;
            // 
            // Beds
            // 
            this.Beds.FormattingEnabled = true;
            this.Beds.Location = new System.Drawing.Point(701, 219);
            this.Beds.Name = "Beds";
            this.Beds.Size = new System.Drawing.Size(124, 56);
            this.Beds.TabIndex = 107;
            // 
            // Cities
            // 
            this.Cities.FormattingEnabled = true;
            this.Cities.Location = new System.Drawing.Point(542, 130);
            this.Cities.Name = "Cities";
            this.Cities.Size = new System.Drawing.Size(132, 56);
            this.Cities.TabIndex = 108;
            this.Cities.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged_1);
            // 
            // Areas
            // 
            this.Areas.FormattingEnabled = true;
            this.Areas.Location = new System.Drawing.Point(705, 128);
            this.Areas.Name = "Areas";
            this.Areas.Size = new System.Drawing.Size(132, 56);
            this.Areas.TabIndex = 109;
            this.Areas.SelectedIndexChanged += new System.EventHandler(this.Areas_SelectedIndexChanged);
            // 
            // Hospitals
            // 
            this.Hospitals.FormattingEnabled = true;
            this.Hospitals.Location = new System.Drawing.Point(375, 218);
            this.Hospitals.Name = "Hospitals";
            this.Hospitals.Size = new System.Drawing.Size(132, 56);
            this.Hospitals.TabIndex = 110;
            this.Hospitals.SelectedIndexChanged += new System.EventHandler(this.Hospitals_SelectedIndexChanged);
            // 
            // BloodType
            // 
            this.BloodType.FormattingEnabled = true;
            this.BloodType.Items.AddRange(new object[] {
            "A+",
            "A-",
            "B+",
            "B-",
            "O+",
            "O-",
            "AB+",
            "AB-"});
            this.BloodType.Location = new System.Drawing.Point(224, 126);
            this.BloodType.Name = "BloodType";
            this.BloodType.Size = new System.Drawing.Size(134, 56);
            this.BloodType.TabIndex = 111;
            this.BloodType.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged_2);
            // 
            // Genders
            // 
            this.Genders.FormattingEnabled = true;
            this.Genders.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.Genders.Location = new System.Drawing.Point(375, 130);
            this.Genders.Name = "Genders";
            this.Genders.Size = new System.Drawing.Size(132, 56);
            this.Genders.TabIndex = 112;
            // 
            // PatientStatus
            // 
            this.PatientStatus.FormattingEnabled = true;
            this.PatientStatus.Items.AddRange(new object[] {
            "In",
            "Out"});
            this.PatientStatus.Location = new System.Drawing.Point(224, 219);
            this.PatientStatus.Name = "PatientStatus";
            this.PatientStatus.Size = new System.Drawing.Size(132, 56);
            this.PatientStatus.TabIndex = 113;
            // 
            // patientID_Label
            // 
            this.patientID_Label.AutoSize = true;
            this.patientID_Label.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientID_Label.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.patientID_Label.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.patientID_Label.Location = new System.Drawing.Point(9, 51);
            this.patientID_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.patientID_Label.Name = "patientID_Label";
            this.patientID_Label.Size = new System.Drawing.Size(73, 14);
            this.patientID_Label.TabIndex = 44;
            this.patientID_Label.Text = "Patient ID";
            // 
            // PatientIDNum
            // 
            this.PatientIDNum.Enabled = false;
            this.PatientIDNum.Location = new System.Drawing.Point(12, 69);
            this.PatientIDNum.Name = "PatientIDNum";
            this.PatientIDNum.Size = new System.Drawing.Size(124, 20);
            this.PatientIDNum.TabIndex = 114;
            this.PatientIDNum.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(12, 9);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(39, 26);
            this.Back.TabIndex = 115;
            this.Back.Text = "<-";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 203);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(197, 20);
            this.dateTimePicker1.TabIndex = 116;
            // 
            // Patient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(860, 521);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.PatientIDNum);
            this.Controls.Add(this.PatientStatus);
            this.Controls.Add(this.Genders);
            this.Controls.Add(this.BloodType);
            this.Controls.Add(this.Hospitals);
            this.Controls.Add(this.Areas);
            this.Controls.Add(this.Cities);
            this.Controls.Add(this.Beds);
            this.Controls.Add(this.Doctors);
            this.Controls.Add(this.Rooms);
            this.Controls.Add(this.TreatmentPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Treatments);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Diseases);
            this.Controls.Add(this.Disease);
            this.Controls.Add(this.DeleteSelectedPhoneNumber);
            this.Controls.Add(this.PhoneNumbers);
            this.Controls.Add(this.WrittenPhoneNumber);
            this.Controls.Add(this.AddPhoneNumber);
            this.Controls.Add(this.PWeight_textBox);
            this.Controls.Add(this.PHeight_textBox);
            this.Controls.Add(this.Page_textBox);
            this.Controls.Add(this.PTreatment_textBox);
            this.Controls.Add(this.Treatment_label);
            this.Controls.Add(this.PDisease_textBox);
            this.Controls.Add(this.Disease_label);
            this.Controls.Add(this.PhoneNum_label);
            this.Controls.Add(this.PRecord_button);
            this.Controls.Add(this.HName_label);
            this.Controls.Add(this.RoomNo_label);
            this.Controls.Add(this.BedID_label);
            this.Controls.Add(this.Blood_Type_label);
            this.Controls.Add(this.DocID_label);
            this.Controls.Add(this.Gender_label);
            this.Controls.Add(this.PStatus_label);
            this.Controls.Add(this.DaysNO_label);
            this.Controls.Add(this.Area_label);
            this.Controls.Add(this.Height_label);
            this.Controls.Add(this.City_label);
            this.Controls.Add(this.Weight_label);
            this.Controls.Add(this.PLName_textBox);
            this.Controls.Add(this.PFName_textBox);
            this.Controls.Add(this.Age_label);
            this.Controls.Add(this.LName_label);
            this.Controls.Add(this.FName_label);
            this.Controls.Add(this.patientID_Label);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Patient";
            this.Text = "Patient";
            this.Load += new System.EventHandler(this.Patient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Page_textBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PHeight_textBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PWeight_textBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WrittenPhoneNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TreatmentPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label PhoneNum_label;
        private System.Windows.Forms.Button PRecord_button;
        private System.Windows.Forms.Label HName_label;
        private System.Windows.Forms.Label RoomNo_label;
        private System.Windows.Forms.Label BedID_label;
        private System.Windows.Forms.Label Blood_Type_label;
        private System.Windows.Forms.Label DocID_label;
        private System.Windows.Forms.Label Gender_label;
        private System.Windows.Forms.Label PStatus_label;
        private System.Windows.Forms.Label DaysNO_label;
        private System.Windows.Forms.Label Area_label;
        private System.Windows.Forms.Label Height_label;
        private System.Windows.Forms.Label City_label;
        private System.Windows.Forms.Label Weight_label;
        private System.Windows.Forms.TextBox PLName_textBox;
        private System.Windows.Forms.TextBox PFName_textBox;
        private System.Windows.Forms.Label Age_label;
        private System.Windows.Forms.Label LName_label;
        private System.Windows.Forms.Label FName_label;
        private System.Windows.Forms.TextBox PDisease_textBox;
        private System.Windows.Forms.Label Disease_label;
        private System.Windows.Forms.TextBox PTreatment_textBox;
        private System.Windows.Forms.Label Treatment_label;
        private System.Windows.Forms.NumericUpDown Page_textBox;
        private System.Windows.Forms.NumericUpDown PHeight_textBox;
        private System.Windows.Forms.NumericUpDown PWeight_textBox;
        private System.Windows.Forms.Button AddPhoneNumber;
        private System.Windows.Forms.NumericUpDown WrittenPhoneNumber;
        private System.Windows.Forms.ListBox PhoneNumbers;
        private System.Windows.Forms.Button DeleteSelectedPhoneNumber;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox Diseases;
        private System.Windows.Forms.Button Disease;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox Treatments;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown TreatmentPrice;
        private System.Windows.Forms.ListBox Rooms;
        private System.Windows.Forms.ListBox Doctors;
        private System.Windows.Forms.ListBox Beds;
        private System.Windows.Forms.ListBox Cities;
        private System.Windows.Forms.ListBox Areas;
        private System.Windows.Forms.ListBox Hospitals;
        private System.Windows.Forms.ListBox BloodType;
        private System.Windows.Forms.ListBox Genders;
        private System.Windows.Forms.ListBox PatientStatus;
        private System.Windows.Forms.Label patientID_Label;
        private System.Windows.Forms.TextBox PatientIDNum;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}