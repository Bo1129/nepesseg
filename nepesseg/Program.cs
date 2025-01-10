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
                
            
        }
    }
}
