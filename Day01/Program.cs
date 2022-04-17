using System;
using System.Collections.Generic;

namespace Day01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            var svService = new SinhVienService();
            Console.Write("Ma Sinh Vien: ");
            var msv = Console.ReadLine();
            Console.Write("Ten Sinh Vien: ");
            var ten = Console.ReadLine();
            Console.Write("Gioi Tinh: ");
            var gt = Console.ReadLine();
            Console.Write("Ngay Sinh: ");
            var ns = Console.ReadLine();

            SinhVien sv = new SinhVien()
            {
                MaSinhVien = msv,
                TenSinhVien = ten,
                GioiTinh = gt == "Nam",
                NgaySinh = ns,
            };
            sv.ShowInfo();
            try
            {
                svService.AddData(sv);
                Console.WriteLine("Them thanh cong");
            } catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            /*var svService = new SinhVienService();
            var list = svService.GetData();
            foreach(var item in list)
            {
                item.ShowInfo();
            }*/

        }
    }
}
