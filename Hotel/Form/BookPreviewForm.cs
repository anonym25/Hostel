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

namespace Hotel
{
    public partial class BookPreviewForm : Form
    {
        public BookPreviewForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private DaoRecall daoRecall = new DaoRecall();
        private DaoEmployee daoEmployee = new DaoEmployee();

        void PrintData(List<Recall> listRecalls)
        {
            Employee employee;
            string fio = "";
            bookDataGridView.Rows.Clear();
            foreach (Recall recall in listRecalls)
            {
                if (recall.IndividualNumberFK != null)
                {
                    employee = daoEmployee.GetEmployeeOnId(Data.context, (int)recall.IndividualNumberFK);
                    fio = employee.Surname + " " + employee.Name + " " + employee.Patronymic;
                }
                if (recall.Answers.Count != 0)
                    foreach (Answer answer in recall.Answers)
                        bookDataGridView.Rows.Add(recall.TopicRecall, recall.DateTime.Date.ToString("dd'-'MM'-'yyyy"), recall.Comment, recall.SubjectRecall, recall.TypeRecall, answer.AnswerOnRecall, recall.Room, fio);
                else
                    bookDataGridView.Rows.Add(recall.TopicRecall, recall.DateTime.Date.ToString("dd'-'MM'-'yyyy"), recall.Comment, recall.SubjectRecall, recall.TypeRecall, recall.Room, fio);
            }
        }

        private string typeRecall = "", subjectRecall = "", numberRoom = "";
        private int individualNumber;
        private DateTime dateRecall, dateRecall2;
        List<Recall> CheckedCheckBox()
        {

            List<Recall> listRecalls = daoRecall.GetRecall(Data.context);
            if (dateCheckBox.Checked)
            {
                dateRecall = dateTimePickerRecall.Value.Date;
                dateRecall2 = dateRecall;
                string n = dateRecall.Year.ToString("0000") + "." + dateRecall.Month.ToString("00") + "." + dateRecall.Day.ToString("00");
                dateRecall2 = Convert.ToDateTime(dateRecall.ToString(n + " 23':'59':'59'.'999"));
                listRecalls = daoRecall.GetRecallBookOnDate(Data.context, dateRecall, dateRecall2);
            }
            if (typeCheckBox.Checked)
            {
                typeRecall = typeComboBox.Text;
                listRecalls = daoRecall.GetRecallBookOnString(Data.context, listRecalls, typeRecall);
            }
            if (subjectCheckBox.Checked)
            {
                subjectRecall = subjectComboBox.Text;
                listRecalls = daoRecall.GetRecallBookOnString(Data.context, listRecalls, subjectRecall);
            }
            if (roomCheckBox.Checked)
            {
                numberRoom = roomComboBox.SelectedValue.ToString();
                listRecalls = daoRecall.GetRecallBookOnString(Data.context, listRecalls, numberRoom);
            }
            if (employeeCheckBox.Checked)
            {
                individualNumber = (int)employeeComboBox.SelectedValue;
                listRecalls = daoRecall.GetRecallBookOnString(Data.context, listRecalls, individualNumber);
            }
            return listRecalls;
        }

        private void BookPreviewForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hotelDataSet1.Employee". При необходимости она может быть перемещена или удалена.
            this.employeeTableAdapter.Fill(this.hotelDataSet1.Employee);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hotelDataSet1.Room". При необходимости она может быть перемещена или удалена.
            this.roomTableAdapter.Fill(this.hotelDataSet1.Room);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hotelDataSet1.Recall". При необходимости она может быть перемещена или удалена.
            this.recallTableAdapter.Fill(this.hotelDataSet1.Recall);
            employeeTextBox.Text = daoEmployee.GetEmployeeOnId(Data.context, (int)employeeComboBox.SelectedValue).Name + " " + daoEmployee.GetEmployeeOnId(Data.context, (int)employeeComboBox.SelectedValue).Patronymic;
            List<Recall> listRecalls = daoRecall.GetRecall(Data.context);
            PrintData(listRecalls);
        }

        private void dateCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (dateCheckBox.Checked)
            {
                dateTimePickerRecall.Enabled = true;
                bookDataGridView.Columns[1].Visible = true;
            }
            else
            {
                dateTimePickerRecall.Enabled = false;
                bookDataGridView.Columns[1].Visible = false;
            }
            PrintData(CheckedCheckBox());
        }

        private void typeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (typeCheckBox.Checked)
                typeComboBox.Enabled = true;
            else typeComboBox.Enabled = false;
            PrintData(CheckedCheckBox());
        }

        private void subjectCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (subjectCheckBox.Checked)
                subjectComboBox.Enabled = true;
            else subjectComboBox.Enabled = false;
            PrintData(CheckedCheckBox());
        }

        private void roomCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (roomCheckBox.Checked)
            {
                roomComboBox.Enabled = true;
                bookDataGridView.Columns[6].Visible = true;
            }
            else
            {
                roomComboBox.Enabled = false;
                bookDataGridView.Columns[6].Visible = false;
            }
            PrintData(CheckedCheckBox());
        }

        private void employeeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (employeeCheckBox.Checked)
            {
                employeeComboBox.Enabled = true;
                employeeTextBox.Enabled = true;
                bookDataGridView.Columns[7].Visible = true;
            }
            else
            {
                employeeTextBox.Enabled = false;
                employeeComboBox.Enabled = false;
                bookDataGridView.Columns[7].Visible = false;
            }
            PrintData(CheckedCheckBox());
        }

        private void employeeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (employeeCheckBox.Checked)
                employeeTextBox.Text = daoEmployee.GetEmployeeOnId(Data.context, (int)employeeComboBox.SelectedValue).Name + " " + daoEmployee.GetEmployeeOnId(Data.context, (int)employeeComboBox.SelectedValue).Patronymic;
            PrintData(CheckedCheckBox());
        }

        private void TopicTextBox_TextChanged(object sender, EventArgs e)
        {
            List<Recall> listRecalls = CheckedCheckBox();
            PrintData(daoRecall.GetRecallBookOnStringLike(Data.context, listRecalls, TopicTextBox.Text));
        }

        private void typeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            PrintData(CheckedCheckBox());
        }

        private void subjectComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            PrintData(CheckedCheckBox());
        }

        private void roomComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            PrintData(CheckedCheckBox());
        }

        private void dateTimePickerRecall_ValueChanged(object sender, EventArgs e)
        {
            PrintData(CheckedCheckBox());
        }

        private void BookPreviewForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            employeeCheckBox.Checked = false;
        }
    }
}
