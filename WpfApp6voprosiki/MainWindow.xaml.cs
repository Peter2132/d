using System;
using System.Collections.Generic;
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
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Test_Click(object sender, RoutedEventArgs e)
        {
            
            Window1 window1 = new Window1();
            window1.DisableButton();
            window1.Show();
            this.Close();
        }

        

        private void CodeAdmin_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (CodeAdmin.Text == "admin")
            {
                Window1 window1 = new Window1();
                window1.Show();

                Window parentWindow = Window.GetWindow(this); 
                if (parentWindow != null)
                {
                    parentWindow.Close(); 
                }
            }
        }

        private void RedactTest_Click(object sender, RoutedEventArgs e)
        {
            CodeAdmin.IsEnabled = true;
        }
    }
}
