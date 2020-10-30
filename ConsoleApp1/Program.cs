using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Solid main = new Solid("A");
            Solid add = new Solid("B");
            Dictionary<Solid, MainAddType> solidDict = new Dictionary<Solid, MainAddType>()
            {
                { new Solid("C"), MainAddType.Add },
                { new Solid("D"), MainAddType.Main },
            };
            List<CalculateType> calTypes = new List<CalculateType>()
            {
                CalculateType.Intersect,
                CalculateType.Except,
                CalculateType.Union,
            };
            CalculateClass c = new CalculateClass();
            c.Calculate();
        }
    }

    enum MainAddType
    {
        Main,
        Add,
    }

    enum CalculateType
    {
        Intersect,
        Union,
        Except,
    }

    class CalculateClass
    {
        public string Calculate(Solid main, Solid add, Dictionary<Solid, MainAddType> solidDict, List<CalculateType> calTypes)
        {

        }
    }

    class Solid
    {
        public string Name { get; set; }
        public Solid(string name)
        {
            this.Name = name;
        }
    }
}
