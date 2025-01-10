namespace nepesseg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Orszag> orszagok = new();

            foreach (var sor in File.ReadAllLines("adatok-utf8.txt").Skip(1))
            {
                orszagok.Add(new Orszag(sor));

            }
            //3. feladat
            Console.WriteLine($"3.feladat: A beolvasott országok száma: {orszagok.Count}");
            //4.feladat

            int nep_suruseg = 0;
            foreach (var o in orszagok)
            {
                if (o.Orszagnev == "Kína")
                {
                    nep_suruseg = o.Nepesseg / o.Terulet;
                }
            }
            Console.WriteLine($"4.feladat: Kína népsűrűsége: {nep_suruseg} fő/km^2");


        }
    }
}
