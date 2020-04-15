using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;

namespace MayChamCong
{
    public partial class Form1 : Form
    {
        UdpClient udpClien = null;
        IPEndPoint RemoteIP = null;
        String dataUID = "";
        String dirPath = "C:/SaveDataFromReader";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DuaNgayThangVaoComboBox();
            if(File.Exists(dirPath + "/test.txt"))
            {

            }
            else
            {
                Directory.CreateDirectory(dirPath);
                FileStream fs = new FileStream(dirPath + "/test.txt", FileMode.Create);
                fs.Close();
            }

            if (File.Exists(dirPath + "/data.txt"))
            {

            }
            else
            {
                Directory.CreateDirectory(dirPath);
                FileStream fs = new FileStream(dirPath + "/data.txt", FileMode.Create);
                fs.Close();
            }
            udpClien = new UdpClient(6688);
            try
            {
                udpClien.BeginReceive(new AsyncCallback(rev), null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void DuaNgayThangVaoComboBox()
        {
            DateTime myDate = DateTime.Now;
            String date = myDate.ToString("MM");
            String nam = myDate.ToString("yyyy");
            String thangNam = myDate.ToString("MM/yyyy");
            int thang = Int16.Parse(date);
            switch (thang)
            {
                case 1:
                    for(int i = 0; i < 31; i++)
                    {
                        cbDateOfMonth.Items.Add((i + 1).ToString() + "/" + thangNam);
                    }
                    break;
                case 2:
                    for (int i = 0; i < 29; i++)
                    {
                        cbDateOfMonth.Items.Add((i + 1).ToString() + "/" + thangNam);
                    }
                    break;
                case 3:
                    for (int i = 0; i < 31; i++)
                    {
                        cbDateOfMonth.Items.Add((i + 1).ToString() + "/" + thangNam);
                    }
                    break;
                case 4:
                    for (int i = 0; i < 30; i++)
                    {
                        cbDateOfMonth.Items.Add((i + 1).ToString() + "/" + thangNam);
                    }
                    break;
                case 5:
                    for (int i = 0; i < 31; i++)
                    {
                        cbDateOfMonth.Items.Add((i + 1).ToString() + "/" + thangNam);
                    }
                    break;
                case 6:
                    for (int i = 0; i < 30; i++)
                    {
                        cbDateOfMonth.Items.Add((i + 1).ToString() + "/" + thangNam);
                    }
                    break;
                case 7:
                    for (int i = 0; i < 31; i++)
                    {
                        cbDateOfMonth.Items.Add((i + 1).ToString() + "/" + thangNam);
                    }
                    break;
                case 8:
                    for (int i = 0; i < 31; i++)
                    {
                        cbDateOfMonth.Items.Add((i + 1).ToString() + "/" + thangNam);
                    }
                    break;
                case 9:
                    for (int i = 0; i < 30; i++)
                    {
                        cbDateOfMonth.Items.Add((i + 1).ToString() + "/" + thangNam);
                    }
                    break;
                case 10:
                    for (int i = 0; i < 31; i++)
                    {
                        cbDateOfMonth.Items.Add((i + 1).ToString() + "/" + thangNam);
                    }
                    break;
                case 11:
                    for (int i = 0; i < 30; i++)
                    {
                        cbDateOfMonth.Items.Add((i + 1).ToString() + "/" + thangNam);
                    }
                    break;
                case 12:
                    for (int i = 0; i < 31; i++)
                    {
                        cbDateOfMonth.Items.Add((i + 1).ToString() + "/" + thangNam);
                    }
                    break;
            }

      
        }
        public string GetDataFromUrl(string uri)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
            request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
            try
            {
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    using (Stream stream = response.GetResponseStream())
                    {
                        using (StreamReader reader = new StreamReader(stream))
                        {
                            return reader.ReadToEnd(); ;
                        }
                    }
                }
            }
            catch (WebException ex)
            {
                return "Server Failure";
            }
        }

