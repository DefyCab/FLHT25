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
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public int player = 2;

        private void Ett_Click(object sender, RoutedEventArgs e)
        {
            if (Ett.Content.ToString() == "X")
            {
                Ett.Content = "O";
            }
            else if (Ett.Content.ToString() == "O")
            {
                Ett.Content = "O";
            }
            else if (Ett.Content.ToString() == "")
            {
                Ett.Content = "X";
            }
        }
        private void EttTva_Click(object sender, RoutedEventArgs e)
        {
            if (EttTva.Content.ToString() == "X")
            {
                EttTva.Content = "O";
            }
            else if (EttTva.Content.ToString() == "O")
            {
                EttTva.Content = "O";
            }
            else if (EttTva.Content.ToString() == "")
            {
                EttTva.Content = "X";
            }
        }

        public void Text(object sender, RoutedEventArgs e)
        {
            EttTre.Content = "Love";
        }

        public void ForLoop(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < 1; i++)
            {
                if (player % 2 != 0)
                {
                    TvaEtt.Content = "X";
                }
                else
                    TvaEtt.Content = "O";
            }
            player++;
        }
        public void ElseIf(object sender, RoutedEventArgs e)
        {
            if (player % 2 != 0)
            {
                TvaEtt.Content = "X";
                player = player + 1;
            }
            else if (player % 2 == 0)
            {
                TvaEtt.Content = "O";
                player = player + 1;
            }
        }

        public void ColorSwap(object sender, RoutedEventArgs e)
        {
            Tre();
        }
        public void Tre()
        {
            TreTre.Background = Brushes.Red;
        }

        private void TreTre_MouseEnter(object sender, MouseEventArgs e)
        {
            TreTre.Background = Brushes.Purple;
        }

        private void Grid_MouseWheel(object sender, MouseWheelEventArgs e)
        {
            TreTre.Background = Brushes.Blue;
        }

        private void Yellow(object sender, RoutedEventArgs e)
        {
            TvaTva.Background = Brushes.Yellow;
            TvaTre.Background = Brushes.LemonChiffon;
        }

        private void TreTre_MouseEnter_1(object sender, MouseEventArgs e)
        {

        }
    }
}