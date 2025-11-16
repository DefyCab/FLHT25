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
            int tio = 10;
            int elva = 11;
            double tiokomma3 = 10.3;
            double elvakomma3 = 11.3;
            int result = Generisk<int>(ref tio, ref elva);
            double result2 = Generisk2<double>(tiokomma3, elvakomma3);
            //MessageBox.Show($"{result} + {result2}");
            MessageBox.Show($"tio {tio}" + $" elva{elva}" + $" tiokomma3 {tiokomma3}" + $" elvakomma3 {elvakomma3}");
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
            public string FirstSubscriber => Subscribers.First();

            public List<string> Subscribers = new List<string>()
        {
              "Love",
              "Erik",
              "Sven",
              "Kurt",
              "Bilal",
              "Erika",
              "Anette",
              "Julie"
        };

        }

        private T Generisk<T>(ref T item, ref T item2)
        {
            T temporary;
            temporary = item;
            item = item2;
            item2 = temporary;

            return item;
        }
        private T Generisk2<T>(T item, T item2)
        {
            T temporary;
            temporary = item;
            item = item2;
            item2 = temporary;

            return item;
        }

        private void Test()
        {
            Channel channel = new Channel();

            int numberOfSubscribers = channel.Subscribers.Count();
            bool second = channel.Subscribers.First() == "Erik";
            int subCount = channel.SubCount;
            string firstSub = channel.FirstSubscriber;
            MessageBox.Show($"{numberOfSubscribers}");
            MessageBox.Show($"{second}");
            MessageBox.Show($"{subCount}");
            MessageBox.Show($"{firstSub}");

        }
    }
}
