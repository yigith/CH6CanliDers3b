baslangic:
Console.Write("Sayı: ");
int sayi = Convert.ToInt32(Console.ReadLine());

#region Yöntem 3
// DİKKAT: diziler konusundan sonra tekrar bakınız!!!
int i = Math.Sign(sayi) + 1; // muhtemelen sonuçlar: -1 0 1

//                        0         1         2
string[] sonuclar = { "Negatif", "Sıfır", "Pozitif" };
Console.WriteLine(sonuclar[i]);
#endregion

#region Yöntem 2
//Console.WriteLine(sayi == 0 ? "Sıfır" : sayi < 0 ? "Negatif" : "Pozitif");
#endregion

#region Yöntem 1
//if (sayi == 0)
//    Console.WriteLine("Sıfır");
//else if (sayi < 0)
//    Console.WriteLine("Negatif");
//else
//    Console.WriteLine("Pozitif");
#endregion

goto baslangic;