using System.Windows;
using System.Windows.Input;

namespace RDClimate
{
    /// <summary>
    /// Interaction logic for UserMeeting.xaml
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
