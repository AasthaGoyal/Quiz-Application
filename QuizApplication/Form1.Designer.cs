namespace QuizApplication
{
    partial class FormAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label questionIdLabel;
            System.Windows.Forms.Label questionNumberLabel;
            System.Windows.Forms.Label questionLabel;
            System.Windows.Forms.Label option1Label;
            System.Windows.Forms.Label option2Label;
            System.Windows.Forms.Label option3Label;
            System.Windows.Forms.Label option4Label;
            System.Windows.Forms.Label optionToDisplayLabel;
            System.Windows.Forms.Label quizTypeLabel;
            System.Windows.Forms.Label correctAnswerLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdmin));
            this.lblTitle = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.AddQuestionTab = new System.Windows.Forms.TabPage();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btmCancel = new System.Windows.Forms.Button();
            this.btmAdd = new System.Windows.Forms.Button();
            this.CorrectAns = new System.Windows.Forms.NumericUpDown();
            this.NoOfOpt = new System.Windows.Forms.NumericUpDown();
            this.txtOption4 = new System.Windows.Forms.TextBox();
            this.txtOption2 = new System.Windows.Forms.TextBox();
            this.txtOption3 = new System.Windows.Forms.TextBox();
            this.txtOption1 = new System.Windows.Forms.TextBox();
            this.txtQuestion = new System.Windows.Forms.TextBox();
            this.txtQuesNo = new System.Windows.Forms.TextBox();
            this.txtQuesId = new System.Windows.Forms.TextBox();
            this.lblQuesType = new System.Windows.Forms.Label();
            this.lblCorrectAns = new System.Windows.Forms.Label();
            this.lblNoOfOptions = new System.Windows.Forms.Label();
            this.lblOption4 = new System.Windows.Forms.Label();
            this.lblOption3 = new System.Windows.Forms.Label();
            this.lblOption2 = new System.Windows.Forms.Label();
            this.lblOption1 = new System.Windows.Forms.Label();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.lblQuesNo = new System.Windows.Forms.Label();
            this.lblQuesId = new System.Windows.Forms.Label();
            this.SearchQuestionTab = new System.Windows.Forms.TabPage();
            this.tblQuizDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblQuizBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbQuizAppDataSet = new QuizApplication.dbQuizAppDataSet();
            this.btmDelete = new System.Windows.Forms.Button();
            this.btmEdit = new System.Windows.Forms.Button();
            this.btmSearch = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.txtSearchQuesId = new System.Windows.Forms.TextBox();
            this.lblSearchQuizType = new System.Windows.Forms.Label();
            this.lblSearchQuestionId = new System.Windows.Forms.Label();
            this.EditQuestionTab = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.questionIdTextBox = new System.Windows.Forms.TextBox();
            this.questionNumberTextBox = new System.Windows.Forms.TextBox();
            this.questionTextBox = new System.Windows.Forms.TextBox();
            this.option1TextBox = new System.Windows.Forms.TextBox();
            this.option2TextBox = new System.Windows.Forms.TextBox();
            this.option3TextBox = new System.Windows.Forms.TextBox();
            this.option4TextBox = new System.Windows.Forms.TextBox();
            this.optionToDisplayTextBox = new System.Windows.Forms.TextBox();
            this.quizTypeTextBox = new System.Windows.Forms.TextBox();
            this.correctAnswerTextBox = new System.Windows.Forms.TextBox();
            this.tblQuizBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tblQuizBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.label11 = new System.Windows.Forms.Label();
            this.tblQuizTableAdapter = new QuizApplication.dbQuizAppDataSetTableAdapters.tblQuizTableAdapter();
            this.tableAdapterManager = new QuizApplication.dbQuizAppDataSetTableAdapters.TableAdapterManager();
            questionIdLabel = new System.Windows.Forms.Label();
            questionNumberLabel = new System.Windows.Forms.Label();
            questionLabel = new System.Windows.Forms.Label();
            option1Label = new System.Windows.Forms.Label();
            option2Label = new System.Windows.Forms.Label();
            option3Label = new System.Windows.Forms.Label();
            option4Label = new System.Windows.Forms.Label();
            optionToDisplayLabel = new System.Windows.Forms.Label();
            quizTypeLabel = new System.Windows.Forms.Label();
            correctAnswerLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.AddQuestionTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CorrectAns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NoOfOpt)).BeginInit();
            this.SearchQuestionTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblQuizDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblQuizBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbQuizAppDataSet)).BeginInit();
            this.EditQuestionTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblQuizBindingNavigator)).BeginInit();
            this.tblQuizBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // questionIdLabel
            // 
            questionIdLabel.AutoSize = true;
            questionIdLabel.Location = new System.Drawing.Point(34, 72);
            questionIdLabel.Name = "questionIdLabel";
            questionIdLabel.Size = new System.Drawing.Size(64, 13);
            questionIdLabel.TabIndex = 58;
            questionIdLabel.Text = "Question Id:";
            // 
            // questionNumberLabel
            // 
            questionNumberLabel.AutoSize = true;
            questionNumberLabel.Location = new System.Drawing.Point(34, 98);
            questionNumberLabel.Name = "questionNumberLabel";
            questionNumberLabel.Size = new System.Drawing.Size(92, 13);
            questionNumberLabel.TabIndex = 60;
            questionNumberLabel.Text = "Question Number:";
            // 
            // questionLabel
            // 
            questionLabel.AutoSize = true;
            questionLabel.Location = new System.Drawing.Point(34, 124);
            questionLabel.Name = "questionLabel";
            questionLabel.Size = new System.Drawing.Size(52, 13);
            questionLabel.TabIndex = 62;
            questionLabel.Text = "Question:";
            // 
            // option1Label
            // 
            option1Label.AutoSize = true;
            option1Label.Location = new System.Drawing.Point(34, 150);
            option1Label.Name = "option1Label";
            option1Label.Size = new System.Drawing.Size(45, 13);
            option1Label.TabIndex = 64;
            option1Label.Text = "option1:";
            // 
            // option2Label
            // 
            option2Label.AutoSize = true;
            option2Label.Location = new System.Drawing.Point(34, 176);
            option2Label.Name = "option2Label";
            option2Label.Size = new System.Drawing.Size(45, 13);
            option2Label.TabIndex = 66;
            option2Label.Text = "option2:";
            // 
            // option3Label
            // 
            option3Label.AutoSize = true;
            option3Label.Location = new System.Drawing.Point(34, 202);
            option3Label.Name = "option3Label";
            option3Label.Size = new System.Drawing.Size(45, 13);
            option3Label.TabIndex = 68;
            option3Label.Text = "option3:";
            // 
            // option4Label
            // 
            option4Label.AutoSize = true;
            option4Label.Location = new System.Drawing.Point(34, 228);
            option4Label.Name = "option4Label";
            option4Label.Size = new System.Drawing.Size(45, 13);
            option4Label.TabIndex = 70;
            option4Label.Text = "option4:";
            // 
            // optionToDisplayLabel
            // 
            optionToDisplayLabel.AutoSize = true;
            optionToDisplayLabel.Location = new System.Drawing.Point(34, 254);
            optionToDisplayLabel.Name = "optionToDisplayLabel";
            optionToDisplayLabel.Size = new System.Drawing.Size(92, 13);
            optionToDisplayLabel.TabIndex = 72;
            optionToDisplayLabel.Text = "option To Display:";
            // 
            // quizTypeLabel
            // 
            quizTypeLabel.AutoSize = true;
            quizTypeLabel.Location = new System.Drawing.Point(34, 280);
            quizTypeLabel.Name = "quizTypeLabel";
            quizTypeLabel.Size = new System.Drawing.Size(56, 13);
            quizTypeLabel.TabIndex = 74;
            quizTypeLabel.Text = "quiz Type:";
            // 
            // correctAnswerLabel
            // 
            correctAnswerLabel.AutoSize = true;
            correctAnswerLabel.Location = new System.Drawing.Point(34, 306);
            correctAnswerLabel.Name = "correctAnswerLabel";
            correctAnswerLabel.Size = new System.Drawing.Size(82, 13);
            correctAnswerLabel.TabIndex = 76;
            correctAnswerLabel.Text = "Correct Answer:";
            // 
            // lblTitle
            // 
            this.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTitle.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(23, 38);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(602, 42);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Welcome Administrator";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.AddQuestionTab);
            this.tabControl1.Controls.Add(this.SearchQuestionTab);
            this.tabControl1.Controls.Add(this.EditQuestionTab);
            this.tabControl1.Location = new System.Drawing.Point(2, 95);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(772, 457);
            this.tabControl1.TabIndex = 2;
            // 
            // AddQuestionTab
            // 
            this.AddQuestionTab.Controls.Add(this.comboBox1);
            this.AddQuestionTab.Controls.Add(this.btmCancel);
            this.AddQuestionTab.Controls.Add(this.btmAdd);
            this.AddQuestionTab.Controls.Add(this.CorrectAns);
            this.AddQuestionTab.Controls.Add(this.NoOfOpt);
            this.AddQuestionTab.Controls.Add(this.txtOption4);
            this.AddQuestionTab.Controls.Add(this.txtOption2);
            this.AddQuestionTab.Controls.Add(this.txtOption3);
            this.AddQuestionTab.Controls.Add(this.txtOption1);
            this.AddQuestionTab.Controls.Add(this.txtQuestion);
            this.AddQuestionTab.Controls.Add(this.txtQuesNo);
            this.AddQuestionTab.Controls.Add(this.txtQuesId);
            this.AddQuestionTab.Controls.Add(this.lblQuesType);
            this.AddQuestionTab.Controls.Add(this.lblCorrectAns);
            this.AddQuestionTab.Controls.Add(this.lblNoOfOptions);
            this.AddQuestionTab.Controls.Add(this.lblOption4);
            this.AddQuestionTab.Controls.Add(this.lblOption3);
            this.AddQuestionTab.Controls.Add(this.lblOption2);
            this.AddQuestionTab.Controls.Add(this.lblOption1);
            this.AddQuestionTab.Controls.Add(this.lblQuestion);
            this.AddQuestionTab.Controls.Add(this.lblQuesNo);
            this.AddQuestionTab.Controls.Add(this.lblQuesId);
            this.AddQuestionTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddQuestionTab.Location = new System.Drawing.Point(4, 22);
            this.AddQuestionTab.Name = "AddQuestionTab";
            this.AddQuestionTab.Padding = new System.Windows.Forms.Padding(3);
            this.AddQuestionTab.Size = new System.Drawing.Size(764, 431);
            this.AddQuestionTab.TabIndex = 0;
            this.AddQuestionTab.Text = "Add ";
            this.AddQuestionTab.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(223, 262);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(213, 28);
            this.comboBox1.TabIndex = 34;
            // 
            // btmCancel
            // 
            this.btmCancel.Location = new System.Drawing.Point(35, 325);
            this.btmCancel.Name = "btmCancel";
            this.btmCancel.Size = new System.Drawing.Size(168, 41);
            this.btmCancel.TabIndex = 33;
            this.btmCancel.Text = "Cancel";
            this.btmCancel.UseVisualStyleBackColor = true;
            // 
            // btmAdd
            // 
            this.btmAdd.Location = new System.Drawing.Point(450, 325);
            this.btmAdd.Name = "btmAdd";
            this.btmAdd.Size = new System.Drawing.Size(173, 41);
            this.btmAdd.TabIndex = 32;
            this.btmAdd.Text = "Add Question";
            this.btmAdd.UseVisualStyleBackColor = true;
            this.btmAdd.Click += new System.EventHandler(this.btmAdd_Click);
            // 
            // CorrectAns
            // 
            this.CorrectAns.Location = new System.Drawing.Point(223, 227);
            this.CorrectAns.Name = "CorrectAns";
            this.CorrectAns.Size = new System.Drawing.Size(213, 26);
            this.CorrectAns.TabIndex = 30;
            this.CorrectAns.ValueChanged += new System.EventHandler(this.CorrectAns_ValueChanged);
            // 
            // NoOfOpt
            // 
            this.NoOfOpt.Location = new System.Drawing.Point(223, 196);
            this.NoOfOpt.Name = "NoOfOpt";
            this.NoOfOpt.Size = new System.Drawing.Size(213, 26);
            this.NoOfOpt.TabIndex = 29;
            this.NoOfOpt.ValueChanged += new System.EventHandler(this.NoOfOpt_ValueChanged);
            // 
            // txtOption4
            // 
            this.txtOption4.Location = new System.Drawing.Point(409, 160);
            this.txtOption4.Name = "txtOption4";
            this.txtOption4.Size = new System.Drawing.Size(215, 26);
            this.txtOption4.TabIndex = 28;
            // 
            // txtOption2
            // 
            this.txtOption2.Location = new System.Drawing.Point(154, 159);
            this.txtOption2.Name = "txtOption2";
            this.txtOption2.Size = new System.Drawing.Size(151, 26);
            this.txtOption2.TabIndex = 27;
            // 
            // txtOption3
            // 
            this.txtOption3.Location = new System.Drawing.Point(409, 128);
            this.txtOption3.Name = "txtOption3";
            this.txtOption3.Size = new System.Drawing.Size(215, 26);
            this.txtOption3.TabIndex = 26;
            // 
            // txtOption1
            // 
            this.txtOption1.Location = new System.Drawing.Point(154, 128);
            this.txtOption1.Name = "txtOption1";
            this.txtOption1.Size = new System.Drawing.Size(151, 26);
            this.txtOption1.TabIndex = 25;
            // 
            // txtQuestion
            // 
            this.txtQuestion.Location = new System.Drawing.Point(154, 92);
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.Size = new System.Drawing.Size(470, 26);
            this.txtQuestion.TabIndex = 24;
            // 
            // txtQuesNo
            // 
            this.txtQuesNo.Location = new System.Drawing.Point(154, 55);
            this.txtQuesNo.Name = "txtQuesNo";
            this.txtQuesNo.Size = new System.Drawing.Size(470, 26);
            this.txtQuesNo.TabIndex = 23;
            this.txtQuesNo.TextChanged += new System.EventHandler(this.txtQuesNo_TextChanged);
            // 
            // txtQuesId
            // 
            this.txtQuesId.Location = new System.Drawing.Point(154, 22);
            this.txtQuesId.Name = "txtQuesId";
            this.txtQuesId.Size = new System.Drawing.Size(470, 26);
            this.txtQuesId.TabIndex = 22;
            this.txtQuesId.TextChanged += new System.EventHandler(this.txtQuesId_TextChanged);
            // 
            // lblQuesType
            // 
            this.lblQuesType.AutoSize = true;
            this.lblQuesType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuesType.Location = new System.Drawing.Point(31, 262);
            this.lblQuesType.Name = "lblQuesType";
            this.lblQuesType.Size = new System.Drawing.Size(115, 20);
            this.lblQuesType.TabIndex = 21;
            this.lblQuesType.Text = "Question Type:";
            // 
            // lblCorrectAns
            // 
            this.lblCorrectAns.AutoSize = true;
            this.lblCorrectAns.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorrectAns.Location = new System.Drawing.Point(31, 228);
            this.lblCorrectAns.Name = "lblCorrectAns";
            this.lblCorrectAns.Size = new System.Drawing.Size(122, 20);
            this.lblCorrectAns.TabIndex = 20;
            this.lblCorrectAns.Text = "Correct Answer:";
            // 
            // lblNoOfOptions
            // 
            this.lblNoOfOptions.AutoSize = true;
            this.lblNoOfOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoOfOptions.Location = new System.Drawing.Point(31, 197);
            this.lblNoOfOptions.Name = "lblNoOfOptions";
            this.lblNoOfOptions.Size = new System.Drawing.Size(149, 20);
            this.lblNoOfOptions.TabIndex = 19;
            this.lblNoOfOptions.Text = "Number Of Options:";
            // 
            // lblOption4
            // 
            this.lblOption4.AutoSize = true;
            this.lblOption4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOption4.Location = new System.Drawing.Point(311, 159);
            this.lblOption4.Name = "lblOption4";
            this.lblOption4.Size = new System.Drawing.Size(69, 20);
            this.lblOption4.TabIndex = 18;
            this.lblOption4.Text = "Option4:";
            // 
            // lblOption3
            // 
            this.lblOption3.AutoSize = true;
            this.lblOption3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOption3.Location = new System.Drawing.Point(311, 128);
            this.lblOption3.Name = "lblOption3";
            this.lblOption3.Size = new System.Drawing.Size(69, 20);
            this.lblOption3.TabIndex = 17;
            this.lblOption3.Text = "Option3:";
            // 
            // lblOption2
            // 
            this.lblOption2.AutoSize = true;
            this.lblOption2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOption2.Location = new System.Drawing.Point(31, 159);
            this.lblOption2.Name = "lblOption2";
            this.lblOption2.Size = new System.Drawing.Size(69, 20);
            this.lblOption2.TabIndex = 16;
            this.lblOption2.Text = "Option2:";
            // 
            // lblOption1
            // 
            this.lblOption1.AutoSize = true;
            this.lblOption1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOption1.Location = new System.Drawing.Point(31, 128);
            this.lblOption1.Name = "lblOption1";
            this.lblOption1.Size = new System.Drawing.Size(69, 20);
            this.lblOption1.TabIndex = 15;
            this.lblOption1.Text = "Option1:";
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.Location = new System.Drawing.Point(31, 92);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(77, 20);
            this.lblQuestion.TabIndex = 14;
            this.lblQuestion.Text = "Question:";
            // 
            // lblQuesNo
            // 
            this.lblQuesNo.AutoSize = true;
            this.lblQuesNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuesNo.Location = new System.Drawing.Point(31, 56);
            this.lblQuesNo.Name = "lblQuesNo";
            this.lblQuesNo.Size = new System.Drawing.Size(101, 20);
            this.lblQuesNo.TabIndex = 13;
            this.lblQuesNo.Text = "Question No:";
            // 
            // lblQuesId
            // 
            this.lblQuesId.AutoSize = true;
            this.lblQuesId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuesId.Location = new System.Drawing.Point(31, 23);
            this.lblQuesId.Name = "lblQuesId";
            this.lblQuesId.Size = new System.Drawing.Size(98, 20);
            this.lblQuesId.TabIndex = 12;
            this.lblQuesId.Text = "Question ID:";
            // 
            // SearchQuestionTab
            // 
            this.SearchQuestionTab.AutoScroll = true;
            this.SearchQuestionTab.Controls.Add(this.tblQuizDataGridView);
            this.SearchQuestionTab.Controls.Add(this.btmDelete);
            this.SearchQuestionTab.Controls.Add(this.btmEdit);
            this.SearchQuestionTab.Controls.Add(this.btmSearch);
            this.SearchQuestionTab.Controls.Add(this.comboBox2);
            this.SearchQuestionTab.Controls.Add(this.txtSearchQuesId);
            this.SearchQuestionTab.Controls.Add(this.lblSearchQuizType);
            this.SearchQuestionTab.Controls.Add(this.lblSearchQuestionId);
            this.SearchQuestionTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchQuestionTab.Location = new System.Drawing.Point(4, 22);
            this.SearchQuestionTab.Name = "SearchQuestionTab";
            this.SearchQuestionTab.Padding = new System.Windows.Forms.Padding(3);
            this.SearchQuestionTab.Size = new System.Drawing.Size(764, 431);
            this.SearchQuestionTab.TabIndex = 1;
            this.SearchQuestionTab.Text = "Search";
            this.SearchQuestionTab.UseVisualStyleBackColor = true;
            this.SearchQuestionTab.Click += new System.EventHandler(this.SearchQuestionTab_Click);
            // 
            // tblQuizDataGridView
            // 
            this.tblQuizDataGridView.AutoGenerateColumns = false;
            this.tblQuizDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblQuizDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.tblQuizDataGridView.DataSource = this.tblQuizBindingSource;
            this.tblQuizDataGridView.Location = new System.Drawing.Point(33, 106);
            this.tblQuizDataGridView.Name = "tblQuizDataGridView";
            this.tblQuizDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblQuizDataGridView.Size = new System.Drawing.Size(698, 258);
            this.tblQuizDataGridView.TabIndex = 7;
            this.tblQuizDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblQuizDataGridView_CellContentClick);
            this.tblQuizDataGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.tblQuizDataGridView_CellMouseDoubleClick);
            this.tblQuizDataGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.tblQuizDataGridView_RowHeaderMouseClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "QuestionId";
            this.dataGridViewTextBoxColumn1.HeaderText = "QuestionId";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "QuestionNumber";
            this.dataGridViewTextBoxColumn2.HeaderText = "QuestionNumber";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Question";
            this.dataGridViewTextBoxColumn3.HeaderText = "Question";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "option1";
            this.dataGridViewTextBoxColumn4.HeaderText = "option1";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "option2";
            this.dataGridViewTextBoxColumn5.HeaderText = "option2";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "option3";
            this.dataGridViewTextBoxColumn6.HeaderText = "option3";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "option4";
            this.dataGridViewTextBoxColumn7.HeaderText = "option4";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "optionToDisplay";
            this.dataGridViewTextBoxColumn8.HeaderText = "optionToDisplay";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "quizType";
            this.dataGridViewTextBoxColumn9.HeaderText = "quizType";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "CorrectAnswer";
            this.dataGridViewTextBoxColumn10.HeaderText = "CorrectAnswer";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // tblQuizBindingSource
            // 
            this.tblQuizBindingSource.DataMember = "tblQuiz";
            this.tblQuizBindingSource.DataSource = this.dbQuizAppDataSet;
            // 
            // dbQuizAppDataSet
            // 
            this.dbQuizAppDataSet.DataSetName = "dbQuizAppDataSet";
            this.dbQuizAppDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btmDelete
            // 
            this.btmDelete.Location = new System.Drawing.Point(162, 386);
            this.btmDelete.Name = "btmDelete";
            this.btmDelete.Size = new System.Drawing.Size(115, 39);
            this.btmDelete.TabIndex = 7;
            this.btmDelete.Text = "Delete";
            this.btmDelete.UseVisualStyleBackColor = true;
            this.btmDelete.Click += new System.EventHandler(this.btmDelete_Click);
            // 
            // btmEdit
            // 
            this.btmEdit.Location = new System.Drawing.Point(22, 386);
            this.btmEdit.Name = "btmEdit";
            this.btmEdit.Size = new System.Drawing.Size(105, 39);
            this.btmEdit.TabIndex = 6;
            this.btmEdit.Text = "Edit";
            this.btmEdit.UseVisualStyleBackColor = true;
            this.btmEdit.Click += new System.EventHandler(this.btmEdit_Click);
            // 
            // btmSearch
            // 
            this.btmSearch.Location = new System.Drawing.Point(502, 14);
            this.btmSearch.Name = "btmSearch";
            this.btmSearch.Size = new System.Drawing.Size(132, 37);
            this.btmSearch.TabIndex = 5;
            this.btmSearch.Text = "Search";
            this.btmSearch.UseVisualStyleBackColor = true;
            this.btmSearch.Click += new System.EventHandler(this.btmSearch_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(177, 50);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(282, 28);
            this.comboBox2.TabIndex = 3;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // txtSearchQuesId
            // 
            this.txtSearchQuesId.Location = new System.Drawing.Point(177, 14);
            this.txtSearchQuesId.Name = "txtSearchQuesId";
            this.txtSearchQuesId.Size = new System.Drawing.Size(282, 26);
            this.txtSearchQuesId.TabIndex = 2;
            this.txtSearchQuesId.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // lblSearchQuizType
            // 
            this.lblSearchQuizType.AutoSize = true;
            this.lblSearchQuizType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchQuizType.Location = new System.Drawing.Point(29, 52);
            this.lblSearchQuizType.Name = "lblSearchQuizType";
            this.lblSearchQuizType.Size = new System.Drawing.Size(83, 20);
            this.lblSearchQuizType.TabIndex = 1;
            this.lblSearchQuizType.Text = "Quiz Type:";
            // 
            // lblSearchQuestionId
            // 
            this.lblSearchQuestionId.AutoSize = true;
            this.lblSearchQuestionId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchQuestionId.Location = new System.Drawing.Point(29, 20);
            this.lblSearchQuestionId.Name = "lblSearchQuestionId";
            this.lblSearchQuestionId.Size = new System.Drawing.Size(98, 20);
            this.lblSearchQuestionId.TabIndex = 0;
            this.lblSearchQuestionId.Text = "Question ID:";
            // 
            // EditQuestionTab
            // 
            this.EditQuestionTab.Controls.Add(this.dataGridView1);
            this.EditQuestionTab.Controls.Add(questionIdLabel);
            this.EditQuestionTab.Controls.Add(this.questionIdTextBox);
            this.EditQuestionTab.Controls.Add(questionNumberLabel);
            this.EditQuestionTab.Controls.Add(this.questionNumberTextBox);
            this.EditQuestionTab.Controls.Add(questionLabel);
            this.EditQuestionTab.Controls.Add(this.questionTextBox);
            this.EditQuestionTab.Controls.Add(option1Label);
            this.EditQuestionTab.Controls.Add(this.option1TextBox);
            this.EditQuestionTab.Controls.Add(option2Label);
            this.EditQuestionTab.Controls.Add(this.option2TextBox);
            this.EditQuestionTab.Controls.Add(option3Label);
            this.EditQuestionTab.Controls.Add(this.option3TextBox);
            this.EditQuestionTab.Controls.Add(option4Label);
            this.EditQuestionTab.Controls.Add(this.option4TextBox);
            this.EditQuestionTab.Controls.Add(optionToDisplayLabel);
            this.EditQuestionTab.Controls.Add(this.optionToDisplayTextBox);
            this.EditQuestionTab.Controls.Add(quizTypeLabel);
            this.EditQuestionTab.Controls.Add(this.quizTypeTextBox);
            this.EditQuestionTab.Controls.Add(correctAnswerLabel);
            this.EditQuestionTab.Controls.Add(this.correctAnswerTextBox);
            this.EditQuestionTab.Controls.Add(this.tblQuizBindingNavigator);
            this.EditQuestionTab.Controls.Add(this.label11);
            this.EditQuestionTab.Location = new System.Drawing.Point(4, 22);
            this.EditQuestionTab.Name = "EditQuestionTab";
            this.EditQuestionTab.Size = new System.Drawing.Size(764, 431);
            this.EditQuestionTab.TabIndex = 2;
            this.EditQuestionTab.Text = "Edit";
            this.EditQuestionTab.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn20});
            this.dataGridView1.DataSource = this.tblQuizBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(278, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(449, 325);
            this.dataGridView1.TabIndex = 78;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "QuestionId";
            this.dataGridViewTextBoxColumn11.HeaderText = "QuestionId";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "QuestionNumber";
            this.dataGridViewTextBoxColumn12.HeaderText = "QuestionNumber";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Question";
            this.dataGridViewTextBoxColumn13.HeaderText = "Question";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "option1";
            this.dataGridViewTextBoxColumn14.HeaderText = "option1";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "option2";
            this.dataGridViewTextBoxColumn15.HeaderText = "option2";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "option3";
            this.dataGridViewTextBoxColumn16.HeaderText = "option3";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "option4";
            this.dataGridViewTextBoxColumn17.HeaderText = "option4";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "optionToDisplay";
            this.dataGridViewTextBoxColumn18.HeaderText = "optionToDisplay";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "quizType";
            this.dataGridViewTextBoxColumn19.HeaderText = "quizType";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "CorrectAnswer";
            this.dataGridViewTextBoxColumn20.HeaderText = "CorrectAnswer";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            // 
            // questionIdTextBox
            // 
            this.questionIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblQuizBindingSource, "QuestionId", true));
            this.questionIdTextBox.Enabled = false;
            this.questionIdTextBox.Location = new System.Drawing.Point(132, 69);
            this.questionIdTextBox.Name = "questionIdTextBox";
            this.questionIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.questionIdTextBox.TabIndex = 59;
            // 
            // questionNumberTextBox
            // 
            this.questionNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblQuizBindingSource, "QuestionNumber", true));
            this.questionNumberTextBox.Location = new System.Drawing.Point(132, 95);
            this.questionNumberTextBox.Name = "questionNumberTextBox";
            this.questionNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.questionNumberTextBox.TabIndex = 61;
            // 
            // questionTextBox
            // 
            this.questionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblQuizBindingSource, "Question", true));
            this.questionTextBox.Location = new System.Drawing.Point(132, 121);
            this.questionTextBox.Name = "questionTextBox";
            this.questionTextBox.Size = new System.Drawing.Size(100, 20);
            this.questionTextBox.TabIndex = 63;
            // 
            // option1TextBox
            // 
            this.option1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblQuizBindingSource, "option1", true));
            this.option1TextBox.Location = new System.Drawing.Point(132, 147);
            this.option1TextBox.Name = "option1TextBox";
            this.option1TextBox.Size = new System.Drawing.Size(100, 20);
            this.option1TextBox.TabIndex = 65;
            // 
            // option2TextBox
            // 
            this.option2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblQuizBindingSource, "option2", true));
            this.option2TextBox.Location = new System.Drawing.Point(132, 173);
            this.option2TextBox.Name = "option2TextBox";
            this.option2TextBox.Size = new System.Drawing.Size(100, 20);
            this.option2TextBox.TabIndex = 67;
            // 
            // option3TextBox
            // 
            this.option3TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblQuizBindingSource, "option3", true));
            this.option3TextBox.Location = new System.Drawing.Point(132, 199);
            this.option3TextBox.Name = "option3TextBox";
            this.option3TextBox.Size = new System.Drawing.Size(100, 20);
            this.option3TextBox.TabIndex = 69;
            // 
            // option4TextBox
            // 
            this.option4TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblQuizBindingSource, "option4", true));
            this.option4TextBox.Location = new System.Drawing.Point(132, 225);
            this.option4TextBox.Name = "option4TextBox";
            this.option4TextBox.Size = new System.Drawing.Size(100, 20);
            this.option4TextBox.TabIndex = 71;
            // 
            // optionToDisplayTextBox
            // 
            this.optionToDisplayTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblQuizBindingSource, "optionToDisplay", true));
            this.optionToDisplayTextBox.Location = new System.Drawing.Point(132, 251);
            this.optionToDisplayTextBox.Name = "optionToDisplayTextBox";
            this.optionToDisplayTextBox.Size = new System.Drawing.Size(100, 20);
            this.optionToDisplayTextBox.TabIndex = 73;
            // 
            // quizTypeTextBox
            // 
            this.quizTypeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblQuizBindingSource, "quizType", true));
            this.quizTypeTextBox.Location = new System.Drawing.Point(132, 277);
            this.quizTypeTextBox.Name = "quizTypeTextBox";
            this.quizTypeTextBox.Size = new System.Drawing.Size(100, 20);
            this.quizTypeTextBox.TabIndex = 75;
            // 
            // correctAnswerTextBox
            // 
            this.correctAnswerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblQuizBindingSource, "CorrectAnswer", true));
            this.correctAnswerTextBox.Location = new System.Drawing.Point(132, 303);
            this.correctAnswerTextBox.Name = "correctAnswerTextBox";
            this.correctAnswerTextBox.Size = new System.Drawing.Size(100, 20);
            this.correctAnswerTextBox.TabIndex = 77;
            // 
            // tblQuizBindingNavigator
            // 
            this.tblQuizBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tblQuizBindingNavigator.BindingSource = this.tblQuizBindingSource;
            this.tblQuizBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tblQuizBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tblQuizBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.tblQuizBindingNavigatorSaveItem});
            this.tblQuizBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tblQuizBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tblQuizBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tblQuizBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tblQuizBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tblQuizBindingNavigator.Name = "tblQuizBindingNavigator";
            this.tblQuizBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tblQuizBindingNavigator.Size = new System.Drawing.Size(764, 25);
            this.tblQuizBindingNavigator.TabIndex = 57;
            this.tblQuizBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tblQuizBindingNavigatorSaveItem
            // 
            this.tblQuizBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tblQuizBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tblQuizBindingNavigatorSaveItem.Image")));
            this.tblQuizBindingNavigatorSaveItem.Name = "tblQuizBindingNavigatorSaveItem";
            this.tblQuizBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tblQuizBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(310, 30);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 24);
            this.label11.TabIndex = 56;
            this.label11.Text = "Edit Data";
            // 
            // tblQuizTableAdapter
            // 
            this.tblQuizTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdminLoginTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tblQuizTableAdapter = this.tblQuizTableAdapter;
            this.tableAdapterManager.UpdateOrder = QuizApplication.dbQuizAppDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 584);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lblTitle);
            this.Name = "FormAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAdmin";
            this.Load += new System.EventHandler(this.FormAdminName_Load);
            this.tabControl1.ResumeLayout(false);
            this.AddQuestionTab.ResumeLayout(false);
            this.AddQuestionTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CorrectAns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NoOfOpt)).EndInit();
            this.SearchQuestionTab.ResumeLayout(false);
            this.SearchQuestionTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblQuizDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblQuizBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbQuizAppDataSet)).EndInit();
            this.EditQuestionTab.ResumeLayout(false);
            this.EditQuestionTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblQuizBindingNavigator)).EndInit();
            this.tblQuizBindingNavigator.ResumeLayout(false);
            this.tblQuizBindingNavigator.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private dbQuizAppDataSet dbQuizAppDataSet;
        private System.Windows.Forms.BindingSource tblQuizBindingSource;
        private dbQuizAppDataSetTableAdapters.tblQuizTableAdapter tblQuizTableAdapter;
        private dbQuizAppDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage AddQuestionTab;
        private System.Windows.Forms.Button btmCancel;
        private System.Windows.Forms.Button btmAdd;
        private System.Windows.Forms.NumericUpDown CorrectAns;
        private System.Windows.Forms.NumericUpDown NoOfOpt;
        private System.Windows.Forms.TextBox txtOption4;
        private System.Windows.Forms.TextBox txtOption2;
        private System.Windows.Forms.TextBox txtOption3;
        private System.Windows.Forms.TextBox txtOption1;
        private System.Windows.Forms.TextBox txtQuestion;
        private System.Windows.Forms.TextBox txtQuesNo;
        private System.Windows.Forms.TextBox txtQuesId;
        private System.Windows.Forms.Label lblQuesType;
        private System.Windows.Forms.Label lblCorrectAns;
        private System.Windows.Forms.Label lblNoOfOptions;
        private System.Windows.Forms.Label lblOption4;
        private System.Windows.Forms.Label lblOption3;
        private System.Windows.Forms.Label lblOption2;
        private System.Windows.Forms.Label lblOption1;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Label lblQuesNo;
        private System.Windows.Forms.Label lblQuesId;
        private System.Windows.Forms.TabPage SearchQuestionTab;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox txtSearchQuesId;
        private System.Windows.Forms.Label lblSearchQuizType;
        private System.Windows.Forms.Label lblSearchQuestionId;
        private System.Windows.Forms.TabPage EditQuestionTab;
        private System.Windows.Forms.Button btmSearch;
        private System.Windows.Forms.Button btmDelete;
        private System.Windows.Forms.Button btmEdit;
        private System.Windows.Forms.DataGridView tblQuizDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.BindingNavigator tblQuizBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton tblQuizBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.TextBox questionIdTextBox;
        private System.Windows.Forms.TextBox questionNumberTextBox;
        private System.Windows.Forms.TextBox questionTextBox;
        private System.Windows.Forms.TextBox option1TextBox;
        private System.Windows.Forms.TextBox option2TextBox;
        private System.Windows.Forms.TextBox option3TextBox;
        private System.Windows.Forms.TextBox option4TextBox;
        private System.Windows.Forms.TextBox optionToDisplayTextBox;
        private System.Windows.Forms.TextBox quizTypeTextBox;
        private System.Windows.Forms.TextBox correctAnswerTextBox;
    }
}

