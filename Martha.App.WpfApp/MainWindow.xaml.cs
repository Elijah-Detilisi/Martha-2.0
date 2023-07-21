using Martha.App.WpfApp.ViewModels;
using System.Windows;

namespace Martha.App.WpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private HomeViewModel _homeViewModel;
        public MainWindow()
        {
            _homeViewModel = new HomeViewModel();
            _homeViewModel.LoadViewModel();
            

            SetStartupLocation();

            InitializeComponent();
        }

        public void SetStartupLocation()
        {
            var test = this.ActualWidth;
            this.Top = SystemParameters.PrimaryScreenHeight - 250;
            this.Left = SystemParameters.PrimaryScreenWidth - 220;
        }
    }
}
