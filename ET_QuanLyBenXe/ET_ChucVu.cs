using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ET_QuanLyBenXe
{
    public class ET_ChucVu
    {
        private string _MsCV;
        private string _TenCV;
        //constructors
        public ET_ChucVu() { }
        public ET_ChucVu(string _MsCV, string _TenCV)
        {
            this.MsCV = _MsCV;
            this.TenCV = _TenCV;
        }
        //getter setter
        public string MsCV
        {
            get
            {
                return _MsCV;
            }

            set
            {
                _MsCV = value;
            }
        }

        public string TenCV
        {
            get
            {
                return _TenCV;
            }

            set
            {
                _TenCV = value;
            }
        }
    }
}
