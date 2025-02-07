using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Projekt
{
    
    public partial class MainWindow : Window
    {
        public List<Album> Albums { get; set; } = new List<Album>();
        public int albumIndex = 0;
        
        public MainWindow()
        {
            InitializeComponent();
            Odczytajzpliku();
            wypiszalbum(albumIndex);
        }

        private void Button_Click_Right(object sender, RoutedEventArgs e)
        {
            if (++albumIndex >= Albums.Count)
            {
                albumIndex -= Albums.Count;
            }
            wypiszalbum(albumIndex);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e){

        }
        private void Odczytajzpliku() {
            Albums = new List<Album>();
            string[] linieWpliku = File.ReadAllLines("Data.txt");

            for (int i = 0; i < linieWpliku.Length; i += 6) 
            { 
                string autysta = linieWpliku[i];
                string tytul = linieWpliku[i + 1];
                int liczba_utworow = int.Parse(linieWpliku[i + 2]);
                int liczba_pobran = int.Parse(linieWpliku[i + 4]);
                int rok = int.Parse(linieWpliku[i + 3]);
                Albums.Add(new Album(autysta,tytul,liczba_utworow,rok,liczba_pobran));
            }
        }
        private void wypiszalbum(int i) {
            artystaTextBlock.Text = Albums[i].Wykonawca;
            tytulTextBlock.Text = Albums[i].Tytul;
            liczbaPobranTextBlock.Text = Albums[i].Liczba_pobran.ToString();
            liczbaTextBlock.Text = Albums[i].Liczba_utworow.ToString();

        }

        private void Button_Click_Left(object sender, RoutedEventArgs e)
        {
            if (--albumIndex < 0)
            {
                albumIndex += Albums.Count;
            }
            wypiszalbum(albumIndex);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            WindowNewAlbum windowNewAlbum = new WindowNewAlbum();
            windowNewAlbum.ShowDialog();

            if (windowNewAlbum.result == null) return;
            Albums.Add(windowNewAlbum.result);
        }
    }
}