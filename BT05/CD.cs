﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT05
{
    class CD
    {
        //khai bao thanh phan du lieu
        private int macd;
        private string tuacd;
        private string casi;
        private int sobaihat;
        private int dongia;
        //phuong thuc constructor
        public CD()
        { }
        public CD(int macd)
        {
            this.macd = macd;
        }
        public CD(int macd, string tuacd, string casi, int sobaihat, int dongia)
        {
            this.macd = macd;
            this.tuacd = tuacd;
            this.casi = casi;
            this.sobaihat = sobaihat;
            this.dongia = dongia;
        }
        //dinh nghia cac property (thay cho cac phuong thuc setter, getter)
        public int MaCD
        {
            set { this.macd = value; }
            get { return macd; }
        }
        public string TuaCD
        {
            set { this.tuacd = value; }
            get { return tuacd; }
        }
        public string CaSi
        {
            set { this.casi = value; }
            get { return casi; }
        }
        public int SoBaiHat
        {
            set { this.sobaihat = value; }
            get { return sobaihat; }
        }
        public int DonGia
        {
            set { this.dongia = value; }
            get { return dongia; }
        }
        public string ToString()
        {
            return string.Format("{0, 10} {1,30} {2,30} {3,10} {4, 15:#,##0}", macd,
            tuacd, casi, sobaihat, dongia);
        }
    }
}