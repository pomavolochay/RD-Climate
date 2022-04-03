using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using System.Threading;
using System.Timers;
using System.Threading.Tasks;
using System.Collections.Generic;
using KeysConfiguration;


namespace RDClimate
{
    /// <summary>
    /// Interaction logic for DataDisplayxaml.xaml
    /// </summary>
    public partial class DataDisplay : Page
    {
        // Storing a Data Collection for Graphs

        public SeriesCollection seriesCollection { get; set; }
        //List storage data for obcisses and ordinates
        public List<string> Labels { get; set; }
        //
        private double[] temp = { 0, 0, 0 };
        private double temperature;
        private double humidity;
        private double pressure;
        private static System.Timers.Timer aTimer;

        /// <summary>
        /// 
        /// </summary>
        class RecivedValues
        {
            //Properties storing weather station values
            public double humidity { get; set; }
            public double temperature { get; set; }
            public double pressure { get; set; }


        }
        /// <summary>
        /// Function to initialize the software timer
        /// </summary>
        private void SetTimer()
        {
            // Creating a timer with an interval of 100 milliseconds
            aTimer = new System.Timers.Timer(100);
            // Connect an FBInit event to a timer
            aTimer.Elapsed += FBInit;
            aTimer.AutoReset = true;
            aTimer.Enabled = true;
        }
        /// <summary>
        /// This function initializes the connection to the cloud database, takes a value from it and returns it
        /// </summary>
        /// <param name="source"> param needs for object timer initialization</param>
        /// <param name="e">argumentive timer parametr</param>
        public async void FBInit(Object source, ElapsedEventArgs e)
        {
            // Setting configuration values ​​for connecting to FireBase

            IFirebaseConfig сonfig = new FirebaseConfig
            {
                AuthSecret = AuthenticationKeys.secretAuthKey,
                BasePath = AuthenticationKeys.firebasePath,
            };
            // Capturing possible errors of working with FireBase  
            try
            {
                IFirebaseClient client = new FirebaseClient(сonfig);
                var response = await client.GetAsync(AuthenticationKeys.dataPath);
                RecivedValues data = response.ResultAs<RecivedValues>();
                temperature = Math.Round(data.temperature, 1);
                humidity = Math.Round(data.humidity, 2);
                pressure = Math.Round(data.pressure / 1.33, 0);
            }
            catch { }


        }
        /// <summary>
        /// The main display function data on the screen
        /// </summary>
        public DataDisplay()
        {
            InitializeComponent();
            // Initialize two new class elements for plotting
            LineSeries humidityLine = new LineSeries();
            LineSeries tempLine = new LineSeries();
            // Set the titles of the polylines
            humidityLine.Title = "Humidity";
            tempLine.Title = "Temp";
            // Set the shape of the polyline
            humidityLine.LineSmoothness = 1;
            tempLine.LineSmoothness = 1;
            // Set the size of the chart points
            humidityLine.PointGeometrySize = 10;
            tempLine.PointGeometrySize = 10;
            // Add initial abscissa
            Labels = new List<string>();
            foreach (var item in temp)
            {
                Labels.Add(item.ToString());
            }
            // Passing data to create a chart
            humidityLine.Values = new ChartValues<double>(temp);
            tempLine.Values = new ChartValues<double>(temp);
            // Create new collection of data
            seriesCollection = new SeriesCollection();
            // Add graphics lines
            seriesCollection.Add(humidityLine);
            seriesCollection.Add(tempLine);
            // Initialization of data update functions
            lineStart();
            GudeStart();
            UpdateClimateStatus();
            DataContext = this;
            this.sl.Series = seriesCollection;


        }
        /// <summary>
        /// This function is needed to update the data on the chart by transferring values ​​from the cloud database
        /// </summary>
        public void lineStart()
        {
            // We call a function that every 5 seconds initializes the function FBInit
            SetTimer();
            Task.Run(() =>
            {

                while (true)
                {
                    // Wait 2 seconds
                    Thread.Sleep(2000);

                    // Update Form UI Elements in Workflow via Dispatcher
                    Application.Current.Dispatcher.Invoke(() =>
                    {
                        // Update the abscissa of time
                        Labels.Add(DateTime.Now.ToString("t"));
                        Labels.RemoveAt(0);
                        // Update the ordinate data       
                        seriesCollection[0].Values.Add(humidity);
                        seriesCollection[0].Values.RemoveAt(0);
                        seriesCollection[1].Values.Add(temperature);
                        seriesCollection[1].Values.RemoveAt(0);
                        pressDg.Value = pressure;
                    });
                    // Wait 60 seconds 
                    Thread.Sleep(60000);
                }

            });
        }
        /// <summary>
        /// This function is designed to update data on a half chart.
        /// </summary>
        public void GudeStart()
        {
            Task.Run(() =>
            {

                while (true)
                {
                    // Wait 1 seconds
                    Thread.Sleep(1000);
                    // Update Form UI Elements in Workflow via Dispatcher
                    Application.Current.Dispatcher.Invoke(() =>
                    {
                        // Setting Data on a Half Chart Humidity
                        humDg.Value = humidity;
                        // Change the color of the half graph depending on the value
                        if (humidity < 40)
                        {
                            humDg.ToColor = System.Windows.Media.Color.FromRgb(252, 101, 134);
                        }
                        else if (humidity >= 40 || humidity <= 65)
                        {
                            humDg.ToColor = System.Windows.Media.Color.FromRgb(61, 221, 194);
                        }
                        else
                        {
                            humDg.ToColor = System.Windows.Media.Color.FromRgb(47, 210, 235);
                        }
                        // Setting Data on a Half Chart Temperature
                        tempDg.Value = temperature;
                        // Change the color of the half graph depending on the value
                        if (temperature <= 20)
                        {
                            tempDg.ToColor = System.Windows.Media.Color.FromRgb(25, 0, 255);
                        }
                        else if (temperature == 22 || temperature <= 27)
                        {
                            tempDg.ToColor = System.Windows.Media.Color.FromRgb(0, 255, 102);
                        }
                        else
                        {
                            tempDg.ToColor = System.Windows.Media.Color.FromRgb(247, 113, 2);
                        }
                        // Setting Data on a Half Chart Pressure
                        pressDg.Value = pressure;
                        // Change the color of the half graph depending on the value
                        if (pressure < 760)
                        {
                            pressDg.ToColor = System.Windows.Media.Color.FromRgb(245, 63, 7);
                        }
                        else if (pressure == 760 || pressure < 765)
                        {
                            pressDg.ToColor = System.Windows.Media.Color.FromRgb(0, 255, 102);
                        }
                        else
                        {
                            pressDg.ToColor = System.Windows.Media.Color.FromRgb(142, 7, 245);
                        }
                    });
                }

            });
        }
        /// <summary>
        /// This function updates the values ​​in the overall climate status output window
        /// </summary>
        public void UpdateClimateStatus()
        {
            Task.Run(() =>
            {

                while (true)
                {
                    // Wait 2 seconds
                    Thread.Sleep(2000);

                    // Update Form UI Elements in Workflow via Dispatcher
                    Application.Current.Dispatcher.Invoke(() =>
                    {
                        //Get the current status of the Internet connection
                        bool stat = System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable();
                        //Condition for displaying the status of the Internet connection
                        if (stat == true)
                        {
                            internetStatusText.Foreground = new SolidColorBrush(Color.FromRgb(54, 198, 174));
                            internetStatusText.Text = "Moderate connection";
                        }
                        else
                        {
                            internetStatusText.Foreground = new SolidColorBrush(Color.FromRgb(255, 0, 51));
                            internetStatusText.Text = "Not connection";
                        }
                        // Humidity status display condition
                        if (humidity < 40)
                        {
                            humidityStatusText.Foreground = new SolidColorBrush(Color.FromRgb(255, 88, 5));
                            humidityStatusText.Text = Convert.ToString(humidity) + "% -- The room is dry, humidification is necessary";
                        }
                        else if (humidity == 40 || humidity <= 65)
                        {
                            humidityStatusText.Foreground = new SolidColorBrush(Color.FromRgb(47, 250, 68));
                            humidityStatusText.Text = Convert.ToString(humidity) + "% -- Indoor humidity is within normal limits";
                        }
                        else
                        {
                            humidityStatusText.Foreground = new SolidColorBrush(Color.FromRgb(0, 195, 255));
                            humidityStatusText.Text = Convert.ToString(humidity) + "% -- The room is very humid, dehumidification is necessary";
                        }
                        // Temperature status display condition
                        if (temperature <= 20)
                        {
                            temperatureStatusText.Foreground = new SolidColorBrush(Color.FromRgb(47, 210, 235));
                            temperatureStatusText.Text = Convert.ToString(temperature) + "C -- The room is cool, you need to warm up the room";
                        }
                        else if (temperature == 22 || temperature <= 27)
                        {
                            temperatureStatusText.Foreground = new SolidColorBrush(Color.FromRgb(47, 250, 68));
                            temperatureStatusText.Text = Convert.ToString(temperature) + "C -- The room temperature is within normal limits";
                        }
                        else
                        {
                            temperatureStatusText.Foreground = new SolidColorBrush(Color.FromRgb(255, 88, 5));
                            temperatureStatusText.Text = Convert.ToString(temperature) + "C -- The room is hot, open the windows to lower temperature";
                        }
                        //// Pressure status display condition
                        if (pressure < 760)
                        {
                            pressureStatusText.Foreground = new SolidColorBrush(Color.FromRgb(47, 210, 235));
                            pressureStatusText.Text = Convert.ToString(pressure) + "mm.rt -- Pressure is low, it is advisible to warm up";
                        }
                        else if (pressure > 761)
                        {
                            pressureStatusText.Foreground = new SolidColorBrush(Color.FromRgb(43, 71, 252));
                            pressureStatusText.Text = Convert.ToString(pressure) + "mm.rt -- Pressure is high, it is desirable to exlude loads";
                        }
                        else
                        {
                            pressureStatusText.Foreground = new SolidColorBrush(Color.FromRgb(47, 250, 68));
                            pressureStatusText.Text = Convert.ToString(pressure) + "mm.rt -- Pressure is stable, everething is fine";
                        }


                    });
                }

            });
        }




    }
}
