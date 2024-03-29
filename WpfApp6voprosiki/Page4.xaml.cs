using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static WpfApp6voprosiki.Page5;

namespace WpfApp6voprosiki
{
    /// <summary>
    /// Логика взаимодействия для Page4.xaml
    /// </summary>
    public partial class Page4 : Page
    {
        private QuestionData1 currentQuestion1;
        public int score = 0;
        public Page4()
        {
            InitializeComponent();
            LoadDataFromJson1();
           
        }


        private void LoadDataFromJson1()
        {
            if (File.Exists("questions1.json"))
            {
                string json = File.ReadAllText("questions1.json");
                List<QuestionData1> questions1 = JsonConvert.DeserializeObject<List<QuestionData1>>(json);

                if (questions1.Count > 0)
                {
                    currentQuestion1 = questions1[0];
                    Name.Text = currentQuestion1.Name1;
                    Description.Text = currentQuestion1.Description1;
                    Button1.Content = currentQuestion1.FirstAnswer1;
                    Button2.Content = currentQuestion1.SecondAnswer1;
                    Button3.Content = currentQuestion1.ThirdAnswer1;
                }

            }

        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            Button clickedButton = (Button)sender;

            if (clickedButton == Button1)
            {
                if (currentQuestion1.RightAnswer1 == RightAnswerEnum1.First)
                {
                    score++;
                    MessageBox.Show(score + " правильный ответ!");
                }
                MessageBox.Show(score + " правильный ответ!");
                PageFrame.Content = new Page2();
            }
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {

            Button clickedButton = (Button)sender;
            if (clickedButton == Button2)
            {
                if (currentQuestion1.RightAnswer1 == RightAnswerEnum1.Second)
                {
                    score++;
                    MessageBox.Show(score + " правильный ответ!");
                }
                PageFrame.Content = new Page2();
                MessageBox.Show(score + " правильный ответ!");

            }

        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {

            Button clickedButton = (Button)sender;
            if (clickedButton == Button3)
            {
                if (currentQuestion1.RightAnswer1 == RightAnswerEnum1.Third)
                {
                    score++;
                    MessageBox.Show(score + " правильный ответ!");
                }
                MessageBox.Show(score + " правильный ответ!");
                PageFrame.Content = new Page2();
            }
        }

        
    }

}
