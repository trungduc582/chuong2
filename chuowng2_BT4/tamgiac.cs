using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chuowng2_BT4
{
    class tamgiac
    {
        int a, b, c;
        public bool istamgiac()
        {
            bool ketqua = false;
            if (a + b > c && a + c > b && b + c > a)
            {
                ketqua = true;
            }
            else Console.WriteLine("khong phai tam giac");
            return ketqua;
        }
        public double ChuVi()
        {
            if (istamgiac())
            {
                return (a + b + c);
            }
            return -1;
        }
        public Double dientich()
        {
            if (istamgiac())
            {
                Double p = 0.5 * (a + b + c) ;
                return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            }
            else return -1;
        }
        public void nhap()
        {
            Console.WriteLine("nhap vao a:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("nhap vao b:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("nhap vao c:");
            c = Convert.ToInt32(Console.ReadLine());
        }
    }
}


