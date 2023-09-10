// See https://aka.ms/new-console-template for more information
using System;
using System.Linq;
using System.Collections.Generic;
namespace BTVN;
class Buoi2
{

    public class Program
    {
        public static void Main()
        {
            int[] test1 = { 1, 2, 3, 3, 1 };
            int[] test2 = { 1, 1, 1, 1, 1, 6 };
            int[] test3 = { 1, 2, 3, 4, 3, 2, 1 };
            int[] test4 = { 1, 3, 3, 3, 1, 2, 5, 2 };

            string[] name = { "A", "B", "C", "D", "E", "F" };
            int[] grade = { 5, 4, 5, 7, 4, 6 };


            Console.WriteLine("BTVN Buoi 2:");
            Console.WriteLine("Ket qua bai 1:");
            Console.WriteLine("Phần tử ko trùng lặp trong testcase1: " + Bai1(test1));
            Console.WriteLine("Phần tử ko trùng lặp trong testcase2: " + Bai1(test2));
            Console.WriteLine("Phần tử ko trùng lặp trong testcase3: " + Bai1(test3));
            Console.WriteLine("Phần tử ko trùng lặp trong testcase4: " + Bai1(test4));
            Console.WriteLine("");
            Console.WriteLine("Ket qua bai 2:");
            Bai2(name, grade);
        }

        private static string Bai1(int[] input)
        {
            int i = 0, j = 0;
            int result = 0;
            for (i = 0; i < input.Length; i++)
            {
                for (j = 0; j < input.Length; j++)
                {
                    if (i == j)
                        continue;
                    if (input[j] == input[i])
                        break;
                }
                if (input.Length == j)
                {
                    result = input[i];
                }
            }
            return "" + result;
        }

        private static void Bai2(string[] name, int[] grade)
        {
            int result = 0;
            Dictionary<string, int> Danhsach = new Dictionary<string, int>();
            for (int i = 0; i < name.Length; i++)
            {
                Danhsach.Add(name[i], grade[i]);
            }
            foreach (var hocsinh in Danhsach)
            {
                Console.WriteLine($"Tên học sinh:{hocsinh.Key}   Điểm số:{hocsinh.Value}");
            }
            foreach (var hocsinh in Danhsach)
            {
                if (Convert.ToInt32(hocsinh.Value) > result)
                {
                    result = Convert.ToInt32(hocsinh.Value);
                }
            }
            Console.WriteLine("Học sinh có điểm số cao nhất là : " + result);
        }
    }

}