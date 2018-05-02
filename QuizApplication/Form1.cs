using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizApplication
{
    public partial class FormAdmin : Form
    {
        public string quizType2;
        public int NumberOfOptions, CorrectAnswer, QuestionId, QuestionNumber, questionId;

        public int RowIndex { get;  }
        public FormAdmin()
        {
            InitializeComponent();

           // lblTitle.Text = ApplicationSettings.applicationTitle;
            this.Text = ApplicationSettings.companyName;
            comboBox1.Items.Add("HTML");
            comboBox1.Items.Add("CSS");
            comboBox1.Items.Add("Java");

            comboBox2.Items.Add("HTML");
            comboBox2.Items.Add("CSS");
            comboBox2.Items.Add("Java");

        }

        private void FormAdminName_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbQuizAppDataSet.tblQuiz' table. You can move, or remove it, as needed.
            this.tblQuizTableAdapter.Fill(this.dbQuizAppDataSet.tblQuiz);

        }

        private void btmAdd_Click(object sender, EventArgs e)
        {
            string quizType;
            if (comboBox1.Text == "HTML")
                quizType = "HTML";
            else if (comboBox1.Text == "Java")
                quizType = "Java";
            else  
            quizType = "CSS";
            tblQuizTableAdapter.InsertData(QuestionId, QuestionNumber , txtQuestion.Text, txtOption1.Text, txtOption2.Text, txtOption3.Text, txtOption4.Text, NumberOfOptions, quizType, CorrectAnswer);
            MessageBox.Show("The question has been added successfully");
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            questionId = Convert.ToInt32(txtSearchQuesId.Text);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text == "HTML")
                quizType2 = "HTML";
            else if (comboBox2.Text == "CSS")
                quizType2 = "CSS";
            else
                quizType2 = "Java";
        }

        private void btmSearch_Click(object sender, EventArgs e)
        {
            this.tblQuizTableAdapter. SearchData(this.dbQuizAppDataSet.tblQuiz, questionId,  quizType2);
        }

        private void txtQuesId_TextChanged(object sender, EventArgs e)
        {
            QuestionId = Convert.ToInt32(txtQuesId.Text);
        }

        private void txtQuesNo_TextChanged(object sender, EventArgs e)
        {
            QuestionNumber = Convert.ToInt32(txtQuesNo.Text);
        }

        private void searchDataToolStripButton_Click_1(object sender, EventArgs e)
        {
            //try
            //{
            //    this.tblQuizTableAdapter.SearchData(this.dbQuizAppDataSet.tblQuiz, ((int)(System.Convert.ChangeType(questionIdToolStripTextBox.Text, typeof(int)))), quizTypeToolStripTextBox.Text);
            //}
            //catch (System.Exception ex)
            //{
            //    System.Windows.Forms.MessageBox.Show(ex.Message);
            //}

        }

        private void returnSearchedDataToolStripButton_Click(object sender, EventArgs e)
        {
        //    try
        //    {
        //        this.tblQuizTableAdapter.ReturnSearchedData(this.dbQuizAppDataSet.tblQuiz, ((int)(System.Convert.ChangeType(questionIdToolStripTextBox1.Text, typeof(int)))), quizTypeToolStripTextBox1.Text);
        //    }
        //    catch (System.Exception ex)
        //    {
        //        System.Windows.Forms.MessageBox.Show(ex.Message);
        //    }

        }

        private void btmEdit_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = EditQuestionTab;
           // tblQuizTableAdapter.FillData(questionId);
        }

        private void btmDelete_Click(object sender, EventArgs e)
        {
            tblQuizTableAdapter.DeleteData(questionId);
            MessageBox.Show("The question has been succesfully deleted");
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            new FormAdminLogin().Show();
        }

        private void tblQuizDataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }

        private void SearchQuestionTab_Click(object sender, EventArgs e)
        {

        }

        private void tblQuizDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tblQuizDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //if (base.tblQuizDataGridView != null)
            //{
            //    Point point1 = base.tblDataGridView.CurrentCellAddress;
            //    if (point1.X == e.ColumnIndex &&
            //        point1.Y == e.RowIndex &&
            //        e.Button == MouseButtons.Left &&
            //        base.DataGridView.EditMode !=
            //        DataGridViewEditMode.EditProgrammatically)
            //    {
            //        base.DataGridView.BeginEdit(true);
            //    }
            //}
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void searchDataToolStripButton_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    this.tblQuizTableAdapter.SearchData(this.dbQuizAppDataSet.tblQuiz, ((int)(System.Convert.ChangeType(questionIdToolStripTextBox.Text, typeof(int)))), quizTypeToolStripTextBox.Text);
            //}
            //catch (System.Exception ex)
            //{
            //    System.Windows.Forms.MessageBox.Show(ex.Message);
            //}

        }

        private void CorrectAns_ValueChanged(object sender, EventArgs e)
        {
            CorrectAnswer = Convert.ToInt32(CorrectAns.Value);
        }

        private void NoOfOpt_ValueChanged(object sender, EventArgs e)
        {
            NumberOfOptions = Convert.ToInt32(NoOfOpt.Value);
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tblQuizTableAdapter.Fill(this.dbQuizAppDataSet.tblQuiz);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
