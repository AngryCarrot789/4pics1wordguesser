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
using MahApps.Metro.Controls;

namespace FPOWGuesser
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(LB.SelectedItem != null) LB.ScrollIntoView(LB.SelectedItem);
        }

        private void MetroWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Environment.Exit(0);
        }

        private void Helpwin_Click(object sender, RoutedEventArgs e)
        {
            new MainHelpWindow().Show();
        }
        private ItemWindow iwin;
        public bool iwinopened = false;
        private void LB_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            try
            {
                if (!iwinopened)
                {
                    iwin = new ItemWindow(LB.SelectedItem.ToString(), $"Index: {LB.SelectedIndex.ToString()}");
                    iwin.Show();
                    iwinopened = true;
                }
                else
                {
                    iwin.top.Text = LB.SelectedItem.ToString(); iwin.bottom.Text = $"Index: {LB.SelectedIndex.ToString()}";
                }
            }
            catch { }
        }
        public static bool IsWindowOpen<T>(string name = "") where T : Window
        {
            return string.IsNullOrEmpty(name) 
                ? Application.Current.Windows.OfType<T>().Any() 
                : Application.Current.Windows.OfType<T>().Any(w => w.Name.Equals(name));
        }
    }
}
