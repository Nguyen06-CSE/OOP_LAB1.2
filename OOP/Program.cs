using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> ds = new List<int>();
            bool running = true;

            while (running)
            {
                Console.WriteLine("\n--- MENU ---");
                Console.WriteLine("1. Nhap ngau nhien");
                Console.WriteLine("2. Nhap tu File");
                Console.WriteLine("3. Xuat ra Console");
                Console.WriteLine("4. Xuat ra File");
                Console.WriteLine("5. Tinh toan cac gia tri trong danh sach");
                Console.WriteLine("6. Tinh tong cac phan tu trong danh sach.");
                Console.WriteLine("7. Tinh trung binh cac phan tu trong danh sach.");
                Console.WriteLine("8. Tim gia tri lon nhat trong danh sach.");
                Console.WriteLine("9. Tim gia tri nho nhat trong danh sach.");
                Console.WriteLine("10. Tim so lan xuat hien cua mot gia tri trong danh sach.");
                Console.WriteLine("11. Tinh tong cac so am trong danh sach.");
                Console.WriteLine("12. Tinh tong cac so duong trong danh sach.");
                Console.WriteLine("13. Dem so chan");
                Console.WriteLine("14. Dem so le");
                Console.WriteLine("15. Dem phan tu x trong danh sach");
                Console.WriteLine("16. Tim kiem cac phan tu trong danh sach");
                Console.WriteLine("17. Kiem tra phan tu x co chua trong danh sach hay khong");
                Console.WriteLine("18. Tim so lan xuat hien cua mot gia tri trong danh sach");
                Console.WriteLine("19. Tim tat ca vi tri cua phan tu x trong danh sach");
                Console.WriteLine("20. Tim vi tri dau tien cua phan tu trong danh sach");
                Console.WriteLine("21. Tim vi tri cuoi cung cua phan tu x trong danh sach");
                Console.WriteLine("22. Tim vi tri cua cac so duong trong danh sach");
                Console.WriteLine("23. Tim vi tri cua cac so am trong danh sach");
                Console.WriteLine("24. Tim vi tri cua so lon nhat trong danh sach");
                Console.WriteLine("25. Tim vi tri cua so nho nhat trong danh sach");
                Console.WriteLine("26. Tim tat ca so chan trong danh sach");
                Console.WriteLine("27. Tim tat ca so le trong danh sach");
                Console.WriteLine("28. Tim so nguyen xuat hien nhieu nhat trong danh sach");
                Console.WriteLine("29. Tim so nguyen xuat hien it nhat trong danh sach");
                Console.WriteLine("30. Tim tat ca cac phan tu trong danh sach(khong trung nhau). Vi du danh sach 1 2 3 1 2 thi tra ve 1 2 3");
                Console.WriteLine("31. Tim so lan xuat hien cua cac phan tu trong danh sach");
                Console.WriteLine("32. Tim vi tri dau tien cua danh sach x trong danh sach. Vi du: voi danh sach 1 2 3 4 5 2 3 va mang x la 2 3 thi vi tri tra ve la 2");
                Console.WriteLine("33. Tim vi tri cuoi cung cua danh sach x trong danh sach.");
                Console.WriteLine("34. Tim hop cua 2 danh sach");
                Console.WriteLine("35. Tim giao cua 2 danh sach");
                Console.WriteLine("36. Tim hieu cua 2 danh sach");
                Console.WriteLine("37. Tim phan tu xuat hien it nhat trong danh sach");
                Console.WriteLine("38. Tim phan tu xuat hien nhieu nhat trong danh sach");
                Console.WriteLine("39. Sap xep danh sach");
                Console.WriteLine("40. Sap xep danh sach theo thu tu tang dan.");
                Console.WriteLine("41. Sap xep danh sach theo thu tu giam dan.");
                Console.WriteLine("42. Cap nhat danh sach");
                Console.WriteLine("43. Xoa phan tu tai vi tri vt trong danh sach");
                Console.WriteLine("44. Xoa phan tu dau tien trong danh sach");
                Console.WriteLine("45. Xoa phan tu cuoi cung trong danh sach");
                Console.WriteLine("46. Xoa tat ca danh sach");
                Console.WriteLine("47. Xoa tat ca cac so lon hon x");
                Console.WriteLine("48. Xoa tat ca so duong");
                Console.WriteLine("49. Xoa tat ca so chan");
                Console.WriteLine("50. Xoa tat ca so nguyen to");
                Console.WriteLine("51. Them mot phan tu tai vi tri vt trong danh sach");
                Console.WriteLine("52. Them phan tu dau tien trong danh sach");
                Console.WriteLine("53. Them phan tu vao cuoi danh sach");
                Console.WriteLine("54. Them mot danh sach so nguyen tai vi tri vt cua danh sach");
                Console.WriteLine("55. Them mot danh sach so nguyen vao cuoi danh sach.");
                Console.WriteLine("56. Them mot danh sach so nguyen vao dau danh sach");
                Console.WriteLine("57. Dao nguoc thu tu cac phan tu trong danh sach");
                Console.WriteLine("58. Dao lon vi tri cac phan tu trong danh sach ngau nhien");
                Console.WriteLine("59. Thay the phan tu x bang phan tu y");
                Console.WriteLine("60. Thoat");
                Console.Write("Chon chuc nang: ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        NhapNgauNhien(ds);
                        break;

                    case 2:
                        DocTuFile(ds);
                        break;

                    case 3:
                        Xuat(ds);
                        break;

                    case 4:
                        XuatRaFile(ds);
                        break;

                    case 5:
                        Console.WriteLine("tong cac phan tu trong danh sach la: " + TinhTong(ds));
                        break;

                    case 6:
                        SapXep(ds);
                        Console.WriteLine("tinh trung binh cac phan tu trong danh sach la :" + TinhTongTB(ds));
                        Xuat(ds);
                        break;

                    case 7:
                        Console.WriteLine("pt co gia tri lon nhat trong danh sach la: " + TimGiaTriLonNhat(ds));    
                        break;

                    
                    case 14:
                        Console.WriteLine("Thoát chương trình...");
                        running = false;
                        break;

                    default:
                        Console.WriteLine("Chọn không hợp lệ, vui lòng chọn lại.");
                        break;
                }
            }
        }


        //bai1
        
        //1.1
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
        //1.2
        static void NhapNgauNhien(List<int> ds)
        {
            Console.Write("nhap so phan tu ngau nhien ban muon tao: ");
            var sl = int.Parse(Console.ReadLine());
            Random random = new Random();
            for(int i = 0; i < sl; i++)
            {
                ds.Add(random.Next(10));
            }
        }
        //1.3
        static void DocTuFile(List<int> ds)
        {
            if (!File.Exists("fileTest.txt"))
            {
                Console.WriteLine("ko ton tai file");
                return;
            }
            using (StreamReader sr = new StreamReader("fileTest.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    ds.Add(int.Parse(line));
                }
            }

            Console.WriteLine("noi dung doc tu file la: ");
            foreach (int i in ds)
            {
                Console.Write($" {i}");
            }
        }
        //1.4
        static void Xuat(List<int> ds)
        {
            foreach (int i in ds)
            {
                Console.Write($"{i}" + '\t');
            }
            Console.WriteLine();
        }
        //1.5
        static void XuatRaFile(List<int> ds)
        {
            using (StreamWriter sw = new StreamWriter("fileTest.txt"))
            {
                foreach (int i in ds)
                {
                    sw.WriteLine($" {i}");
                }
            }
        }
        


        //bai2

        

        static void XuLy(List<int> ds)
        {
            List<int> uniqueElements = new List<int>();

            foreach (int num in ds)
            {
                if (!uniqueElements.Contains(num)) // Kiểm tra xem phần tử đã tồn tại chưa
                {
                    uniqueElements.Add(num); // Thêm phần tử nếu chưa tồn tại
                }
            }

            ds.Clear(); // Xóa danh sách gốc
            ds.AddRange(uniqueElements); // Thêm các phần tử duy nhất trở lại danh sách
            Console.WriteLine();
        }
        static void SapXep(List<int> ds)
        {
            // Sử dụng Bubble Sort để sắp xếp danh sách theo thứ tự tăng dần
            for (int i = 0; i < ds.Count - 1; i++) // Lặp qua từng phần tử
            {
                for (int j = 0; j < ds.Count - i - 1; j++) // So sánh từng cặp phần tử
                {
                    if (ds[j] > ds[j + 1]) // Nếu phần tử hiện tại lớn hơn phần tử kế tiếp
                    {
                        // Hoán đổi vị trí của 2 phần tử
                        int temp = ds[j];
                        ds[j] = ds[j + 1];
                        ds[j + 1] = temp;
                    }
                }
            }
        }
        static void HoanVi(List<int> ds, int i, int j)
        {
            int tmp = ds[i];
            ds[i] = ds[j];
            ds[j]  = tmp;
        }
        //2.1
        static int TinhTong(List<int> a)
        {
            int sum = 0;
            for(int i = 0; i < a.Count; i++)
            {
                sum += a[i];
            }
            return sum;
        }
        //2.2
        static double TinhTongTB(List<int> a)
        {
            return TinhTong(a) / a.Count;
        }
        //2.3
        static int TimGiaTriLonNhat(List<int> ds)
        {
            if (ds.Count == 0) return -1;
            int max = ds[0];
            foreach (int num in ds)
            {
                if (num > max)
                {
                    max = num;
                }
            }
            return max;
        }
        //2.4
        static int TimGiaTriNhoNhat(List<int> ds)
        {
            if (ds.Count == 0) return -1;
            int min = ds[0];
            foreach (int num in ds)
            {
                if (num < min)
                {
                    min = num;
                }
            }
            return min;
        }
        //2.5
        static int TimSoLanXuatHien(List<int> ds, int giaTri)
        {
            int count = 0;
            foreach (int num in ds)
            {
                if (num == giaTri)
                {
                    count++;
                }
            }
            return count;
        }
        //2.6
        static int TinhTongSoAm(List<int> ds)
        {
            int sum = 0;
            foreach (int num in ds)
            {
                if (num < 0)
                {
                    sum += num;
                }
            }
            return sum;
        }
        //2.7
        static int TinhTongSoDuong(List<int> ds)
        {
            int sum = 0;
            foreach (int num in ds)
            {
                if (num > 0)
                {
                    sum += num;
                }
            }
            return sum;
        }
        //2.8
        static int DemSoChan(List<int> ds)
        {
            int count = 0;
            foreach (int num in ds)
            {
                if (num % 2 == 0)
                {
                    count++;
                }
            }
            return count;
        }
        //2.9
        static int DemSoLe(List<int> ds)
        {
            int count = 0;
            foreach (int num in ds)
            {
                if (num % 2 != 0)
                {
                    count++;
                }
            }
            return count;
        }
        //2.10
        static int DemPhanTuX(List<int> a, int x)
        {
            return TimSoLanXuatHien(a, x);
        }

        //bai3

        //3.1
        static bool KiemTraPhanTu(List<int> ds, int x)
        {
            foreach (int num in ds)
            {
                if (num == x)
                {
                    return true;
                }
            }
            return false;
        }
        //3.2
        static int DemSoLanXuatHien(List<int> ds, int x)
        {
            int count = 0;
            foreach (int num in ds)
            {
                if (num == x)
                {
                    count++;
                }
            }
            return count;
        }
        //3.3
        static List<int> TimTatCaViTri(List<int> ds, int x)
        {
            List<int> viTri = new List<int>();
            for (int i = 0; i < ds.Count; i++)
            {
                if (ds[i] == x)
                {
                    viTri.Add(i);
                }
            }
            return viTri;
        }
        //3.4
        static int TimViTriDauTien(List<int> ds, int x)
        {
            for (int i = 0; i < ds.Count; i++)
            {
                if (ds[i] == x)
                {
                    return i;
                }
            }
            return -1; 
        }
        //3.5
        static int TimViTriCuoiCung(List<int> ds, int x)
        {
            for (int i = ds.Count - 1; i >= 0; i--)
            {
                if (ds[i] == x)
                {
                    return i;
                }
            }
            return -1; 
        }
        //3.6
        static List<int> TimViTriSoDuong(List<int> ds)
        {
            List<int> viTri = new List<int>();
            for (int i = 0; i < ds.Count; i++)
            {
                if (ds[i] > 0)
                {
                    viTri.Add(i);
                }
            }
            return viTri;
        }
        //3.7
        static List<int> TimViTriSoAm(List<int> ds)
        {
            List<int> viTri = new List<int>();
            for (int i = 0; i < ds.Count; i++)
            {
                if (ds[i] < 0)
                {
                    viTri.Add(i);
                }
            }
            return viTri;
        }
        //3.8
        static int TimViTriLonNhat(List<int> ds)
        {
            if (ds.Count == 0) return -1;
            int max = ds[0];
            int viTri = 0;
            for (int i = 1; i < ds.Count; i++)
            {
                if (ds[i] > max)
                {
                    max = ds[i];
                    viTri = i;
                }
            }
            return viTri;
        }
        //3.9
        static int TimViTriNhoNhat(List<int> ds)
        {
            if (ds.Count == 0) return -1;
            int min = ds[0];
            int viTri = 0;
            for (int i = 1; i < ds.Count; i++)
            {
                if (ds[i] < min)
                {
                    min = ds[i];
                    viTri = i;
                }
            }
            return viTri;
        }
        //3.10
        static List<int> TimTatCaSoChan(List<int> ds)
        {
            List<int> soChan = new List<int>();
            foreach (int num in ds)
            {
                if (num % 2 == 0)
                {
                    soChan.Add(num);
                }
            }
            return soChan;
        }
        //3.11
        static List<int> TimTatCaSoLe(List<int> ds)
        {
            List<int> soLe = new List<int>();
            foreach (int num in ds)
            {
                if (num % 2 != 0)
                {
                    soLe.Add(num);
                }
            }
            return soLe;
        }
        //3.12
        static int TimSoNguyenXuatHienNhieuNhat(List<int> ds)
        {
            int max = 0;
            int result = ds[0];
            for(int i = 1; i < ds.Count; i++)
            {
                int count = DemSoLanXuatHien(ds, ds[i]);
                if (max < count)
                {
                    max = count;
                    result = ds[i];
                }
            }
            return result;

        }
        //3.13
        static int TimSoNguyenXuatHienItNhat(List<int> ds)
        {
            int min = 0;
            int result = ds[0];
            for (int i = 1; i < ds.Count; i++)
            {
                int count = DemSoLanXuatHien(ds, ds[i]);
                if (min > count)
                {
                    min = count;
                    result = ds[i];
                }
            }
            return result;
        }
        //3.14
        static List<int> TimTatCaKhongTrungNhau(List<int> ds)
        {
            List<int> khongTrung = new List<int>();
            foreach (int num in ds)
            {
                if (!khongTrung.Contains(num))
                {
                    khongTrung.Add(num);
                }
            }
            return khongTrung;
        }
        //3.15
        static List<string> DemTanSuat(List<int> ds)
        {
            List<string> ketQua = new List<string>();
            List<int> PTKoTrung = TimTatCaKhongTrungNhau(ds); 

            for (int i = 0; i < PTKoTrung.Count; i++)
            {
                int demSoLan = DemSoLanXuatHien(ds, PTKoTrung[i]); 
                ketQua.Add($"{PTKoTrung[i]}: {demSoLan}"); 
            }

            return ketQua;
        }
        //3.16
        static int TimViTriDauTienDanhSach(List<int> ds,int x)
        {
            for(int i = 0; i < ds.Count; i++)
            {
                if (ds[i] == x) return i;
            }
            return -1;
        }
        //3.17
        static int TimViTriCuoiCungDanhSach(List<int> ds,int x)
        {
            for (int i = ds.Count; i >= 0; i--)
            {
                if (ds[i] == x) return i;
            }
            return -1;
        }
        //3.18
        static List<int> HopHaiDanhSach(List<int> ds1, List<int> ds2)
        {
            List<int> hop = new List<int>(ds1);
            foreach (int num in ds2)
            {
                if (!hop.Contains(num))
                {
                    hop.Add(num);
                }
            }
            return hop;
        }
        //3.19
        static List<int> TimGiao(List<int> ds1, List<int> ds2)
        {
            List<int> giao = new List<int>();

            for (int i = 0; i < ds1.Count; i++) 
            {
                if (DemSoLanXuatHien(ds2, ds1[i]) > 0 && DemSoLanXuatHien(giao, ds1[i]) == 0) 
                {
                    giao.Add(ds1[i]); 
                }
            }
            return giao; 
        }
        //static List<int> TimGiao(List<int> ds1, List<int> ds2)
        //{
        //    List<int> giao = new List<int>();

        //    for (int i = 0; i < ds1.Count; i++)
        //    {
        //        if (ds2.Contains(ds1[i]) && !giao.Contains(ds1[i])) // Kiểm tra tồn tại trong ds2 và chưa có trong giao
        //        {
        //            giao.Add(ds1[i]);
        //        }
        //    }
        //    return giao;
        //}



        //3.20
        static List<int> TimHieu(List<int> a, List<int> b)
        {
            List<int> hieu = new List<int>();

            for (int i = 0; i < a.Count; i++)
            {
                if (!b.Contains(a[i]) && !hieu.Contains(a[i]))
                {
                    hieu.Add(a[i]);
                }
            }

            return hieu;
        }

        //3.21
        static int TimPTXuatHienItNhat(List<int> ds)
        {
            int dem = int.MaxValue;
            int pt = ds[0];
            for(int i = 0; i < ds.Count; i++)
            {
                int tmp = DemSoLanXuatHien(ds, ds[i]);
                if (dem < tmp)
                {
                    dem = tmp;
                    pt = ds[i];
                }
            }
            return pt;
        }
        //3.22
        static int TimPTXuatHienNhieuNhat(List<int> ds)
        {
            int dem = 0;
            int pt = ds[0];
            for (int i = 0; i < ds.Count; i++)
            {
                int tmp = DemSoLanXuatHien(ds, ds[i]);
                if (dem < tmp)
                {
                    dem = tmp;
                    pt = ds[i];
                }
            }
            return pt;
        }

        //BAI 4


        //4.1
        static void SapXepTang(List<int> ds)
        {
            for(int i = 0; i < ds.Count - 1; i++)
            {
                for(int j = i + 1; j < ds.Count; j++)
                {
                    if (ds[i] < ds[j]) HoanVi(ds, ds[i], ds[j]);
                }
            }
        }
        //4.2
        static void SapXepGiam(List<int> ds)
        {
            for (int i = 0; i < ds.Count - 1; i++)
            {
                for (int j = i + 1; j < ds.Count; j++)
                {
                    if (ds[i] > ds[j]) HoanVi(ds, ds[i], ds[j]);
                }
            }
        }


        //BAI 5

        //5.1
        static void XoaPTTaiX(List<int> ds, int x)
        {
            ds.Remove(ds[x]);
        }
        //5.2
        static void XoaPTDau(List<int> ds)
        {
            ds.Remove(ds[0]);
        }
        //5.3
        static void XoaPTCuoi(List<int> ds)
        {
            ds.Remove(ds.Count - 1);
        }
        //5.4
        static void XoaTatCa(List<int> ds)
        {
            ds.Clear();
        }
        //5.5
        static void XoaTatCaLonHonX(List<int> ds, int x)
        {
            for(int i = 0; i < ds.Count; i++)
            {
                if (ds[i] > x) ds.Remove(ds[i]);
            }
        }
        //5.6
        static void XoaDuong(List<int> ds)
        {
            for (int i = 0; i < ds.Count; i++)
            {
                if (ds[i] > 0) ds.Remove(ds[i]);
            }
        }
        //5.7
        static void XoaChan(List<int> ds)
        {
            for (int i = 0; i < ds.Count; i++)
            {
                if (ds[i] %2 == 0) ds.Remove(ds[i]);
            }
        }

        static bool SoNT(int a)
        {
            if(a < 2) return false;
            for(int i = 2; i < Math.Sqrt(a); i++)
            {
                if(a % i == 0) return false;
            }
            return true;
        }
        //5.8
        static void XoaTatCaSoNT(List<int> ds)
        {
            for(int i = 0; i < ds.Count ; i++)
            {
                if (SoNT(ds[i]))    ds.Remove(ds[i]);
            }
        }
        //5.9
        static void ThemMotPTTaiVT(List<int> ds, int vt, int pt)
        {
            ds.Insert(vt, pt);
        }
        //5.10
        static void ThemPTVaoDau(List<int > ds, int pt)
        {
            ds.Insert(0, pt);
        }
        //5.11
        static void ThemPTVaoCuoi(List<int> ds, int pt)
        {
            ds.Insert(ds.Count-1, pt);
        }
        //5.12
        static void ThemDSMoiTaiViTri(List<int> ds, List<int> dsMoi, int vt)
        {
            if (vt < 0 || vt > ds.Count)
            {
                Console.WriteLine("vi tri ko hop le.");
                return;
            }
            ds.InsertRange(vt, dsMoi);
        }
        //5.13
        static void ThemDSMoiVaoCuoi(List<int> ds, List<int> dsMoi)
        {
            ds.AddRange(dsMoi);
        }
        //5.14
        static void ThemDSMoiVaoDau(List<int> ds, List<int> dsMoi)
        {
            ds.InsertRange(0, dsMoi);
        }
        //5.15
        static void DaoNguocDanhSach(List<int> ds)
        {
            ds.Reverse();
        }
        //5.16
        static void DaoLonNgauNhienDanhSach(List<int> ds)
        {
            Random rnd = new Random();
            for (int i = 0; i < ds.Count; i++)
            {
                int vtNgauNhien = rnd.Next(0, ds.Count);
                int temp = ds[i];
                ds[i] = ds[vtNgauNhien];
                ds[vtNgauNhien] = temp;
            }
        }
        //5.17
        static void ThayThePhanTu(List<int> ds, int x, int y)
        {
            for (int i = 0; i < ds.Count; i++)
            {
                if (ds[i] == x)
                {
                    ds[i] = y;
                }
            }
        }


    }
}
