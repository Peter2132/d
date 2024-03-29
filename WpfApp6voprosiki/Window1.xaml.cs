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


namespace WpfApp6voprosiki
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            
        }

        private void AddTestButton_Click(object sender, RoutedEventArgs e)
        {
            PageFrame.Content = new Page5();
        }

        private void BeginTestButton_Click(object sender, RoutedEventArgs e)
        {
            if (IsJsonDataAvailable())
            {
                PageFrame.Content = new Page1();
            }
            else
            {
                MessageBox.Show("Нет теста.");
            }
        }

        private bool IsJsonDataAvailable()
        {
            bool isAvailable = false;

            if (File.Exists("questions.json") && File.Exists("questions1.json") && File.Exists("questions2.json"))
            {
                string json1 = File.ReadAllText("questions.json");
                string json2 = File.ReadAllText("questions1.json");
                string json3 = File.ReadAllText("questions2.json");

                if (!string.IsNullOrEmpty(json1) && !string.IsNullOrEmpty(json2) && !string.IsNullOrEmpty(json3))
                {
                    isAvailable = true;
                }
            }

            return isAvailable;
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            if (PageFrame.CanGoBack)
            {
                PageFrame.GoBack(); 
            }
            else
            {
               

                MainWindow window12 = new MainWindow();
                window12.Show();
                this.Close();
            }
        }

        public void DisableButton()
        {
           
            AddTestButton.IsEnabled = false; 
        }
    }
}
