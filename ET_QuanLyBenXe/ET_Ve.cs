using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ET_QuanLyBenXe
{
    public class ET_Ve
    {
        private string _MsV;
        private int _Ghe;
        private string _MsX;
        private string _MsNV;
        //constructors
        public ET_Ve() { }
        public ET_Ve(string _MsV, int _Ghe, string _MsX, string _MsNV)
        {
            this._MsV = _MsV;
            this._Ghe = _Ghe;
            this._MsX = _MsX;
            this._MsNV = _MsNV;
        }
        //getter setter
        public string MsV
        {
            get
            {
                return _MsV;
            }

            set
            {
                _MsV = value;
            }
        }

        public int Ghe
        {
            get
            {
                return _Ghe;
            }

            set
            {
                _Ghe = value;
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

        public string MsNV
        {
            get
            {
                return _MsNV;
            }

            set
            {
                _MsNV = value;
            }
        }
    }
}
