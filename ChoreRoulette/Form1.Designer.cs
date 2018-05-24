namespace ChoreRoulette
{
    partial class Form1
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
            this.tbQuestion = new System.Windows.Forms.TextBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.okButton = new System.Windows.Forms.Button();
            this.tb_Result = new System.Windows.Forms.TextBox();
            this.tb_Answer = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbQuestion
            // 
            this.tbQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbQuestion.Location = new System.Drawing.Point(12, 38);
            this.tbQuestion.Name = "tbQuestion";
            this.tbQuestion.Size = new System.Drawing.Size(542, 30);
            this.tbQuestion.TabIndex = 0;
            this.tbQuestion.Text = "Who will be sharing the chores?";
            this.tbQuestion.TextChanged += new System.EventHandler(this.tb_Question);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Cook dinner",
            "Do the laundry",
            "Feed the dog",
            "Fold the laundry",
            "Load the dishwasher",
            "Prepare lunchboxes",
            "Shop for groceries",
            "Take away the trash",
            "Ubload dishwasher",
            "Vacuum",
            "Walk the dog"});
            this.checkedListBox1.Location = new System.Drawing.Point(12, 185);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(224, 208);
            this.checkedListBox1.TabIndex = 3;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.CheckedListBox1);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(12, 399);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 4;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // tb_Result
            // 
            this.tb_Result.Location = new System.Drawing.Point(395, 185);
            this.tb_Result.Multiline = true;
            this.tb_Result.Name = "tb_Result";
            this.tb_Result.ReadOnly = true;
            this.tb_Result.Size = new System.Drawing.Size(266, 208);
            this.tb_Result.TabIndex = 5;
            this.tb_Result.TextChanged += new System.EventHandler(this.tb_Result_TextChanged);
            // 
            // tb_Answer
            // 
            this.tb_Answer.Location = new System.Drawing.Point(13, 91);
            this.tb_Answer.Name = "tb_Answer";
            this.tb_Answer.Size = new System.Drawing.Size(541, 22);
            this.tb_Answer.TabIndex = 6;
            this.tb_Answer.TextChanged += new System.EventHandler(this.tb_Answer_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 503);
            this.Controls.Add(this.tb_Answer);
            this.Controls.Add(this.tb_Result);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.tbQuestion);
            this.Name = "Form1";
            this.Text = " ";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbQuestion;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.TextBox tb_Result;
        private System.Windows.Forms.TextBox tb_Answer;
    }
}

