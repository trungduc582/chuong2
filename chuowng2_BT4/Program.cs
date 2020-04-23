using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chuowng2_BT4
{
    class Program
    {
        static void Main(string[] args)
        {
            tamgiac tamgiac1 = new tamgiac();
            tamgiac1.nhap();
            if (tamgiac1.istamgiac())
                Console.WriteLine("tam giac co dien tich la:{0} , co chu vi la:{1}", tamgiac1.dientich(), tamgiac1.ChuVi());
            Console.ReadLine();
        }
    }
}
