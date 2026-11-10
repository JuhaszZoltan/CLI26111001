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
