using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Art_Arda_Toplama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                int sayi1, sayi2;
                Console.WriteLine("Sayıyı Giriniz:");
                sayi1 = Convert.ToInt32(Console.ReadLine());
            Tekrar:
                Console.WriteLine("Toplanacak sayıyı girin:");
                Console.WriteLine("Çıkış için 83 giriniz:");
                sayi2 = Convert.ToInt32(Console.ReadLine());
                if (sayi2 == 83)
                    Console.WriteLine("Döngü Bitti.");
                else
                {
                    sayi1 = sayi1 + sayi2;
                    Console.WriteLine("Sayımız" + sayi1);
                    goto Tekrar;
                }
            }
            Console.ReadKey();
        }
    }
}

