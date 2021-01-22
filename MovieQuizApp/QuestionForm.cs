using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieQuizApp
{
    public partial class QuestionMenu : Form
    {
        public QuestionMenu()
        {
            InitializeComponent();
        }
        private void QuestionMenu_Load(object sender, EventArgs e)
        {
            QuestionTypeComboBox.SelectedIndex = 0;
            LoadAllQuestions();
            QUIZTIMER.Value = QuestionController.Instance.QuestionTime;
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            if (QuestionTypeComboBox.SelectedIndex == 0)
            {
                Question question = new Question(DescriptionTextBox.Text,QuestionTextBox.Text,'M',OptionTextBox1.Text,OptionTextBox2.Text,OptionTextBox3.Text,OptionTextBox4.Text, (int)CorrectAnswerNumberBox.Value);
                QuestionController.Instance.QuestionsList.Add(question);
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = @"MCQ";
                listViewItem.SubItems.Add(question.Question1);
                listViewItem.SubItems.Add(question.CorrectOption.ToString());
                QuestionListView.Items.Add(listViewItem);
            }
            else
            {
                Question question = new Question(DescriptionTextBox.Text, QuestionTextBox.Text, 'T', OptionTextBox1.Text, OptionTextBox2.Text, OptionTextBox3.Text, OptionTextBox4.Text, (int)CorrectAnswerNumberBox.Value);
                QuestionController.Instance.QuestionsList.Add(question);
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = @"TRUE/FALSE";
                listViewItem.SubItems.Add(question.Question1);
                listViewItem.SubItems.Add(question.CorrectOption.ToString());
                QuestionListView.Items.Add(listViewItem);
            }

            
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (QuestionListView.SelectedIndices.Count > 0)
            {
                int index = QuestionListView.SelectedIndices[0];
                Question question = new Question(DescriptionTextBox.Text, QuestionTextBox.Text, 'M', OptionTextBox1.Text, OptionTextBox2.Text, OptionTextBox3.Text, OptionTextBox4.Text, (int)CorrectAnswerNumberBox.Value);
                QuestionController.Instance.QuestionsList[index] = question; 
                ListViewItem listViewItem = QuestionListView.Items[index];
                listViewItem.SubItems.Clear();


                if (QuestionTypeComboBox.SelectedIndex == 0)
                {
                    listViewItem.Text = @"MCQ";
                    listViewItem.SubItems.Add(question.Question1);
                    listViewItem.SubItems.Add(question.CorrectOption.ToString());
                }
                else
                {
                    listViewItem.Text = @"TRUE/FALSE";
                    listViewItem.SubItems.Add(question.Question1);
                    listViewItem.SubItems.Add(question.CorrectOption.ToString());
                }
            }

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (QuestionListView.SelectedIndices.Count > 0)
            {
                int index = QuestionListView.SelectedIndices[0];
                QuestionListView.Items.RemoveAt(index);
                QuestionController.Instance.QuestionsList.RemoveAt(index);
            }

        }

        private void QuestionListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (QuestionListView.SelectedIndices.Count > 0)
            {
                int index = QuestionListView.SelectedIndices[0];
                Question question =  QuestionController.Instance.QuestionsList[index];
                DescriptionTextBox.Text = question.Description;
                QuestionTextBox.Text = question.Question1;
                CorrectAnswerNumberBox.Value = question.CorrectOption;
                if (question.Type == 'M')
                {
                    QuestionTypeComboBox.SelectedIndex = 0;
                    OptionTextBox1.Text = question.Option1;
                    OptionTextBox2.Text = question.Option2;
                    OptionTextBox3.Text = question.Option3;
                    OptionTextBox4.Text = question.Option4;
                }
                else
                {
                    QuestionTypeComboBox.SelectedIndex = 1;
                }
            }
                
        }

        private void QuestionTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (QuestionTypeComboBox.SelectedIndex == 0)
            {

                OptionTextBox1.Text = @"";
                OptionTextBox2.Text = @"";
                OptionTextBox3.Text = @"";
                OptionTextBox4.Text = @"";
                OptionTextBox1.Enabled = true;
                OptionTextBox2.Enabled = true;
                OptionTextBox3.Enabled = true;
                OptionTextBox4.Enabled = true;
                CorrectAnswerNumberBox.Maximum = 4;
            }
            else
            {
                OptionTextBox1.Text = @"TRUE";
                OptionTextBox2.Text = @"FALSE";
                OptionTextBox3.Text = @""; 
                OptionTextBox4.Text = @"";
                OptionTextBox1.Enabled = false;
                OptionTextBox2.Enabled = false;
                OptionTextBox3.Enabled = false;
                OptionTextBox4.Enabled = false;
                CorrectAnswerNumberBox.Maximum = 2;
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            FileDialog fileDialog = new SaveFileDialog();
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                if (QuestionController.Instance.SaveAllQuestions(fileDialog.FileName))
                {

                }
                else
                {
                    MessageBox.Show(@"Unable To save File");
                }
            }
        }

        private void LoadAllQuestions()
        {
            QuestionListView.Items.Clear();
            for (var i = 0; i < QuestionController.Instance.QuestionsList.Count; i++)
            {
                Question question = QuestionController.Instance.QuestionsList[i];
                ListViewItem listViewItem = new ListViewItem();
                if(question.Type=='M')
                    listViewItem.Text = @"MCQ";
                else
                    listViewItem.Text = @"TRUE/FALSE";
                listViewItem.SubItems.Add(question.Question1);
                listViewItem.SubItems.Add(question.CorrectOption.ToString());
                QuestionListView.Items.Add(listViewItem);
            }
        }

        private void QUIZTIMER_ValueChanged(object sender, EventArgs e)
        {
            QuestionController.Instance.QuestionTime = (int) QUIZTIMER.Value;
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            FileDialog file = new OpenFileDialog();
            if (file.ShowDialog() == DialogResult.OK)
            {
                if (QuestionController.Instance.ReadAllQuestion(file.FileName))
                {
                    LoadAllQuestions();
                    FileNameLabel.Text = file.FileName;
                }
                else
                {
                    MessageBox.Show(@"Enable To readFile");
                }
            }
        }
    }
}
