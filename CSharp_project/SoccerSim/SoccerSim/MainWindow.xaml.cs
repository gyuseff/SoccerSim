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

namespace SoccerSim
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

        private void HelloWorld_button_Click(object sender, RoutedEventArgs e)
        {
            switch (HelloWorld_button.Content)
            {
                case "Click Here":
                    HelloWorld_button.Content = "Hello World!";
                    break;
                default:
                    HelloWorld_button.Content = "Click Here";
                    break;
            }

        }
    }
}