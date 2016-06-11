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
    public partial class DirectorForm : Form
    {
        public DirectorForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        WorkDataGridView work = new WorkDataGridView();
        private void DirectorForm_Load(object sender, EventArgs e)
        {
            if (Data.adminValue)
            {
                userPage.Parent = null;
                recallPage.Parent = null;
                answerPage.Parent = null;
            }
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hotelDataSet1.HotelUser". При необходимости она может быть перемещена или удалена.
            this.hotelUserTableAdapter.Fill(this.hotelDataSet1.HotelUser);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hotelDataSet1.Room". При необходимости она может быть перемещена или удалена.
            this.roomTableAdapter.Fill(this.hotelDataSet1.Room);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hotelDataSet1.Room". При необходимости она может быть перемещена или удалена.
            this.roomTableAdapter.Fill(this.hotelDataSet1.Room);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hotelDataSet1.Position". При необходимости она может быть перемещена или удалена.
            this.positionTableAdapter.Fill(this.hotelDataSet1.Position);
            work.PrintEmployee(employeeDataGridView);
            work.PrintRecall(recallDataGridView);
            work.PrintAnswer(answerDataGridView);
            labelRecord.Text = (positionDataGridView.RowCount - 1).ToString();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (directorTabControl.SelectedIndex == 0)
            {
                work.TabPosition(positionDataGridView);
                this.positionTableAdapter.Fill(this.hotelDataSet1.Position);
            }
            if (directorTabControl.SelectedIndex == 1)
            {
                work.TabRoom(roomDataGridView);
                this.roomTableAdapter.Fill(this.hotelDataSet1.Room);
            }
            if (directorTabControl.SelectedIndex == 2)
            {
                work.TabEmployee(employeeDataGridView);
                work.PrintEmployee(employeeDataGridView);
            }
        }

        private void directorTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (directorTabControl.SelectedIndex == 0)
            {
                addButton.Enabled = true;
                labelRecord.Text = (positionDataGridView.RowCount - 1).ToString();
                numberRecordTextBox.Value = 1;
            }
            if (directorTabControl.SelectedIndex == 1)
            {
                addButton.Enabled = true;
                labelRecord.Text = (roomDataGridView.RowCount - 1).ToString();
                numberRecordTextBox.Value = 1;
            }
            if (directorTabControl.SelectedIndex == 2)
            {
                addButton.Enabled = true;
                labelRecord.Text = (employeeDataGridView.RowCount - 1).ToString();
                numberRecordTextBox.Value = 1;
            }
            if (directorTabControl.SelectedIndex == 3)
            {
                addButton.Enabled = false;
                labelRecord.Text = hotelUserDataGridView.RowCount.ToString();
                numberRecordTextBox.Value = 1;
            }
            if (directorTabControl.SelectedIndex == 4)
            {
                addButton.Enabled = false;
                labelRecord.Text = recallDataGridView.RowCount.ToString();
                numberRecordTextBox.Value = 1;
            }
            if (directorTabControl.SelectedIndex == 5)
            {
                addButton.Enabled = false;
                labelRecord.Text = answerDataGridView.RowCount.ToString();
                numberRecordTextBox.Value = 1;
            }
        }

        private void prevDoubleButton_Click(object sender, EventArgs e)
        {
            if (directorTabControl.SelectedIndex == 0 && positionDataGridView.CurrentCell.RowIndex != 0)
            {
                positionDataGridView.CurrentCell = positionDataGridView[0, 0];
                numberRecordTextBox.Value = 1;
            }
            if (directorTabControl.SelectedIndex == 1 && roomDataGridView.CurrentCell.RowIndex != 0)
            {
                roomDataGridView.CurrentCell = roomDataGridView[0, 0];
                numberRecordTextBox.Value = 1;
            }
            if (directorTabControl.SelectedIndex == 2 && employeeDataGridView.CurrentCell.RowIndex != 0)
            {
                employeeDataGridView.CurrentCell = employeeDataGridView[0, 0];
                numberRecordTextBox.Value = 1;
            }
            if (directorTabControl.SelectedIndex == 3 && hotelUserDataGridView.CurrentCell.RowIndex != 0)
            {
                hotelUserDataGridView.CurrentCell = hotelUserDataGridView[0, 0];
                numberRecordTextBox.Value = 1;
            }
            if (directorTabControl.SelectedIndex == 4 && recallDataGridView.CurrentCell.RowIndex != 0)
            {
                recallDataGridView.CurrentCell = recallDataGridView[0, 0];
                numberRecordTextBox.Value = 1;
            } if (directorTabControl.SelectedIndex == 5 && answerDataGridView.CurrentCell.RowIndex != 0)
            {
                answerDataGridView.CurrentCell = answerDataGridView[0, 0];
                numberRecordTextBox.Value = 1;
            }
        }

        private void prevButton_Click(object sender, EventArgs e)
        {
            if (directorTabControl.SelectedIndex == 0 && positionDataGridView.CurrentCell.RowIndex != 0)
            {
                positionDataGridView.CurrentCell = positionDataGridView[0, positionDataGridView.CurrentCell.RowIndex - 1];
                numberRecordTextBox.Value = positionDataGridView.CurrentCell.RowIndex + 1;
            }
            if (directorTabControl.SelectedIndex == 1 && roomDataGridView.CurrentCell.RowIndex != 0)
            {
                roomDataGridView.CurrentCell = roomDataGridView[0, roomDataGridView.CurrentCell.RowIndex - 1];
                numberRecordTextBox.Value = roomDataGridView.CurrentCell.RowIndex + 1;
            }
            if (directorTabControl.SelectedIndex == 2 && employeeDataGridView.CurrentCell.RowIndex != 0)
            {
                employeeDataGridView.CurrentCell = employeeDataGridView[0, employeeDataGridView.CurrentCell.RowIndex - 1];
                numberRecordTextBox.Value = employeeDataGridView.CurrentCell.RowIndex + 1;
            }
            if (directorTabControl.SelectedIndex == 3 && hotelUserDataGridView.CurrentCell.RowIndex != 0)
            {
                hotelUserDataGridView.CurrentCell = hotelUserDataGridView[0, hotelUserDataGridView.CurrentCell.RowIndex - 1];
                numberRecordTextBox.Value = hotelUserDataGridView.CurrentCell.RowIndex + 1;
            }
            if (directorTabControl.SelectedIndex == 4 && recallDataGridView.CurrentCell.RowIndex != 0)
            {
                recallDataGridView.CurrentCell = recallDataGridView[0, recallDataGridView.CurrentCell.RowIndex - 1];
                numberRecordTextBox.Value = recallDataGridView.CurrentCell.RowIndex + 1;
            } if (directorTabControl.SelectedIndex == 5 && answerDataGridView.CurrentCell.RowIndex != 0)
            {
                answerDataGridView.CurrentCell = answerDataGridView[0, answerDataGridView.CurrentCell.RowIndex - 1];
                numberRecordTextBox.Value = answerDataGridView.CurrentCell.RowIndex + 1;
            }
        }

        private void positionDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (directorTabControl.SelectedIndex == 0)
                numberRecordTextBox.Value = positionDataGridView.CurrentCell.RowIndex + 1;
            if (directorTabControl.SelectedIndex == 1 && roomDataGridView.CurrentCell.RowIndex != roomDataGridView.RowCount - 1)
                numberRecordTextBox.Value = roomDataGridView.CurrentCell.RowIndex + 1;
            if (directorTabControl.SelectedIndex == 2 && employeeDataGridView.CurrentCell.RowIndex != employeeDataGridView.RowCount - 1)
                numberRecordTextBox.Value = employeeDataGridView.CurrentCell.RowIndex + 1;
            if (directorTabControl.SelectedIndex == 3 && hotelUserDataGridView.CurrentCell.RowIndex != hotelUserDataGridView.RowCount - 1)
                numberRecordTextBox.Value = hotelUserDataGridView.CurrentCell.RowIndex + 1;
            if (directorTabControl.SelectedIndex == 4 && recallDataGridView.CurrentCell.RowIndex != recallDataGridView.RowCount - 1)
                numberRecordTextBox.Value = recallDataGridView.CurrentCell.RowIndex + 1;
            if (directorTabControl.SelectedIndex == 5 && answerDataGridView.CurrentCell.RowIndex != answerDataGridView.RowCount - 1)
                numberRecordTextBox.Value = answerDataGridView.CurrentCell.RowIndex + 1;
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (directorTabControl.SelectedIndex == 0 && positionDataGridView.CurrentCell.RowIndex != positionDataGridView.RowCount - 1)
            {
                positionDataGridView.CurrentCell = positionDataGridView[0, positionDataGridView.CurrentCell.RowIndex + 1];
                numberRecordTextBox.Value = positionDataGridView.CurrentCell.RowIndex + 1;
            }
            if (directorTabControl.SelectedIndex == 1 && roomDataGridView.CurrentCell.RowIndex != roomDataGridView.RowCount - 1)
            {
                roomDataGridView.CurrentCell = roomDataGridView[0, roomDataGridView.CurrentCell.RowIndex + 1];
                numberRecordTextBox.Value = roomDataGridView.CurrentCell.RowIndex + 1;
            }
            if (directorTabControl.SelectedIndex == 2 && employeeDataGridView.CurrentCell.RowIndex != employeeDataGridView.RowCount - 1)
            {
                employeeDataGridView.CurrentCell = employeeDataGridView[0, employeeDataGridView.CurrentCell.RowIndex + 1];
                numberRecordTextBox.Value = employeeDataGridView.CurrentCell.RowIndex + 1;
            }
            if (directorTabControl.SelectedIndex == 3 && hotelUserDataGridView.CurrentCell.RowIndex != hotelUserDataGridView.RowCount - 1)
            {
                hotelUserDataGridView.CurrentCell = hotelUserDataGridView[0, hotelUserDataGridView.CurrentCell.RowIndex + 1];
                numberRecordTextBox.Value = hotelUserDataGridView.CurrentCell.RowIndex + 1;
            }
            if (directorTabControl.SelectedIndex == 4 && recallDataGridView.CurrentCell.RowIndex != recallDataGridView.RowCount - 1)
            {
                recallDataGridView.CurrentCell = recallDataGridView[0, recallDataGridView.CurrentCell.RowIndex + 1];
                numberRecordTextBox.Value = recallDataGridView.CurrentCell.RowIndex + 1;
            } if (directorTabControl.SelectedIndex == 5 && answerDataGridView.CurrentCell.RowIndex != answerDataGridView.RowCount - 1)
            {
                answerDataGridView.CurrentCell = answerDataGridView[0, answerDataGridView.CurrentCell.RowIndex + 1];
                numberRecordTextBox.Value = answerDataGridView.CurrentCell.RowIndex + 1;
            }
        }

        private void nextDoubleButton_Click(object sender, EventArgs e)
        {
            if (directorTabControl.SelectedIndex == 0 && positionDataGridView.CurrentCell.RowIndex != positionDataGridView.RowCount - 1)
            {
                positionDataGridView.CurrentCell = positionDataGridView[0, positionDataGridView.RowCount - 2];
                numberRecordTextBox.Value = positionDataGridView.RowCount - 1;
            }
            if (directorTabControl.SelectedIndex == 1 && roomDataGridView.CurrentCell.RowIndex != roomDataGridView.CurrentCell.RowIndex - 1)
            {
                roomDataGridView.CurrentCell = roomDataGridView[0, roomDataGridView.RowCount - 2];
                numberRecordTextBox.Value = roomDataGridView.RowCount - 1;
            }
            if (directorTabControl.SelectedIndex == 2 && employeeDataGridView.CurrentCell.RowIndex != employeeDataGridView.CurrentCell.RowIndex - 1)
            {
                employeeDataGridView.CurrentCell = employeeDataGridView[0, employeeDataGridView.RowCount - 2];
                numberRecordTextBox.Value = employeeDataGridView.RowCount - 1;
            }
            if (directorTabControl.SelectedIndex == 3 && hotelUserDataGridView.CurrentCell.RowIndex != hotelUserDataGridView.CurrentCell.RowIndex - 1)
            {
                hotelUserDataGridView.CurrentCell = hotelUserDataGridView[0, hotelUserDataGridView.RowCount - 1];
                numberRecordTextBox.Value = hotelUserDataGridView.RowCount;
            }
            if (directorTabControl.SelectedIndex == 4 && recallDataGridView.CurrentCell.RowIndex != recallDataGridView.CurrentCell.RowIndex - 1)
            {
                recallDataGridView.CurrentCell = recallDataGridView[0, recallDataGridView.RowCount - 1];
                numberRecordTextBox.Value = recallDataGridView.RowCount;
            } if (directorTabControl.SelectedIndex == 5 && answerDataGridView.CurrentCell.RowIndex != answerDataGridView.CurrentCell.RowIndex - 1)
            {
                answerDataGridView.CurrentCell = answerDataGridView[0, answerDataGridView.RowCount - 1];
                numberRecordTextBox.Value = answerDataGridView.RowCount;
            }
        }

        private void numberRecordTextBox_ValueChanged(object sender, EventArgs e)
        {
            if (directorTabControl.SelectedIndex == 0)
                if (numberRecordTextBox.Value <= positionDataGridView.RowCount - 1 && numberRecordTextBox.Value > 0)
                    positionDataGridView.CurrentCell = positionDataGridView[0, (int)numberRecordTextBox.Value - 1];
            if (directorTabControl.SelectedIndex == 1)
                if (numberRecordTextBox.Value <= roomDataGridView.RowCount - 1 && numberRecordTextBox.Value > 0)
                    roomDataGridView.CurrentCell = roomDataGridView[0, (int)numberRecordTextBox.Value - 1];
            if (directorTabControl.SelectedIndex == 2)
                if (numberRecordTextBox.Value <= employeeDataGridView.RowCount - 1 && numberRecordTextBox.Value > 0)
                    employeeDataGridView.CurrentCell = employeeDataGridView[0, (int)numberRecordTextBox.Value - 1];
            if (directorTabControl.SelectedIndex == 3)
                if (numberRecordTextBox.Value <= hotelUserDataGridView.RowCount - 1 && numberRecordTextBox.Value > 0)
                    hotelUserDataGridView.CurrentCell = hotelUserDataGridView[0, (int)numberRecordTextBox.Value - 1];
            if (directorTabControl.SelectedIndex == 4)
                if (numberRecordTextBox.Value <= recallDataGridView.RowCount - 1 && numberRecordTextBox.Value > 0)
                    recallDataGridView.CurrentCell = recallDataGridView[0, (int)numberRecordTextBox.Value - 1];
            if (directorTabControl.SelectedIndex == 5)
                if (numberRecordTextBox.Value <= answerDataGridView.RowCount - 1 && numberRecordTextBox.Value > 0)
                    answerDataGridView.CurrentCell = answerDataGridView[0, (int)numberRecordTextBox.Value - 1];
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DaoEmployee daoEmployee = new DaoEmployee();
            DaoPosition daoPosition = new DaoPosition();
            DaoRoom daoRoom = new DaoRoom();
            DaoRecall daoRecall = new DaoRecall();
            DaoHotelUser daoHotelUser = new DaoHotelUser();
            DaoAnswer daoAnswer = new DaoAnswer();
            if (directorTabControl.SelectedIndex == 0)
                daoPosition.DeletePosition(Data.context, Convert.ToInt16(positionDataGridView.Rows[positionDataGridView.CurrentCell.RowIndex].Cells[0].Value.ToString()));
            this.positionTableAdapter.Fill(this.hotelDataSet1.Position);
            if (directorTabControl.SelectedIndex == 1)
                daoRoom.DeleteRoom(Data.context, Convert.ToInt16(roomDataGridView.Rows[roomDataGridView.CurrentCell.RowIndex].Cells[0].Value.ToString()));
            this.roomTableAdapter.Fill(this.hotelDataSet1.Room);
            if (directorTabControl.SelectedIndex == 2)
                daoEmployee.DeleteEmployee(Data.context, Convert.ToInt16(employeeDataGridView.Rows[employeeDataGridView.CurrentCell.RowIndex].Cells[0].Value.ToString()));
            work.PrintEmployee(employeeDataGridView);
            if (directorTabControl.SelectedIndex == 3)
                daoHotelUser.DeleteRoom(Data.context, Convert.ToInt16(hotelUserDataGridView.Rows[hotelUserDataGridView.CurrentCell.RowIndex].Cells[0].Value.ToString()));
            this.hotelUserTableAdapter.Fill(this.hotelDataSet1.HotelUser);
            if (directorTabControl.SelectedIndex == 4)
                daoRecall.DeleteRecall(Data.context, Convert.ToInt16(recallDataGridView.Rows[recallDataGridView.CurrentCell.RowIndex].Cells[0].Value.ToString()));
            work.PrintRecall(recallDataGridView);
            if (directorTabControl.SelectedIndex == 5)
                daoAnswer.DeleteAnswer(Data.context, Convert.ToInt16(answerDataGridView.Rows[answerDataGridView.CurrentCell.RowIndex].Cells[0].Value.ToString()));
            work.PrintAnswer(answerDataGridView);
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

        private void информацияОРазработчикахToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Выпускная квалификационная работа бакалавра по теме: \n«АВТОМАТИЗИРОВАННАЯ СИСТЕМА «КНИГА ЖАЛОБ И ПРЕДЛОЖЕНИЙ ГОСТИНИЦЫ». \nВыполнила студентка группы 6402Б358: Назарова А.Н. \nРуководитель проекта: Соловьева Я.В.");
        }

        private void просмотрКнигиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            BookPreviewForm bookPreviewForm = new BookPreviewForm();
            bookPreviewForm.Owner = this;
            bookPreviewForm.ShowDialog();
            Show();
        }
    }
}