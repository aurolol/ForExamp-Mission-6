//    Example 1
for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini hallederim!");
}
Console.WriteLine("-------------------------");
//    Example 2 : 1 ve 20 arasındaki sayılar 
for (int i = 2; i < 20; i++)
{
    Console.WriteLine($"{i}");
}
Console.WriteLine("-------------------------");
//    Example 3 : 1 ve 20 arasındaki çift sayılar
for (int i = 1; i < 19; i++)
{
    if (i % 2 == 0)
        Console.WriteLine(i);
}
Console.WriteLine("--------------------------");
//    Example 4 : 50 ile 150 arasındaki sayılarım toplamı
int sayı = 0;
for (int i = 51; i < 150; i++)
{
    sayı += i; 
}
Console.WriteLine("Sayıların Toplamı ->" + sayı);
Console.WriteLine("---------------------------");
//    Example 5 : 1 ile 120 arasındaki tek ve çift sayıların toplamı
int tekSayıTop = 0;
int ciftSayıTop = 0;
for (int i = 2; i < 120; i++)
{
    if ((i % 2) == 0)
    {
        ciftSayıTop += i;
    }
    else
    {
        tekSayıTop += i;
    }
}
Console.WriteLine("Tek Sayıların Toplamı ->" + tekSayıTop);
Console.WriteLine("Çift Sayıların Toplamı ->"+ ciftSayıTop);
