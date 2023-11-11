using System.Windows;

namespace TicTacToe
{
    /// <summary>
    /// Interaction logic for Ask_Names.xaml
    /// </summary>
    public partial class Ask_Names : Window
    {
        //Variables made in order to recall other forms
        MainWindow main;      
        Menu Menu;

        public Ask_Names()
        {
            main = new MainWindow();
            InitializeComponent();
        }

        private void btnPlay_Click(object sender, RoutedEventArgs e)
        {
            //Checks if the TextBoxes and CheckBoxes are all perfectly set 
            if (ChBoxComfirm1.IsChecked == true && ChBoxComfirm2.IsChecked == true && txtEnterName1.Text != "Enter Your Name" && txtEnterName2.Text != "Enter Your Name" && txtEnterName1.Text != "" && txtEnterName2.Text != "")
            {
                //Open the Menu form
                if (Menu == null)
                {
                    Menu = new Menu();
                }
                Menu.Show();
                Hide();

                //Applies the names input onto the other form's label and respective scores
                Menu.lblName1.Text = txtEnterName1.Text;
                Menu.lblName2.Text = txtEnterName2.Text;
                Menu.ScoreContainer1.Content = "0";
                Menu.ScoreContainer2.Content = "0";
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Simply opens the main form
            main.Show();
            Hide();
        }
    }
}
