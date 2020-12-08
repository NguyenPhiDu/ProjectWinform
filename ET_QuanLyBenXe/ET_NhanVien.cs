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
        private string _SDT;
        private string _MaSoCV;
        private int _MaSoLuong;
        private string _MaSoPhongBan;

        //contructors 
        public ET_NhanVien() { }

        public ET_NhanVien(string MaSoNV, string TenNV, DateTime NgaySinh, string DiaChi, string SDT, string MaSoCV, int MaSoLuong, string MaSoPhongBan)
        {
            _MaSoNV = MaSoNV;
            _TenNV = TenNV;
            _NgaySinh = NgaySinh;
            _DiaChi = DiaChi;
            _SDT = SDT;
            _MaSoCV = MaSoCV;
            _MaSoLuong = MaSoLuong;
            _MaSoPhongBan = MaSoPhongBan;
        }

        //properties

        public string MaSoNV
        {
            get
            {
                return _MaSoNV;
            }

            set
            {
                _MaSoNV = value;
            }
        }

        public string TenNV
        {
            get
            {
                return _TenNV;
            }

            set
            {
                _TenNV = value;
            }
        }

        public DateTime NgaySinh
        {
            get
            {
                return _NgaySinh;
            }

            set
            {
                _NgaySinh = value;
            }
        }

        public string DiaChi
        {
            get
            {
                return _DiaChi;
            }

            set
            {
                _DiaChi = value;
            }
        }

        public string SDT
        {
            get
            {
                return _SDT;
            }

            set
            {
                _SDT = value;
            }
        }

        public string MaSoCV
        {
            get
            {
                return _MaSoCV;
            }

            set
            {
                _MaSoCV = value;
            }
        }

        public int MaSoLuong
        {
            get
            {
                return _MaSoLuong;
            }

            set
            {
                _MaSoLuong = value;
            }
        }

        public string MaSoPhongBan
        {
            get
            {
                return _MaSoPhongBan;
            }

            set
            {
                _MaSoPhongBan = value;
            }
        }
    }
}
