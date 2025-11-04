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

namespace Yatzy
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


        public int ettSumma = 0;
        public int tvaSumma = 0;
        public int treSumma = 0;
        public int fyrSumma = 0;
        public int femSumma = 0;
        public int sexSumma = 0;
        public int total;

        private void ettorSumma(object sender, TextChangedEventArgs e)
        {
            ettSumma = int.Parse(ettBox.Text);
            total = total + ettSumma;
        }
        private void tvaorSumma(object sender, TextChangedEventArgs e)
        {
            tvaSumma = int.Parse(tvaBox.Text);
            total = total + tvaSumma;
        }
        private void treorSumma(object sender, TextChangedEventArgs e)
        {
            treSumma = int.Parse(treBox.Text);
            total = total + treSumma;
        }
        private void fyrorsumma(object sender, TextChangedEventArgs e)
        {
            fyrSumma = int.Parse(fyrBox.Text);
            total = total + fyrSumma;
        }
        private void femmorSumma(object sender, TextChangedEventArgs e)
        {
            femSumma = int.Parse(ettBox.Text);
            total = total + femSumma;
        }
        private void sexorSumma(object sender, TextChangedEventArgs e)
        {
            sexSumma = int.Parse(ettBox.Text);
            total = total + sexSumma;
        }

        private void btnSumma_Click(object sender, RoutedEventArgs e)
        {
            btnSumma.Content = total;
        }

    }
}