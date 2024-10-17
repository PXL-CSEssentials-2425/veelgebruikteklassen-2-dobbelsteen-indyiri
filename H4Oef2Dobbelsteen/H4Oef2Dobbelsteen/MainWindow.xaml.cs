using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace H4Oef2Dobbelsteen
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        StringBuilder sb = new StringBuilder();
        Random rnd = new Random();

        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void againButton_Click(object sender, RoutedEventArgs e)
        {
            resultTextBox.Clear();
            startButton.Focus();
            sb.Clear();
        }

        private void startButton_Click(object sender, RoutedEventArgs e)
        {
            int worp = 0;
            int resultaatWorp;

            do
            {
                resultaatWorp = rnd.Next(1, 7);
                worp++;

                sb.AppendLine($"Worp {worp} geeft {resultaatWorp}");
            }
            while (resultaatWorp != 6);
            
            resultTextBox.Text = sb.ToString();
        }
    }
}