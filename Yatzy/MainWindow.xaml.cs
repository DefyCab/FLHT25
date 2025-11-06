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

        public int ettSumma = 0, tvaSumma = 0, treSumma = 0, fyrSumma = 0, femSumma = 0, sexSumma = 0, total = 0;

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
        private void fyrorSumma(object sender, TextChangedEventArgs e)
        {
            fyrSumma = int.Parse(fyrBox.Text);
        }
        private void femmorSumma(object sender, TextChangedEventArgs e)
        {
            femSumma = int.Parse(femBox.Text);
        }
        private void sexorSumma(object sender, TextChangedEventArgs e)
        {
            sexSumma = int.Parse(sexBox.Text);
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