// Ekrana girilen sayıya kadar tek olanları ekrana yazdır

// int girilen = Convert.ToInt32(Console.ReadLine());

// for (int i = 1; i <= girilen; i++)
// {
//     if (i % 2 ==1)
//     {
//         Console.WriteLine(i);
//     }
// }
//1 - 1000 arası tek cift toplamı
int ciftToplam = 0;
int tekToplam = 0;
for (int i = 0; i <= 1000; i++)
{
    if (i %2 ==1)
    {
        
        tekToplam+=i; //tekToplam = tekToplam + i;
    }
    else
    {
        ciftToplam+=i;
    }
}
Console.WriteLine("Tek toplamlar :" +tekToplam);
Console.WriteLine("Cift toplmalar :" +ciftToplam);

//break , continue

for (int i = 1; i < 10; i++)
{
    if(i == 4)
    //break; //1-2-3 yazdı ve döngüyü bitirdi
    continue; // 1-2-3 yazdı 4 ü atladı devam
    Console.WriteLine(i);
}
