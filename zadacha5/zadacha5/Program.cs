using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> plus = new List<int>();
            List<int> minus = new List<int>();
            int n = Convert.ToInt32(Console.ReadLine()); 
            for(int i = 0;i<n;++i)
            {
                int zn = Convert.ToInt32(Console.ReadLine());
                if (zn < 0) minus.Add(zn);
                else plus.Add(zn);
            }
            plus.Sort();
            minus.Sort();
            minus.Reverse() ;
            foreach(var t in plus)
            {
                Console.WriteLine(t);
            }

            foreach (var t in minus)
            {
                Console.WriteLine(t);
            }
            Console.ReadKey();
        }
    }
}
