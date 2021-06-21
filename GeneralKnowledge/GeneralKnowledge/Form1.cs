using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeneralKnowledge
{
    public partial class Form1 : Form
    {
        int correctAns;
        int qnumber = 1;
        int score;
        int percentage;
        int totalQuestions; 



        public Form1()
        {
            InitializeComponent();
            askQuestion(qnumber);
            totalQuestions = 4; //no. of qs in the game 

        }

        private void checkAnsEvent(object sender, EventArgs e)
        {
            //evrytime the buttons are clicked, this event iwll be triggered//check which obj sent this event
            var senderObje = (Button)sender;
            int buttontag = Convert.ToInt32(senderObje.Tag);//will convert  the int and send it to this btton tag
            if (buttontag==correctAns)
            {
                score++;

            }
            if (qnumber==totalQuestions)
            {
                //work out percentage
                percentage = (int)Math.Round((double)(score * 100 / totalQuestions));
                MessageBox.Show("Quiz ended" + Environment.NewLine + " you answered" + " " + score + " " + "questions correctly" +
                    Environment.NewLine + "" + "" + "Total Percentage: " + "" + percentage + "%" + Environment.NewLine + "click ok to play again");
                score = 0;
                qnumber = 0;
                askQuestion(qnumber);
            
            }
            qnumber++;
            askQuestion(qnumber);
        }
          private void askQuestion(int qnum)//question number
        {
            //function that is going to run evrytime you ask a question
            // when the statement is false it will continue u is true
            switch (qnum)
            {
                case 1:
                    picBox.Image = Properties.Resources.succulent;//name of the image in the picture box 
                    lblQuestions.Text = "What type of plant is this";
                    button1.Text = "Rose";
                    button2.Text = "Succulent";// correct answer
                    button3.Text = "Lilly";
                    button4.Text = "Daisie";
                    correctAns = 2;
                    break;

                case 2:
                    picBox.Image = Properties.Resources.drake;//name of the image in the picture box 
                    lblQuestions.Text = "Whose ablum is this?";
                    button1.Text = "Drake";// correct answer 
                    button2.Text = "Rick Ross";
                    button3.Text = "JMSN";
                    button4.Text = "Kid Cudi";
                    correctAns = 1;
                    break;

                case 3:
                    picBox.Image = Properties.Resources.bird;//name of the image in the picture box 
                    lblQuestions.Text = "What type of bird is this?";
                    button1.Text = "Raven";
                    button2.Text = "Tweety";
                    button3.Text = "Robin";
                    button4.Text = "Columbidae";//correct answer
                    correctAns =4 ;
                    break;

                case 4:
                    picBox.Image = Properties.Resources.controller;//name of the image in the picture box 
                    lblQuestions.Text = "To which company does this controller belong to?";
                    button1.Text = "Nintendo";
                    button2.Text = "Hisense";
                    button3.Text = "Sony";// correct answer 
                    button4.Text = "Samsung";
                    correctAns = 3;
                    break;
                default:
                    Console.WriteLine("Looks like we are facing a problem. We're working on it... ");
                    break;
            }
        }
    }
}
