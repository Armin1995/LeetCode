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
            var solidList = new List<string>() { "A", "B", "C", "D" };
            var MainAddDict = new Dictionary<string, MainAddType>()
            {
                {"C",MainAddType.Main },
                {"D",MainAddType.Add },
            };
            var calList = new List<CalculateType>()
            {
                CalculateType.Union,
                CalculateType.Except,
                CalculateType.Except,
            };

            CalculateClass calculateClass = new CalculateClass(solidList, MainAddDict, calList);
        }
    }

    enum MainAddType
    {
        Non,
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
        private string main;
        private string add;

        public CalculateClass(List<string> solidList, Dictionary<string, MainAddType> mainAddDict, List<CalculateType> calList)
        {
            main = solidList[0];
            add = solidList[1];

            for (int i = 0; i < calList.Count; i++)
            {
                var a = solidList[i];
                var b = solidList[i + 1];
                if (mainAddDict.ContainsKey(a))
                {
                    switch (mainAddDict[a])
                    {
                        case MainAddType.Non:
                            break;
                        case MainAddType.Main:
                            a = Main(a);
                            break;
                        case MainAddType.Add:
                            a = Add(a);
                            break;
                        default:
                            break;
                    }
                }
                if (mainAddDict.ContainsKey(b))
                {
                    switch (mainAddDict[b])
                    {
                        case MainAddType.Non:
                            break;
                        case MainAddType.Main:
                            b = Main(b);
                            break;
                        case MainAddType.Add:
                            b = Add(b);
                            break;
                        default:
                            break;
                    }
                }

                switch (calList[i])
                {
                    case CalculateType.Intersect:
                        solidList[i + 1] = Intersect(a, b);
                        break;
                    case CalculateType.Union:
                        solidList[i + 1] = Union(a, b);
                        break;
                    case CalculateType.Except:
                        solidList[i + 1] = Except(a, b);
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine(solidList.Last());
            Console.ReadKey();
        }

        private string Intersect(string a, string b)
        {
            return "(" + a + " ∩ " + b + ")";
        }

        private string Union(string a, string b)
        {
            return "(" + a + " ∪ " + b + ")";
        }

        private string Except(string a, string b)
        {
            return "(" + a + " - " + b + ")";
        }

        private string Main(string a)
        {
            return "(" + main + " ∩ " + a + ")";
        }

        private string Add(string a)
        {
            return "(" + Except(add, main) + " ∩ " + a + ")";
        }
    }
}
