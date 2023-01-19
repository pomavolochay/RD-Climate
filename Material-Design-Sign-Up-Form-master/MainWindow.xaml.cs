using System;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Animation;
using System.Windows.Navigation;
using System.Windows.Threading;

namespace Sign_Up_Form
{
    public partial class MainWindow : Window
    {
        private bool _allowDirectNavigation = false;
        private NavigatingCancelEventArgs _navArgs = null;
        private Duration _duration = new Duration(TimeSpan.FromSeconds(1));
        private double _oldHeight = 0;

        public MainWindow()
        {
            InitializeComponent();
          
            LogSingFrame.Navigate(new SingUpPage());
            Manager.LogSingFrame = LogSingFrame;
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private void Frame_Navigating(object sender, NavigatingCancelEventArgs e)
        {
            var fa = new DoubleAnimation(0, 1, TimeSpan.FromSeconds(0.5));
            (e.Content as Page).BeginAnimation(OpacityProperty, fa);
        }

    }
}