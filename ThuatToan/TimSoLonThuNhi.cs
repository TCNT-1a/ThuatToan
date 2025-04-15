using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThuatToan
{
    static class TimSoLonThuNhi
    {
        public delegate void XuLyMang(int[] a);

        public static void ThucThi()
        {
            int[] a = { 1, 2, 3, 5, 4, 5 };
            XuLyMang xuLy = XuLyTimSoLonThuNhi(false); // false: không kiểm tra điều kiện phụ
            xuLy(a);
        }

        public static void ThucThi2()
        {
            int[] a = { 1, 2, 3, 5, 4, 5 };
            XuLyMang xuLy = XuLyTimSoLonThuNhi(true); // true: có kiểm tra điều kiện phụ
            xuLy(a);
        }

        public static XuLyMang XuLyTimSoLonThuNhi(bool kiemTraDieuKienPhu)
        {
            return (int[] a) =>
            {
                int soLonNhat = a[0], pSoLonNhat = 0;
                int soLonNhi = a[0], pSoLonNhi = 0;

                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] > soLonNhat)
                    {
                        soLonNhi = soLonNhat;
                        pSoLonNhi = pSoLonNhat;
                        soLonNhat = a[i];
                        pSoLonNhat = i;
                    }
                    else
                    {
                        if (a[i] > soLonNhi && (!kiemTraDieuKienPhu || a[i] < soLonNhat))
                        {
                            soLonNhi = a[i];
                            pSoLonNhi = i;
                        }
                    }
                }

                Console.WriteLine($"So lon nhat la {soLonNhat} tai vi tri {pSoLonNhat}");
                Console.WriteLine($"So lon nhi la {soLonNhi} tai vi tri {pSoLonNhi}");
            };
        }
    }

}
