
void KaresiKubunuHesapla(int sayi, out int karesi, out int kubu)
{
    karesi = sayi * sayi;
    kubu = karesi * sayi;
}

Console.Write("n: ");
int n = Convert.ToInt32(Console.ReadLine());

int kar, kup;
KaresiKubunuHesapla(n, out kar, out kup);

Console.WriteLine("karesi: " + kar);
Console.WriteLine("kübü: " + kup);

Console.ReadKey();