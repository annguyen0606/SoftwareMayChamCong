using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayChamCong
{
    public class DuLieuLayTuThietBi
    {
        private string maUID;
        private string ngay;
        private string gio;

        public string MaUID
        {
            get { return maUID; }
            set { maUID = value; }
        }

        public string Ngay
        {
            get { return ngay; }
            set { ngay = value; }
        }
        public string Gio
        {
            get { return gio; }
            set { gio = value; }
        }

        public DuLieuLayTuThietBi(string UIDStaff, string date, string time)
        {
            this.MaUID = UIDStaff;
            this.Ngay = date;
            this.Gio = time;
        }
    }
}
