using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ET_QuanLyBenXe
{
    public class ET_PhieuDangTai
    {
        private string _MsPDT;
        private DateTime _ThoiGian;
        private string _MsX;
        private string _MsT;
        //constructors
        public ET_PhieuDangTai() { }
        public ET_PhieuDangTai(string _MsPDT, DateTime _ThoiGian, string _MsX, string _MsT)
        {
            this.MsPDT = _MsPDT;
            this.ThoiGian = _ThoiGian;
            this.MsX = _MsX;
            this.MsT = _MsT;
        }
        //getter setter
        public string MsPDT
        {
            get
            {
                return _MsPDT;
            }

            set
            {
                _MsPDT = value;
            }
        }

        public DateTime ThoiGian
        {
            get
            {
                return _ThoiGian;
            }

            set
            {
                _ThoiGian = value;
            }
        }

        public string MsX
        {
            get
            {
                return _MsX;
            }

            set
            {
                _MsX = value;
            }
        }

        public string MsT
        {
            get
            {
                return _MsT;
            }

            set
            {
                _MsT = value;
            }
        }
    }
}
