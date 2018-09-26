using System.Windows;
using ClassLibraryNetStandard;

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var class1 = new Class1()
            {
            };
        }
    }
}
