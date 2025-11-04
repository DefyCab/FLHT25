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
        }
        private void tvaorSumma(object sender, TextChangedEventArgs e)
        {
            tvaSumma = int.Parse(tvaBox.Text);
        }
        private void treorSumma(object sender, TextChangedEventArgs e)
        {
            treSumma = int.Parse(treBox.Text);
        }
        private void fyrorsumma(object sender, TextChangedEventArgs e)
        {
            fyrSumma = int.Parse(fyrBox.Text);
        }
        private void femmorSumma(object sender, TextChangedEventArgs e)
        {
            femSumma = int.Parse(ettBox.Text);
        }
        private void sexorSumma(object sender, TextChangedEventArgs e)
        {
            sexSumma = int.Parse(ettBox.Text);
        }

        private void btnSumma_Click(object sender, RoutedEventArgs e)
        {
            totalSumma();
            btnSumma.Content = total;
        }

        public void totalSumma()
        {
            total = ettSumma + tvaSumma + treSumma + fyrSumma + femSumma + sexSumma;
        }
    }
}