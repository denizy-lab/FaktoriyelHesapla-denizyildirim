using System;

namespace Faktoriyel
{
    class Program
    {
        private static int sonuc = 1;
        static void Main(string[] args)
        {
            Console.WriteLine("Faktoriyelini Alacağın Sayıyı Gir: ");
            int sayi =Convert.ToInt32 (Console.ReadLine());
            for(int i = 1; i<=sayi; i++)
            {
                sonuc = sonuc * i;
            }     
            Console.WriteLine(sonuc);
            Console.ReadLine();
        }
    }
}
