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

namespace FactoryPattern
{

    public partial class MainWindow : Window
    {
        private CakeFactory _cake = new();
        public MainWindow()
        {
            InitializeComponent();
        }
        //private void OrderCake()
        //{
        //    Cake princess = _cake.MakeACake();
        //    princess.price = 100;
        //    princess.id = 1;
        //    princess.type = "Princesstårta";

        //}

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Cake princess = _cake.MakeACake();
            princess.price = 100;
            princess.id = 1;
            princess.type = "Princesstårta";
            cakeBox.Text = princess.type.ToString();
        }
    }
}