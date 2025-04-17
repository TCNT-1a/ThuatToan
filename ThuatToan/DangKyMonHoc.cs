using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThuatToan
{
    public class DangKyMonHoc
    {
        int[] sinhvien = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, };
        int[] monhoc = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
        public DangKyMonHoc()
        {
        }
    }
    public class MonHoc {
        public int Id { get; set; }
        public string Name { get; set; }
        public HashSet<SinhVien> sinhviens { get; set; }
        public int soLuongToiDa { get; set; }
        public MonHoc()
        {
            sinhviens = new HashSet<SinhVien>();
        }
        public bool DangKy(SinhVien sv)
        {
            var sinhVien = sinhviens.AsQueryable().FirstOrDefault(p=>p.Id==sv.Id);
            if (sinhVien == null)
            {
                sinhviens.Add(sv);
                return true;
            }
            return false;
        }
        public bool HuyDangKy(SinhVien sv)
        {
            var sinhVien = sinhviens.AsQueryable().FirstOrDefault(p => p.Id == sv.Id);
            if (sinhVien == null)
            {
                sinhviens.Remove(sv);
                return true;
            }
            return false;
        }

    }
    public class SinhVien

    {
        public int Id { get; set; }
        public int FullName { get; set; }
        public List<MonHoc> monhocs { get; set; }
    }

}
