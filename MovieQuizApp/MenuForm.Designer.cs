namespace MovieQuizApp
{
    partial class MenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            this.QuestionButton = new System.Windows.Forms.Button();
            this.PlayButton = new System.Windows.Forms.Button();
            this.SelectFile = new System.Windows.Forms.Button();
            this.FileNameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MessageTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // QuestionButton
            // 
            this.QuestionButton.BackColor = System.Drawing.Color.Lime;
            this.QuestionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QuestionButton.Location = new System.Drawing.Point(192, 234);
            this.QuestionButton.Name = "QuestionButton";
            this.QuestionButton.Size = new System.Drawing.Size(357, 93);
            this.QuestionButton.TabIndex = 8;
            this.QuestionButton.Text = "PLAY";
            this.QuestionButton.UseVisualStyleBackColor = false;
            this.QuestionButton.Click += new System.EventHandler(this.QuestionButton_Click);
            // 
            // PlayButton
            // 
            this.PlayButton.BackColor = System.Drawing.Color.SlateBlue;
            this.PlayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlayButton.Location = new System.Drawing.Point(192, 116);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(357, 93);
            this.PlayButton.TabIndex = 7;
            this.PlayButton.Text = "QUESTIONS MENU";
            this.PlayButton.UseVisualStyleBackColor = false;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // SelectFile
            // 
            this.SelectFile.BackColor = System.Drawing.Color.Magenta;
            this.SelectFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectFile.Location = new System.Drawing.Point(192, 355);
            this.SelectFile.Name = "SelectFile";
            this.SelectFile.Size = new System.Drawing.Size(357, 93);
            this.SelectFile.TabIndex = 9;
            this.SelectFile.Text = "SELECT FILE";
            this.SelectFile.UseVisualStyleBackColor = false;
            this.SelectFile.Click += new System.EventHandler(this.SelectFile_Click);
            // 
            // FileNameLabel
            // 
            this.FileNameLabel.AutoSize = true;
            this.FileNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.FileNameLabel.Location = new System.Drawing.Point(705, 9);
            this.FileNameLabel.Name = "FileNameLabel";
            this.FileNameLabel.Size = new System.Drawing.Size(33, 13);
            this.FileNameLabel.TabIndex = 10;
            this.FileNameLabel.Text = "None";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(632, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "FILE NAME :";
            // 
            // MessageTextBox
            // 
            this.MessageTextBox.Location = new System.Drawing.Point(192, 471);
            this.MessageTextBox.Name = "MessageTextBox";
            this.MessageTextBox.Size = new System.Drawing.Size(357, 93);
            this.MessageTextBox.TabIndex = 12;
            this.MessageTextBox.Text = "";
            this.MessageTextBox.TextChanged += new System.EventHandler(this.MessageTextBox_TextChanged);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1279, 681);
            this.Controls.Add(this.MessageTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FileNameLabel);
            this.Controls.Add(this.SelectFile);
            this.Controls.Add(this.QuestionButton);
            this.Controls.Add(this.PlayButton);
            this.Name = "MenuForm";
            this.Text = "MenuForm";
            this.Load += new System.EventHandler(this.MenuForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button QuestionButton;
        private System.Windows.Forms.Button PlayButton;
        private System.Windows.Forms.Button SelectFile;
        private System.Windows.Forms.Label FileNameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox MessageTextBox;
    }
}