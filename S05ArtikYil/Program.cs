
bool ArtikMi2(int sene)
{
        // 4'ün katı     VE (100ün katı değil YA DA 400'ün katı)
    return sene % 4 == 0 && (sene % 100 != 0 || sene % 400 == 0);
}


bool ArtikMi1(int sene)
{
    if (sene % 4 != 0)
        return false;
    else if (sene % 400 == 0)
        return true;
    else if (sene % 100 == 0)
        return false;
    else
        return true;
}

Console.WriteLine("Şubat ayının 29 çektiği yıllar artık yıldır.");

Console.Write("Yıl: ");
int yil = Convert.ToInt32(Console.ReadLine());

// ingilizcede leap year
Console.WriteLine(ArtikMi2(yil) ? "artık yıl" : "artık yıl değil");


Console.ReadKey();
/*
Hangi yıllar artıktır:
400'ün katı olmayan 100'ün katları hariç 4'ün katları artık yıldır.

Artık yıl örnekleri:
1996
2000
2004
2008

Artık yıl olmayanlar:
1999
2001
2100 (çünkü hem 100'ün katı hem de 400'ün katı olmadan)
 
 */