using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for Helpwintthingy.xaml
    /// </summary>
    public partial class Helpwintthingy : Window
    {
        public Helpwintthingy(ObservableCollection<string> list, char num, int pos)
        {
            InitializeComponent();
            foreach(string g in list)
            {
                if (g[pos] == num)
                {
                    mainlist.Items.Add(g);
                }
            }
        }

        private void Clsdbttn_Click(object sender, RoutedEventArgs e)
        {
            mainlist.Items.Clear();
        }
    }
}
