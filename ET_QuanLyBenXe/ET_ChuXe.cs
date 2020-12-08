using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ET_QuanLyBenXe
{
    public class ET_ChuXe
    {
        private string _MsCX;
        private string _TenCX;
        private int _CMND;
        private string _DiaChi;
        private int _SoDT;
        //constructors
        public ET_ChuXe(string _MsCX, string _TenCX, int _CMND, string _DiaChi, int _SoDT)
        {
            this.MsCX = _MsCX;
            this.TenCX = _TenCX;
            this.CMND = _CMND;
            this.DiaChi = _DiaChi;
            this.SoDT = _SoDT;
        }
        public ET_ChuXe() { }
        //getter setter
        public string MsCX
        {
            get
            {
                return _MsCX;
            }

            set
            {
                _MsCX = value;
            }
        }

        public string TenCX
        {
            get
            {
                return _TenCX;
            }

            set
            {
                _TenCX = value;
            }
        }

        public int CMND
        {
            get
            {
                return _CMND;
            }

            set
            {
                _CMND = value;
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

        public int SoDT
        {
            get
            {
                return _SoDT;
            }

            set
            {
                _SoDT = value;
            }
        }
    }
}
