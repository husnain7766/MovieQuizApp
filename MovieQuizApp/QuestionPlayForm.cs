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
using System.Windows.Forms.VisualStyles;

namespace MovieQuizApp
{

    public partial class QuestionPlayForm : Form
    {
        private PrivateFontCollection _privateFont;

        private int _questionNumber;
        private Timer _timer;
        private Timer _displayTimer;
        private Timer _nextQuestionDelay;
        private int _buttonPressed;
        public QuestionPlayForm()
        {
            _questionNumber = 0;
            _buttonPressed = -1;
            _timer = new Timer();
            _displayTimer = new Timer();
            _nextQuestionDelay = new Timer();
            InitializeComponent();
        }

        private void QuestionPlayForm_Load(object sender, EventArgs e)
        {
            MessageTextBox.Text = QuestionController.Instance.message;
            MessageTextBox.MaximumSize = panel1.Size;
            MessageTextBox.AutoSize = true;
            
            try
            {
                _privateFont = new PrivateFontCollection();
                _privateFont.AddFontFile("./FONT/CenturyGothicRegular.ttf");
                label1.Font = new Font(_privateFont.Families[0], 30, FontStyle.Bold);
                DescriptionTextBox.Font = new Font(_privateFont.Families[0], 14, FontStyle.Regular);
                QuestionTectBox.Font = new Font(_privateFont.Families[0], 14, FontStyle.Regular);
                label1.Font = new Font(_privateFont.Families[0], 30, FontStyle.Regular);
                MessageTextBox.Font = new Font(_privateFont.Families[0], 40, FontStyle.Bold);
                MessageTextBox.ForeColor = Color.FromArgb(255,219,158);
                QuestionTectBox.BackColor = Color.FromArgb(5,154,187);
                DescriptionTextBox.BackColor = Color.FromArgb(5,154,187);
                MessageTextBox.BackColor = Color.FromArgb(5,154,187);


                OptionButton1.Font = new Font(_privateFont.Families[0], 14, FontStyle.Regular);
                OptionButton2.Font = new Font(_privateFont.Families[0], 14, FontStyle.Regular);
                OptionButton3.Font = new Font(_privateFont.Families[0], 14, FontStyle.Regular);
                OptionButton4.Font = new Font(_privateFont.Families[0], 14, FontStyle.Regular);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }

            MessageTextBox.BackColor = Color.Transparent;

            _timer.Interval = (1000 * QuestionController.Instance.QuestionTime);
            _timer.Tick += new EventHandler(DisplayNextQuestion);

            _nextQuestionDelay.Interval = 1000 * 2;
            _nextQuestionDelay.Tick += new EventHandler(NextQuestionDelay);

            StartQuestion();
        }

        private void CloseApp(object sender,EventArgs e)
        {
            Close();
        }
        private void DisplayNextQuestion(object sender, EventArgs e)
        {
            _timer.Stop();
            _displayTimer.Stop();
            _nextQuestionDelay.Start();
            DescriptionTextBox.Visible = true;
            if (_questionNumber < QuestionController.Instance.QuestionsList.Count)
            {

                Question question = QuestionController.Instance.QuestionsList[_questionNumber];
                OptionButton1.Visible = false;
                OptionButton2.Visible = false;
                OptionButton3.Visible = false;
                OptionButton4.Visible = false;


                if (question.CorrectOption == 1)
                {
                    OptionButton1.Visible = true;
                    OptionButton1.BackColor = Color.Green;
                }

                if (question.CorrectOption == 2)
                {
                    OptionButton2.Visible = true;
                    OptionButton2.BackColor = Color.Green;
                }

                if (question.CorrectOption == 3)
                {
                    OptionButton3.Visible = true;
                    OptionButton3.BackColor = Color.Green;
                }

                if (question.CorrectOption == 4)
                {
                    OptionButton4.Visible = true;
                    OptionButton4.BackColor = Color.Green;
                }
            }
        }

        private void NextQuestionDelay(object sender, EventArgs e)
        {
            _nextQuestionDelay.Stop();
            _questionNumber++;
            StartQuestion();
        }



        void StartQuestion()
        {
            DescriptionTextBox.Visible = false;
            if (_questionNumber >= QuestionController.Instance.QuestionsList.Count)
            {
                _questionNumber = 0;
            }

            _buttonPressed = -1;
                Question question = QuestionController.Instance.QuestionsList[_questionNumber];
                DescriptionTextBox.Text = question.Description;
                QuestionTectBox.Text = question.Question1;
                OptionButton1.Enabled = true;
                OptionButton2.Enabled = true;
                OptionButton3.Enabled = true;
                OptionButton4.Enabled = true;
                OptionButton1.BackColor = Color.White;
                OptionButton2.BackColor = Color.White;
                OptionButton3.BackColor = Color.White;
                OptionButton4.BackColor = Color.White;

                if (question.Type == 'M')
                {
                    OptionButton1.Text = question.Option1;
                    OptionButton2.Text = question.Option2;
                    OptionButton3.Text = question.Option3;
                    OptionButton4.Text = question.Option4;
                    OptionButton1.Visible = true;
                    OptionButton2.Visible = true;
                    OptionButton3.Visible = true;
                    OptionButton4.Visible = true;
                }
                else
                {
                    OptionButton1.Text = @"TRUE";
                    OptionButton2.Text = @"FALSE";
                    OptionButton1.Visible = true;
                    OptionButton2.Visible = true;
                    OptionButton3.Visible = false;
                    OptionButton4.Visible = false;
                }

                _timer.Start();
                _displayTimer.Start();
        }



        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
