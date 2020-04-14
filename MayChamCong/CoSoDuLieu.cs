using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayChamCong
{
    public class CoSoDuLieu
    {
        private string maUID;
        private string hoTen;

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

        public CoSoDuLieu(string UIDStaff, string nameStaff)
        {
            this.MaUID = UIDStaff;
            this.Ten = nameStaff;
        }
    }
}
