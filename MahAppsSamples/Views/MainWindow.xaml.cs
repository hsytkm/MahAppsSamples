using System;
using System.Windows;
using System.Diagnostics;

namespace MahAppsSamples.Views
{
    public partial class MainWindow : MahApps.Metro.Controls.MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void LaunchMahAppsOnGitHub(object sender, RoutedEventArgs e)
            => Process.Start(new ProcessStartInfo("https://github.com/hsytkm/MahAppsSamples") { UseShellExecute = true });

    }
}
