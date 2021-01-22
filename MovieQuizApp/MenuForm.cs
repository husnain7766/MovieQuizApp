using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieQuizApp
{
    public partial class MenuForm : Form
    {
        private PrivateFontCollection _privateFont;
        private String _fileName;
        public MenuForm()
        {
            _fileName = "";
            InitializeComponent();
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
                new QuestionMenu().ShowDialog();
        }

        private void QuestionButton_Click(object sender, EventArgs e)
        {
            if (_fileName != "")
                new QuestionPlayForm().ShowDialog();
            else
            {
                MessageBox.Show(@"NO DATABASE SELECTED");
            }
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            _privateFont = new PrivateFontCollection();
            try
            {
                _privateFont.AddFontFile("./FONT/CenturyGothicRegular.ttf");
                PlayButton.Font = new Font(_privateFont.Families[0],16,FontStyle.Regular);
                QuestionButton.Font = new Font(_privateFont.Families[0],16,FontStyle.Regular);
                SelectFile.Font = new Font(_privateFont.Families[0],16,FontStyle.Regular);
                
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
            
        }

        private void SelectFile_Click(object sender, EventArgs e)
        {
            FileDialog file = new OpenFileDialog();
            if (file.ShowDialog() == DialogResult.OK)
            {
                if (!QuestionController.Instance.ReadAllQuestion(file.FileName))
                {
                    MessageBox.Show(@"ERROR READING FILE");
                }
                else
                {
                    _fileName = file.FileName;
                    FileNameLabel.Text = file.FileName;
                }
            }
        }

        private void MessageTextBox_TextChanged(object sender, EventArgs e)
        {
            QuestionController.Instance.message = MessageTextBox.Text;
        }
    }
}
