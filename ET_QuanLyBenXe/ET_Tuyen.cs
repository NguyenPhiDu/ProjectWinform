using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ET_QuanLyBenXe
{
    public class ET_Tuyen
    {
        private string _Mst;
        private string _Tuyen;
        private string _BenDi;
        private int _DoDaiTuyen;
        //constructors
        public ET_Tuyen() { }
        public ET_Tuyen(string Mst, string Tuyen, string BenDi, int DoDaiTuyen)
        {
            _Mst = Mst;
            _Tuyen = Tuyen;
            _BenDi = BenDi;
            _DoDaiTuyen = DoDaiTuyen;
        }
        //getter setter
        public string Mst { get => _Mst; set => _Mst = value; }
        public string Tuyen { get => _Tuyen; set => _Tuyen = value; }
        public string BenDi { get => _BenDi; set => _BenDi = value; }
        public int DoDaiTuyen { get => _DoDaiTuyen; set => _DoDaiTuyen = value; }
    }
}
