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
    public partial class AuthorizationForm : Form
    {
        public AuthorizationForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            DaoEmployee daoEmployee = new DaoEmployee();
            List<Employee> list = daoEmployee.GetEmployeeOnString(Data.context, "администратор");
            if (loginTextBox.Text == "admin" && (passwordTextBox.Text == list[0].Surname || passwordTextBox.Text == list[1].Surname))
            {
                Data.stringValue = passwordTextBox.Text;
                Hide();
                this.Close();
                AdminForm adminForm = new AdminForm();
                adminForm.Owner = this;
                adminForm.ShowDialog();
                Show();
            }
            else if (loginTextBox.Text == "direction" && passwordTextBox.Text == "anonym25")
            {
                Hide();
                this.Close();
                DirectorForm directorForm = new DirectorForm();
                directorForm.Owner = this;
                directorForm.ShowDialog();
                Show();
            }
            else if (loginTextBox.Text == "" && passwordTextBox.Text == "")
                MessageBox.Show("Введите данные для авторизации");
            else MessageBox.Show("Вы ввели неверный login или password");
        }
    }
}
