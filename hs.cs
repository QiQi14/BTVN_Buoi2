using System;

namespace HH
{
    class hocsinh
    {
        private string hoTen;
        private float diem;
        public string HoTen { get => hoTen; set => hoTen = value; }
        public float Diem { get => diem; set => diem = value; }

        public void nhapthongtin()
        {
            Console.Write("Nhap Ho Ten:");
            hoTen = Console.ReadLine();
            Console.Write("Nhap Diem:");
            diem = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("");
        }
    }
    class hs
    {
        static void Main(string[] args)
        {

            Console.Write("Nhap vao n hoc sinh:");
            int n = Convert.ToInt32(Console.ReadLine());
            hocsinh[] a = new hocsinh[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap thong tin hoc sinh thu " + (i + 1));
                a[i] = new hocsinh();
                a[i].nhapthongtin();
            }
            hocsinh tb;
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (a[i].Diem < a[j].Diem)

                    {
                        tb = a[i];
                        a[i] = a[j];
                        a[j] = tb;

                    }

                }
            }
            Console.WriteLine("\n hoc sinh co diem cao nhat la:");
            for (int i = 0; i <= 0; i++)
            {
                Console.WriteLine("\n  Ho Ten: {0} |Diem : {1}", a[i].HoTen, a[i].Diem);
            }


            Console.ReadKey();
        }
    }
}