using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace RDClimate
{
    /// <summary>
    /// Interaction logic for Authorization.xaml
    /// </summary>
    public partial class ConnectingStation : Page
    {
        public ConnectingStation()
        {
            InitializeComponent();
        }
        /// <summary>
        /// The function that initiates the transition to the next form
        /// </summary>
        /// <param name="sender"> Object parametr</param>
        /// <param name="e"> Argumets param</param>
        private void GoToDataDisplay(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new DataDisplay());
        }


    }
}
