using System.Windows;

namespace NoSleepMonitor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool m_NoSleep;

        public MainWindow()
        {
            InitializeComponent();
            m_NoSleep = false;
            toogleSleepBtn.Content = "Start";
        }

        private void toggleSleep(object sender, RoutedEventArgs e)
        {
            m_NoSleep = !m_NoSleep;
            toogleSleepBtn.Content = m_NoSleep ? "Stop" : "Start";
            if (m_NoSleep)
            {
                NoSleepWay1.NoSleep();
            }
            else
            {
                NoSleepWay1.Sleep();
            }
        }

        protected override void OnClosed(System.EventArgs e)
        {
            NoSleepWay1.Sleep();
        }
    }
}
