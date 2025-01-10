using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nepesseg
{
    internal class Orszag
    {
        public string Orszagnev { get; private set; }
        public int Terulet { get; private set; }
        public int Nepesseg { get; private set; }
        public string Fovaros { get; private set; }
        public string FovarosNepesseg { get; private set; }

        public Orszag(string sor)
        {
            string[] s = sor.Split(';');
            Orszagnev = s[0];
            Terulet = int.Parse(s[1]);
            Nepesseg = int.Parse(s[2]);
            Fovaros = s[3];
            FovarosNepesseg = s[4];
        }

        public override string ToString()
        {
            return "";
        }
    }
}
