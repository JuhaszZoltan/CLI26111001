List<Product> products = [];

#region file beolvasása
#nullable disable
const string FilePath = "..\\..\\..\\data\\arukeszlet.csv";
using StreamReader sr = new(FilePath);
_ = sr.ReadLine();
while (!sr.EndOfStream)
{
    var tmp = sr.ReadLine().Split(',');
    products.Add(new()
    {
        Id = int.Parse(tmp[0]),
        Category = tmp[1],
        Brand = tmp[2],
        Model = tmp[3],
        Price = int.Parse(tmp[4]),
        StockQTY = int.Parse(tmp[5]),
        Rating = float.Parse(tmp[6].Replace('.', ','))
    });
}
#endregion


var f001 = products.Count(p => p.Price < 10000);
Console.WriteLine($"{f001} db olyan termék van, aminek az ára kevesebb, mint 10 000 Ft");

var f002 = products.MaxBy(p => p.Price);
Console.WriteLine($"a legdrágább termék a kínálatban:\n{f002}");

var f003 = products.Single(p => p.Id == 42);
Console.WriteLine($"a 42-es azonosítójú termék:\n{f003}");

var f004 = products.Any(p => p.Price > 1000000);
Console.WriteLine($"{(f004 ? "van": "nincs")} olyan termék, aminek az ára meghaladja az 1 000 000 Ft-ot");

var f005 = products.Average(p => p.Rating);
Console.WriteLine($"a kínálat átlagos értékelése: {f005:0.000} pont");

var f006 = products.FirstOrDefault(
    p => p.Brand == "Quantum" 
    && p.Category == "Okostelefon" 
    && p.Price < 200000);
Console.WriteLine(f006 is null 
    ? "nincs 200K alatti Quantum okostelefon" 
    : $"a listában első 200K alatti Quantum okostelefon:\n{f006}");

var f007 = products.LastOrDefault(p => p.StockQTY == 0);
Console.WriteLine(f007 is null
    ? "nincs olyan termék amiből jelenleg nincs raktáron egyetlen egy db sem"
    : $"az utolsó termék a kínálatban, amiből nincs raktáron egy sem:\n{f007}");

var f008 = products.All(p => p.Rating >= 3);
Console.WriteLine(f008
    ? "minden termék értékelése eléri a 3.0-t"
    : "nem minden termék értékelése éri el a 3.0-t");

var f009 = products.MaxBy(p => p.StockQTY);
Console.WriteLine($"a legnagyobb darabszámban készleten lévő termék:\n{f009}");

var f010 = products.First(p => p.Category == "Tablet");
Console.WriteLine($"első tablet:\n{f010}");