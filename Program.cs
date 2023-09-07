// See https://aka.ms/new-console-template for more information

namespace BTVN;
class Buoi2
{

    public static void Main(string[] args)
    {
        int luachon = 2;
        Console.WriteLine("Bai Tap Can Kiem Tra");
        Console.WriteLine("Bai tap 1 ban nhap so 1 ");
        Console.WriteLine("Bai tap 2 ban nhap so 2 ");
        Console.Write("Moi Ban Nhap Bai Tap So = ");
        luachon = int.Parse(Console.ReadLine());
        switch(luachon)
        {
            case 1:
                BaiTap1();
                break;
            case 2:
                BaiTap2();
                break;
            default:
                Console.WriteLine("Ban Nhap Lua chon khong co bai tap");
                break;
        } 
    }
    public static void NhapMang(int[] a, int n)
    {
        for (int i = 0; i < n; i++)
        {
            Console.Write("a[" + i + "]=");
            a[i] = int.Parse(Console.ReadLine());
        }
    }

    public static void XuatMang(int[] a, int n)
    {
        for (int i = 0; i < n; i++)
        {
            Console.Write(a[i] + " ");
        }
    }

    public static void BaiTap1()
    {
        Console.Write("Nhap vao mang n phan tu: ");
        int n = int.Parse(Console.ReadLine());
        int[] a = new int[n];
        NhapMang(a, n);

        Console.Write("Phan Tu Giong Nhau la : ");

        for(int i = 0; i < n; i++)
        {
            for(int j = i + 1; j < n; j++)
            {
                if (a[i] == a[j])
                {
                    Console.Write(a[i] + " ");
                }
            }
        }
        Console.WriteLine("");
        Console.WriteLine("Phan Tu Khac Nhau la : ");
        Console.Write("Co Mang ");
        XuatMang(a, n);
        Console.Write("Thi ");
        for (int i = 0; i < a.Length; i++)
        {
            bool phantuTrung = true;

            for(int j = 0; j < a.Length; j++)
            {
                if(i != j && a[i] == a[j])
                {
                    phantuTrung = false;
                    break;
                }
            }
            if (phantuTrung)
            {                
                Console.Write(a[i] + " ");               
            }
        }
        Console.Write("la phan tu khong bi trung");
        Console.ReadKey();
    }

    public static void NhapMangbt2(string[] tenhs, double[] diemhs, int soluong)
    {
        for(int i = 0; i < soluong; i++)
        {
            Console.Write("Nhap ten hoc sinh thu " + (i + 1) + " = " );
            tenhs[i] = Console.ReadLine();

            Console.Write("Nhap diem hoc sinh " + tenhs[i] + " = ");
            diemhs[i] = Double.Parse(Console.ReadLine());
        }
    }

    public static void XuatMangbt2(string[] tenhs, double[] diemhs, int soluong)
    {
        Console.WriteLine("Danh Sach Sinh Vien va Diem: ");
        
        for(int i = 0; i < soluong; i++)
        {
            Console.WriteLine("Hoc Sinh Thu " + (i+1) +  " Ten: " + tenhs[i] + " Diem: " + diemhs[i]);
        }
    }

    public static void BaiTap2()
    {
        Console.Write("Nhap so luong hoc sinh lop hoc = ");
        int soluong = int.Parse(Console.ReadLine());
        string[] tenhs = new string[soluong];
        double[] diemhs = new double[soluong];
        NhapMangbt2(tenhs, diemhs, soluong);
        int max = 0;
        for(int i = 1; i < soluong; i++)
        {    
            if (diemhs[i] > diemhs[max])
            {
                max = i;
                
            }        
        }
        Console.WriteLine("Hoc Vien " + tenhs[max] + " Co Diem Cao Nhat la = " + tenhs[max] + " - " + diemhs[max]);
        Console.ReadKey();
        //XuatMangbt2(tenhs, diemhs, soluong);
    }

    /*
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
        //Xử lý kết quả dựa theo đầu vào input rồi gán vào biến result
        int result = -1;
        return "" + result;
    }

    private static void Bai2(string[]name, int[] grade)
    {
        //Xử lý kết quả dựa theo đầu vào là mảng name và mảng grade rồi gán vào biến result

        string result = "Khong biet";
        Console.WriteLine("Nguoi co diem so cao nhat la: " + result);
    }
    */
}
