using System.Diagnostics;
using System.Diagnostics.Metrics;
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

namespace Laxa1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public int player = 2;
        public int turns = 0;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            if (button.Content.ToString() == "")
            {

                if (player % 2 == 0)
                {
                    button.Content = "X";
                    player = player + 1;
                    turns = turns + 1;
                }
                else if (player % 2 != 0)
                {
                    button.Content = "O";
                    player = player + 1;
                    turns = turns + 1;
                }
            }
        }
    }
}