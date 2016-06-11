namespace Hotel
{
    partial class BookPreviewForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookPreviewForm));
            this.bookDataGridView = new System.Windows.Forms.DataGridView();
            this.TopicRecallColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateRecallColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CommentColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubjectRecallColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeRecallColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnswerOnRecallColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberRoomColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePickerRecall = new System.Windows.Forms.DateTimePicker();
            this.dateCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TopicTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.employeeTextBox = new System.Windows.Forms.TextBox();
            this.employeeComboBox = new System.Windows.Forms.ComboBox();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelDataSet1 = new Hotel.HotelDataSet1();
            this.employeeCheckBox = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.roomComboBox = new System.Windows.Forms.ComboBox();
            this.roomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roomCheckBox = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.subjectComboBox = new System.Windows.Forms.ComboBox();
            this.subjectCheckBox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.typeCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.recallBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.recallTableAdapter = new Hotel.HotelDataSet1TableAdapters.RecallTableAdapter();
            this.roomTableAdapter = new Hotel.HotelDataSet1TableAdapters.RoomTableAdapter();
            this.employeeTableAdapter = new Hotel.HotelDataSet1TableAdapters.EmployeeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bookDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recallBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bookDataGridView
            // 
            this.bookDataGridView.AllowUserToAddRows = false;
            this.bookDataGridView.AllowUserToDeleteRows = false;
            this.bookDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bookDataGridView.BackgroundColor = System.Drawing.Color.Lavender;
            this.bookDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TopicRecallColumn,
            this.DateRecallColumn,
            this.CommentColumn,
            this.SubjectRecallColumn,
            this.TypeRecallColumn,
            this.AnswerOnRecallColumn,
            this.NumberRoomColumn,
            this.EmployeeColumn});
            this.bookDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bookDataGridView.Location = new System.Drawing.Point(0, 0);
            this.bookDataGridView.Name = "bookDataGridView";
            this.bookDataGridView.ReadOnly = true;
            this.bookDataGridView.Size = new System.Drawing.Size(989, 386);
            this.bookDataGridView.TabIndex = 1;
            this.bookDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bookDataGridView_CellDoubleClick);
            // 
            // TopicRecallColumn
            // 
            this.TopicRecallColumn.HeaderText = "Тема отзыва";
            this.TopicRecallColumn.Name = "TopicRecallColumn";
            this.TopicRecallColumn.ReadOnly = true;
            // 
            // DateRecallColumn
            // 
            this.DateRecallColumn.HeaderText = "Дата отзыва";
            this.DateRecallColumn.Name = "DateRecallColumn";
            this.DateRecallColumn.ReadOnly = true;
            this.DateRecallColumn.Visible = false;
            // 
            // CommentColumn
            // 
            this.CommentColumn.HeaderText = "Отзыв";
            this.CommentColumn.Name = "CommentColumn";
            this.CommentColumn.ReadOnly = true;
            // 
            // SubjectRecallColumn
            // 
            this.SubjectRecallColumn.HeaderText = "Предмет отзыва";
            this.SubjectRecallColumn.Name = "SubjectRecallColumn";
            this.SubjectRecallColumn.ReadOnly = true;
            // 
            // TypeRecallColumn
            // 
            this.TypeRecallColumn.HeaderText = "Тип отзыва";
            this.TypeRecallColumn.Name = "TypeRecallColumn";
            this.TypeRecallColumn.ReadOnly = true;
            // 
            // AnswerOnRecallColumn
            // 
            this.AnswerOnRecallColumn.HeaderText = "Ответ на отзыв";
            this.AnswerOnRecallColumn.Name = "AnswerOnRecallColumn";
            this.AnswerOnRecallColumn.ReadOnly = true;
            // 
            // NumberRoomColumn
            // 
            this.NumberRoomColumn.HeaderText = "Номер комнаты";
            this.NumberRoomColumn.Name = "NumberRoomColumn";
            this.NumberRoomColumn.ReadOnly = true;
            this.NumberRoomColumn.Visible = false;
            // 
            // EmployeeColumn
            // 
            this.EmployeeColumn.HeaderText = "Сотрудник";
            this.EmployeeColumn.Name = "EmployeeColumn";
            this.EmployeeColumn.ReadOnly = true;
            this.EmployeeColumn.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bookDataGridView);
            this.panel1.Location = new System.Drawing.Point(3, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(989, 386);
            this.panel1.TabIndex = 2;
            // 
            // dateTimePickerRecall
            // 
            this.dateTimePickerRecall.Enabled = false;
            this.dateTimePickerRecall.Location = new System.Drawing.Point(27, 19);
            this.dateTimePickerRecall.Name = "dateTimePickerRecall";
            this.dateTimePickerRecall.Size = new System.Drawing.Size(140, 20);
            this.dateTimePickerRecall.TabIndex = 3;
            this.dateTimePickerRecall.Value = new System.DateTime(2016, 6, 5, 19, 44, 52, 0);
            this.dateTimePickerRecall.ValueChanged += new System.EventHandler(this.dateTimePickerRecall_ValueChanged);
            // 
            // dateCheckBox
            // 
            this.dateCheckBox.AutoSize = true;
            this.dateCheckBox.Location = new System.Drawing.Point(6, 25);
            this.dateCheckBox.Name = "dateCheckBox";
            this.dateCheckBox.Size = new System.Drawing.Size(15, 14);
            this.dateCheckBox.TabIndex = 5;
            this.dateCheckBox.UseVisualStyleBackColor = true;
            this.dateCheckBox.CheckedChanged += new System.EventHandler(this.dateCheckBox_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MintCream;
            this.groupBox1.Controls.Add(this.TopicTextBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.employeeTextBox);
            this.groupBox1.Controls.Add(this.employeeComboBox);
            this.groupBox1.Controls.Add(this.employeeCheckBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.roomComboBox);
            this.groupBox1.Controls.Add(this.roomCheckBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.subjectComboBox);
            this.groupBox1.Controls.Add(this.subjectCheckBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.typeComboBox);
            this.groupBox1.Controls.Add(this.typeCheckBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dateTimePickerRecall);
            this.groupBox1.Controls.Add(this.dateCheckBox);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(147, 413);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(759, 87);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Параметры поиска";
            // 
            // TopicTextBox
            // 
            this.TopicTextBox.Location = new System.Drawing.Point(555, 32);
            this.TopicTextBox.Multiline = true;
            this.TopicTextBox.Name = "TopicTextBox";
            this.TopicTextBox.Size = new System.Drawing.Size(179, 42);
            this.TopicTextBox.TabIndex = 20;
            this.TopicTextBox.TextChanged += new System.EventHandler(this.TopicTextBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(552, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Тема";
            // 
            // employeeTextBox
            // 
            this.employeeTextBox.Enabled = false;
            this.employeeTextBox.Location = new System.Drawing.Point(361, 54);
            this.employeeTextBox.Name = "employeeTextBox";
            this.employeeTextBox.ReadOnly = true;
            this.employeeTextBox.Size = new System.Drawing.Size(161, 20);
            this.employeeTextBox.TabIndex = 18;
            // 
            // employeeComboBox
            // 
            this.employeeComboBox.DataSource = this.employeeBindingSource;
            this.employeeComboBox.DisplayMember = "Surname";
            this.employeeComboBox.Enabled = false;
            this.employeeComboBox.FormattingEnabled = true;
            this.employeeComboBox.Location = new System.Drawing.Point(382, 26);
            this.employeeComboBox.Name = "employeeComboBox";
            this.employeeComboBox.Size = new System.Drawing.Size(140, 21);
            this.employeeComboBox.TabIndex = 17;
            this.employeeComboBox.ValueMember = "IndividualNumber";
            this.employeeComboBox.SelectedIndexChanged += new System.EventHandler(this.employeeComboBox_SelectedIndexChanged);
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.hotelDataSet1;
            // 
            // hotelDataSet1
            // 
            this.hotelDataSet1.DataSetName = "HotelDataSet1";
            this.hotelDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeCheckBox
            // 
            this.employeeCheckBox.AutoSize = true;
            this.employeeCheckBox.Location = new System.Drawing.Point(361, 29);
            this.employeeCheckBox.Name = "employeeCheckBox";
            this.employeeCheckBox.Size = new System.Drawing.Size(15, 14);
            this.employeeCheckBox.TabIndex = 16;
            this.employeeCheckBox.UseVisualStyleBackColor = true;
            this.employeeCheckBox.CheckedChanged += new System.EventHandler(this.employeeCheckBox_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(358, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Сотрудник";
            // 
            // roomComboBox
            // 
            this.roomComboBox.DataSource = this.roomBindingSource;
            this.roomComboBox.DisplayMember = "NumberRoom";
            this.roomComboBox.Enabled = false;
            this.roomComboBox.FormattingEnabled = true;
            this.roomComboBox.Location = new System.Drawing.Point(197, 63);
            this.roomComboBox.Name = "roomComboBox";
            this.roomComboBox.Size = new System.Drawing.Size(140, 21);
            this.roomComboBox.TabIndex = 14;
            this.roomComboBox.ValueMember = "NumberRoom";
            this.roomComboBox.SelectedIndexChanged += new System.EventHandler(this.roomComboBox_SelectedIndexChanged);
            // 
            // roomBindingSource
            // 
            this.roomBindingSource.DataMember = "Room";
            this.roomBindingSource.DataSource = this.hotelDataSet1;
            // 
            // roomCheckBox
            // 
            this.roomCheckBox.AutoSize = true;
            this.roomCheckBox.Location = new System.Drawing.Point(176, 66);
            this.roomCheckBox.Name = "roomCheckBox";
            this.roomCheckBox.Size = new System.Drawing.Size(15, 14);
            this.roomCheckBox.TabIndex = 13;
            this.roomCheckBox.UseVisualStyleBackColor = true;
            this.roomCheckBox.CheckedChanged += new System.EventHandler(this.roomCheckBox_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(173, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Номер комнаты";
            // 
            // subjectComboBox
            // 
            this.subjectComboBox.Enabled = false;
            this.subjectComboBox.FormattingEnabled = true;
            this.subjectComboBox.Items.AddRange(new object[] {
            "гостиница",
            "персонал",
            "комната"});
            this.subjectComboBox.Location = new System.Drawing.Point(197, 22);
            this.subjectComboBox.Name = "subjectComboBox";
            this.subjectComboBox.Size = new System.Drawing.Size(140, 21);
            this.subjectComboBox.TabIndex = 11;
            this.subjectComboBox.Text = "гостиница";
            this.subjectComboBox.SelectedIndexChanged += new System.EventHandler(this.subjectComboBox_SelectedIndexChanged);
            // 
            // subjectCheckBox
            // 
            this.subjectCheckBox.AutoSize = true;
            this.subjectCheckBox.Location = new System.Drawing.Point(176, 25);
            this.subjectCheckBox.Name = "subjectCheckBox";
            this.subjectCheckBox.Size = new System.Drawing.Size(15, 14);
            this.subjectCheckBox.TabIndex = 10;
            this.subjectCheckBox.UseVisualStyleBackColor = true;
            this.subjectCheckBox.CheckedChanged += new System.EventHandler(this.subjectCheckBox_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(173, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Объект отзыва";
            // 
            // typeComboBox
            // 
            this.typeComboBox.Enabled = false;
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Items.AddRange(new object[] {
            "жалоба",
            "предложение",
            "благодарность"});
            this.typeComboBox.Location = new System.Drawing.Point(27, 63);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(140, 21);
            this.typeComboBox.TabIndex = 8;
            this.typeComboBox.Text = "жалоба";
            this.typeComboBox.SelectedIndexChanged += new System.EventHandler(this.typeComboBox_SelectedIndexChanged);
            // 
            // typeCheckBox
            // 
            this.typeCheckBox.AutoSize = true;
            this.typeCheckBox.Location = new System.Drawing.Point(6, 66);
            this.typeCheckBox.Name = "typeCheckBox";
            this.typeCheckBox.Size = new System.Drawing.Size(15, 14);
            this.typeCheckBox.TabIndex = 7;
            this.typeCheckBox.UseVisualStyleBackColor = true;
            this.typeCheckBox.CheckedChanged += new System.EventHandler(this.typeCheckBox_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Тип отзыва";
            // 
            // recallBindingSource
            // 
            this.recallBindingSource.DataMember = "Recall";
            this.recallBindingSource.DataSource = this.hotelDataSet1;
            // 
            // recallTableAdapter
            // 
            this.recallTableAdapter.ClearBeforeFill = true;
            // 
            // roomTableAdapter
            // 
            this.roomTableAdapter.ClearBeforeFill = true;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // BookPreviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(991, 505);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BookPreviewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Просмотр книги";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BookPreviewForm_FormClosed);
            this.Load += new System.EventHandler(this.BookPreviewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bookDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recallBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView bookDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn TopicRecallColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateRecallColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CommentColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectRecallColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeRecallColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnswerOnRecallColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberRoomColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeColumn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dateTimePickerRecall;
        private System.Windows.Forms.CheckBox dateCheckBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.CheckBox typeCheckBox;
        private System.Windows.Forms.Label label1;
        private HotelDataSet1 hotelDataSet1;
        private System.Windows.Forms.BindingSource recallBindingSource;
        private HotelDataSet1TableAdapters.RecallTableAdapter recallTableAdapter;
        private System.Windows.Forms.ComboBox subjectComboBox;
        private System.Windows.Forms.CheckBox subjectCheckBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox roomComboBox;
        private System.Windows.Forms.CheckBox roomCheckBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource roomBindingSource;
        private HotelDataSet1TableAdapters.RoomTableAdapter roomTableAdapter;
        private System.Windows.Forms.TextBox employeeTextBox;
        private System.Windows.Forms.ComboBox employeeComboBox;
        private System.Windows.Forms.CheckBox employeeCheckBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private HotelDataSet1TableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.TextBox TopicTextBox;
        private System.Windows.Forms.Label label5;

    }
}