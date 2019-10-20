using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySort
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new int[] { 5, 3, 8, 2, 1, 4 };

            Console.WriteLine($"Original Array:{string.Join(",", list)}");
            Console.WriteLine("Please enter number for choosing sort method:");
            Console.WriteLine("1.BubbleSort 2.SortChoice");
            Console.WriteLine("3.InsertSort 4.ShellSort");
            Console.Write("Option:");
            var option = "";
            option = Console.ReadLine();
            switch (option)
            {
                case "1":
                    BubbleSort(list);
                    break;
                case "2":
                    ChoiceSort(list);
                    break;
                case "3":
                    InsertSort(list);
                    break;
                case "4":
                    ShellSort(list);
                    break;
                default:
                    break;
            }
            Console.WriteLine($"Sort Array:{string.Join(",", list)}");
        }

        static void BubbleSort(int[] list)
        {
            int arrayIndex = list.Length;
            while (arrayIndex > 1)
            {
                arrayIndex--;
                for (int i = 0; i < arrayIndex; i++)
                {
                    // 如果前面元素比后面大，则交换位置
                    if (list[i] > list[i + 1])
                    {
                        var temp = list[i];
                        list[i] = list[i + 1];
                        list[i + 1] = temp;
                    }
                }
            }
        }

        static void ChoiceSort(int[] list)
        {
            int min;
            for (int i = 0; i < list.Length - 1; i++)
            {
                min = i;
                for (int j = i + 1; j < list.Length; j++)
                {
                    if (list[j] < list[min])
                    {
                        min = j;
                    }
                }
                int t = list[min];
                list[min] = list[i];
                list[i] = t;
            }
        }

        static void InsertSort(int[] list)
        {
            for (int i = 1; i < list.Length; i++)
            {
                int t = list[i];
                int j = i;
                while ((j > 0) && (list[j - 1] > t))
                {
                    list[j] = list[j - 1];
                    --j;
                }
                list[j] = t;
            }
        }

        static void ShellSort(int[] list)
        {
            int inc;
            for (inc = 1; inc <= list.Length / 9; inc = 3 * inc + 1) ;
            for (; inc > 0; inc /= 3)
            {
                for (int i = inc + 1; i <= list.Length; i += inc)
                {
                    int t = list[i - 1];
                    int j = i;
                    while ((j > inc) && (list[j - inc - 1] > t))
                    {
                        list[j - 1] = list[j - inc - 1];
                        j -= inc;
                    }
                    list[j - 1] = t;
                }
            }

        }
    }
}
