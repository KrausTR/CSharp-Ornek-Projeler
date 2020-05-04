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
            int çiftsayılar_toplamı = 0, teksayılar_toplamı = 0;
            for(int i = 0, sayi; i < 10; i++)
            {
                Console.Write((i + 1) + ". sayıyı giriniz: ");
                sayi = int.Parse(Console.ReadLine());
                if (sayi % 2 == 0)
                    çiftsayılar_toplamı += sayi;
                else
                    teksayılar_toplamı += sayi;
            }
            int çiftfarktek = çiftsayılar_toplamı - teksayılar_toplamı;
            Console.WriteLine("Girdiğiniz çift sayıların toplamı: " + çiftsayılar_toplamı);
            Console.WriteLine("Girdiğiniz tek sayıların toplamı: " + teksayılar_toplamı);
            Console.WriteLine("Çift Sayılar Toplamı - Tek Sayılar Toplamı: "
                + çiftsayılar_toplamı + " - "+ teksayılar_toplamı + " = " + çiftfarktek);
            Console.ReadKey();
        }
    }
}