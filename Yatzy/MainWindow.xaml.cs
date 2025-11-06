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

        public int total;
        public string ettSumma, tvaSumma, treSumma, fyrSumma, femSumma, sexSumma;

        private void ettorSumma(object sender, TextChangedEventArgs e)
        {
            ettSumma = ettBox.Text;
        }
        private void tvaorSumma(object sender, TextChangedEventArgs e)
        {
            tvaSumma = tvaBox.Text;
        }
        private void treorSumma(object sender, TextChangedEventArgs e)
        {
            treSumma = treBox.Text;
        }
        private void fyrorSumma(object sender, TextChangedEventArgs e)
        {
            fyrSumma = fyrBox.Text;
        }
        private void femmorSumma(object sender, TextChangedEventArgs e)
        {
            femSumma = femBox.Text;
        }
        private void sexorSumma(object sender, TextChangedEventArgs e)
        {
            sexSumma = sexBox.Text;
        }

        private void btnSumma_Click(object sender, RoutedEventArgs e)
        {
            totalSumma();
            btnSumma.Content = total;
        }

        public void totalSumma()
        {
            // Parsing utflyttad så inte programmet kastar undantag om ändrar summan i textboxen.
            total = int.Parse(ettSumma) + int.Parse(tvaSumma) + int.Parse(treSumma) + int.Parse(fyrSumma) + int.Parse(femSumma) + int.Parse(sexSumma);
        }

    }


}