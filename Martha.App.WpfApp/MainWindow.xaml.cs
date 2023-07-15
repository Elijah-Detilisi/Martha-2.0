using Martha.App.Utility;
using System.Windows;

namespace Martha.App.WpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Personalization _personalization;
        public MainWindow()
        {
            _personalization = new Personalization();
            _personalization.LoadSystemStatus();

            InitializeComponent();
        }
    }
}
