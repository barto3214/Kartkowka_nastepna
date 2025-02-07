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

namespace Projekt
{

    /// <summary>
    /// Logika interakcji dla klasy WindowNewAlbum.xaml
    /// </summary>
    public partial class WindowNewAlbum : Window
    {
        public Album result;

        public WindowNewAlbum()
        {
            InitializeComponent();

            DataContext = this;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int rok, liczbaUtworow;
            if (!int.TryParse(jer.Text, out rok)) return; 
            if (!int.TryParse(picnawode.Text, out liczbaUtworow)) return;
            result = new Album(executor.Text, tajtl.Text, liczbaUtworow, rok, 0);
            
            Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
