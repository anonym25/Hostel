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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hotelDataSet1.Recall". При необходимости она может быть перемещена или удалена.
            this.recallTableAdapter.FillByNotAnswer(this.hotelDataSet1.Recall);

        }

        private void recallDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Data.intValue = (int)recallDataGridView.CurrentRow.Cells[0].Value;
            Hide();
            SendAnswerForm sendAnswerForm = new SendAnswerForm();
            sendAnswerForm.Owner = this;
            sendAnswerForm.ShowDialog();
            Show();
        }

        private void просмотрКнигиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            BookPreviewForm bookPreviewForm = new BookPreviewForm();
            bookPreviewForm.Owner = this;
            bookPreviewForm.ShowDialog();
            Show();
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

        private void РаботаСДаннмиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Data.adminValue = true;
            Hide();
            DirectorForm directorForm = new DirectorForm();
            directorForm.Owner = this;
            directorForm.ShowDialog();
            Show();
        }

        private void AdminForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Data.adminValue)
                Data.adminValue = false;
        }
    }
}
