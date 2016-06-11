using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hotel.DAO;
using System.Diagnostics;

namespace Hotel
{
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private DaoEmployee daoEmployee = new DaoEmployee();

        private void recallUser_Click(object sender, EventArgs e)
        {
            string surname = surnameTextbox.Text;
            string name = nameTextbox.Text;
            string patronymic = patronymicTextbox.Text;
            string topicRecall = topicTextbox.Text;
            string commentReccal = commentTextbox.Text;
            string email = "";
            string typeRecall = "";
            string subjectRecall = "";
            Room room = null;
            Employee employee = null;
            if (appealRadioButton.Checked == true)
                typeRecall = "жалоба";
            else if (sentenceRadioButton.Checked == true)
                typeRecall = "предложение";
            else if (thanksRadioButton.Checked == true)
                typeRecall = "благодарность";
            if (hostelRadioButton.Checked == true)
                subjectRecall = "гостиница";
            else if (staffRadioButton.Checked == true)
            {
                staffComboBox.Enabled = true;
                nameStaffTextBox.Visible = true;
                subjectRecall = "персонал";
                employee = daoEmployee.GetEmployeeOnId(Data.context, (int)staffComboBox.SelectedValue);
            }
            else if (roomRadioButton.Checked == true)
            {
                roomComboBox.Enabled = true;
                subjectRecall = "комната";
                DaoRoom daoRoom = new DaoRoom();
                room = daoRoom.GetRoomOnId(Data.context, (int)roomComboBox.SelectedValue);
            }
            if (emailRadioYes.Checked == true)
                email = emailTextbox.Text;
            string s = DateTime.Now.ToString("u");
            DateTime d = Convert.ToDateTime(DateTime.Now.ToString("yyyy'-'MM'-'dd HH':'mm':'ss'.'fff"));
            if (name != "")
            {
                HotelUser hotelUser = Data.context.HotelUsers.Add(new HotelUser { Surname = surname, Name = name, Patronymic = patronymic, Email = email });
                Recall recall = Data.context.Recalls.Add(new Recall { Comment = commentReccal, HotelUser = hotelUser, TopicRecall = topicRecall, TypeRecall = typeRecall, SubjectRecall = subjectRecall, Employee = employee, Room = room, DateTime = Convert.ToDateTime(DateTime.Now.ToString("yyyy'-'MM'-'dd HH':'mm':'ss'.'fff")) });
                Data.context.SaveChanges();
                appealRadioButton.Checked = true;
                hostelRadioButton.Checked = true;
                surnameTextbox.Text = "";
                nameTextbox.Text = "";
                patronymicTextbox.Text = "";
                topicTextbox.Text = "";
                commentTextbox.Text = "";
                emailTextbox.Text = "";
                emailRadioNo.Checked = true;
            }
            else MessageBox.Show("Заполните обязательное поле Имя");
        }


        private void UserForm_Load(object sender, EventArgs e)
        {
            HotelContext context = new HotelContext();
            Data.context = context;
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hotelDataSet1.Room". При необходимости она может быть перемещена или удалена.
            this.roomTableAdapter.Fill(this.hotelDataSet1.Room);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hotelDataSet1.Employee". При необходимости она может быть перемещена или удалена.
            this.employeeTableAdapter.Fill(this.hotelDataSet1.Employee);
            if (staffComboBox.SelectedValue != null)
                nameStaffTextBox.Text = daoEmployee.GetEmployeeOnId(context, (int)staffComboBox.SelectedValue).Name + " " + daoEmployee.GetEmployeeOnId(context, (int)staffComboBox.SelectedValue).Patronymic;
        }

        private void staffComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (staffComboBox.Enabled == true)
                nameStaffTextBox.Text = daoEmployee.GetEmployeeOnId(Data.context, (int)staffComboBox.SelectedValue).Name + " " + daoEmployee.GetEmployeeOnId(Data.context, (int)staffComboBox.SelectedValue).Patronymic;
        }
        private void staffRadioButton_Click(object sender, EventArgs e)
        {
            staffComboBox.Enabled = true;
            nameStaffTextBox.Enabled = true;
            roomComboBox.Enabled = false;
        }

        private void UserForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            staffComboBox.Enabled = false;
        }

        private void roomRadioButton_Click(object sender, EventArgs e)
        {
            roomComboBox.Enabled = true;
            staffComboBox.Enabled = false;
            nameStaffTextBox.Enabled = false;
        }

        private void hostelRadioButton_Click(object sender, EventArgs e)
        {
            roomComboBox.Enabled = false;
            staffComboBox.Enabled = false;
            nameStaffTextBox.Enabled = false;
        }

        private void emailRadioYes_Click(object sender, EventArgs e)
        {
            emailTextbox.Enabled = true;
        }

        private void emsilRadioNo_Click(object sender, EventArgs e)
        {
            emailTextbox.Enabled = false;
        }

        private void nameTextbox_TextChanged(object sender, EventArgs e)
        {
            recallUser.Enabled = true;
        }

        private void авторизоватьсяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            AuthorizationForm authorizationForm = new AuthorizationForm();
            authorizationForm.Owner = this;
            authorizationForm.ShowDialog();
            Show();
        }

        private void просмотрToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            BookPreviewForm bookPreviewForm = new BookPreviewForm();
            bookPreviewForm.Owner = this;
            bookPreviewForm.ShowDialog();
            Show();
        }

        private void информацияОРазработчикахToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Выпускная квалификационная работа бакалавра по теме: \n«АВТОМАТИЗИРОВАННАЯ СИСТЕМА «КНИГА ЖАЛОБ И ПРЕДЛОЖЕНИЙ ГОСТИНИЦЫ». \nВыполнила студентка группы 6402Б358: Назарова А.Н. \nРуководитель проекта: Соловьева Я.В.");
        }

        private void сведенияОСистемеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("help.chm");
            }
            catch (Win32Exception exp)
            {
                MessageBox.Show("Отсутствует файл справки");
            }

            catch
            {
                MessageBox.Show("Файл справки поврежден");
            }
        }

    }
}
