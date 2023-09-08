// See https://aka.ms/new-console-template for more information

namespace BTVN;
class Buoi2
{
    public static void Main()
    {
        Console.WriteLine("bai 1");
        int[] chuoi = { 1, 2, 3, 2, 3, 6 };
        int i = 0;
        int j = 0;
        Console.Write("Phan tu khong giong nhau la ");
        for (i = 0; i < chuoi.Length; i++)
        {
            for (j = 0; j < chuoi.Length; j++)
            {
                if (i == j)
                    continue;
                if (chuoi[j] == chuoi[i])
                    break;


            }
            if (chuoi.Length == j)
            {
                Console.Write(chuoi[i] + " ");
            }

        }

        Console.WriteLine("\n++++++++++++++");
        Console.WriteLine("++++++++++++++");
        Console.WriteLine("bai 2");

        Dictionary<String, int> dssv = new Dictionary<String, int>();
        dssv.Add("Nguyen Van A", 8);
        dssv.Add("Tran Van B", 5);
        dssv.Add("Le Thi C", 10);
        dssv.Add("Le Thi D", 3);

        var DiemMAX = dssv.FirstOrDefault(x => x.Value == dssv.Values.Max());
        Console.WriteLine(DiemMAX);





    }
}
