using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT05
{

    class QuanLyCD
    {
        private CD[] ds; //mang luu danh sach cac CD
        private int n; //so luong CD hien hanh
        //phuong thuc constructor
        public QuanLyCD()
        {
            ds = new CD[100];
            n = 0;
        }
        public QuanLyCD(int sophantu)
        {
            ds = new CD[sophantu];
            n = 0;
        }
        //phuong thuc them CD vao danh sach
        public void ThemCD(CD cd)
        {
            if (n >= ds.Length)
            {
                Console.WriteLine("Danh sach da day");
            }
            else
            {
                if (!kiemTraTrungCD(cd.MaCD))
                    ds[n++] = cd;
                else
                {
                    Console.WriteLine("Trung ma CD");
                }
            }
        }
        private bool kiemTraTrungCD(int macd)
        {
            for (int i = 0; i < n; i++)
            {
                if (ds[i].MaCD == macd)
                {
                    return true;
                }
            }
            return false;
        }
        //phuong thuc tinh gia thanh trung binh
        public double tinhGiaTB()
        {
            int tonggia = 0;
            for (int i = 0; i < n; i++)
            {
                tonggia += ds[i].DonGia;
            }
            return (double)tonggia / n;
        }//phuong thuc xuat toan bo CD
        public void Xuat()
        {
            Console.WriteLine("{0, 10} {1,30} {2,30} {3,10} {4, 15}",
            "MaCD", "Tua CD", "Ca si", "So bai hat", "Gia thanh");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(ds[i].ToString());
            }
        }
        //phuong thuc sap xep giam dan theo gia thanh
        public void SapXepGiamTheoGiaThanh()
        {
            CD tam;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (ds[i].DonGia < ds[j].DonGia)
                    {
                        //hoan vi
                        tam = ds[i];
                        ds[i] = ds[j];
                        ds[j] = tam;
                    }
                }
            }
        }
        //phuong thuc sap xep tang dan theo tua CD
        public void SapXepTangDanTheoTuaCD()
        {
            CD tam;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (ds[i].TuaCD.CompareTo(ds[j].TuaCD) > 0) 
                    {
                        //hoan vi
                        tam = ds[i];
                        ds[i] = ds[j];
                        ds[j] = tam;
                    }
                }
            }
        }
    }
}

