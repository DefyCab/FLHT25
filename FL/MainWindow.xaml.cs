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

namespace FL
{


    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            robot.namn = "Love";
        }
        public string full = "jag är en variabel";
        Person Love = new() { Name = "Love", Age = 25 };
        Car car = new();
        Robot robot = new();


        // static betyder tillgänglig för alla instanser.
        static string firstName = "Erik";
        static string lastName = "Öberg";
        static string name = $"My full name is: {firstName} {lastName}";

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Love_says_hi();
        }

        static public void Love_says_hi()
        {
            string hej = "hej";
            MessageBox.Show($"Love säger {hej}");
            MessageBox.Show($"{name}");
        }

        private void ok(object sender, RoutedEventArgs e)
        {
            //textBox.Text = Love.Name;
            //car.fullThrottle(textBox, full);
            robot.namn = "Love";
            robot.sayHello(textBox);

        }
    }
}
