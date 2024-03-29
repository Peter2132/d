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
    /// Логика взаимодействия для Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {

        private QuestionData2 currentQuestion2;
        public int score = 0;
        public Page2()
        {
            InitializeComponent();
            LoadDataFromJson2();

            
        }

        private void LoadDataFromJson2()
        {
            if (File.Exists("questions2.json"))
            {
                string json = File.ReadAllText("questions2.json");
                List<QuestionData2> questions2 = JsonConvert.DeserializeObject<List<QuestionData2>>(json);

                if (questions2.Count > 0)
                {
                    currentQuestion2 = questions2[0];
                    Name.Text = currentQuestion2.Name2;
                    Description.Text = currentQuestion2.Description2;
                    Button1.Content = currentQuestion2.FirstAnswer2;
                    Button2.Content = currentQuestion2.SecondAnswer2;
                    Button3.Content = currentQuestion2.ThirdAnswer2;
                }

            }

        }
        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            Button clickedButton = (Button)sender;

           
            if (clickedButton == Button1)
            {
                if (currentQuestion2.RightAnswer2 == RightAnswerEnum2.First)
                {
                    score++;
                    MessageBox.Show(score + " правильный ответ!");
                }
                MessageBox.Show(score + " правильный ответ!");
            }
           
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {

            Button clickedButton = (Button)sender;
            if (clickedButton == Button2)
            {
                if (currentQuestion2.RightAnswer2 == RightAnswerEnum2.Second)
                {
                    score++;
                    MessageBox.Show(score + " правильный ответ!");
                }
                MessageBox.Show(score + " правильный ответ!");
            }
            
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {

            Button clickedButton = (Button)sender;
            if (clickedButton == Button3)
            {
                if (currentQuestion2.RightAnswer2 == RightAnswerEnum2.Third)
                {
                    score++;
                    MessageBox.Show(score + " правильный ответ!");
                }
                MessageBox.Show(score + " правильный ответ!");
            }

            
        }


    }
}
