namespace Hotel
{
    partial class UserForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.просмотрToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.авторизоватьсяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topicTextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.recallUser = new System.Windows.Forms.Button();
            this.emailTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.emailRadioNo = new System.Windows.Forms.RadioButton();
            this.emailRadioYes = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.commentTextbox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.thanksRadioButton = new System.Windows.Forms.RadioButton();
            this.sentenceRadioButton = new System.Windows.Forms.RadioButton();
            this.appealRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.roomComboBox = new System.Windows.Forms.ComboBox();
            this.roomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelDataSet1 = new Hotel.HotelDataSet1();
            this.nameStaffTextBox = new System.Windows.Forms.TextBox();
            this.staffComboBox = new System.Windows.Forms.ComboBox();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roomRadioButton = new System.Windows.Forms.RadioButton();
            this.staffRadioButton = new System.Windows.Forms.RadioButton();
            this.hostelRadioButton = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.surnameTextbox = new System.Windows.Forms.TextBox();
            this.nameTextbox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.patronymicTextbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.employeeTableAdapter = new Hotel.HotelDataSet1TableAdapters.EmployeeTableAdapter();
            this.roomTableAdapter = new Hotel.HotelDataSet1TableAdapters.RoomTableAdapter();
            this.label5 = new System.Windows.Forms.Label();
            this.сведенияОСистемеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.информацияОРазработчикахToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.AliceBlue;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.просмотрToolStripMenuItem,
            this.авторизоватьсяToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(977, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // просмотрToolStripMenuItem
            // 
            this.просмотрToolStripMenuItem.Name = "просмотрToolStripMenuItem";
            this.просмотрToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.просмотрToolStripMenuItem.Text = "Просмотр книги";
            this.просмотрToolStripMenuItem.Click += new System.EventHandler(this.просмотрToolStripMenuItem_Click);
            // 
            // авторизоватьсяToolStripMenuItem
            // 
            this.авторизоватьсяToolStripMenuItem.Name = "авторизоватьсяToolStripMenuItem";
            this.авторизоватьсяToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.авторизоватьсяToolStripMenuItem.Text = "Авторизоваться";
            this.авторизоватьсяToolStripMenuItem.Click += new System.EventHandler(this.авторизоватьсяToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сведенияОСистемеToolStripMenuItem,
            this.информацияОРазработчикахToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // topicTextbox
            // 
            this.topicTextbox.Location = new System.Drawing.Point(255, 25);
            this.topicTextbox.Name = "topicTextbox";
            this.topicTextbox.Size = new System.Drawing.Size(710, 20);
            this.topicTextbox.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(215, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Тема";
            // 
            // recallUser
            // 
            this.recallUser.Image = global::Hotel.Properties.Resources.button_ok;
            this.recallUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.recallUser.Location = new System.Drawing.Point(816, 435);
            this.recallUser.Name = "recallUser";
            this.recallUser.Size = new System.Drawing.Size(149, 51);
            this.recallUser.TabIndex = 20;
            this.recallUser.Text = "Оставить отзыв";
            this.recallUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.recallUser.UseVisualStyleBackColor = true;
            this.recallUser.Click += new System.EventHandler(this.recallUser_Click);
            // 
            // emailTextbox
            // 
            this.emailTextbox.Enabled = false;
            this.emailTextbox.Location = new System.Drawing.Point(11, 457);
            this.emailTextbox.Name = "emailTextbox";
            this.emailTextbox.Size = new System.Drawing.Size(232, 20);
            this.emailTextbox.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 441);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Введите ваш электронный адрес";
            // 
            // emailRadioNo
            // 
            this.emailRadioNo.AutoSize = true;
            this.emailRadioNo.Checked = true;
            this.emailRadioNo.Location = new System.Drawing.Point(108, 410);
            this.emailRadioNo.Name = "emailRadioNo";
            this.emailRadioNo.Size = new System.Drawing.Size(44, 17);
            this.emailRadioNo.TabIndex = 10;
            this.emailRadioNo.TabStop = true;
            this.emailRadioNo.Text = "Нет";
            this.emailRadioNo.UseVisualStyleBackColor = true;
            this.emailRadioNo.Click += new System.EventHandler(this.emsilRadioNo_Click);
            // 
            // emailRadioYes
            // 
            this.emailRadioYes.AutoSize = true;
            this.emailRadioYes.Location = new System.Drawing.Point(24, 410);
            this.emailRadioYes.Name = "emailRadioYes";
            this.emailRadioYes.Size = new System.Drawing.Size(40, 17);
            this.emailRadioYes.TabIndex = 9;
            this.emailRadioYes.TabStop = true;
            this.emailRadioYes.Text = "Да";
            this.emailRadioYes.UseVisualStyleBackColor = true;
            this.emailRadioYes.Click += new System.EventHandler(this.emailRadioYes_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 391);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Хотели бы вы получить ответ на свой отзыв";
            // 
            // commentTextbox
            // 
            this.commentTextbox.Location = new System.Drawing.Point(255, 53);
            this.commentTextbox.Multiline = true;
            this.commentTextbox.Name = "commentTextbox";
            this.commentTextbox.Size = new System.Drawing.Size(710, 376);
            this.commentTextbox.TabIndex = 13;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.thanksRadioButton);
            this.groupBox2.Controls.Add(this.sentenceRadioButton);
            this.groupBox2.Controls.Add(this.appealRadioButton);
            this.groupBox2.Location = new System.Drawing.Point(12, 104);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(127, 95);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Типы отзыва:";
            // 
            // thanksRadioButton
            // 
            this.thanksRadioButton.AutoSize = true;
            this.thanksRadioButton.Location = new System.Drawing.Point(12, 65);
            this.thanksRadioButton.Name = "thanksRadioButton";
            this.thanksRadioButton.Size = new System.Drawing.Size(101, 17);
            this.thanksRadioButton.TabIndex = 5;
            this.thanksRadioButton.TabStop = true;
            this.thanksRadioButton.Text = "благодарность";
            this.thanksRadioButton.UseVisualStyleBackColor = true;
            // 
            // sentenceRadioButton
            // 
            this.sentenceRadioButton.AutoSize = true;
            this.sentenceRadioButton.Location = new System.Drawing.Point(12, 42);
            this.sentenceRadioButton.Name = "sentenceRadioButton";
            this.sentenceRadioButton.Size = new System.Drawing.Size(93, 17);
            this.sentenceRadioButton.TabIndex = 4;
            this.sentenceRadioButton.TabStop = true;
            this.sentenceRadioButton.Text = "предложение";
            this.sentenceRadioButton.UseVisualStyleBackColor = true;
            // 
            // appealRadioButton
            // 
            this.appealRadioButton.AutoSize = true;
            this.appealRadioButton.Checked = true;
            this.appealRadioButton.Location = new System.Drawing.Point(12, 19);
            this.appealRadioButton.Name = "appealRadioButton";
            this.appealRadioButton.Size = new System.Drawing.Size(63, 17);
            this.appealRadioButton.TabIndex = 3;
            this.appealRadioButton.TabStop = true;
            this.appealRadioButton.Text = "жалоба";
            this.appealRadioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.roomComboBox);
            this.groupBox1.Controls.Add(this.nameStaffTextBox);
            this.groupBox1.Controls.Add(this.staffComboBox);
            this.groupBox1.Controls.Add(this.roomRadioButton);
            this.groupBox1.Controls.Add(this.staffRadioButton);
            this.groupBox1.Controls.Add(this.hostelRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 205);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(127, 183);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "О чем бы вы хотели оставить отзыв:";
            // 
            // roomComboBox
            // 
            this.roomComboBox.DataSource = this.roomBindingSource;
            this.roomComboBox.DisplayMember = "NumberRoom";
            this.roomComboBox.Enabled = false;
            this.roomComboBox.FormattingEnabled = true;
            this.roomComboBox.Location = new System.Drawing.Point(6, 155);
            this.roomComboBox.Name = "roomComboBox";
            this.roomComboBox.Size = new System.Drawing.Size(115, 21);
            this.roomComboBox.TabIndex = 6;
            this.roomComboBox.ValueMember = "NumberRoom";
            // 
            // roomBindingSource
            // 
            this.roomBindingSource.DataMember = "Room";
            this.roomBindingSource.DataSource = this.hotelDataSet1;
            // 
            // hotelDataSet1
            // 
            this.hotelDataSet1.DataSetName = "HotelDataSet1";
            this.hotelDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nameStaffTextBox
            // 
            this.nameStaffTextBox.Enabled = false;
            this.nameStaffTextBox.Location = new System.Drawing.Point(6, 106);
            this.nameStaffTextBox.Name = "nameStaffTextBox";
            this.nameStaffTextBox.ReadOnly = true;
            this.nameStaffTextBox.Size = new System.Drawing.Size(115, 20);
            this.nameStaffTextBox.TabIndex = 5;
            // 
            // staffComboBox
            // 
            this.staffComboBox.DataSource = this.employeeBindingSource;
            this.staffComboBox.DisplayMember = "Surname";
            this.staffComboBox.Enabled = false;
            this.staffComboBox.FormattingEnabled = true;
            this.staffComboBox.Location = new System.Drawing.Point(6, 79);
            this.staffComboBox.Name = "staffComboBox";
            this.staffComboBox.Size = new System.Drawing.Size(115, 21);
            this.staffComboBox.TabIndex = 4;
            this.staffComboBox.ValueMember = "IndividualNumber";
            this.staffComboBox.SelectedIndexChanged += new System.EventHandler(this.staffComboBox_SelectedIndexChanged);
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.hotelDataSet1;
            // 
            // roomRadioButton
            // 
            this.roomRadioButton.AutoSize = true;
            this.roomRadioButton.Location = new System.Drawing.Point(12, 132);
            this.roomRadioButton.Name = "roomRadioButton";
            this.roomRadioButton.Size = new System.Drawing.Size(72, 17);
            this.roomRadioButton.TabIndex = 8;
            this.roomRadioButton.TabStop = true;
            this.roomRadioButton.Text = "о номере";
            this.roomRadioButton.UseVisualStyleBackColor = true;
            this.roomRadioButton.Click += new System.EventHandler(this.roomRadioButton_Click);
            // 
            // staffRadioButton
            // 
            this.staffRadioButton.AutoSize = true;
            this.staffRadioButton.Location = new System.Drawing.Point(12, 56);
            this.staffRadioButton.Name = "staffRadioButton";
            this.staffRadioButton.Size = new System.Drawing.Size(88, 17);
            this.staffRadioButton.TabIndex = 7;
            this.staffRadioButton.TabStop = true;
            this.staffRadioButton.Text = "о персонале";
            this.staffRadioButton.UseVisualStyleBackColor = true;
            this.staffRadioButton.Click += new System.EventHandler(this.staffRadioButton_Click);
            // 
            // hostelRadioButton
            // 
            this.hostelRadioButton.AutoSize = true;
            this.hostelRadioButton.Checked = true;
            this.hostelRadioButton.Location = new System.Drawing.Point(12, 33);
            this.hostelRadioButton.Name = "hostelRadioButton";
            this.hostelRadioButton.Size = new System.Drawing.Size(86, 17);
            this.hostelRadioButton.TabIndex = 6;
            this.hostelRadioButton.TabStop = true;
            this.hostelRadioButton.Text = "о гостинице";
            this.hostelRadioButton.UseVisualStyleBackColor = true;
            this.hostelRadioButton.Click += new System.EventHandler(this.hostelRadioButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Фамилия";
            // 
            // surnameTextbox
            // 
            this.surnameTextbox.Location = new System.Drawing.Point(70, 27);
            this.surnameTextbox.Name = "surnameTextbox";
            this.surnameTextbox.Size = new System.Drawing.Size(136, 20);
            this.surnameTextbox.TabIndex = 0;
            // 
            // nameTextbox
            // 
            this.nameTextbox.Location = new System.Drawing.Point(70, 51);
            this.nameTextbox.Name = "nameTextbox";
            this.nameTextbox.Size = new System.Drawing.Size(136, 20);
            this.nameTextbox.TabIndex = 1;
            this.nameTextbox.TextChanged += new System.EventHandler(this.nameTextbox_TextChanged);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(21, 56);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(29, 13);
            this.nameLabel.TabIndex = 25;
            this.nameLabel.Text = "Имя";
            // 
            // patronymicTextbox
            // 
            this.patronymicTextbox.Location = new System.Drawing.Point(70, 78);
            this.patronymicTextbox.Name = "patronymicTextbox";
            this.patronymicTextbox.Size = new System.Drawing.Size(136, 20);
            this.patronymicTextbox.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Отчество";
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // roomTableAdapter
            // 
            this.roomTableAdapter.ClearBeforeFill = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(53, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 16);
            this.label5.TabIndex = 28;
            this.label5.Text = "*";
            // 
            // сведенияОСистемеToolStripMenuItem
            // 
            this.сведенияОСистемеToolStripMenuItem.Name = "сведенияОСистемеToolStripMenuItem";
            this.сведенияОСистемеToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.сведенияОСистемеToolStripMenuItem.Text = "Сведения о системе";
            this.сведенияОСистемеToolStripMenuItem.Click += new System.EventHandler(this.сведенияОСистемеToolStripMenuItem_Click);
            // 
            // информацияОРазработчикахToolStripMenuItem
            // 
            this.информацияОРазработчикахToolStripMenuItem.Name = "информацияОРазработчикахToolStripMenuItem";
            this.информацияОРазработчикахToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.информацияОРазработчикахToolStripMenuItem.Text = "Информация о разработчиках";
            this.информацияОРазработчикахToolStripMenuItem.Click += new System.EventHandler(this.информацияОРазработчикахToolStripMenuItem_Click);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(977, 489);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.patronymicTextbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nameTextbox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.surnameTextbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.topicTextbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.recallUser);
            this.Controls.Add(this.emailTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.emailRadioNo);
            this.Controls.Add(this.emailRadioYes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.commentTextbox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserForm";
            this.Text = "Книга жалоб и предложений гостиницы";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UserForm_FormClosed);
            this.Load += new System.EventHandler(this.UserForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem просмотрToolStripMenuItem;
        private System.Windows.Forms.TextBox topicTextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button recallUser;
        private System.Windows.Forms.TextBox emailTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton emailRadioNo;
        private System.Windows.Forms.RadioButton emailRadioYes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox commentTextbox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton thanksRadioButton;
        private System.Windows.Forms.RadioButton sentenceRadioButton;
        private System.Windows.Forms.RadioButton appealRadioButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton roomRadioButton;
        private System.Windows.Forms.RadioButton staffRadioButton;
        private System.Windows.Forms.RadioButton hostelRadioButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox surnameTextbox;
        private System.Windows.Forms.TextBox nameTextbox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox patronymicTextbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox staffComboBox;
        private HotelDataSet1 hotelDataSet1;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private HotelDataSet1TableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.TextBox nameStaffTextBox;
        private System.Windows.Forms.ComboBox roomComboBox;
        private System.Windows.Forms.BindingSource roomBindingSource;
        private HotelDataSet1TableAdapters.RoomTableAdapter roomTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem авторизоватьсяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripMenuItem сведенияОСистемеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem информацияОРазработчикахToolStripMenuItem;
    }
}