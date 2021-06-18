
namespace DBP_UI
{
    partial class Hospital
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
            this.HRecord_button = new System.Windows.Forms.Button();
            this.Height_label = new System.Windows.Forms.Label();
            this.area_label = new System.Windows.Forms.Label();
            this.HHName_textBox = new System.Windows.Forms.TextBox();
            this.HName_Label = new System.Windows.Forms.Label();
            this.HDName = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Rooms = new System.Windows.Forms.ListBox();
            this.Disease = new System.Windows.Forms.Button();
            this.RoomType_textBox = new System.Windows.Forms.TextBox();
            this.Disease_label = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.Departments = new System.Windows.Forms.ListBox();
            this.button4 = new System.Windows.Forms.Button();
            this.City = new System.Windows.Forms.ListBox();
            this.Area = new System.Windows.Forms.ListBox();
            this.numberOfBeds = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.Depratments_avaliable_names = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfBeds)).BeginInit();
            this.SuspendLayout();
            // 
            // HRecord_button
            // 
            this.HRecord_button.BackColor = System.Drawing.Color.Teal;
            this.HRecord_button.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HRecord_button.ForeColor = System.Drawing.Color.Ivory;
            this.HRecord_button.Location = new System.Drawing.Point(416, 275);
            this.HRecord_button.Margin = new System.Windows.Forms.Padding(2);
            this.HRecord_button.Name = "HRecord_button";
            this.HRecord_button.Size = new System.Drawing.Size(132, 68);
            this.HRecord_button.TabIndex = 76;
            this.HRecord_button.Text = "Add Record";
            this.HRecord_button.UseVisualStyleBackColor = false;
            this.HRecord_button.Click += new System.EventHandler(this.HRecord_button_Click);
            // 
            // Height_label
            // 
            this.Height_label.AutoSize = true;
            this.Height_label.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Height_label.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Height_label.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Height_label.Location = new System.Drawing.Point(193, 3);
            this.Height_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Height_label.Name = "Height_label";
            this.Height_label.Size = new System.Drawing.Size(34, 14);
            this.Height_label.TabIndex = 55;
            this.Height_label.Text = "City";
            // 
            // area_label
            // 
            this.area_label.AutoSize = true;
            this.area_label.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.area_label.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.area_label.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.area_label.Location = new System.Drawing.Point(371, 3);
            this.area_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.area_label.Name = "area_label";
            this.area_label.Size = new System.Drawing.Size(39, 14);
            this.area_label.TabIndex = 45;
            this.area_label.Text = "Area";
            // 
            // HHName_textBox
            // 
            this.HHName_textBox.Location = new System.Drawing.Point(32, 72);
            this.HHName_textBox.Margin = new System.Windows.Forms.Padding(2);
            this.HHName_textBox.Name = "HHName_textBox";
            this.HHName_textBox.Size = new System.Drawing.Size(132, 20);
            this.HHName_textBox.TabIndex = 44;
            this.HHName_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // HName_Label
            // 
            this.HName_Label.AutoSize = true;
            this.HName_Label.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HName_Label.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.HName_Label.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HName_Label.Location = new System.Drawing.Point(31, 56);
            this.HName_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.HName_Label.Name = "HName_Label";
            this.HName_Label.Size = new System.Drawing.Size(103, 14);
            this.HName_Label.TabIndex = 43;
            this.HName_Label.Text = "Hospital Name";
            // 
            // HDName
            // 
            this.HDName.AutoSize = true;
            this.HDName.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HDName.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.HDName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HDName.Location = new System.Drawing.Point(29, 138);
            this.HDName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.HDName.Name = "HDName";
            this.HDName.Size = new System.Drawing.Size(93, 14);
            this.HDName.TabIndex = 77;
            this.HDName.Text = "Departments";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkRed;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(252, 299);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 23);
            this.button1.TabIndex = 104;
            this.button1.Text = "Delete Selected";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Rooms
            // 
            this.Rooms.FormattingEnabled = true;
            this.Rooms.HorizontalScrollbar = true;
            this.Rooms.Location = new System.Drawing.Point(252, 236);
            this.Rooms.Name = "Rooms";
            this.Rooms.Size = new System.Drawing.Size(131, 56);
            this.Rooms.TabIndex = 103;
            // 
            // Disease
            // 
            this.Disease.BackColor = System.Drawing.Color.Teal;
            this.Disease.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Disease.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Disease.ForeColor = System.Drawing.SystemColors.Control;
            this.Disease.Location = new System.Drawing.Point(251, 206);
            this.Disease.Name = "Disease";
            this.Disease.Size = new System.Drawing.Size(132, 23);
            this.Disease.TabIndex = 102;
            this.Disease.Text = "Add Room";
            this.Disease.UseVisualStyleBackColor = false;
            this.Disease.Click += new System.EventHandler(this.Disease_Click);
            // 
            // RoomType_textBox
            // 
            this.RoomType_textBox.Location = new System.Drawing.Point(215, 179);
            this.RoomType_textBox.Margin = new System.Windows.Forms.Padding(2);
            this.RoomType_textBox.Multiline = true;
            this.RoomType_textBox.Name = "RoomType_textBox";
            this.RoomType_textBox.Size = new System.Drawing.Size(101, 21);
            this.RoomType_textBox.TabIndex = 101;
            // 
            // Disease_label
            // 
            this.Disease_label.AutoSize = true;
            this.Disease_label.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Disease_label.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Disease_label.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Disease_label.Location = new System.Drawing.Point(211, 138);
            this.Disease_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Disease_label.Name = "Disease_label";
            this.Disease_label.Size = new System.Drawing.Size(78, 23);
            this.Disease_label.TabIndex = 100;
            this.Disease_label.Text = "Rooms";
            this.Disease_label.Click += new System.EventHandler(this.Disease_label_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkRed;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.Control;
            this.button3.Location = new System.Drawing.Point(32, 298);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(135, 24);
            this.button3.TabIndex = 109;
            this.button3.Text = "Delete Selected";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Departments
            // 
            this.Departments.FormattingEnabled = true;
            this.Departments.HorizontalScrollbar = true;
            this.Departments.Location = new System.Drawing.Point(32, 235);
            this.Departments.Name = "Departments";
            this.Departments.Size = new System.Drawing.Size(134, 56);
            this.Departments.TabIndex = 108;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Teal;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.Control;
            this.button4.Location = new System.Drawing.Point(32, 205);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(135, 23);
            this.button4.TabIndex = 107;
            this.button4.Text = "Add Department ";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // City
            // 
            this.City.FormattingEnabled = true;
            this.City.Items.AddRange(new object[] {
            "Alexandria ",
            "Aswan ",
            "Asyut ",
            "Beheira ",
            "Beni Suef ",
            "Cairo ",
            "Dakahlia ",
            "Damietta ",
            "Faiyum ",
            "Gharbia ",
            "Giza ",
            "Ismailia ",
            "Kafr El Sheikh ",
            "Luxor ",
            "Matruh ",
            "Minya ",
            "Monufia ",
            "New Valley ",
            "North Sinai ",
            "Port Said ",
            "Qalyubia ",
            "Qena ",
            "Red Sea ",
            "Sharqia ",
            "Sohag ",
            "South Sinai ",
            "Suez"});
            this.City.Location = new System.Drawing.Point(196, 20);
            this.City.Name = "City";
            this.City.Size = new System.Drawing.Size(120, 95);
            this.City.TabIndex = 110;
            // 
            // Area
            // 
            this.Area.FormattingEnabled = true;
            this.Area.Items.AddRange(new object[] {
            "10th of Ramadan",
            " 15th of May",
            " 6th of October",
            " Abu El Matamir",
            " Abu",
            " Hummus",
            " Abu",
            " Tesht",
            " Akhmim",
            " Al",
            " Khankah",
            " Alexandria",
            " Arish",
            " Ashmoun",
            " Aswan",
            " Asyut",
            " Awsim",
            " Badr",
            " Baltim",
            " Banha",
            " Basyoun",
            " Biyala",
            " Belqas",
            " Beni",
            " Mazar",
            " Beni",
            " Suef",
            " Beni Ebeid",
            " Biba",
            " Bilbeis",
            " Birket El Sab",
            " Borg El Arab",
            " Borg El",
            " Burullus",
            " Bush",
            " Cairo",
            " Dahab",
            " Dairut",
            " Damanhur",
            " Damietta",
            " Dar El Salam",
            " Daraw",
            " Deir Mawas",
            " Dekernes",
            " Dendera",
            " Desouk",
            " Dishna",
            " Edfu",
            " Edku",
            " El",
            " Alamein",
            " El Arish",
            " El",
            " Ayyat",
            " El Badari",
            " El Badrashein",
            " El",
            " Bagour",
            " El",
            " Balyana",
            " El Basaliya",
            " El Bayadiya",
            " El",
            " Dabaa",
            " El",
            " Delengat",
            " El",
            " Fashn",
            " El Gamaliya",
            " El",
            " Ghanayem",
            " El",
            " Hamool",
            " El",
            " Hamam",
            " El Hawamdeya",
            " El Husseiniya",
            " El Idwa",
            " El Ibrahimiya",
            " El Kanayat",
            " El Kareen",
            " El Mahalla El Kubra",
            " El Mahmoudiyah",
            " El Mansha",
            " El",
            " Manzala",
            " El",
            " Maragha",
            " El",
            " Matareya",
            " El Qantara",
            " El Qanater El Khayreya",
            " El",
            " Qoseir",
            " El Qusiya",
            " El Rahmaniya",
            " El",
            " Reyad",
            " El Rhoda",
            " El Saff",
            " El",
            " Santa",
            " El Sarw",
            " El",
            " Sebaiya",
            " El Senbellawein",
            " El Shohada",
            " El",
            " Shorouk",
            " El Tor",
            " El Waqf",
            " El Wasta",
            " El",
            " Zarqa",
            " Esna",
            " Ezbet El Borg",
            " Faqous",
            " Faraskur",
            " Farshut",
            " Fayed",
            " Faiyum",
            " Fuka",
            " Girga",
            " Giza",
            " Hihya",
            " Hosh",
            " Essa",
            " Hurghada",
            " Ibsheway",
            " Ihnasiya",
            " Ismailia",
            " Itay El Barud",
            " Itsa",
            " Juhayna",
            " Kafr El Sheikh",
            " Kafr El Zayat",
            " Kafr El",
            " Batikh",
            " Kafr El Dawwar",
            " Kafr",
            " Saad",
            " Kafr",
            " Saqr",
            " Kafr",
            " Shukr",
            " Kafr Zarqan",
            " Kerdasa",
            " Khanka",
            " Kharga",
            " Khusus",
            " Kom",
            " Hamada",
            " Kom",
            " Ombo",
            " Kotoor",
            " Luxor",
            " Maghagha",
            " Mallawi",
            " Manfalut",
            " Mansoura",
            " Mashtool",
            " El Souk",
            " Matai",
            " Menouf",
            " Marsa",
            " Alam",
            " Mersa Matruh",
            " Metoubes",
            " Minya",
            " Minyet El",
            " Nasr",
            " Mit Abu El Kom",
            " Mit Abu Ghaleb",
            " Mit Adlan",
            " Mit Bera",
            " Mit El",
            " Korama",
            " Mit",
            " Elwan",
            " Mit Fadala",
            " Mit",
            " Ghamr",
            " Mit Kenana",
            " Mit Rahina",
            " Mit Salsil",
            " Mit Sudan",
            " Mit Yazid",
            " Monsha\'at",
            " El-Qanater",
            " Mut",
            " Nabaroh",
            " Nag",
            " Hammadi",
            " Naqada",
            " New",
            " Administrative Capital (NAC)",
            " New",
            " Alamein",
            " New",
            " Aswan",
            " New Akhmim",
            " New",
            " Asyut",
            " New Beni",
            " Suef",
            " New Borg El Arab",
            " New",
            " Cairo",
            " New Damietta",
            " New Faiyum",
            " New",
            " Minya",
            " New Nubariya",
            " New Salhia",
            " New Sohag",
            " New Tiba",
            " New Qena",
            " Obour",
            " Port",
            " Said",
            " Qaha",
            " Qallin",
            " Qalyub",
            " Qena",
            " Qift",
            " Quesna",
            " Qus",
            " Rafah",
            " Ras",
            " Burqa",
            " Ras",
            " El Bar",
            " Ras Gharib",
            " Ras",
            " Sedr",
            " Ras",
            " Shokeir",
            " Rosetta",
            " Sadat",
            " Safaga",
            " Sahel Selim",
            " Saint Catherine",
            " Samalut",
            " Samanoud",
            " Saqultah",
            " Shubra Khit",
            " Sers El",
            " Lyan",
            " Sharm El Sheikh",
            " Sherbin",
            " Sheikh Zuweid",
            " Shibin El Qanater",
            " Shibin El Kom",
            " Shubra El Kheima",
            " Sidi Barrani",
            " Sidi",
            " Salem",
            " Sinnuris",
            " Siwa",
            " Oasis",
            " Sodfa",
            " Sohag",
            " Suez",
            " Sumusta El",
            " Waqf",
            " Tahta",
            " Tala",
            " Talkha",
            " Tamiya",
            " Tanta",
            " Tell El Kebir",
            " Tima",
            " Tukh",
            " Wadi El Natrun",
            " Zagazig",
            " Zefta"});
            this.Area.Location = new System.Drawing.Point(372, 20);
            this.Area.Name = "Area";
            this.Area.Size = new System.Drawing.Size(132, 95);
            this.Area.TabIndex = 111;
            // 
            // numberOfBeds
            // 
            this.numberOfBeds.Location = new System.Drawing.Point(321, 179);
            this.numberOfBeds.Name = "numberOfBeds";
            this.numberOfBeds.Size = new System.Drawing.Size(101, 20);
            this.numberOfBeds.TabIndex = 114;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(212, 163);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 14);
            this.label1.TabIndex = 115;
            this.label1.Text = "Room Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(318, 162);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 14);
            this.label2.TabIndex = 116;
            this.label2.Text = "Room Max Capacity";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(13, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(36, 24);
            this.button2.TabIndex = 117;
            this.button2.Text = "<-";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Depratments_avaliable_names
            // 
            this.Depratments_avaliable_names.FormattingEnabled = true;
            this.Depratments_avaliable_names.Location = new System.Drawing.Point(32, 155);
            this.Depratments_avaliable_names.Name = "Depratments_avaliable_names";
            this.Depratments_avaliable_names.Size = new System.Drawing.Size(132, 43);
            this.Depratments_avaliable_names.TabIndex = 118;
            // 
            // Hospital
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(559, 354);
            this.Controls.Add(this.Depratments_avaliable_names);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numberOfBeds);
            this.Controls.Add(this.Area);
            this.Controls.Add(this.City);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Departments);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Rooms);
            this.Controls.Add(this.Disease);
            this.Controls.Add(this.RoomType_textBox);
            this.Controls.Add(this.Disease_label);
            this.Controls.Add(this.HDName);
            this.Controls.Add(this.HRecord_button);
            this.Controls.Add(this.Height_label);
            this.Controls.Add(this.area_label);
            this.Controls.Add(this.HHName_textBox);
            this.Controls.Add(this.HName_Label);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Hospital";
            this.Text = "Hospital";
            this.Load += new System.EventHandler(this.Hospital_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numberOfBeds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button HRecord_button;
        private System.Windows.Forms.Label Height_label;
        private System.Windows.Forms.Label area_label;
        private System.Windows.Forms.TextBox HHName_textBox;
        private System.Windows.Forms.Label HName_Label;
        private System.Windows.Forms.Label HDName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox Rooms;
        private System.Windows.Forms.Button Disease;
        private System.Windows.Forms.TextBox RoomType_textBox;
        private System.Windows.Forms.Label Disease_label;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox Departments;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ListBox City;
        private System.Windows.Forms.ListBox Area;
        private System.Windows.Forms.NumericUpDown numberOfBeds;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox Depratments_avaliable_names;
    }
}