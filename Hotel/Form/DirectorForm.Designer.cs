namespace Hotel
{
    partial class DirectorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DirectorForm));
            this.directorTabControl = new System.Windows.Forms.TabControl();
            this.positionPage = new System.Windows.Forms.TabPage();
            this.positionDataGridView = new System.Windows.Forms.DataGridView();
            this.IdentifierPosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelDataSet1 = new Hotel.HotelDataSet1();
            this.roomPage = new System.Windows.Forms.TabPage();
            this.roomDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.roomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeePage = new System.Windows.Forms.TabPage();
            this.employeeDataGridView = new System.Windows.Forms.DataGridView();
            this.NumberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SurnameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatronymicColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamePositionColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.positionBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.userPage = new System.Windows.Forms.TabPage();
            this.hotelUserDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hotelUserBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.recallPage = new System.Windows.Forms.TabPage();
            this.recallDataGridView = new System.Windows.Forms.DataGridView();
            this.NumberRecallColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateRecallColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeRecallColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubjectRecallColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TopicRecallColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CommentColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnswerOnRecallColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberRoomColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.answerPage = new System.Windows.Forms.TabPage();
            this.answerDataGridView = new System.Windows.Forms.DataGridView();
            this.NumberAnswerColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionTableAdapter = new Hotel.HotelDataSet1TableAdapters.PositionTableAdapter();
            this.tableAdapterManager = new Hotel.HotelDataSet1TableAdapters.TableAdapterManager();
            this.employeeTableAdapter = new Hotel.HotelDataSet1TableAdapters.EmployeeTableAdapter();
            this.roomTableAdapter = new Hotel.HotelDataSet1TableAdapters.RoomTableAdapter();
            this.hotelUserTableAdapter = new Hotel.HotelDataSet1TableAdapters.HotelUserTableAdapter();
            this.addButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numberRecordTextBox = new System.Windows.Forms.NumericUpDown();
            this.labelRecord = new System.Windows.Forms.Label();
            this.nextDoubleButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.prevButton = new System.Windows.Forms.Button();
            this.prevDoubleButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.просмотрКнигиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сведенияОСистемеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.информацияОРазработчикахToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.directorTabControl.SuspendLayout();
            this.positionPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.positionDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet1)).BeginInit();
            this.roomPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).BeginInit();
            this.employeePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionBindingSource2)).BeginInit();
            this.userPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hotelUserDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelUserBindingSource)).BeginInit();
            this.recallPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recallDataGridView)).BeginInit();
            this.answerPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.answerDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberRecordTextBox)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // directorTabControl
            // 
            this.directorTabControl.Controls.Add(this.positionPage);
            this.directorTabControl.Controls.Add(this.roomPage);
            this.directorTabControl.Controls.Add(this.employeePage);
            this.directorTabControl.Controls.Add(this.userPage);
            this.directorTabControl.Controls.Add(this.recallPage);
            this.directorTabControl.Controls.Add(this.answerPage);
            this.directorTabControl.Location = new System.Drawing.Point(1, 73);
            this.directorTabControl.Name = "directorTabControl";
            this.directorTabControl.SelectedIndex = 0;
            this.directorTabControl.Size = new System.Drawing.Size(868, 344);
            this.directorTabControl.TabIndex = 0;
            this.directorTabControl.SelectedIndexChanged += new System.EventHandler(this.directorTabControl_SelectedIndexChanged);
            // 
            // positionPage
            // 
            this.positionPage.AutoScroll = true;
            this.positionPage.Controls.Add(this.positionDataGridView);
            this.positionPage.Location = new System.Drawing.Point(4, 22);
            this.positionPage.Name = "positionPage";
            this.positionPage.Padding = new System.Windows.Forms.Padding(3);
            this.positionPage.Size = new System.Drawing.Size(860, 318);
            this.positionPage.TabIndex = 0;
            this.positionPage.Text = "Должности";
            this.positionPage.UseVisualStyleBackColor = true;
            // 
            // positionDataGridView
            // 
            this.positionDataGridView.AutoGenerateColumns = false;
            this.positionDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.positionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.positionDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdentifierPosition,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.positionDataGridView.DataSource = this.positionBindingSource;
            this.positionDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.positionDataGridView.Location = new System.Drawing.Point(3, 3);
            this.positionDataGridView.Name = "positionDataGridView";
            this.positionDataGridView.Size = new System.Drawing.Size(854, 312);
            this.positionDataGridView.TabIndex = 0;
            this.positionDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.positionDataGridView_CellClick);
            // 
            // IdentifierPosition
            // 
            this.IdentifierPosition.DataPropertyName = "IdentifierPosition";
            this.IdentifierPosition.HeaderText = "Номер должности";
            this.IdentifierPosition.Name = "IdentifierPosition";
            this.IdentifierPosition.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NamePosition";
            this.dataGridViewTextBoxColumn2.HeaderText = "Название";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn3.HeaderText = "Описание";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // positionBindingSource
            // 
            this.positionBindingSource.DataMember = "Position";
            this.positionBindingSource.DataSource = this.hotelDataSet1;
            // 
            // hotelDataSet1
            // 
            this.hotelDataSet1.DataSetName = "HotelDataSet1";
            this.hotelDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // roomPage
            // 
            this.roomPage.AutoScroll = true;
            this.roomPage.Controls.Add(this.roomDataGridView);
            this.roomPage.Location = new System.Drawing.Point(4, 22);
            this.roomPage.Name = "roomPage";
            this.roomPage.Padding = new System.Windows.Forms.Padding(3);
            this.roomPage.Size = new System.Drawing.Size(860, 318);
            this.roomPage.TabIndex = 2;
            this.roomPage.Text = "Комнаты";
            this.roomPage.UseVisualStyleBackColor = true;
            // 
            // roomDataGridView
            // 
            this.roomDataGridView.AutoGenerateColumns = false;
            this.roomDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.roomDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.roomDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn4});
            this.roomDataGridView.DataSource = this.roomBindingSource;
            this.roomDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roomDataGridView.Location = new System.Drawing.Point(3, 3);
            this.roomDataGridView.Name = "roomDataGridView";
            this.roomDataGridView.Size = new System.Drawing.Size(854, 312);
            this.roomDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "NumberRoom";
            this.dataGridViewTextBoxColumn1.HeaderText = "Номер комнаты";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "TypeRoom";
            this.dataGridViewTextBoxColumn4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.dataGridViewTextBoxColumn4.HeaderText = "Тип комнаты";
            this.dataGridViewTextBoxColumn4.Items.AddRange(new object[] {
            "стандарт",
            "стандарт+",
            "стандарт+(малый)",
            "стандарт(малый)",
            "блок",
            "люкс",
            "люкс+"});
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // roomBindingSource
            // 
            this.roomBindingSource.DataMember = "Room";
            this.roomBindingSource.DataSource = this.hotelDataSet1;
            // 
            // employeePage
            // 
            this.employeePage.AutoScroll = true;
            this.employeePage.Controls.Add(this.employeeDataGridView);
            this.employeePage.Location = new System.Drawing.Point(4, 22);
            this.employeePage.Name = "employeePage";
            this.employeePage.Padding = new System.Windows.Forms.Padding(3);
            this.employeePage.Size = new System.Drawing.Size(860, 318);
            this.employeePage.TabIndex = 1;
            this.employeePage.Text = "Сотрудники";
            this.employeePage.UseVisualStyleBackColor = true;
            // 
            // employeeDataGridView
            // 
            this.employeeDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.employeeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumberColumn,
            this.SurnameColumn,
            this.NameColumn,
            this.PatronymicColumn,
            this.NamePositionColumn});
            this.employeeDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employeeDataGridView.Location = new System.Drawing.Point(3, 3);
            this.employeeDataGridView.Name = "employeeDataGridView";
            this.employeeDataGridView.Size = new System.Drawing.Size(854, 312);
            this.employeeDataGridView.TabIndex = 0;
            // 
            // NumberColumn
            // 
            this.NumberColumn.HeaderText = "Индивидуальный номер";
            this.NumberColumn.Name = "NumberColumn";
            this.NumberColumn.ReadOnly = true;
            // 
            // SurnameColumn
            // 
            this.SurnameColumn.HeaderText = "Фамилия";
            this.SurnameColumn.Name = "SurnameColumn";
            // 
            // NameColumn
            // 
            this.NameColumn.HeaderText = "Имя";
            this.NameColumn.Name = "NameColumn";
            // 
            // PatronymicColumn
            // 
            this.PatronymicColumn.HeaderText = "Отчество";
            this.PatronymicColumn.Name = "PatronymicColumn";
            // 
            // NamePositionColumn
            // 
            this.NamePositionColumn.DataSource = this.positionBindingSource2;
            this.NamePositionColumn.DisplayMember = "NamePosition";
            this.NamePositionColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.NamePositionColumn.HeaderText = "Должность";
            this.NamePositionColumn.Name = "NamePositionColumn";
            this.NamePositionColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.NamePositionColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.NamePositionColumn.ToolTipText = "mn";
            // 
            // positionBindingSource2
            // 
            this.positionBindingSource2.DataMember = "Position";
            this.positionBindingSource2.DataSource = this.hotelDataSet1;
            // 
            // userPage
            // 
            this.userPage.AutoScroll = true;
            this.userPage.Controls.Add(this.hotelUserDataGridView);
            this.userPage.Location = new System.Drawing.Point(4, 22);
            this.userPage.Name = "userPage";
            this.userPage.Padding = new System.Windows.Forms.Padding(3);
            this.userPage.Size = new System.Drawing.Size(860, 318);
            this.userPage.TabIndex = 3;
            this.userPage.Text = "Пользователи";
            this.userPage.UseVisualStyleBackColor = true;
            // 
            // hotelUserDataGridView
            // 
            this.hotelUserDataGridView.AllowUserToAddRows = false;
            this.hotelUserDataGridView.AutoGenerateColumns = false;
            this.hotelUserDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.hotelUserDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hotelUserDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.hotelUserDataGridView.DataSource = this.hotelUserBindingSource;
            this.hotelUserDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hotelUserDataGridView.Location = new System.Drawing.Point(3, 3);
            this.hotelUserDataGridView.Name = "hotelUserDataGridView";
            this.hotelUserDataGridView.ReadOnly = true;
            this.hotelUserDataGridView.Size = new System.Drawing.Size(854, 312);
            this.hotelUserDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "UserNumber";
            this.dataGridViewTextBoxColumn5.HeaderText = "Номер пользователя";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Surname";
            this.dataGridViewTextBoxColumn6.HeaderText = "Фамилия";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn7.HeaderText = "Имя";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Patronymic";
            this.dataGridViewTextBoxColumn8.HeaderText = "Отчество";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn9.HeaderText = "Email";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // hotelUserBindingSource
            // 
            this.hotelUserBindingSource.DataMember = "HotelUser";
            this.hotelUserBindingSource.DataSource = this.hotelDataSet1;
            // 
            // recallPage
            // 
            this.recallPage.Controls.Add(this.recallDataGridView);
            this.recallPage.Location = new System.Drawing.Point(4, 22);
            this.recallPage.Name = "recallPage";
            this.recallPage.Padding = new System.Windows.Forms.Padding(3);
            this.recallPage.Size = new System.Drawing.Size(860, 318);
            this.recallPage.TabIndex = 4;
            this.recallPage.Text = "Отзывы";
            this.recallPage.UseVisualStyleBackColor = true;
            // 
            // recallDataGridView
            // 
            this.recallDataGridView.AllowUserToAddRows = false;
            this.recallDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.recallDataGridView.BackgroundColor = System.Drawing.Color.Lavender;
            this.recallDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.recallDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumberRecallColumn,
            this.UserColumn,
            this.DateRecallColumn,
            this.TypeRecallColumn,
            this.SubjectRecallColumn,
            this.TopicRecallColumn,
            this.CommentColumn,
            this.AnswerOnRecallColumn,
            this.NumberRoomColumn,
            this.EmployeeColumn});
            this.recallDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.recallDataGridView.Location = new System.Drawing.Point(3, 3);
            this.recallDataGridView.Name = "recallDataGridView";
            this.recallDataGridView.ReadOnly = true;
            this.recallDataGridView.Size = new System.Drawing.Size(854, 312);
            this.recallDataGridView.TabIndex = 2;
            // 
            // NumberRecallColumn
            // 
            this.NumberRecallColumn.HeaderText = "Номер отзыва";
            this.NumberRecallColumn.Name = "NumberRecallColumn";
            this.NumberRecallColumn.ReadOnly = true;
            // 
            // UserColumn
            // 
            this.UserColumn.HeaderText = "Пользователь";
            this.UserColumn.Name = "UserColumn";
            this.UserColumn.ReadOnly = true;
            // 
            // DateRecallColumn
            // 
            this.DateRecallColumn.HeaderText = "Дата отзыва";
            this.DateRecallColumn.Name = "DateRecallColumn";
            this.DateRecallColumn.ReadOnly = true;
            // 
            // TypeRecallColumn
            // 
            this.TypeRecallColumn.HeaderText = "Тип отзыва";
            this.TypeRecallColumn.Name = "TypeRecallColumn";
            this.TypeRecallColumn.ReadOnly = true;
            // 
            // SubjectRecallColumn
            // 
            this.SubjectRecallColumn.HeaderText = "Предмет отзыва";
            this.SubjectRecallColumn.Name = "SubjectRecallColumn";
            this.SubjectRecallColumn.ReadOnly = true;
            // 
            // TopicRecallColumn
            // 
            this.TopicRecallColumn.HeaderText = "Тема отзыва";
            this.TopicRecallColumn.Name = "TopicRecallColumn";
            this.TopicRecallColumn.ReadOnly = true;
            // 
            // CommentColumn
            // 
            this.CommentColumn.HeaderText = "Отзыв";
            this.CommentColumn.Name = "CommentColumn";
            this.CommentColumn.ReadOnly = true;
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
            // 
            // EmployeeColumn
            // 
            this.EmployeeColumn.HeaderText = "Сотрудник";
            this.EmployeeColumn.Name = "EmployeeColumn";
            this.EmployeeColumn.ReadOnly = true;
            // 
            // answerPage
            // 
            this.answerPage.Controls.Add(this.answerDataGridView);
            this.answerPage.Location = new System.Drawing.Point(4, 22);
            this.answerPage.Name = "answerPage";
            this.answerPage.Padding = new System.Windows.Forms.Padding(3);
            this.answerPage.Size = new System.Drawing.Size(860, 318);
            this.answerPage.TabIndex = 5;
            this.answerPage.Text = "Ответы";
            this.answerPage.UseVisualStyleBackColor = true;
            // 
            // answerDataGridView
            // 
            this.answerDataGridView.AllowUserToAddRows = false;
            this.answerDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.answerDataGridView.BackgroundColor = System.Drawing.Color.Lavender;
            this.answerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.answerDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumberAnswerColumn,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn19});
            this.answerDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.answerDataGridView.Location = new System.Drawing.Point(3, 3);
            this.answerDataGridView.Name = "answerDataGridView";
            this.answerDataGridView.ReadOnly = true;
            this.answerDataGridView.Size = new System.Drawing.Size(854, 312);
            this.answerDataGridView.TabIndex = 3;
            // 
            // NumberAnswerColumn
            // 
            this.NumberAnswerColumn.HeaderText = "Номер ответа";
            this.NumberAnswerColumn.Name = "NumberAnswerColumn";
            this.NumberAnswerColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.HeaderText = "Отзыв";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.HeaderText = "Пользователь";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.HeaderText = "Дата ответа";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.HeaderText = "Ответ на отзыв";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.HeaderText = "Сотрудник";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.ReadOnly = true;
            // 
            // positionTableAdapter
            // 
            this.positionTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AnswerTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EmployeeTableAdapter = this.employeeTableAdapter;
            this.tableAdapterManager.HotelUserTableAdapter = null;
            this.tableAdapterManager.PositionTableAdapter = this.positionTableAdapter;
            this.tableAdapterManager.RecallTableAdapter = null;
            this.tableAdapterManager.RoomTableAdapter = null;
            this.tableAdapterManager.SuperUserTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Hotel.HotelDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // roomTableAdapter
            // 
            this.roomTableAdapter.ClearBeforeFill = true;
            // 
            // hotelUserTableAdapter
            // 
            this.hotelUserTableAdapter.ClearBeforeFill = true;
            // 
            // addButton
            // 
            this.addButton.Image = global::Hotel.Properties.Resources.add;
            this.addButton.Location = new System.Drawing.Point(248, 8);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(31, 31);
            this.addButton.TabIndex = 1;
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.AliceBlue;
            this.groupBox1.Controls.Add(this.numberRecordTextBox);
            this.groupBox1.Controls.Add(this.labelRecord);
            this.groupBox1.Controls.Add(this.nextDoubleButton);
            this.groupBox1.Controls.Add(this.nextButton);
            this.groupBox1.Controls.Add(this.prevButton);
            this.groupBox1.Controls.Add(this.prevDoubleButton);
            this.groupBox1.Controls.Add(this.deleteButton);
            this.groupBox1.Controls.Add(this.addButton);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(3, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(319, 41);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // numberRecordTextBox
            // 
            this.numberRecordTextBox.Location = new System.Drawing.Point(77, 15);
            this.numberRecordTextBox.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numberRecordTextBox.Name = "numberRecordTextBox";
            this.numberRecordTextBox.Size = new System.Drawing.Size(42, 20);
            this.numberRecordTextBox.TabIndex = 9;
            this.numberRecordTextBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numberRecordTextBox.ValueChanged += new System.EventHandler(this.numberRecordTextBox_ValueChanged);
            // 
            // labelRecord
            // 
            this.labelRecord.AutoSize = true;
            this.labelRecord.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRecord.Location = new System.Drawing.Point(125, 11);
            this.labelRecord.Name = "labelRecord";
            this.labelRecord.Size = new System.Drawing.Size(0, 24);
            this.labelRecord.TabIndex = 8;
            // 
            // nextDoubleButton
            // 
            this.nextDoubleButton.Image = global::Hotel.Properties.Resources.next_next;
            this.nextDoubleButton.Location = new System.Drawing.Point(202, 9);
            this.nextDoubleButton.Name = "nextDoubleButton";
            this.nextDoubleButton.Size = new System.Drawing.Size(31, 31);
            this.nextDoubleButton.TabIndex = 7;
            this.nextDoubleButton.UseVisualStyleBackColor = true;
            this.nextDoubleButton.Click += new System.EventHandler(this.nextDoubleButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.Image = global::Hotel.Properties.Resources.next;
            this.nextButton.Location = new System.Drawing.Point(165, 9);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(31, 31);
            this.nextButton.TabIndex = 6;
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // prevButton
            // 
            this.prevButton.Image = global::Hotel.Properties.Resources.prev;
            this.prevButton.Location = new System.Drawing.Point(39, 8);
            this.prevButton.Name = "prevButton";
            this.prevButton.Size = new System.Drawing.Size(32, 33);
            this.prevButton.TabIndex = 4;
            this.prevButton.UseVisualStyleBackColor = true;
            this.prevButton.Click += new System.EventHandler(this.prevButton_Click);
            // 
            // prevDoubleButton
            // 
            this.prevDoubleButton.Image = global::Hotel.Properties.Resources.prev_prev;
            this.prevDoubleButton.Location = new System.Drawing.Point(2, 8);
            this.prevDoubleButton.Name = "prevDoubleButton";
            this.prevDoubleButton.Size = new System.Drawing.Size(31, 33);
            this.prevDoubleButton.TabIndex = 3;
            this.prevDoubleButton.UseVisualStyleBackColor = true;
            this.prevDoubleButton.Click += new System.EventHandler(this.prevDoubleButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Image = global::Hotel.Properties.Resources.delete;
            this.deleteButton.Location = new System.Drawing.Point(285, 8);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(31, 31);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.просмотрКнигиToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(868, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // просмотрКнигиToolStripMenuItem
            // 
            this.просмотрКнигиToolStripMenuItem.Name = "просмотрКнигиToolStripMenuItem";
            this.просмотрКнигиToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.просмотрКнигиToolStripMenuItem.Text = "Просмотр книги";
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
            // DirectorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(868, 417);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.directorTabControl);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DirectorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Работа с данными";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DirectorForm_FormClosing);
            this.Load += new System.EventHandler(this.DirectorForm_Load);
            this.directorTabControl.ResumeLayout(false);
            this.positionPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.positionDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet1)).EndInit();
            this.roomPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.roomDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).EndInit();
            this.employeePage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionBindingSource2)).EndInit();
            this.userPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hotelUserDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelUserBindingSource)).EndInit();
            this.recallPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.recallDataGridView)).EndInit();
            this.answerPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.answerDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberRecordTextBox)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl directorTabControl;
        private System.Windows.Forms.TabPage positionPage;
        private System.Windows.Forms.TabPage employeePage;
        private HotelDataSet1 hotelDataSet1;
        private HotelDataSet1TableAdapters.PositionTableAdapter positionTableAdapter;
        private HotelDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView positionDataGridView;
        private HotelDataSet1TableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.DataGridView employeeDataGridView;
        private System.Windows.Forms.BindingSource positionBindingSource2;
        private System.Windows.Forms.BindingSource positionBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SurnameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatronymicColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn NamePositionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdentifierPosition;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.TabPage roomPage;
        private System.Windows.Forms.TabPage userPage;
        private System.Windows.Forms.TabPage recallPage;
        private System.Windows.Forms.TabPage answerPage;
        private System.Windows.Forms.BindingSource roomBindingSource;
        private HotelDataSet1TableAdapters.RoomTableAdapter roomTableAdapter;
        private System.Windows.Forms.DataGridView roomDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.BindingSource hotelUserBindingSource;
        private HotelDataSet1TableAdapters.HotelUserTableAdapter hotelUserTableAdapter;
        private System.Windows.Forms.DataGridView hotelUserDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridView recallDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberRecallColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateRecallColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeRecallColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectRecallColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TopicRecallColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CommentColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnswerOnRecallColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberRoomColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeColumn;
        private System.Windows.Forms.DataGridView answerDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberAnswerColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button prevButton;
        private System.Windows.Forms.Button prevDoubleButton;
        private System.Windows.Forms.Label labelRecord;
        private System.Windows.Forms.Button nextDoubleButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.NumericUpDown numberRecordTextBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem просмотрКнигиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сведенияОСистемеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem информацияОРазработчикахToolStripMenuItem;
    }
}