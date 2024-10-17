bool AsalMi(int sayi)
{
    if (sayi < 2)
        return false;

    for (int i = 2; i <= Math.Sqrt(sayi); i++)
    {
        if (sayi % i == 0)
            return false;
    }

    return true;
}

Console.Write("Sayı: ");
int sayi = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(AsalMi(sayi) ? "Asal" : "Asal Değil");

Console.ReadKey();