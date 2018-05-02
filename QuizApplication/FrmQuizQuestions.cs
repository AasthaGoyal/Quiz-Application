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
    public partial class FrmQuizQuestions : Form
    {
        List<QuizQuestions> allQuestions;
        DataAccessLayer dao = new DataAccessLayer();
        int currentRecord;

       public string type { get; set; }
        public FrmQuizQuestions()
        {
            InitializeComponent();
         //   type = Type;
            
        }

        private void rbOption1_CheckedChanged(object sender, EventArgs e)
        {
 
        }

        private void LoadData()
        {
            QuizQuestions aQues = allQuestions[currentRecord];
            lblquestion.Text = aQues.question;
            rbOption1.Text = aQues.option1;
            rbOption2.Text = aQues.option2;
            rbOption3.Text = aQues.option3;
            rbOption4.Text = aQues.option4;

        }
        private void FrmQuizQuestions_Load(object sender, EventArgs e)
        {
            allQuestions = dao.GetAllQuestions();
            currentRecord = 0;
            LoadData();
         //   MessageBox.Show("Question = " + aQues.question);

            //   currentRecord = 0;
            // LoadData();
        }

        private void lblquestion_Click(object sender, EventArgs e)
        {

        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            currentRecord--;
            LoadData();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            currentRecord++;
            LoadData();
        }
    }
}
