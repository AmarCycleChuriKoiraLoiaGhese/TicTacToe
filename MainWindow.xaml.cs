using System.Windows;

namespace TicTacToe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Ask_Names askNames;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Opening a new AskNames form
            if (askNames == null)
            {
                askNames = new Ask_Names();
            }
            askNames.Show();
            Hide();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //Closing the program
            Close();
        }
    }
}
