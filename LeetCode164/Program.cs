using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode164
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public class Solution
        {
            public int MaximumGap(int[] nums)
            {
                if (nums.Length < 2)
                {
                    return 0;
                }

                RadixSort(ref nums);

                int ret = 0;
                for (int i = 1; i < nums.Length; i++)
                {
                    ret = Math.Max(ret, nums[i] - nums[i - 1]);
                }
                return ret;
            }

            public static void RadixSort(ref int[] arr)
            {
                int iMaxLength = GetMaxLength(arr);
                RadixSort(ref arr, iMaxLength);
            }

            //排序
            private static void RadixSort(ref int[] arr, int iMaxLength)
            {
                List<int> list = new List<int>(); //存放每次排序后的元素
                List<int>[] listArr = new List<int>[10]; //十个桶
                char currnetChar;//存放当前的字符比如说某个元素123中的2
                string currentItem;//存放当前的元素比如说某个元素123
                for (int i = 0; i < listArr.Length; i++) //给十个桶分配内存初始化。
                    listArr[i] = new List<int>();
                for (int i = 0; i < iMaxLength; i++) //一共执行iMaxLength次，iMaxLength是元素的最大位数。
                {
                    foreach (int number in arr)//分桶
                    {
                        currentItem = number.ToString(); //将当前元素转化成字符串
                        try
                        {
                            currnetChar = currentItem[currentItem.Length - i - 1];   //从个位向高位开始分桶
                        }
                        catch
                        {
                            listArr[0].Add(number);    //如果发生异常，则将该数压入listArr[0]。比如说5是没有十位数的，执行上面的操作肯定会发生越界异常的，这正是期望的行为，我们认为5的十位数是0，所以将它压入listArr[0]的桶里。
                            continue;
                        }
                        switch (currnetChar)//通过currnetChar的值，确定它压人哪个桶中。
                        {
                            case '0':
                                listArr[0].Add(number);
                                break;
                            case '1':
                                listArr[1].Add(number);
                                break;
                            case '2':
                                listArr[2].Add(number);
                                break;
                            case '3':
                                listArr[3].Add(number);
                                break;
                            case '4':
                                listArr[4].Add(number);
                                break;
                            case '5':
                                listArr[5].Add(number);
                                break;
                            case '6':
                                listArr[6].Add(number);
                                break;
                            case '7':
                                listArr[7].Add(number);
                                break;
                            case '8':
                                listArr[8].Add(number);
                                break;
                            case '9':
                                listArr[9].Add(number);
                                break;
                            default:
                                throw new Exception("unknowerror");
                        }
                    }
                    for (int j = 0; j < listArr.Length; j++) //将十个桶里的数据重新排列，压入list
                        foreach (int number in listArr[j].ToArray<int>())
                        {
                            list.Add(number);
                            listArr[j].Clear();//清空每个桶
                        }
                    arr = list.ToArray<int>(); //arr指向重新排列的元素
                                               //Console.Write("{0}times:",i);
                                               //Print(arr);//输出一次排列的结果
                    list.Clear();//清空list
                }
            }

            //得到最大元素的位数
            private static int GetMaxLength(int[] arr)
            {
                int iMaxNumber = Int32.MinValue;
                foreach (int i in arr)//遍历得到最大值
                {
                    if (i > iMaxNumber)
                        iMaxNumber = i;
                }
                return iMaxNumber.ToString().Length;//这样获得最大元素的位数是不是有点投机取巧了...
            }
        }
    }
}
