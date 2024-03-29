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
using System.Xml;

namespace WpfApp6voprosiki
{
    /// <summary>
    /// Логика взаимодействия для Page5.xaml
    /// </summary>
    public partial class Page5 : Page
    {
        private List<QuestionData> questions = new List<QuestionData>();
        private List<QuestionData1> questions1 = new List<QuestionData1>();
        private List<QuestionData2> questions2 = new List<QuestionData2>();

        public Page5()
        {
            InitializeComponent();
            LoadQuestionsFromJson();
        }
        public enum RightAnswerEnum
        {
            First,
            Second,
            Third
        }
        public class QuestionData
        {
            public string Name { get; set; }
            public string Description { get; set; }
            public string FirstAnswer { get; set; }
            public string SecondAnswer { get; set; }
            public string ThirdAnswer { get; set; }
            public RightAnswerEnum RightAnswer { get; set; }
        }

     
        private void NameAnswer_TextChanged(object sender, TextChangedEventArgs e)
        {
            UpdateJson();
        }

        private void DescriptionAnswer_TextChanged(object sender, TextChangedEventArgs e)
        {
            UpdateJson();
        }

        private void FirstAnswerAnswer_TextChanged(object sender, TextChangedEventArgs e)
        {
            UpdateJson();
        }

        private void VtoroyAnswerAnswer_TextChanged(object sender, TextChangedEventArgs e)
        {
            UpdateJson();
        }

        private void TretiyAnswerAnswer_TextChanged(object sender, TextChangedEventArgs e)
        {
            UpdateJson();
        }

        private void RightAnswer_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateJson();
        }

        private void UpdateJson()
        {
            RightAnswerEnum selectedAnswer;
            if (Enum.TryParse((RightAnswer.SelectedItem as ComboBoxItem)?.Tag.ToString(), out selectedAnswer))
            {
                QuestionData currentQuestion = new QuestionData
                {
                    Name = NameAnswer.Text,
                    Description = DescriptionAnswer.Text,
                    FirstAnswer = FirstAnswerAnswer.Text,
                    SecondAnswer = VtoroyAnswerAnswer.Text,
                    ThirdAnswer = TretiyAnswerAnswer.Text,
                    RightAnswer = selectedAnswer
                };

                
                questions.Clear();
                questions.Add(currentQuestion);

                
                string json = JsonConvert.SerializeObject(questions, Newtonsoft.Json.Formatting.Indented);
                File.WriteAllText("questions.json", json);
            }
        }



        public enum RightAnswerEnum1
        {
            First,
            Second,
            Third
        }
        public class QuestionData1
        {
            public string Name1 { get; set; }
            public string Description1 { get; set; }
            public string FirstAnswer1 { get; set; }
            public string SecondAnswer1 { get; set; }
            public string ThirdAnswer1 { get; set; }
            public RightAnswerEnum1 RightAnswer1 { get; set; }
        }

        
       


        private void NameAnswer1_TextChanged(object sender, TextChangedEventArgs e)
        {
            UpdateJson1();
        }

        private void DescriptionAnswer1_TextChanged(object sender, TextChangedEventArgs e)
        {
            UpdateJson1();
        }

        private void FirstAnswerAnswer1_TextChanged(object sender, TextChangedEventArgs e)
        {
            UpdateJson1();
        }

        private void VtoroyAnswerAnswer1_TextChanged(object sender, TextChangedEventArgs e)
        {
            UpdateJson1();
        }

        private void TretiyAnswerAnswer1_TextChanged(object sender, TextChangedEventArgs e)
        {
            UpdateJson1();
        }

