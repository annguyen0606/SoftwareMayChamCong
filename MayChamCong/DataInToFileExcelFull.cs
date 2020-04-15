﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayChamCong
{
    public class DataInToFileExcelFull
    {
        private string maUID;
        private string hoTen;
        private string ngay;
        private string thoiGianCheckIn;
        private string thoiGianCheckOut;
        private string trangThaiDiLam;
        private string soPhutMuon;

        public string MaUID
        {
            get { return maUID; }
            set { maUID = value; }
        }
        public string Ten
        {
            get { return hoTen; }
            set { hoTen = value; }
        }
        public string Ngay
        {
            get { return ngay; }
            set { ngay = value; }
        }
        public string GioCheckIn
        {
            get { return thoiGianCheckIn; }
            set { thoiGianCheckIn = value; }
        }
        public string GioCheckOut
        {
            get { return thoiGianCheckOut; }
            set { thoiGianCheckOut = value; }
        }
        public string TrangThai
        {
            get { return trangThaiDiLam; }
            set { trangThaiDiLam = value; }
        }
        public string PhutMuon
        {
            get { return soPhutMuon; }
            set { soPhutMuon = value; }
        }
        public DataInToFileExcelFull(string UIDStaff, string NameStaff, string date, string timeIn, string timeOut, string trangThai, string phut)
        {
            this.MaUID = UIDStaff;
            this.Ten = NameStaff;
            this.Ngay = date;
            this.GioCheckIn = timeIn;
            this.GioCheckOut = timeOut;
            this.TrangThai = trangThai;
            this.PhutMuon = phut;
        }
    }
}
