using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chuong2_BT5
{
    class nguyento
    {
        int n;
        public bool songto()
        {
            if (n <= 1)
                return false;
            else
            {
                bool ketqua = true;
                for (int i = 2; i < n; i++)
                {
                    if (n % i == 0)
                        ketqua= false;
                }
                return ketqua;
            }
        }
        public void nhap()
        {
            Console.WriteLine("nhap n:");
            n = Convert.ToInt32(Console.ReadLine());
        }
    }
}
