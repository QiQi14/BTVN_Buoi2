// See https://aka.ms/new-console-template for more information

using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Xml.Linq;

namespace BTVN;
class Buoi2
{
    public static void Main()
    {
        int[] test1 = { 1, 2, 3, 3, 1};
        int[] test2 = { 1, 1, 1, 1, 1, 6};
        int[] test3 = { 1, 2, 3, 4, 3, 2, 1};
        int[] test4 = { 1, 3, 3, 3, 1, 2, 5, 2};
        string[] name = { "A", "B", "C", "D", "E", "F"};
        int[] grade = { 5, 4, 5, 7, 4, 6};
        


        System.Console.WriteLine("BTVN Buoi 2:");
        System.Console.WriteLine("Ket qua bai 1:");
        System.Console.WriteLine("test case 1: " + Bai1(test1));
        System.Console.WriteLine("test case 2: " + Bai1(test2));
        System.Console.WriteLine("test case 3: " + Bai1(test3));
        System.Console.WriteLine("test case 4: " + Bai1(test4));
        System.Console.WriteLine("Ket qua bai 2:");
        Bai2(name, grade);
    }

    private static string Bai1(int[] input)
    {
        if (input == null)
        {
            return "Mang rong";
        }

        //Xử lý kết quả dựa theo đầu vào input rồi gán vào biến result
        int result = -1;
        
        for (int i = 0; i < input.Length; i++)
        {
            int flag = 0;
            for (int j = 0; j < input.Length; j++)
            {
                if (flag == 2)
                {
                    break;
                }
                else if (input[i] == input[j])
                {
                    flag = flag + 1;
                }
            }
            if (flag == 1)
            {
                result = input[i];
                break;
            }

        }
        if (result == -1)
        {
            return "Khong co phan tu khong trung trong mang";
        }
        else
            return "Phan tu khong trung trong mang la " + result;
    }

    private static void Bai2(string[]name, int[] grade)
    {
        if ((grade == null) || (name == null))
        {
            Console.WriteLine("Mang rong");
            return;
        }

        //Xử lý kết quả dựa theo đầu vào là mảng name và mảng grade rồi gán vào biến result
        int max = grade.Max();
        List<int> list_max = new List<int> ();
        for (int i = 0;i < grade.Length;i++)
        {
            if (grade[i] == max)
            {
                list_max.Add(i);
            }
        }

        string result = "";
        foreach (int i in list_max)
        {
            result = result + name[i] + " ";
        }

        Console.WriteLine("Nguoi co diem so cao nhat la: " + result);
    }
}
