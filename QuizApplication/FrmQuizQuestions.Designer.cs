namespace QuizApplication
{
    partial class FrmQuizQuestions
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
            this.lblquestion = new System.Windows.Forms.Label();
            this.rbOption1 = new System.Windows.Forms.RadioButton();
            this.rbOption2 = new System.Windows.Forms.RadioButton();
            this.rbOption3 = new System.Windows.Forms.RadioButton();
            this.rbOption4 = new System.Windows.Forms.RadioButton();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblquestion
            // 
            this.lblquestion.BackColor = System.Drawing.Color.DarkGray;
            this.lblquestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblquestion.Location = new System.Drawing.Point(13, 13);
            this.lblquestion.Name = "lblquestion";
            this.lblquestion.Size = new System.Drawing.Size(523, 61);
            this.lblquestion.TabIndex = 0;
            this.lblquestion.Text = "Question";
            this.lblquestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblquestion.Click += new System.EventHandler(this.lblquestion_Click);
            // 
            // rbOption1
            // 
            this.rbOption1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbOption1.Location = new System.Drawing.Point(17, 109);
            this.rbOption1.Name = "rbOption1";
            this.rbOption1.Size = new System.Drawing.Size(519, 24);
            this.rbOption1.TabIndex = 1;
            this.rbOption1.TabStop = true;
            this.rbOption1.Text = "Option1";
            this.rbOption1.UseVisualStyleBackColor = true;
            this.rbOption1.CheckedChanged += new System.EventHandler(this.rbOption1_CheckedChanged);
            // 
            // rbOption2
            // 
            this.rbOption2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbOption2.Location = new System.Drawing.Point(17, 149);
            this.rbOption2.Name = "rbOption2";
            this.rbOption2.Size = new System.Drawing.Size(519, 24);
            this.rbOption2.TabIndex = 2;
            this.rbOption2.TabStop = true;
            this.rbOption2.Text = "Option2";
            this.rbOption2.UseVisualStyleBackColor = true;
            // 
            // rbOption3
            // 
            this.rbOption3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbOption3.Location = new System.Drawing.Point(17, 189);
            this.rbOption3.Name = "rbOption3";
            this.rbOption3.Size = new System.Drawing.Size(519, 24);
            this.rbOption3.TabIndex = 3;
            this.rbOption3.TabStop = true;
            this.rbOption3.Text = "Option3";
            this.rbOption3.UseVisualStyleBackColor = true;
            // 
            // rbOption4
            // 
            this.rbOption4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbOption4.Location = new System.Drawing.Point(17, 230);
            this.rbOption4.Name = "rbOption4";
            this.rbOption4.Size = new System.Drawing.Size(519, 24);
            this.rbOption4.TabIndex = 4;
            this.rbOption4.TabStop = true;
            this.rbOption4.Text = "Option4";
            this.rbOption4.UseVisualStyleBackColor = true;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnPrevious.Location = new System.Drawing.Point(17, 283);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(117, 46);
            this.btnPrevious.TabIndex = 5;
            this.btnPrevious.Text = "< Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnNext.Location = new System.Drawing.Point(419, 283);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(117, 46);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = "Next >";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // FrmQuizQuestions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 344);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.rbOption4);
            this.Controls.Add(this.rbOption3);
            this.Controls.Add(this.rbOption2);
            this.Controls.Add(this.rbOption1);
            this.Controls.Add(this.lblquestion);
            this.Name = "FrmQuizQuestions";
            this.Text = "FrmQuizQuestions";
            this.Load += new System.EventHandler(this.FrmQuizQuestions_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblquestion;
        private System.Windows.Forms.RadioButton rbOption1;
        private System.Windows.Forms.RadioButton rbOption2;
        private System.Windows.Forms.RadioButton rbOption3;
        private System.Windows.Forms.RadioButton rbOption4;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
    }
}