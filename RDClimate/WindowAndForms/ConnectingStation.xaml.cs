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
