using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Day01
{
    public class SinhVienService
    {
        public  async Task AddData(SinhVien sv)
        {
            var url = @"C:\Users\Admin\Desktop\Teach\Day01\data.txt";

            using StreamWriter file = new StreamWriter(url, append: true);
            var gt = sv.GioiTinh ? 1 : 0;
            var text = $"{sv.MaSinhVien}|{sv.TenSinhVien}|{gt}|{sv.NgaySinh}";
            await file.WriteLineAsync(text);
          
        
                
         
        }
        public List<SinhVien> GetData()
        {
            var url = @"C:\Users\Admin\Desktop\Teach\Day01\data.txt";
            var lst = new List<SinhVien>();
            StreamReader sr = new StreamReader(url);
            while (true)
            {
                String line = sr.ReadLine();
                if (line == null)
                    break;

                line = line.Trim(); 
                string[] parts = line.Split("|");
                SinhVien sv = new SinhVien()
                {
                    MaSinhVien = parts[0],
                    TenSinhVien = parts[1],
                    GioiTinh = int.Parse(parts[2]) == 1 ? true : false,
                    NgaySinh = parts[3]
                };
                lst.Add(sv);
            }
            sr.Close();
            return lst;
        }
    }
}
