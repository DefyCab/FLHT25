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
        public string full = "jag heter Mimmi";
        Person Love = new() { Name = "Love", Age = 25 };
        Car volvo = new();
        Robot robot = new();
        Car saab = new();

        // static betyder tillgänglig för alla instanser.
        static string firstName = "Erik";
        static string lastName = "Öberg";
        static string name = $"My full name is: {firstName} {lastName}";

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Love_says_hi();
            Test();
            int result = Generisk(10);
            string result2 = Generisk("10");
            MessageBox.Show($"{result} + {result2}");
        }

        static public void Love_says_hi()
        {
            string hej = "hej";
            MessageBox.Show($"Love säger {hej}");
            MessageBox.Show($"{name}");
        }

        private void ok(object sender, RoutedEventArgs e)
        {
            saab.speed = 10020;
            mimmi.Text = saab.speed.ToString();
            saab.fullThrottle(mimmi, "Jag är noah");
            //robot.namn = "Love";
            //robot.sayHello(textBox);

        }

        class Channel
        {
            public int SubCount => Subscribers.Count;

            public List<string> Subscribers = new List<string>()
        {
            "Love", "Erik"
        };

        }

        private T Generisk<T>(T item)
        {
            return item;
        }

        private void Test()
        {
            Channel channel = new Channel();

            //bool first = channel.Subscribers.First() == "Love";
            bool second = channel.Subscribers.First() == "Erik";
            //MessageBox.Show($"{first}");
            MessageBox.Show($"{second}");

        }


    }
}
