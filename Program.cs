// See https://aka.ms/new-console-template for more information

namespace BTVN;
class Buoi2
{
    public static void Main()
    {
        int[] test1 = { 1, 2, 3, 3, 1 };
        int[] test2 = { 1, 1, 1, 1, 1, 6 };
        int[] test3 = { 1, 2, 3, 4, 3, 2, 1 };
        int[] test4 = { 1, 3, 3, 3, 1, 2, 5, 2 };

        string[] name = { "A", "B", "C", "D", "E", "F" };
        int[] grade = { 5, 4, 5, 7, 4, 6 };


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
        string result = "";
        for (int i = 0; i < input.Length; i++)
        {
            bool isDuplicate = false;
            for (int j = 0; j < input.Length; j++)
            {
                if (i != j && input[i] == input[j])
                {
                    isDuplicate = true;
                    break;
                }
            }
            if (!isDuplicate)
            {
                result = input[i].ToString();
            }
        }

        return result;
    }

    private static void Bai2(string[] name, int[] grade)
    {
        int max = grade[0];
        int index = 0;

        for (int i = 1; i < grade.Length; i++)
        {
            if (grade[i] > max)
            {
                max = grade[i];
                index = i;
            }
        };

        System.Console.WriteLine("Học sinh có điểm cao nhất là: " + name[index]);
    }
}
