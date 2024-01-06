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

        private void exitButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void dragBar_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                DragMove();
            }
        }

        private void shopButton_Click(object sender, RoutedEventArgs e)
        {
            userLevel.Text = "100";
            usernameText.Text = "NiTzuA";
            currentStreak.Text = 189.ToString() + " Days";
            levelProgress.Text = 1119.ToString() + "/" + 1120.ToString() + " XP";
            MessageBox.Show("You opened the shop!");
        }

        private void configButton_Click(object sender, RoutedEventArgs e)
        {
            userLevel.Text = "69";
            usernameText.Text = "Apeir0n";
            currentStreak.Text = 365.ToString() + " Days";
            levelProgress.Text = 9999.ToString() + "/" + 10000.ToString() + " XP";
            MessageBox.Show("You opened the configuration menu!");
        }

        /*private void testButton_Click(object sender, RoutedEventArgs e)
        {
            userLevel.Text = "100";
            usernameText.Text = "NiTzuA";
            currentStreak.Text = 189.ToString() + " Days"; 
            levelProgress.Text = 1119.ToString() + "/" + 1120.ToString() + " XP";
        }*/
    }
}
