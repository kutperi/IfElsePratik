Console.Write("Lütfen bir sayı giriniz: ");
string sayi = Console.ReadLine();

int num = Convert.ToInt32(sayi);

if (num == 10)

{
    Console.WriteLine("Girilen sayı 10'dur.");
    Console.WriteLine("Girilen sayı çifttir.");
}
else if (num > 10)
{
    Console.WriteLine("Girilen sayı 10'dan büyüktür.");
    
    if (num % 2 == 0)
    {
        Console.WriteLine("Girilen sayı çifttir.");
    }
    else
    {
        Console.WriteLine("Girilen sayı tektir.");
    }
}
else
{
    Console.WriteLine("Girilen Sayı 10'dan küçüktür.");

    if (num % 2 == 0)
    {
        Console.WriteLine("Girilen sayı çifttir.");
    }
    else
    {
        Console.WriteLine("Girilen sayı tektir.");
    }
}
