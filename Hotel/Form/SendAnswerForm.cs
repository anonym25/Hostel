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
    public partial class SendAnswerForm : Form
    {
        public SendAnswerForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private Recall recall = new Recall();
        private void SendAnswerForm_Load(object sender, EventArgs e)
        {
            DaoRecall daoRecall = new DaoRecall();
            recall = daoRecall.GetRecallOnId(Data.context, Data.intValue);
            recallTextBox.Text = recall.Comment;
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            DaoEmployee daoEmployee = new DaoEmployee();
            Employee employee = daoEmployee.GetEmployeeOnSurname(Data.context, Data.stringValue);
            Answer answer = Data.context.Answers.Add(new Answer { AnswerOnRecall = answerTextBox.Text, Recall = recall, Employee = employee, DateTimeAnswer = Convert.ToDateTime(DateTime.Now.ToString("yyyy'-'MM'-'dd HH':'mm':'ss'.'fff")) });
            Data.context.SaveChanges();
            if (recall.HotelUser.Email != "")
            {
                SendMail sendMail = new SendMail();
                sendMail.SendMails(recall.HotelUser.Email, answerTextBox.Text);
            }
            this.Close();
        }

    }
}
