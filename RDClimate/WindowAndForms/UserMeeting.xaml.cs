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

namespace RDClimate
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class UserMeeting : Window
    {

        public UserMeeting()
        {
            InitializeComponent();

        }
        /// <summary>
        /// The function that initiates the transition to the next form
        /// </summary>
        /// <param name="sender">Object parametr</param>
        /// <param name="e">Argumets param</param>
        private void GoAut(object sender, RoutedEventArgs e)
        {
            MainPage.Content = new ConnectingStation();
        }
        /// <summary>
        /// The function that initializes the closing of the window
        /// </summary>
        /// <param name="sender">Object parametr</param>
        /// <param name="e">Argumets param</param>
        private void CloseWindow(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.Close();

        }
        /// <summary>
        /// The function that initializes the minimize of the window
        /// </summary>
        /// <param name="sender">Object parametr</param>
        /// <param name="e">Argumets param</param>
        private void MinimizeWindow(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.WindowState = WindowState.Minimized;
        }
        /// <summary>
        /// The function that initializes the window movement
        /// </summary>
        /// <param name="sender">Object parametr</param>
        /// <param name="e">Argumets param</param>
        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }
    }
}
