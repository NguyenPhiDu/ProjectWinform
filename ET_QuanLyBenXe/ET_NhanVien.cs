using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ET_QuanLyBenXe
{
    public class ET_NhanVien
    {
        private string _MaSoNV;
        private string _TenNV;
        private DateTime _NgaySinh;
        private string _DiaChi;
        private int _SDT;
        private int _HeSoLuong;
        private float _LuongCB;
        private float _TienLuong;
        private string _MaSoChucVu;

        //contructors 
        public ET_NhanVien() { }

        public ET_NhanVien(string MaSoNV, string TenNV, DateTime NgaySinh, string DiaChi, int SDT, int HeSoLuong, float LuongCB, float TienLuong, string MaSoChucVu)
        {
            this.MaSoNV = MaSoNV;
            this.TenNV = TenNV;
            this.NgaySinh = NgaySinh;
            this.DiaChi = DiaChi;
            this.SDT = SDT;
            this.HeSoLuong = HeSoLuong;
            this.LuongCB = LuongCB;
            this.TienLuong = TienLuong;
            this.MaSoChucVu = MaSoChucVu;
        }

        public string MaSoNV { get => _MaSoNV; set => _MaSoNV = value; }
        public string TenNV { get => _TenNV; set => _TenNV = value; }
        public DateTime NgaySinh { get => _NgaySinh; set => _NgaySinh = value; }
        public string DiaChi { get => _DiaChi; set => _DiaChi = value; }
        public int SDT { get => _SDT; set => _SDT = value; }
        public int HeSoLuong { get => _HeSoLuong; set => _HeSoLuong = value; }
        public float LuongCB { get => _LuongCB; set => _LuongCB = value; }
        public float TienLuong { get => _TienLuong; set => _TienLuong = value; }
        public string MaSoChucVu { get => _MaSoChucVu; set => _MaSoChucVu = value; }
    }
}
