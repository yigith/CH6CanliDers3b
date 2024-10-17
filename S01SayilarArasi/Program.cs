int a, b;

Console.WriteLine("Bu program sırayla girilen 2 sayı aralığında tüm sayıları sırayla yazdırır.");
Console.Write("a: ");
a = Convert.ToInt32(Console.ReadLine());
Console.Write("b: ");
b = Convert.ToInt32(Console.ReadLine());

for (int i = a; i <= b; i++)
{
    Console.Write(i + " ");
}

Console.ReadKey();