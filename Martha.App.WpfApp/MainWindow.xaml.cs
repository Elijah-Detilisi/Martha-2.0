using Martha.App.Utility;
using System.Collections.Generic;
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
            _personalization.LoadGreeting();
            _personalization.LoadSystemStatus();

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
