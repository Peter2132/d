using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using static WpfApp6voprosiki.Page5;

namespace WpfApp6voprosiki
{
    public partial class Page1 : Page
    {
        private QuestionData currentQuestion;
        public int score = 0;
        public Page1()
        {
            InitializeComponent();
            LoadDataFromJson();
        }

        private void LoadDataFromJson()
        {
            if (File.Exists("questions.json"))
            {
                string json = File.ReadAllText("questions.json");
                List<QuestionData> questions = JsonConvert.DeserializeObject<List<QuestionData>>(json);

                if (questions.Count > 0)
                {
                    currentQuestion = questions[0];
                    Name.Text = currentQuestion.Name;
                    Description.Text = currentQuestion.Description;
                    Button1.Content = currentQuestion.FirstAnswer;
                    Button2.Content = currentQuestion.SecondAnswer;
                    Button3.Content = currentQuestion.ThirdAnswer;
                }

                
            }
           

        }

        

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            Button clickedButton = (Button)sender;

           
            if (clickedButton == Button1)
            {
                if (currentQuestion.RightAnswer == RightAnswerEnum.First)
                {
                    score++;
                    MessageBox.Show(score + " правильный ответ!");
                }
               
                PageFrame.Content = new Page4();
                MessageBox.Show(score + " правильный ответ!");
            }

        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {

            Button clickedButton = (Button)sender;
            if (clickedButton == Button2)
            {
                if (currentQuestion.RightAnswer == RightAnswerEnum.Second)
                {
                    score++;
                    MessageBox.Show(score + " правильный ответ!");
                }
               
                PageFrame.Content = new Page4();
                MessageBox.Show(score + " правильный ответ!");
            }
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {

            Button clickedButton = (Button)sender;
            if (clickedButton == Button3)
            {
                if (currentQuestion.RightAnswer == RightAnswerEnum.Third)
                {
                    score++;
                    MessageBox.Show(score + " правильный ответ!");
                }
               
                PageFrame.Content = new Page4();
                MessageBox.Show(score + " правильный ответ!");
            }
        }

        
    }
}