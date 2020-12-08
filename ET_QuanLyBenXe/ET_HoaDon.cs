using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ET_QuanLyBenXe
{
    public class ET_HoaDon
    {
        private string _MsHD;
        private DateTime _NgayLapHD;
        private string _NguoiLapHD;
        private int _Tien;
        private string _MaSX;
        //constructors
        public ET_HoaDon(string _MsHD, DateTime _NgayLapHD, string _NguoiLapHD, int _Tien, string _MaSX)
        {
            this.MsHD = _MsHD;
            this.NgayLapHD = _NgayLapHD;
            this.NguoiLapHD = _NguoiLapHD;
            this.Tien = _Tien;
            this.MaSX = _MaSX;
        }
        public ET_HoaDon() { }
        //getter setter
        public string MsHD
        {
            get
            {
                return _MsHD;
            }

            set
            {
                _MsHD = value;
            }
        }

        public DateTime NgayLapHD
        {
            get
            {
                return _NgayLapHD;
            }

            set
            {
                _NgayLapHD = value;
            }
        }

        public string NguoiLapHD
        {
            get
            {
                return _NguoiLapHD;
            }

            set
            {
                _NguoiLapHD = value;
            }
        }

        public int Tien
        {
            get
            {
                return _Tien;
            }

            set
            {
                _Tien = value;
            }
        }

        public string MaSX
        {
            get
            {
                return _MaSX;
            }

            set
            {
                _MaSX = value;
            }
        }
    }
}
