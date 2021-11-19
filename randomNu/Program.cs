using System;

namespace randomNu
{
    class Program
    {
        static int tahmin;
        static void Main(string[] args)
        {
            Random sayi = new Random();
            int rnd = sayi.Next(0, 20);
            Console.WriteLine("lütfen sayı giriniz");
            int tahmin = Convert.ToInt32(Console.ReadLine());
            int i = 0;
            
            while (i<10)
            {
                
                if (tahmin==rnd)
                {
                    Console.WriteLine("Tebrikler Doğru Tahmin! Sayı :" + rnd +",>>>" +i+". Tahminde buldunuz");
                    break;
                }
                else
                {
                    int kalan = 10 - i;
                    Console.WriteLine("Yanlış Tahmin lütfen sayı giriniz Kalan tahmin hakkınız " + kalan);
                    if (tahmin>rnd)
                    {
                        Console.WriteLine("Tahmin değeriniz Sayıdan büyük " );

                    }
                    else
                    {
                        Console.WriteLine("Tahmin değeriniz Sayıdan küçük " );

                    }
                    tahmin = Convert.ToInt32(Console.ReadLine());
                    i++;
                }
               
                if (i == 10)
                {
                    Console.WriteLine("Tahmin Hakkınız Bitti");
                    break;
                }
                
                
            }
        }
    }
}
