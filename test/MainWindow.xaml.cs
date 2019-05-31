using System.Windows;

namespace test
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

        private void CountingButton_OnClick(object sender, RoutedEventArgs e)
        {
            txt.Clear();
        }
    }
}
