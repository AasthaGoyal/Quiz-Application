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
    public partial class FormQuizMain : Form
    {
        public string Type;
        public FormQuizMain()
        {
            InitializeComponent();
            comboBox1.Items.Add("HTML");
            comboBox1.Items.Add("CSS");
            comboBox1.Items.Add("Java");
        }

        private void FormQuizMain_Load(object sender, EventArgs e)
        {

        }

        private void btmAdmin_Click(object sender, EventArgs e)
        {
            new FormAdminLogin().Show();
        }

        private void btmNew_Click(object sender, EventArgs e)
        {
            new RegisterNewUser().Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btmGo_Click(object sender, EventArgs e)
        {
            new FrmQuizQuestions().Show();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Type = comboBox1.SelectedItem.ToString();
        }
    }
}