        private void RightAnswer1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateJson1();
        }


        private void UpdateJson1()
        {
            RightAnswerEnum1 selectedAnswer1;
            if (Enum.TryParse((RightAnswer1.SelectedItem as ComboBoxItem)?.Tag.ToString(), out selectedAnswer1))
            {
                QuestionData1 currentQuestion1 = new QuestionData1
                {
                    Name1 = NameAnswer1.Text,
                    Description1 = DescriptionAnswer1.Text,
                    FirstAnswer1 = FirstAnswerAnswer1.Text,
                    SecondAnswer1 = VtoroyAnswerAnswer1.Text,
                    ThirdAnswer1 = TretiyAnswerAnswer1.Text,
                    RightAnswer1 = selectedAnswer1
                };

                questions1.Clear();
                questions1.Add(currentQuestion1);

                string json = JsonConvert.SerializeObject(questions1, Newtonsoft.Json.Formatting.Indented);
                File.WriteAllText("questions1.json", json);
            }
        }








        public enum RightAnswerEnum2
        {
            First,
            Second,
            Third
        }
        public class QuestionData2
        {
            public string Name2 { get; set; }
            public string Description2 { get; set; }
            public string FirstAnswer2 { get; set; }
            public string SecondAnswer2 { get; set; }
            public string ThirdAnswer2 { get; set; }
            public RightAnswerEnum2 RightAnswer2 { get; set; }
        }


        

        private void NameAnswer2_TextChanged(object sender, TextChangedEventArgs e)
        {
            UpdateJson2();
        }

        private void DescriptionAnswer2_TextChanged(object sender, TextChangedEventArgs e)
        {
            UpdateJson2();
        }

        private void FirstAnswerAnswer2_TextChanged(object sender, TextChangedEventArgs e)
        {
            UpdateJson2();
        }

        private void VtoroyAnswerAnswer2_TextChanged(object sender, TextChangedEventArgs e)
        {
            UpdateJson2();
        }

        private void TretiyAnswerAnswer2_TextChanged(object sender, TextChangedEventArgs e)
        {
            UpdateJson2();
        }

        private void RightAnswer2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateJson2();
        }


        private void UpdateJson2()
        {
            RightAnswerEnum2 selectedAnswer2;
            if (Enum.TryParse((RightAnswer2.SelectedItem as ComboBoxItem)?.Tag.ToString(), out selectedAnswer2))
            {
                QuestionData2 currentQuestion2 = new QuestionData2
                {
                    Name2 = NameAnswer2.Text,
                    Description2 = DescriptionAnswer2.Text,
                    FirstAnswer2 = FirstAnswerAnswer2.Text,
                    SecondAnswer2 = VtoroyAnswerAnswer2.Text,
                    ThirdAnswer2 = TretiyAnswerAnswer2.Text,
                    RightAnswer2 = selectedAnswer2
                };

                questions2.Clear();
                questions2.Add(currentQuestion2);

                string json = JsonConvert.SerializeObject(questions2, Newtonsoft.Json.Formatting.Indented);
                File.WriteAllText("questions2.json", json);
            }
        }





        private void LoadQuestionsFromJson()
        {
            if (File.Exists("questions1.json"))
            {
                string json = File.ReadAllText("questions1.json");
                List<QuestionData1> tempQuestions = JsonConvert.DeserializeObject<List<QuestionData1>>(json);

                foreach (var question in tempQuestions)
                {
                    NameAnswer1.Text = question.Name1;
                    DescriptionAnswer1.Text = question.Description1;
                    FirstAnswerAnswer1.Text = question.FirstAnswer1;
                    VtoroyAnswerAnswer1.Text = question.SecondAnswer1;
                    TretiyAnswerAnswer1.Text = question.ThirdAnswer1;

                    switch (question.RightAnswer1)
                    {
                        case RightAnswerEnum1.First:
                            RightAnswer1.SelectedIndex = 0;
                            break;
                        case RightAnswerEnum1.Second:
                            RightAnswer1.SelectedIndex = 1;
                            break;
                        case RightAnswerEnum1.Third:
                            RightAnswer1.SelectedIndex = 2;
                            break;

                    }
                }


                if (File.Exists("questions.json"))
                {
                    string json1 = File.ReadAllText("questions.json");
                    List<QuestionData> tempQuestions1 = JsonConvert.DeserializeObject<List<QuestionData>>(json1);

                    foreach (var question in tempQuestions1)
                    {
                        NameAnswer.Text = question.Name;
                        DescriptionAnswer.Text = question.Description;
                        FirstAnswerAnswer.Text = question.FirstAnswer;
                        VtoroyAnswerAnswer.Text = question.SecondAnswer;
                        TretiyAnswerAnswer.Text = question.ThirdAnswer;

                        switch (question.RightAnswer)
                        {
                            case RightAnswerEnum.First:
                                RightAnswer.SelectedIndex = 0;
                                break;
                            case RightAnswerEnum.Second:
                                RightAnswer.SelectedIndex = 1;
                                break;
                            case RightAnswerEnum.Third:
                                RightAnswer.SelectedIndex = 2;
                                break;

                        }
                    }
                }



                if (File.Exists("questions2.json"))
                {
                    string json2 = File.ReadAllText("questions2.json");
                    List<QuestionData2> tempQuestions2 = JsonConvert.DeserializeObject<List<QuestionData2>>(json2);

                    foreach (var question in tempQuestions2)
                    {
                        NameAnswer2.Text = question.Name2;
                        DescriptionAnswer2.Text = question.Description2;
                        FirstAnswerAnswer2.Text = question.FirstAnswer2;
                        VtoroyAnswerAnswer2.Text = question.SecondAnswer2;
                        TretiyAnswerAnswer2.Text = question.ThirdAnswer2;

                        switch (question.RightAnswer2)
                        {
                            case RightAnswerEnum2.First:
                                RightAnswer2.SelectedIndex = 0;
                                break;
                            case RightAnswerEnum2.Second:
                                RightAnswer.SelectedIndex = 1;
                                break;
                            case RightAnswerEnum2.Third:
                                RightAnswer2.SelectedIndex = 2;
                                break;

                        }
                    }
                }



            }


        }

    }   
}
