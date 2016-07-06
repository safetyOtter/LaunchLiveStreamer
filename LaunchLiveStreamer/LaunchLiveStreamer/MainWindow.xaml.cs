using System;
using System.Diagnostics;
using System.IO;
using System.Windows;

namespace LaunchLiveStreamer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ChannelName.Text))
            {
                MessageBox.Show("type something");
                return;
            }
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\LaunchLiveStreamer.bat";
            string contents = "livestreamer https://www.twitch.tv/" + ChannelName.Text.Trim() + " best";
            File.WriteAllText(path, contents);
            Process.Start(path);
        }
    }
}
