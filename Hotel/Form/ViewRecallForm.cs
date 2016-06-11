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
    public partial class ViewRecallForm : Form
    {
        public ViewRecallForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void ViewRecallForm_Load(object sender, EventArgs e)
        {
            Recall recall = new Recall();
            DaoRecall daoRecall = new DaoRecall();
            recall = daoRecall.GetRecallOnId(Data.context, Data.intValue);
            topicTextBox.Text = recall.TopicRecall;
            recallTextBox.Text = recall.Comment;
        }
    }
}
