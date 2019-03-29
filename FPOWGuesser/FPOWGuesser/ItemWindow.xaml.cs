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
using System.Windows.Shapes;

namespace FPOWGuesser
{
    /// <summary>
    /// Interaction logic for ItemWindow.xaml
    /// </summary>
    public partial class ItemWindow : Window
    {
        public ItemWindow(string toptext, string bottomtext)
        {
            InitializeComponent();
            top.Text = toptext;
            bottom.Text = bottomtext;
        }
        private MainWindow mv => (MainWindow)Application.Current.MainWindow;
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try { mv.iwinopened = false; }
            catch { }
        }
    }
}
