
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

for (int i = 1; i <= 100; i++)
{
    if (AsalMi(i))
        Console.Write(i + " ");
}

Console.ReadKey();