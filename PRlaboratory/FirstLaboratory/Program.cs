using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstLaboratory
{
    class Program
    {
        public static void Main(string[] args)
        {
            var t = new Program();
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(t.Add(a, b));
        }
        public int Add(int a, int b) => a + b;
    }
}
