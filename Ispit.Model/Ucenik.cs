namespace Ispit.Model;

public class Ucenik
{
    private double _prosjek;
    
    public string Ime { get; set; } = String.Empty;
    public string Prezime { get; set; } = String.Empty;
    public DateTime DatumRodjenja { get; set; }
    public double Prosjek
    {
        get => _prosjek;
        set
        {
            if (value > 5 || value < 1)
            {
                throw new ArgumentOutOfRangeException();
            }
            else
            {
                _prosjek = value;
            }
        }
    }

    public double Starost()
    {
        return Math.Floor(DateTime.Now.Subtract(DatumRodjenja).TotalDays / 365); 
    }

    public string IspisProsjeka()
    {
        switch (Prosjek)
        {
            case <= 1.49:
                Console.ForegroundColor = ConsoleColor.Red;
                return "Nedovoljan";
                break;
            case >= 1.5 and <= 2.49:
                Console.ForegroundColor = ConsoleColor.Yellow;
                return "Dovoljan";
                break;
            case >= 2.5 and <= 3.49:
                Console.ForegroundColor = ConsoleColor.Yellow;
                return "Dobar";
                break;
            case >= 3.5 and <= 4.49:
                Console.ForegroundColor = ConsoleColor.Green;
                return "Vrlo dobar";
                break;
            default:
                Console.ForegroundColor = ConsoleColor.Green;
                return "Odličan";
                break;
        }
    }

    public override string ToString()
    {
        return $"{Ime} {Prezime} | {Starost()}god. | Prosjek ocjena: {Prosjek} - {IspisProsjeka()}";
    }
}