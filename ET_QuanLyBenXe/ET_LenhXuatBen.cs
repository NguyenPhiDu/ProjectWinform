using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ET_QuanLyBenXe
{
    public class ET_LenhXuatBen
    {
        private string _MsLXB;
        private string _MsX;
        private string _MsHD;
        //constructors
        public ET_LenhXuatBen() { }
        public ET_LenhXuatBen(string _MsLXB, string _MsX, string _MsHD)
        {
            this.MsLXB = _MsLXB;
            this.MsX = _MsX;
            this.MsHD = _MsHD;
        }
        //getter setter
        public string MsLXB
        {
            get
            {
                return _MsLXB;
            }

            set
            {
                _MsLXB = value;
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
    }
}
