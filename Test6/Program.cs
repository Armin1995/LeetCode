using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test6
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                try
                {
                    var reply = Console.ReadLine().ToUpper();
                    if (reply == "Y")
                    {
                        break;
                    }
                    else
                    {
                        throw new Exception();
                    }
                }
                catch (Exception)
                {
                    continue;
                }
            }
            Console.WriteLine("End");
            Console.ReadKey();
        }
    }
}
