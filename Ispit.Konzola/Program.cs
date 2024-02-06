using Ispit.Model;

namespace Ispit.Konzola;

class Program
{
    static void Main(string[] args)
    {
        List<Ucenik> ucenici = new List<Ucenik>();
        
        Console.WriteLine("Kreiranje učenika:");
        Console.WriteLine("");
        for (int i = 0; i < 1; i++)
        {
            var ucenik = new Ucenik();
            Console.WriteLine();
            Console.WriteLine($"Unos podataka za učenika {i + 1}");
            
            Console.WriteLine("Unesite ime učenika");
            ucenik.Ime = Console.ReadLine();
            
            Console.WriteLine("Unesite prezime učenika");
            ucenik.Prezime = Console.ReadLine();
            
            Console.WriteLine("Unos datuma rođenja učenika u formatu YYYY MM DD");
            string[] datumStr = Console.ReadLine().Split(" ");
            List<int> datum = new List<int>();
            foreach (var el in datumStr)
            {
                datum.Add(int.Parse(el));
            }
            
            ucenik.DatumRodjenja = new DateTime(datum[0], datum[1], datum[2]);

            bool ispravanUnos = false;
            while (!ispravanUnos)
            {
                try
                {
                    Console.WriteLine("Unesite prosjek ocjena u formatu (x,xx): ");
                    ucenik.Prosjek = double.Parse(Console.ReadLine());
                    ispravanUnos = true;
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("Neispravna vrijednost. Prosjek mora biti između 1 i 5.");
                }    
            }
            
            ucenici.Add(ucenik);
        }

        Console.WriteLine();
        foreach (var ucenik in ucenici)
        {
            Console.WriteLine(ucenik.ToString());
            Console.WriteLine();
        }
        
    }
}