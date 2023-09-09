// See https://aka.ms/new-console-template for more information
using System;

public class KiemtraPhanTu
{
    static void nhap(int[] a, int n)
    {
        for (int i = 0; i < n; i++)
        {
            Console.Write("a[" + i + "]= ");
            a[i] = int.Parse(Console.ReadLine());
        }
    }
    static void xuat(int[] a, int n)
    {
        Console.Write("co mang:");
        for (int i = 0; i < n; i++)
            Console.Write(a[i] + " ");
    }
    static void xuatkotrung(int[] a, int n)
    {
        int i, j;
        Console.Write("Cac phan tu khong trung lap: ");
        for (i = 0; i < a.Length; i++)
        {
            for (j = 0; j < a.Length; j++)
            {
                if (i == j)
                    continue;
                if (a[j] == a[i])
                    break;
            }
            if (a.Length == j)
            {
                Console.Write(a[i] + " ");

            }
        }
    }
    static void Main(string[] args)
    {
        Console.Write("Nhap so phan tu cua mang: ");
        int n = int.Parse(Console.ReadLine());
        int[] a = new int[100];
        nhap(a, n);
        xuat(a, n);
        xuatkotrung(a, n);
        Console.ReadKey();
    }
}
