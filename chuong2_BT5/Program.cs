using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chuong2_BT5
{
    class Program
    {
        static void Main(string[] args)
        {
            nguyento so1 = new nguyento();
            so1.nhap();
            if (so1.songto())
                Console.WriteLine("co la so ng to");
            else Console.WriteLine("khong la so ng to");
            Console.ReadLine();
        }
    }
}
