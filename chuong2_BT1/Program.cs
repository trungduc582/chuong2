using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chuong2_BT1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("nhap a:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("nhap b:");
            b = Convert.ToInt32(Console.ReadLine());

            int tong = a + b;
            int hieu = a - b;
            int tich = a * b;
            float thuong = a / b;
            Console.WriteLine("tong{0}  hieu{1}, tich{2}, thuong{3}", tong, hieu, tich, thuong);
            Console.ReadLine();
        }
    }
}
