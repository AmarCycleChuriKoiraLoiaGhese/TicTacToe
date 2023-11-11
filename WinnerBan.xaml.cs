using System.Windows;

namespace TicTacToe
{
    /// <summary>
    /// Interaction logic for WinnerBan.xaml
    /// </summary>
    public partial class WinnerBan : Window
    {
        Ask_Names AskNames;
        Menu menu;
        int winningplayer;
        string P1;
        string P2;
        int score1;
        int score2;

        public WinnerBan(int WinningPlayer, string Player1, string Player2, int Score1, int Score2)
        {
            P1 = Player1;
            P2 = Player2;
            winningplayer = WinningPlayer;
            score1 = Score1;
            score2 = Score2;
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Opening a new AskNames form
            if (AskNames == null)
            {
                AskNames = new Ask_Names();
            }
            AskNames.Show();
            Hide();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (Banner.Visibility == Visibility.Hidden)
            {
                Banner.Visibility = Visibility.Visible;
            }
            if (lblScore.Visibility == Visibility.Hidden)
            {
                lblScore.Visibility = Visibility.Visible;
            }
            
            //Opening a new menu form
            if (menu == null)
            {
                menu = new Menu();
            }
            menu.Show();
            Hide();

            //Resetting the names and scores for the new Menu form
            menu.lblName1.Text = P1;
            menu.lblName2.Text = P2;
            menu.ScoreContainer1.Content = score1.ToString();
            menu.ScoreContainer2.Content = score2.ToString();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if (winningplayer == 0)
            {
                lblWinner.Content = P1;
                score1 += 1;
                lblScore.Content += score1.ToString();

            }
            else if (winningplayer == 1)
            {
                lblWinner.Content = P2;
                score2 += 1;
                lblScore.Content += score2.ToString();
            }
            else if (winningplayer == 2)
            {
                Banner.Visibility = Visibility.Hidden;
                lblWinner.Content = "Draw";
                lblScore.Visibility = Visibility.Hidden;
            }
        }
    }
}
