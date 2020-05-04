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
            int[,] ogrenci_notlari = new int[10, 3]; // 0 vize, 1 final, 2 toplam
            string[] ogrencinot_string = { "Vize", "Final" };
            for(int i = 0; i < ogrenci_notlari.GetLength(0); i++)
            {
                for (int x = 0, not = 0; x < ogrenci_notlari.GetLength(1)-1; x++)
                {
                    back:
                    Console.Write((i + 1) + ". öğrencinin " + ogrencinot_string[x].ToLower() + " notunu giriniz: ");
                    not = int.Parse(Console.ReadLine());

                    if (not > 100 || not < 0) goto back;
                    if (x == 0)
                        ogrenci_notlari[i, x] = Convert.ToInt32((not * 40) / 100);
                    else
                        ogrenci_notlari[i, x] = Convert.ToInt32((not * 60) / 100);

                    ogrenci_notlari[i, 2] += ogrenci_notlari[i, x];
                }
                Console.WriteLine((i + 1) + ". öğrencinin geçme notu: " + ogrenci_notlari[i, 2]+"\r\n");
            }
            for (int i = 0, toplam = 0, ogrenci_sayisi = ogrenci_notlari.GetLength(0); i < ogrenci_sayisi; i++)
            {
                toplam += ogrenci_notlari[i, 2];
                if(i == ogrenci_sayisi - 1)
                {
                    int ortalama = toplam / ogrenci_sayisi;
                    Console.WriteLine("Sınıfın Not Ortalaması: " + ortalama);
                }
            }
            Console.ReadKey();
        }
    }
}