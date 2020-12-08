using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ET_QuanLyBenXe
{
    public class ET_Xe
    {
        private string _MsX;
        private string _BienSo;
        private int _SoGhe;
        private string _MsCX;
        private string _MsT;
        //constructors
        public ET_Xe() { }
        public ET_Xe(string _MsX, string _BienSo, int _SoGhe, string _MsCX, string _MsT)
        {
            this._MsX = _MsX;
            this._BienSo = _BienSo;
            this._SoGhe = _SoGhe;
            this._MsCX = _MsCX;
            this._MsT = _MsT;
        }
        //getter setter
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

        public string BienSo
        {
            get
            {
                return _BienSo;
            }

            set
            {
                _BienSo = value;
            }
        }

        public int SoGhe
        {
            get
            {
                return _SoGhe;
            }

            set
            {
                _SoGhe = value;
            }
        }

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
