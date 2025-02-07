using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    public class Album
    {
        public string Wykonawca { get; set; }
        public string Tytul { get; set; }
        public string? ImageFilename { get; set; }
        public int Liczba_utworow { get; set; }
        public int Rok { get; set; }
        public int Liczba_pobran { get; set; }

        public Album(string wykonawca, string tytul, int liczba_utworow, int rok, int liczba_pobran)
        {
            Wykonawca = wykonawca;
            Tytul = tytul;
            Liczba_utworow = liczba_utworow;
            Rok = rok;
            Liczba_pobran = liczba_pobran;
        }
    }
}
