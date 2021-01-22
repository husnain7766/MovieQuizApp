namespace MovieQuizApp
{
    partial class QuestionMenu
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
            this.QuestionListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OptionTextBox1 = new System.Windows.Forms.TextBox();
            this.OptionTextBox2 = new System.Windows.Forms.TextBox();
            this.OptionTextBox3 = new System.Windows.Forms.TextBox();
            this.OptionTextBox4 = new System.Windows.Forms.TextBox();
            this.DescriptionTextBox = new System.Windows.Forms.RichTextBox();
            this.QuestionTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Option1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CorrectAnswerNumberBox = new System.Windows.Forms.NumericUpDown();
            this.QuestionTypeComboBox = new System.Windows.Forms.ComboBox();
            this.asd = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.QUIZTIMER = new System.Windows.Forms.NumericUpDown();
            this.TIMER = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FileNameLabel = new System.Windows.Forms.Label();
            this.LoadButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CorrectAnswerNumberBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QUIZTIMER)).BeginInit();
            this.SuspendLayout();
            // 
            // QuestionListView
            // 
            this.QuestionListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.QuestionListView.HideSelection = false;
            this.QuestionListView.Location = new System.Drawing.Point(13, 237);
            this.QuestionListView.Name = "QuestionListView";
            this.QuestionListView.Size = new System.Drawing.Size(776, 232);
            this.QuestionListView.TabIndex = 0;
            this.QuestionListView.UseCompatibleStateImageBehavior = false;
            this.QuestionListView.View = System.Windows.Forms.View.Details;
            this.QuestionListView.SelectedIndexChanged += new System.EventHandler(this.QuestionListView_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "TYPE";
            this.columnHeader1.Width = 96;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "QUESTION";
            this.columnHeader2.Width = 560;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "CORRECT ANSWER";
            this.columnHeader3.Width = 140;
            // 
            // OptionTextBox1
            // 
            this.OptionTextBox1.Location = new System.Drawing.Point(13, 129);
            this.OptionTextBox1.Name = "OptionTextBox1";
            this.OptionTextBox1.Size = new System.Drawing.Size(100, 20);
            this.OptionTextBox1.TabIndex = 1;
            // 
            // OptionTextBox2
            // 
            this.OptionTextBox2.Location = new System.Drawing.Point(119, 129);
            this.OptionTextBox2.Name = "OptionTextBox2";
            this.OptionTextBox2.Size = new System.Drawing.Size(100, 20);
            this.OptionTextBox2.TabIndex = 2;
            // 
            // OptionTextBox3
            // 
            this.OptionTextBox3.Location = new System.Drawing.Point(225, 129);
            this.OptionTextBox3.Name = "OptionTextBox3";
            this.OptionTextBox3.Size = new System.Drawing.Size(100, 20);
            this.OptionTextBox3.TabIndex = 3;
            // 
            // OptionTextBox4
            // 
            this.OptionTextBox4.Location = new System.Drawing.Point(331, 129);
            this.OptionTextBox4.Name = "OptionTextBox4";
            this.OptionTextBox4.Size = new System.Drawing.Size(100, 20);
            this.OptionTextBox4.TabIndex = 4;
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Location = new System.Drawing.Point(437, 53);
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(351, 96);
            this.DescriptionTextBox.TabIndex = 5;
            this.DescriptionTextBox.Text = "";
            // 
            // QuestionTextBox
            // 
            this.QuestionTextBox.Location = new System.Drawing.Point(13, 53);
            this.QuestionTextBox.Name = "QuestionTextBox";
            this.QuestionTextBox.Size = new System.Drawing.Size(419, 20);
            this.QuestionTextBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Question";
            // 
            // Option1
            // 
            this.Option1.AutoSize = true;
            this.Option1.Location = new System.Drawing.Point(9, 113);
            this.Option1.Name = "Option1";
            this.Option1.Size = new System.Drawing.Size(47, 13);
            this.Option1.TabIndex = 8;
            this.Option1.Text = "Option 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(116, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Option 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(222, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Option 3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(328, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Option 4";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(434, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Explaination";
            // 
            // CorrectAnswerNumberBox
            // 
            this.CorrectAnswerNumberBox.Location = new System.Drawing.Point(149, 179);
            this.CorrectAnswerNumberBox.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.CorrectAnswerNumberBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CorrectAnswerNumberBox.Name = "CorrectAnswerNumberBox";
            this.CorrectAnswerNumberBox.Size = new System.Drawing.Size(120, 20);
            this.CorrectAnswerNumberBox.TabIndex = 13;
            this.CorrectAnswerNumberBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // QuestionTypeComboBox
            // 
            this.QuestionTypeComboBox.FormattingEnabled = true;
            this.QuestionTypeComboBox.Items.AddRange(new object[] {
            "MCQ",
            "TRUE/FALSE"});
            this.QuestionTypeComboBox.Location = new System.Drawing.Point(12, 179);
            this.QuestionTypeComboBox.Name = "QuestionTypeComboBox";
            this.QuestionTypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.QuestionTypeComboBox.TabIndex = 14;
            this.QuestionTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.QuestionTypeComboBox_SelectedIndexChanged);
            // 
            // asd
            // 
            this.asd.AutoSize = true;
            this.asd.Location = new System.Drawing.Point(10, 163);
            this.asd.Name = "asd";
            this.asd.Size = new System.Drawing.Size(76, 13);
            this.asd.TabIndex = 15;
            this.asd.Text = "Question Type";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(146, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "CorrectOption";
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(714, 208);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 17;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(518, 208);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(190, 23);
            this.EditButton.TabIndex = 18;
            this.EditButton.Text = "Save Changes to Question";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(437, 208);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 19;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(622, 179);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(163, 23);
            this.SaveButton.TabIndex = 20;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // QUIZTIMER
            // 
            this.QUIZTIMER.Location = new System.Drawing.Point(275, 179);
            this.QUIZTIMER.Name = "QUIZTIMER";
            this.QUIZTIMER.Size = new System.Drawing.Size(120, 20);
            this.QUIZTIMER.TabIndex = 21;
            this.QUIZTIMER.ValueChanged += new System.EventHandler(this.QUIZTIMER_ValueChanged);
            // 
            // TIMER
            // 
            this.TIMER.AutoSize = true;
            this.TIMER.Location = new System.Drawing.Point(272, 163);
            this.TIMER.Name = "TIMER";
            this.TIMER.Size = new System.Drawing.Size(41, 13);
            this.TIMER.TabIndex = 22;
            this.TIMER.Text = "TIMER";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 472);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "FileName";
            // 
            // FileNameLabel
            // 
            this.FileNameLabel.AutoSize = true;
            this.FileNameLabel.Location = new System.Drawing.Point(70, 472);
            this.FileNameLabel.Name = "FileNameLabel";
            this.FileNameLabel.Size = new System.Drawing.Size(38, 13);
            this.FileNameLabel.TabIndex = 24;
            this.FileNameLabel.Text = "NONE";
            // 
            // LoadButton
            // 
            this.LoadButton.Location = new System.Drawing.Point(437, 179);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(179, 23);
            this.LoadButton.TabIndex = 25;
            this.LoadButton.Text = "Load";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // QuestionMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 489);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.FileNameLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TIMER);
            this.Controls.Add(this.QUIZTIMER);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.asd);
            this.Controls.Add(this.QuestionTypeComboBox);
            this.Controls.Add(this.CorrectAnswerNumberBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Option1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.QuestionTextBox);
            this.Controls.Add(this.DescriptionTextBox);
            this.Controls.Add(this.OptionTextBox4);
            this.Controls.Add(this.OptionTextBox3);
            this.Controls.Add(this.OptionTextBox2);
            this.Controls.Add(this.OptionTextBox1);
            this.Controls.Add(this.QuestionListView);
            this.Name = "QuestionMenu";
            this.Text = "Question Menu";
            this.Load += new System.EventHandler(this.QuestionMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CorrectAnswerNumberBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QUIZTIMER)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView QuestionListView;
        private System.Windows.Forms.TextBox OptionTextBox1;
        private System.Windows.Forms.TextBox OptionTextBox2;
        private System.Windows.Forms.TextBox OptionTextBox3;
        private System.Windows.Forms.TextBox OptionTextBox4;
        private System.Windows.Forms.RichTextBox DescriptionTextBox;
        private System.Windows.Forms.TextBox QuestionTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Option1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown CorrectAnswerNumberBox;
        private System.Windows.Forms.ComboBox QuestionTypeComboBox;
        private System.Windows.Forms.Label asd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.NumericUpDown QUIZTIMER;
        private System.Windows.Forms.Label TIMER;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label FileNameLabel;
        private System.Windows.Forms.Button LoadButton;
    }
}

