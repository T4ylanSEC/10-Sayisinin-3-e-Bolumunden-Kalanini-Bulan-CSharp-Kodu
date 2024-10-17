using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Sayisinin_3_e_Bolumunden_Kalanini_Bulan_CSharp_Kodu
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int Sayı = 10;

            int Bölen = 3;

            int Kalan = Sayı % Bölen;

            Console.WriteLine("10 Sayısının 3'e Bölümünden Kalan: " + Kalan);

            Console.ReadKey();

        }
    }
}