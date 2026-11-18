using System.Collections.ObjectModel;
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

namespace WpfApp3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 



    public partial class MainWindow : Window
    {
        public string TxValue { get; set; }
        public int My_int_value { get; set; }
        public ObservableCollection<int> My_collection { get; set; }
        public MainWindow()
        {
            InitializeComponent();

            this.My_collection = new ObservableCollection<int>();
            DataContext = this;
        }
        private void Btn_add(object sender, RoutedEventArgs e)
        {
            if (validate_number(this.TxValue))
            {
                this.My_collection.Add(this.My_int_value);
            }
        }
        private bool validate_number(string text) {
            var isNumber = int.TryParse(text, out var number);
            this.My_int_value = number;
            return isNumber;
        }


    }
}