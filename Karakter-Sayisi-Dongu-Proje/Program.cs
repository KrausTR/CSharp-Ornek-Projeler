#define FOR_DONGUSU_KULLAN

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string girdi;
            int karakter_sayisi = 0;
            Console.Write("Adınızı ve Soyadınızı Giriniz: ");
            girdi = Console.ReadLine();
#if FOR_DONGUSU_KULLAN
            for (int i = 0; i < girdi.Length; i++)
            {
                if (girdi[i] != ' ')
                {
                    karakter_sayisi++;
                }
            }
            Console.WriteLine("Girdiğiniz Ad - Soyad " + karakter_sayisi + " karakterdir.");
            for (int i = 1; i <= karakter_sayisi; i++)
            {
                Console.WriteLine("["+ i + "] Deneme");
            }
#else
            int x = 0;
            while(x < girdi.Length)
            {
                if(girdi[x] != ' ')
                    karakter_sayisi++;               
                x++;
            }
            Console.WriteLine("Girdiğiniz Ad - Soyad " + karakter_sayisi + " karakterdir.");
            x = 1;
            while (x <= karakter_sayisi)
            {
                Console.WriteLine("[" + x + "] Deneme");
                x++;
            }
#endif
            Console.ReadKey();
        }
    }
}