        private void BtnGetData_Click(object sender, EventArgs e)
        {
            String url = "http://" + txbIpAddress.Text.ToString() + "/ngay";
            switch (cbDateOfMonth.SelectedIndex)
            {
                case -1:
                    MessageBox.Show("Bạn chưa chọn thời gian thống kê!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 0:
                    url += "01";
                    break;
                case 1:
                    url += "02";
                    break;
                case 2:
                    url += "03";
                    break;
                case 3:
                    url += "04";
                    break;
                case 4:
                    url += "05";
                    break;
                case 5:
                    url += "06";
                    break;
                case 6:
                    url += "07";
                    break;
                case 7:
                    url += "08";
                    break;
                case 8:
                    url += "09";
                    break;
                case 9:
                    url += "10";
                    break;
                case 10:
                    url += "11";
                    break;
                case 11:
                    url += "12";
                    break;
                case 12:
                    url += "13";
                    break;
                case 13:
                    url += "14";
                    break;
                case 14:
                    url += "15";
                    break;
                case 15:
                    url += "16";
                    break;
                case 16:
                    url += "17";
                    break;
                case 17:
                    url += "18";
                    break;
                case 18:
                    url += "19";
                    break;
                case 19:
                    url += "20";
                    break;
                case 20:
                    url += "21";
                    break;
                case 21:
                    url += "22";
                    break;
                case 22:
                    url += "23";
                    break;
                case 23:
                    url += "24";
                    break;
                case 24:
                    url += "25";
                    break;
                case 25:
                    url += "26";
                    break;
                case 26:
                    url += "27";
                    break;
                case 27:
                    url += "28";
                    break;
                case 28:
                    url += "29";
                    break;
                case 29:
                    url += "30";
                    break;
                case 30:
                    url += "31";
                    break;
            }
            //txbIpAddress.Enabled = false;
            ArrayList addDataClass = new ArrayList();
            if (!txbIpAddress.Text.Equals(""))
            {
                String duLieuChamCong = GetDataFromUrl(url);
                string[] dataChamCong = duLieuChamCong.Split(',');
                
                for (int i = 0; i < dataChamCong.Length - 1; i += 3)
                {
                    addDataClass.Add(new DuLieuLayTuThietBi(dataChamCong[i].ToString(), dataChamCong[i + 1].ToString(), dataChamCong[i + 2]));
                }
                ArrayList danhSachChuaCoTen = XuLyDuLieuDauVao(addDataClass);
                ArrayList danhSachCoSoDuLieu = LayDuLieuCSDL();
                ArrayList danhSachDayDu = new ArrayList();
                
                foreach (CoSoDuLieu item in danhSachCoSoDuLieu)
                {
                    bool kiemTraCoCheckInOutKhong = false;
                    foreach (DataInToFileExcelChuaCoTen item2 in danhSachChuaCoTen)
                    {
                        if (item.MaUID.ToString().Equals(item2.MaUID.ToString()))
                        {
                            kiemTraCoCheckInOutKhong = true;
                            danhSachDayDu.Add(new DataInToFileExcelFull("'" + item2.MaUID.ToString(), item.Ten.ToString(), item2.Ngay.ToString(),
                                item2.GioCheckIn.ToString(), item2.GioCheckOut.ToString(), item2.TrangThai.ToString(),item2.PhutMuon.ToString()));
                        }
                        else
                        {
                        }
                    }
                    if(kiemTraCoCheckInOutKhong == false)
                    {
                        danhSachDayDu.Add(new DataInToFileExcelFull("'" + item.MaUID.ToString(), item.Ten.ToString(), cbDateOfMonth.Text.ToString(),
                            "", "", "Không Check In / Check Out",""));
                    }
                    
                }
                DuaVaoFileExcel(danhSachDayDu);
            }
            else
            {
            }
        }
        ArrayList LayDuLieuCSDL()
        {
            ArrayList CoSoDuLieu = new ArrayList();
            try
            {
                using (StreamReader streamreader = new StreamReader(dirPath + "/test.txt"))
                {
                    string[] lines = File.ReadAllLines(dirPath + "/test.txt");
                    streamreader.Close();
                    for (int i = 0; i < lines.Length; i++)
                    {
                        string[] duLieuStaff = lines[i].Split(',');
                        CoSoDuLieu.Add(new CoSoDuLieu(duLieuStaff[0].ToString(), duLieuStaff[1].ToString()));
                    }
                }
            }
            catch (Exception ex) { }
            return CoSoDuLieu;
        }
        ArrayList XuLyDuLieuDauVao(ArrayList arrayList)
        {
            ArrayList addDataClass = new ArrayList();
            foreach (DuLieuLayTuThietBi item in arrayList)
            {
                string statusGo = "";
                if (!item.MaUID.ToString().Equals(""))
                {
                    string timeIn = "";
                    string timeOut = "";
                    string thoiGianMuon = "";
                    int countSoLanTonTai = 0;
                    //Lay trang thai
                    foreach (DuLieuLayTuThietBi item2 in arrayList)
                    {
                        if (item.MaUID.ToString().Equals(item2.MaUID.ToString()))
                        {
                            countSoLanTonTai++;
                            if (countSoLanTonTai == 1)
                            {
                                timeIn = item.Gio.ToString();
                                string[] thoigian = timeIn.Split(':');
                                if (Int16.Parse(thoigian[0].ToString()) >= 8 && Int16.Parse(thoigian[1].ToString()) > 30 && Int16.Parse(thoigian[0].ToString()) < 12)
                                {
                                    int timeLate = (Int16.Parse(thoigian[0].ToString()) - 8)*60 + (Int16.Parse(thoigian[1].ToString()) - 30);
                                    thoiGianMuon = timeLate.ToString();
                                    statusGo += "Đi muộn ";
                                }
                                else if (Int16.Parse(thoigian[0].ToString()) > 8 && Int16.Parse(thoigian[0].ToString()) < 12)
                                {
                                    int timeLate = (Int16.Parse(thoigian[0].ToString()) - 8)*60 + (Int16.Parse(thoigian[1].ToString()) - 30);
                                    thoiGianMuon = timeLate.ToString();
                                    statusGo += "Đi muộn ";
                                }
                                else if (Int16.Parse(thoigian[0].ToString()) >= 13 && Int16.Parse(thoigian[1].ToString()) > 30)
                                {
                                    int timeLate = (Int16.Parse(thoigian[0].ToString()) - 13)*60 + (Int16.Parse(thoigian[1].ToString()) - 30);
                                    thoiGianMuon = timeLate.ToString();
                                    statusGo += "Đi muộn ";
                                }
                                else if (Int16.Parse(thoigian[0].ToString()) > 13 && Int16.Parse(thoigian[0].ToString()) < 18)
                                {
                                    int timeLate = (Int16.Parse(thoigian[0].ToString()) - 13) * 60 + (Int16.Parse(thoigian[1].ToString()) - 30);
                                    statusGo += "Đi muộn ";
                                    thoiGianMuon = timeLate.ToString();
                                }
                            }
                            if (countSoLanTonTai > 1)
                            {
                                timeOut = item2.Gio.ToString();
                            }
                            
                        }
                    }
                    if(countSoLanTonTai == 1)
                    {
                        string[] thoigian = timeIn.Split(':');
                        if (Int16.Parse(thoigian[0].ToString()) < 18)
                        {
                            statusGo += "Không Check OUT";
                        }
                        else
                        {
                            timeOut = timeIn;
                            timeIn = "";
                            statusGo += " Không Check IN";
                        }
                        if(Int16.Parse(thoigian[0].ToString()) > 8)
                        {

                        }
                    }
                    //Lay du lieu duy nhat
                    bool kiemTraSuTonTai = false;
                    foreach(DataInToFileExcelChuaCoTen item3 in addDataClass)
                    {
                        if (item.MaUID.ToString().Equals(item3.MaUID.ToString())){
                            kiemTraSuTonTai = true;
                        }
                    }
                    if(kiemTraSuTonTai == false)
                    {
                        addDataClass.Add(new DataInToFileExcelChuaCoTen(item.MaUID.ToString(), item.Ngay.ToString(), timeIn, timeOut, statusGo,thoiGianMuon));
                    }
                }
            }
            return addDataClass;
        }
        void DuaVaoFileExcel(ArrayList arrayList)
        {
            Microsoft.Office.Interop.Excel.Application cExcel = new Microsoft.Office.Interop.Excel.Application();
            cExcel.Application.Workbooks.Add(Type.Missing);
            cExcel.Cells[1, 1] = "UID";
            cExcel.Cells[1, 2] = "Họ Tên";
            cExcel.Cells[1, 3] = "Ngày";
            cExcel.Cells[1, 4] = "CheckIn";
            cExcel.Cells[1, 5] = "CheckOut";
            cExcel.Cells[1, 6] = "Trạng thái";
            cExcel.Cells[1, 7] = "Số phút";
            int i = 2;
            foreach(DataInToFileExcelFull item in arrayList)
            {
                cExcel.Cells[i, 1] = item.MaUID.ToString();
                cExcel.Cells[i, 2] = item.Ten.ToString();
                cExcel.Cells[i, 3] = item.Ngay.ToString();
                cExcel.Cells[i, 4] = item.GioCheckIn.ToString();
                cExcel.Cells[i, 5] = item.GioCheckOut.ToString();
                cExcel.Cells[i, 6] = item.TrangThai.ToString();
                cExcel.Cells[i, 7] = item.PhutMuon.ToString();
                i++;
            }
            
            cExcel.Columns.AutoFit();
            cExcel.Visible = true;
        }
        void rev(IAsyncResult res)
        {
            try
            {   //Receive data
                RemoteIP = new IPEndPoint(IPAddress.Any, 0);
                byte[] received = udpClien.EndReceive(res, ref RemoteIP);
                dataUID = Encoding.UTF8.GetString(received);
                this.Invoke(new EventHandler(ShowData));
            }
            catch (ObjectDisposedException)
            {
                return;
            }

            udpClien.BeginReceive(new AsyncCallback(rev), null);
        }

        private void ShowData(object sender, EventArgs e)
        {
            txtUID.Text = dataUID;
        }
       
        private void BtnRegistration_Click(object sender, EventArgs e)
        {
            if (txtUID.Text.Equals("") || txtNameStaff.Text.Equals(""))
            {
                MessageBox.Show("Chưa chạm thẻ hoặc chưa nhập tên","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                ArrayList danhSachDaDangKy = new ArrayList();
                danhSachDaDangKy = LayDuLieuCSDL();
                bool kiemTraDaDangKyChua = false;
                foreach(CoSoDuLieu item in danhSachDaDangKy)
                {
                    if (item.MaUID.ToString().Equals(txtUID.Text.ToString()))
                    {
                        kiemTraDaDangKyChua = true;
                    }
                }
                if(kiemTraDaDangKyChua == false)
                {
                    if (File.Exists(dirPath + "/test.txt"))
                    {
                        using (StreamWriter sw = File.AppendText(dirPath + "/test.txt"))
                        {
                            sw.WriteLine(txtUID.Text + "," + txtNameStaff.Text);
                            sw.Close();
                        }
                    }
                    else
                    {
                        using (StreamWriter sw = new StreamWriter(dirPath + "/test.txt"))
                        {
                            sw.WriteLine(txtUID.Text + "," + txtNameStaff.Text);
                            sw.Close();
                        }
                    }
                    txtUID.Text = "";
                    txtNameStaff.Text = "";
                }
                else
                {
                    MessageBox.Show("Thẻ đã đăng ký rồi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
        }

        private void BtnThongKeMonth_Click(object sender, EventArgs e)
        {
            for (int k = 1; k < 31; k++)
            {
                DateTime myDate = DateTime.Now;
                String date = myDate.ToString("MM/yyyy");
                String dateYear = myDate.ToString("yyyy");
                String dateMonth = myDate.ToString("MM");
                String ngayThang = dateMonth+"/"+(k).ToString() +"/"+dateYear;
                String url = "http://" + txbIpAddress.Text.ToString() + "/ngay";
                if (k < 10)
                {
                    url += "0" + k.ToString();
                }
                else
                {
                    url += k.ToString();
                }
                ArrayList addDataClass = new ArrayList();
                if (!txbIpAddress.Text.Equals(""))
                {
                    String duLieuChamCong = GetDataFromUrl(url);
                    if (!duLieuChamCong.Trim().Equals(""))
                    {
                        string[] dataChamCong = duLieuChamCong.Split(',');

                        for (int i = 0; i < dataChamCong.Length - 1; i += 3)
                        {
                            addDataClass.Add(new DuLieuLayTuThietBi(dataChamCong[i].ToString(), dataChamCong[i + 1].ToString(), dataChamCong[i + 2]));
                        }
                        ArrayList danhSachChuaCoTen = XuLyDuLieuDauVao(addDataClass);
                        ArrayList danhSachCoSoDuLieu = LayDuLieuCSDL();
                        ArrayList danhSachDayDu = new ArrayList();

                        foreach (CoSoDuLieu item in danhSachCoSoDuLieu)
                        {
                            bool kiemTraCoCheckInOutKhong = false;
                            foreach (DataInToFileExcelChuaCoTen item2 in danhSachChuaCoTen)
                            {
                                if (item.MaUID.ToString().Equals(item2.MaUID.ToString()))
                                {
                                    kiemTraCoCheckInOutKhong = true;
                                    danhSachDayDu.Add(new DataInToFileExcelFull("'" + item2.MaUID.ToString(), item.Ten.ToString(), item2.Ngay.ToString(),
                                        item2.GioCheckIn.ToString(), item2.GioCheckOut.ToString(), item2.TrangThai.ToString(), item2.PhutMuon.ToString()));
                                }
                                else
                                {
                                }
                            }
                            if (kiemTraCoCheckInOutKhong == false)
                            {
                                danhSachDayDu.Add(new DataInToFileExcelFull("'" + item.MaUID.ToString(), item.Ten.ToString(), ngayThang,
                                    "", "", "Không Check In / Check Out", ""));
                            }
                        }
                        foreach (DataInToFileExcelFull item5 in danhSachDayDu)
                        {
                            if (File.Exists(dirPath + "/data.txt"))
                            {
                                using (StreamWriter sw = File.AppendText(dirPath + "/data.txt"))
                                {
                                    sw.WriteLine(item5.MaUID.ToString() + "," + item5.Ten.ToString() + ","
                                        + item5.Ngay.ToString() + "," + item5.GioCheckIn.ToString() + ","
                                        + item5.GioCheckOut.ToString() + "," + item5.TrangThai.ToString() + "," + item5.PhutMuon.ToString());
                                    sw.Close();
                                }
                            }
                            else
                            {

                            }
                        }
                    }
                    else
                    {

                    }
                }
                else
                {
                    MessageBox.Show("Bạn chưa nhập địa chỉ IP!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                }

            }
            DuaVaoFileExcel(ThongKeCaThang());
            File.WriteAllText(dirPath + "/data.txt", string.Empty);
        }

        

        ArrayList ThongKeCaThang()
        {
            ArrayList CoSoDuLieu = new ArrayList();
            try
            {
                using (StreamReader streamreader = new StreamReader(dirPath + "/data.txt"))
                {
                    string[] lines = File.ReadAllLines(dirPath + "/data.txt");
                    streamreader.Close();
                    for (int i = 0; i < lines.Length; i++)
                    {
                        string[] duLieuStaff = lines[i].Split(',');
                        CoSoDuLieu.Add(new DataInToFileExcelFull(duLieuStaff[0].ToString(), duLieuStaff[1].ToString(),duLieuStaff[2].ToString(),
                            duLieuStaff[3].ToString(),duLieuStaff[4].ToString(),duLieuStaff[5].ToString(),duLieuStaff[6].ToString()));
                    }
                }
            }
            catch (Exception ex) { }
            return CoSoDuLieu;
        }
    }
}
