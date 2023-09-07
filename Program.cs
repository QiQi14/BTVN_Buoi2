// See https://aka.ms/new-console-template for more information

using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Xml.Linq;

namespace BTVN;
class Buoi2
{
    public static void Main()
    {
        int[] test1 = { 1, 2, 3, 3, 1 };
        int[] test2 = { 1, 1, 1, 1, 1, 6 };
        int[] test3 = { 1, 2, 3, 4, 3, 2, 1 };
        int[] test4 = { 1, 3, 3, 3, 1, 2, 5, 2 };
        string[] test_name_01 = { "A", "B", "C", "D", "E", "F"};
        int[] test_grade_01 = { 5, 4, 5, 7, 4, 6 };
        string[] test_name_02 = { "A", "B", "C", "D", "E", "F" ,"G", "H"};
        int[] test_grade_02 = { 2, 6, 5, 7, 8, 9, 9, 9};
        string[] test_name_03 = { "A", "B"};
        int[] test_grade_03 = {};


        System.Console.WriteLine("BTVN Buoi 2:");
        System.Console.WriteLine("Ket qua bai 1:");
        System.Console.WriteLine("test case 1: " + Bai1(test1));
        System.Console.WriteLine("test case 2: " + Bai1(test2));
        System.Console.WriteLine("test case 3: " + Bai1(test3));
        System.Console.WriteLine("test case 4: " + Bai1(test4));
        System.Console.WriteLine("Ket qua bai 2:");
        System.Console.WriteLine("test case 1: "); 
        Bai2(test_name_01, test_grade_01);
        System.Console.WriteLine("test case 2: ");
        Bai2(test_name_02, test_grade_02);
        System.Console.WriteLine("test case 3: ");
        Bai2(test_name_03, test_grade_03);
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
            bool flag = true;
            for (int j = 0; j < input.Length; j++)
            {

                if (i != j && input[i] == input[j])
                {
                    flag = false;
                    break;
                }
            }
            if (flag)
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

    private static void Bai2(string[] name, int[] grade)
    {
        if ((grade.Length == 0) || (name.Length == 0))
        {
            Console.WriteLine("Mang rong");
            return;
        }

        //Xử lý kết quả dựa theo đầu vào là mảng name và mảng grade rồi gán vào biến result
        int max = grade.Max();
        List<int> list_max = new List<int>();
        for (int i = 0; i < grade.Length; i++)
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
