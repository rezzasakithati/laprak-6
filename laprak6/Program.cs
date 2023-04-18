using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Encapsuletion;

namespace Encapsuletion 
{
    internal class program
    {
        static void Main(string[] args)
        {
            handphone hp1 = new handphone();
            hp1.merek = "IPHONE";
            hp1.model = "XR";
            hp1.tahun = "2020";

            Console.WriteLine($"Merek Handphone : {hp1.merek}" + "\n" + $"Model Handphone : {hp1.model}" + "\n" + $"Tahun Keluaran : {hp1.tahun}");
            Console.WriteLine("=========================");

            handphone hp2 = new handphone();
            hp2.SetHandphone("ASUS", "ROG 6");
            hp2.SetTahunkeluar("2023");
            Console.Write(hp2);

            Console.ReadKey();
        }
    }
}
