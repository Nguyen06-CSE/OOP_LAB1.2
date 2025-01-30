using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            int soMenu = 30;
            int chon;
            List<int> ds = new List<int>();
            do
            {
                XuatMenu();
                chon = ChonMenu(soMenu);
                XuLyMenu(chon, ref n, ds);
            } while (chon != 0);
        }


        static void XuatMenu()
        {
            Console.WriteLine("____________________MENU_____________________");
            Console.WriteLine("0.\tthoat khoi chuong trinh ");
            Console.WriteLine("1.\tNhập vào một mảng số nguyên và in ra mảng.\r\n2.\tTìm giá trị lớn nhất trong mảng.\r\n3.\tTìm giá trị nhỏ nhất trong mảng.\r\n4.\tTính tổng tất cả các phần tử trong mảng.\r\n5.\tTính trung bình cộng của các phần tử.\r\n6.\tĐếm số lượng phần tử chẵn trong mảng.\r\n7.\tĐếm số lượng phần tử lẻ trong mảng.\r\n8.\tTìm vị trí của phần tử lớn nhất đầu tiên trong mảng.\r\n9.\tTìm vị trí của phần tử nhỏ nhất đầu tiên trong mảng.\r\n10.\tKiểm tra xem mảng có chứa số x hay không.\r\n11.\tĐếm số lần xuất hiện của phần tử x.\r\n12.\tTìm tất cả các số nguyên tố trong mảng.\r\n13.\tTìm số hoàn hảo nhỏ nhất trong mảng.\r\n14.\tTìm ước chung lớn nhất của tất cả các phần tử.\r\n15.\tTìm bội chung nhỏ nhất của tất cả các phần tử.\r\n16.\tKiểm tra xem mảng có toàn là số dương không.\r\n17.\tKiểm tra xem mảng có toàn là số âm không.\r\n18.\tĐếm số lượng các số nguyên tố trong mảng.\r\n19.\tĐếm số lượng các số đối xứng trong mảng.\r\n20.\tTính tổng các phần tử dương trong mảng.\r\n21.\tTính tổng các phần tử âm trong mảng.\r\n22.\tTìm tất cả các cặp số có hiệu là số chẵn.\r\n23.\tKiểm tra xem mảng có chứa ít nhất một số lẻ không.\r\n24.\tTính tổng bình phương của tất cả các phần tử.\r\n25.\tTìm phần tử xuất hiện nhiều nhất trong mảng.\r\n26.\tKiểm tra xem mảng có phải là mảng tăng dần không.\r\n27.\tKiểm tra xem mảng có phải là mảng giảm dần không.\r\n28.\tKiểm tra xem mảng có phải là mảng toàn các số chia hết cho x.\r\n29.\tTính tổng các số nguyên tố trong mảng.\r\n30.\tĐếm số lượng các số nguyên tố nhỏ hơn x.\r\n");
            
        }

        static int ChonMenu(int soMenu) 
        {
            int chon;

            do
            {
                Console.Write($"Nhập chọn [0....{soMenu}]: ");
                chon = int.Parse(Console.ReadLine());
                if (chon >= 0 && chon <= soMenu)
                {
                    break;
                }
            } while (true);
            return chon;
        }

        static void XuLyMenu(int chon, ref int n, List<int> ds)
        {
            int x;
            switch (chon)
            {
                case 0:
                    Console.WriteLine("Thoát khỏi chương trình");
                    break;
                case 1:
                    Nhap(ds);
                    Xuat(ds);
                    break;
                case 2:
                    Console.WriteLine("Giá trị lớn nhất: " + TimGiaTriLonNhat(ds));
                   
                    break;
                case 3:
                    Console.WriteLine("Giá trị nhỏ nhất: " + TimGiaTriNhoNhat(ds));
                    
                    break;
                case 4:
                    Console.WriteLine("Tổng các phần tử: " + TinhTong(ds));
                  
                    break;
                case 5:
                    Console.WriteLine("Trung bình cộng: " + TinhTrungBinhCong(ds));
                    
                    break;
                case 6:
                    Console.WriteLine("Số lượng phần tử chẵn: " + DemPhanTuChan(ds));
                   
                    break;
                case 7:
                    Console.WriteLine("Số lượng phần tử lẻ: " + DemPhanTuLe(ds));
                    
                    break;
                case 8:
                    Console.WriteLine("Vị trí phần tử lớn nhất: " + TimViTriLonNhat(ds));
                    
                    break;
                case 9:
                    Console.WriteLine("Vị trí phần tử nhỏ nhất: " + TimViTriNhoNhat(ds));
                    
                    break;
                case 10:
                    Console.Write("nhap phan tu x ban muon tim kiem: ");
                    x = Console.Read();
                    Console.WriteLine("Danh sách chứa số x: " + (KiemTraChuaX(ds, x) ? "Có" : "Không"));
                    
                    break;
                case 11:
                    Console.Write("nhap phan tu x ban muon dem: ");
                    x = Console.Read();
                    Console.WriteLine("Số lần xuất hiện của x: " + DemSoLanXuatHien(ds, x));
                    
                    break;
                case 12:
                    Console.WriteLine("Các số nguyên tố: " + string.Join(", ", TimSoNguyenTo(ds)));
                    
                    break;
                case 13:
                    Console.WriteLine("Số hoàn hảo nhỏ nhất: " + TimSoHoanHao(ds));
                    
                    break;
                case 14:
                    Console.WriteLine("Ước chung lớn nhất: " + UCLN(ds));
                    
                    break;
                case 15:
                    Console.WriteLine("Bội chung nhỏ nhất: " + BCNN(ds));
                    
                    break;
                case 16:
                    Console.WriteLine("Danh sách toàn số dương: " + (KiemTraToanDuong(ds) ? "Có" : "Không"));
                    

                    break;
                case 17:
                    Console.WriteLine("Danh sách toàn số âm: " + (KiemTraToanAm(ds) ? "Có" : "Không"));
                   
                    break;
                case 18:
                    Console.WriteLine("Số nguyên tố trong danh sách: " + DemSoNguyenTo(ds));
                    
                    break;
                case 19:
                    Console.WriteLine("Số đối xứng: " + DemSoDoiXung(ds));
                    break;
                case 20:
                    Console.WriteLine("Tổng các số dương: " + TinhTongSoDuong(ds));

                    break;
                case 21:
                    Console.Write("tong so am trong mang la: " + TinhTongSoAm(ds));
                    

                    break;
                case 22:
                    Console.Write("cac cap co hieu la so chan la: ");
                    XuatCap(TimCapHieuChan(ds));
                    break;
                case 23:
                    if (KiemTraChuaSoLe(ds))
                    {
                        Console.WriteLine("chuoi co chua so le");
                    }
                    else Console.WriteLine("chuoi ckhong chua so le");
                    break;
                case 24:
                    Console.Write("tong binh phuong cac so trong mang la: " + TinhTongBinhPhuong(ds));

                   
                    break;
                case 25:
                    Console.Write("phan tu xuat hien nhieu nhat trong mang la: " + TimPhanTuXuatHienNhieuNhat(ds));
                    
                    break;
                case 26:
                    if (KiemTraTangDan(ds))
                    {
                        Console.WriteLine("mang la mang tang dan");
                    }
                    else Console.WriteLine("mang la mang khong tang dan");
                    break;
                case 27:
                    if (KiemTraGiamDan(ds))
                    {
                        Console.WriteLine("mang la mang giam dan");
                    }
                    else Console.WriteLine("mang la mang khong giam dan");
                    
                    break;
                case 28:
                    Console.Write("nhap phan tu x ban muon dem: ");
                    x = Console.Read();
                    KiemTraChiaHet(ds, x);
                    break;
                case 29:
                    Console.Write("tong cac so nguyen to trong mang la: " + TinhTongSoNguyenTo(ds));
                    break;
                case 30:
                    Console.Write("tong cac so nguyen to trong mang la: " + TinhTongSoNguyenTo(ds));
                    break;

                    
                default:
                    break;
            }
            Console.ReadKey();
        }

        static void Nhap(List<int> ds)
        {
            Console.WriteLine("nhap so phan tu");
            var dem = int.Parse(Console.ReadLine());
            for (int i = 0; i < dem; i++)
            {
                Console.Write("nhap vao phan tu thu {0}: ", i); // Sử dụng Console.Write thay vì Console.WriteLine
                ds.Add(int.Parse(Console.ReadLine()));
            }
        }
        
        static void NhapNgauNhien(List<int> ds, int k)
        {
            
            Random random = new Random();
            for (int i = 0; i < k; i++)
            {
                ds.Add(random.Next(10));
            }
        }
        
        static void Xuat(List<int> ds)
        {
            foreach (int i in ds)
            {
                Console.Write($"{i}" + '\t');
            }
            Console.WriteLine();
        }

        static void XuatCap(List<(int, int)> result)
        {
            foreach (var pair in result)
            {
                Console.WriteLine($"({pair.Item1}, {pair.Item2})");
            }
            Console.WriteLine();
        }


        

        static int TimGiaTriLonNhat(List<int> list) => list.Max();

        static int TimGiaTriNhoNhat(List<int> list) => list.Min();

        static int TinhTong(List<int> list) => list.Sum();

        static double TinhTrungBinhCong(List<int> list) => list.Average();

        static int DemPhanTuChan(List<int> list) => list.Count(x => x % 2 == 0);

        static int DemPhanTuLe(List<int> list) => list.Count(x => x % 2 != 0);

        static int TimViTriLonNhat(List<int> list) => list.IndexOf(list.Max());

        static int TimViTriNhoNhat(List<int> list) => list.IndexOf(list.Min());

        static bool KiemTraChuaX(List<int> list, int x) => list.Contains(x);

        static int DemSoLanXuatHien(List<int> list, int x) => list.Count(n => n == x);

        static List<int> TimSoNguyenTo(List<int> list) => list.Where(IsPrime).ToList();

        static int TimSoHoanHao(List<int> list) => list.FirstOrDefault(IsPerfect);

        static int UCLN(List<int> list) => list.Aggregate(Ucln);

        static int BCNN(List<int> list) => list.Aggregate(Bcnn);

        static bool KiemTraToanDuong(List<int> list) => list.All(x => x > 0);

        static bool KiemTraToanAm(List<int> list) => list.All(x => x < 0);

        static int DemSoNguyenTo(List<int> list) => list.Count(IsPrime);

        static int DemSoDoiXung(List<int> list) => list.Count(IsPalindrome);

        static int TinhTongSoDuong(List<int> list) => list.Where(x => x > 0).Sum();

        static bool IsPrime(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
                if (n % i == 0) return false;
            return true;
        }

        static bool IsPerfect(int n)
        {
            if (n <= 0) return false;
            int sum = 0;
            for (int i = 1; i < n; i++)
                if (n % i == 0) sum += i;
            return sum == n;
        }

        static int Ucln(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        static int Bcnn(int a, int b) => (a * b) / Ucln(a, b);

        static bool IsPalindrome(int n)
        {
            string s = n.ToString();
            return s == new string(s.Reverse().ToArray());
        }

        static int TinhTongSoAm(List<int> list) => list.Where(x => x < 0).Sum();

        static bool TinhHieuChan(int a, int b)
        {
            return ((a - b) % 2 == 0);
        }

        static List<(int, int)> TimCapHieuChan(List<int> ds)
        {
            List<(int, int)> result = new List<(int, int)>();
            for (int i = 0; i < ds.Count - 1; i++)
            {
                for (int j = i + 1; j < ds.Count; j++)
                {
                    if (TinhHieuChan(ds[i], ds[j]))
                    {
                        result.Add((ds[i], ds[j])); 
                    }
                }
            }

            return result;  
        }

        static bool KiemTraChuaSoLe(List<int> list) => list.Any(x => x % 2 != 0);

        static int TinhTongBinhPhuong(List<int> list) => list.Sum(x => x * x);

        static int Dem(List<int> ds, int n)
        {
            int dem = 0;
            for(int i =0; i < ds.Count; i++)
            {
                if(ds[i] == n)
                {
                    ++dem;
                }
            }
            return dem;
        }

        static int TimPhanTuXuatHienNhieuNhat(List<int> ds)
        {
            int kq = ds[0];
            int max = Dem(ds, 0);  
            for (int i = 1; i < ds.Count; i++)
            {
                int count = Dem(ds, i);
                if (count > max)
                {
                    max = count;
                    kq = ds[i];
                }
            }

            return kq;
        }

        static bool KiemTraTangDan(List<int> list)
        {
            for (int i = 1; i < list.Count; i++)
            {
                if (list[i] < list[i - 1]) return false;
            }
            return true;
        }

        static bool KiemTraGiamDan(List<int> list)
        {
            for (int i = 1; i < list.Count; i++)
            {
                if (list[i] > list[i - 1]) return false;
            }
            return true;
        }

        static bool KiemTraChiaHet(List<int> list, int x) => list.All(num => num % x == 0);

        static int TinhTongSoNguyenTo(List<int> list) => list.Where(IsPrime).Sum();

        static int DemSoNguyenToNhoHonX(List<int> list, int x) => list.Count(n => IsPrime(n) && n < x);

    }
}

