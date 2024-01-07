using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DComms
{
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
        }

        public void EnableButtons()
        {
            Button[] commsListButtons = { commsListOne, commsListTwo, commsListThree, commsListFour, commsListFive };
            foreach (Button button in commsListButtons)
            {
                if (!button.IsEnabled)
                {
                    button.IsEnabled = true;
                }
            }
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void DragBar_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                DragMove();
            }
        }

        private void ShopButton_Click(object sender, RoutedEventArgs e)
        {
            userLevel.Text = "100";
            usernameText.Text = "NiTzuA";
            currentStreak.Text = 189.ToString() + " Days";
            levelProgress.Text = 1119.ToString() + "/" + 1120.ToString() + " XP";
            MessageBox.Show("You opened the shop!");
        }

        private void ConfigButton_Click(object sender, RoutedEventArgs e)
        {
            userLevel.Text = "69";
            usernameText.Text = "Apeir0n";
            currentStreak.Text = 365.ToString() + " Days";
            levelProgress.Text = 9999.ToString() + "/" + 10000.ToString() + " XP";
            MessageBox.Show("You opened the configuration menu!");
        }

        private void CommsListOne_Click(object sender, RoutedEventArgs e)
        {
            EnableButtons();
            commsListOne.IsEnabled = false;
        }

        private void CommsListTwo_Click(object sender, RoutedEventArgs e)
        {
            EnableButtons();
            commsListTwo.IsEnabled = false;
        }

        private void CommsListThree_Click(object sender, RoutedEventArgs e)
        {
            EnableButtons();
            commsListThree.IsEnabled = false;
        }

        private void CommsListFour_Click(object sender, RoutedEventArgs e)
        {
            EnableButtons();
            commsListFour.IsEnabled = false;
        }

        private void CommsListFive_Click(object sender, RoutedEventArgs e)
        {
            EnableButtons();
            commsListFive.IsEnabled = false;
        }

        /*Make a function that checks if a button is disabled, if disabled, enable. Then make the function disable the receibed button*/
    }
}
