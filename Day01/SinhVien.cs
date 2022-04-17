using System;
using System.Collections.Generic;
using System.Text;

namespace Day01
{
    public class SinhVien
    {
        public string MaSinhVien { get; set; }

        public string TenSinhVien { get; set; }

        public bool GioiTinh { get; set; }

        public string NgaySinh { get; set; } 
        public string GetGender()
        {
            return GioiTinh ? "Nam" : "Nữ";
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Ma Sinh Vien: {MaSinhVien} " +
                $"Ten Sinh Vien: {TenSinhVien} Gioi Tinh: {GetGender()} Ngay Sinh: {NgaySinh}");
        }
    }
}
