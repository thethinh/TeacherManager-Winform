using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;


namespace GUI
{
    public partial class FormChiTietNhanLuc : Form
    {
        public FormChiTietNhanLuc()
        {
            InitializeComponent();
        }

       

        private void comboboxNam_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Nam = comboboxNam.SelectedItem.ToString();
            //Hiển thị nhân lực ban chủ nhiệm khoa
            NhanLucKhoaBLL nlkbll = new NhanLucKhoaBLL();
            List<ThongTinNhanLuc> nlKhoa = nlkbll.HienThiNhanLucKhoa(Nam);
            listViewCNKhoa.Items.Clear();
            foreach (ThongTinNhanLuc nlbcnk in nlKhoa)
            {
                
                ListViewItem lvi = new ListViewItem(nlbcnk.MaGV + "");
                lvi.SubItems.Add(nlbcnk.TenGV);
                lvi.SubItems.Add(nlbcnk.TenChucVu);
                lvi.SubItems.Add(nlbcnk.TenHocHam);
                lvi.SubItems.Add(nlbcnk.TenHocVi);
                
                listViewCNKhoa.Items.Add(lvi);  
            }

            NhanLucBMBLL nlbmbll = new NhanLucBMBLL();

            //Hiển thị nhân lực bộ môn CNPM
            List<ThongTinNhanLuc> nlbmcnpm = nlbmbll.HienThiNhanLucBM(Nam, "BM01");
            listViewCNPM.Items.Clear();
            foreach (ThongTinNhanLuc item in nlbmcnpm)
            {
               
                ListViewItem lvi = new ListViewItem(item.MaGV+ "");
                lvi.SubItems.Add(item.TenGV);
                lvi.SubItems.Add(item.TenChucVu);
                lvi.SubItems.Add(item.TenHocHam);
                lvi.SubItems.Add(item.TenHocVi);
                lvi.SubItems.Add(item.MaGV);

                listViewCNPM.Items.Add(lvi);
            }

            //Hiển thị nhân lực bộ môn CNTT
            List<ThongTinNhanLuc> nlbmcntt = nlbmbll.HienThiNhanLucBM(Nam, "BM03");
            listViewCNTT.Items.Clear();
            foreach (ThongTinNhanLuc item in nlbmcntt)
            {
                
                ListViewItem lvi = new ListViewItem(item.MaGV + "");
                lvi.SubItems.Add(item.TenGV);
                lvi.SubItems.Add(item.TenChucVu);
                lvi.SubItems.Add(item.TenHocHam);
                lvi.SubItems.Add(item.TenHocVi);
                lvi.SubItems.Add(item.MaGV);

                listViewCNTT.Items.Add(lvi);
            }

            //Hiển thị nhân lực bộ môn HTTT
            List<ThongTinNhanLuc> nlbmhttt = nlbmbll.HienThiNhanLucBM(Nam, "BM04");
            listViewHTTT.Items.Clear();
            foreach (ThongTinNhanLuc item in nlbmhttt)
            {

                ListViewItem lvi = new ListViewItem(item.MaGV + "");
                lvi.SubItems.Add(item.TenGV);
                lvi.SubItems.Add(item.TenChucVu);
                lvi.SubItems.Add(item.TenHocHam);
                lvi.SubItems.Add(item.TenHocVi);
                lvi.SubItems.Add(item.MaGV);

                listViewHTTT.Items.Add(lvi);
            }

            //Hiển thị nhân lực bộ môn KHMT
            List<ThongTinNhanLuc> nlKHMT = nlbmbll.HienThiNhanLucBM(Nam, "BM02");
            listViewKHMT.Items.Clear();
            foreach (ThongTinNhanLuc item in nlKHMT)
            {
               
                ListViewItem lvi = new ListViewItem(item.MaGV+ "");
                lvi.SubItems.Add(item.TenGV);
                lvi.SubItems.Add(item.TenChucVu);
                lvi.SubItems.Add(item.TenHocHam);
                lvi.SubItems.Add(item.TenHocVi);
                lvi.SubItems.Add(item.MaGV);

                listViewKHMT.Items.Add(lvi);
            }

            //Hiển thị nhân lực bộ môn ATTT
            List<ThongTinNhanLuc> nlATTT = nlbmbll.HienThiNhanLucBM(Nam, "BM05");
            listViewATTT.Items.Clear();
            foreach (ThongTinNhanLuc item in nlATTT)
            {

                ListViewItem lvi = new ListViewItem(item.MaGV + "");
                lvi.SubItems.Add(item.TenGV);
                lvi.SubItems.Add(item.TenChucVu);
                lvi.SubItems.Add(item.TenHocHam);
                lvi.SubItems.Add(item.TenHocVi);
                lvi.SubItems.Add(item.MaGV);

                listViewATTT.Items.Add(lvi);
            }
        }

        private void ltvCNKhoa_MouseClick(object sender, MouseEventArgs e)
        {
            string Nam1 = comboboxNam.SelectedItem.ToString();
            string magv = listViewCNKhoa.SelectedItems[0].Text;

            
            
            FormLyLichCaNhan llCaNhan = new FormLyLichCaNhan();
            llCaNhan.HienThiTTCNK(magv, Nam1);
            llCaNhan.HienThiHH(Nam1, magv);
            llCaNhan.HienThiHV(Nam1, magv);
            llCaNhan.SoLATSdaHD(magv, Nam1);
            llCaNhan.SoLATSdangHD(magv, Nam1);
            llCaNhan.SoLVCHdaHD(magv, Nam1);
            llCaNhan.ChiTietLATS(magv, Nam1);
            llCaNhan.ChiTietLVCH(magv, Nam1);
            llCaNhan.HienThiDetailHPGD(magv, Nam1);
            llCaNhan.HienThiHHFull(magv, Nam1);
            llCaNhan.HienThiHVFull(magv, Nam1);
            llCaNhan.HienThiSachCK(magv, Nam1);
            llCaNhan.HienThiSachGT(magv, Nam1);
            llCaNhan.HienThiTLKhac(magv, Nam1);
            llCaNhan.HienThiAllBB(magv, Nam1);
            llCaNhan.HienThiSoBBQuocTe(magv, Nam1);
            llCaNhan.HienThiSoBBTrongNuoc(magv, Nam1);
            llCaNhan.ShowDialog();

        }

        private void ltvCNPM_MouseClick(object sender, MouseEventArgs e)
        {
            string Nam1 = comboboxNam.SelectedItem.ToString();
            string magv = listViewCNPM.SelectedItems[0].Text;

            FormLyLichCaNhan llCaNhan = new FormLyLichCaNhan();
            llCaNhan.HienThiTTGVBM(magv, Nam1);
            llCaNhan.HienThiHH(Nam1, magv);
            llCaNhan.SoLATSdaHD(magv, Nam1);
            llCaNhan.SoLATSdangHD(magv, Nam1);
            llCaNhan.ChiTietLATS(magv, Nam1);
            llCaNhan.ChiTietLVCH(magv, Nam1);
            llCaNhan.SoLVCHdaHD(magv, Nam1);
            llCaNhan.HienThiSachCK(magv, Nam1);
            llCaNhan.HienThiSachGT(magv, Nam1);
            llCaNhan.HienThiTLKhac(magv, Nam1);
            llCaNhan.HienThiAllBB(magv, Nam1);
            llCaNhan.HienThiHV(Nam1, magv);
            llCaNhan.HienThiSoBBQuocTe(magv, Nam1);
            llCaNhan.HienThiSoBBTrongNuoc(magv, Nam1);
            llCaNhan.HienThiHHFull(magv, Nam1);
            llCaNhan.HienThiHVFull(magv, Nam1);
            llCaNhan.HienThiDetailHPGD(magv, Nam1);
            llCaNhan.ShowDialog();
        }

        private void ltvKHMT_MouseClick(object sender, MouseEventArgs e)
        {
            string Nam1 = comboboxNam.SelectedItem.ToString();
            string magv = listViewKHMT.SelectedItems[0].Text;

            FormLyLichCaNhan llCaNhan = new FormLyLichCaNhan();
            llCaNhan.HienThiTTGVBM(magv, Nam1);
            llCaNhan.HienThiHH(Nam1, magv);
            llCaNhan.HienThiHV(Nam1, magv);
            llCaNhan.SoLATSdaHD(magv, Nam1);
            llCaNhan.SoLATSdangHD(magv, Nam1);
            llCaNhan.HienThiSoBBQuocTe(magv, Nam1);
            llCaNhan.HienThiSoBBTrongNuoc(magv, Nam1);
            llCaNhan.HienThiHHFull(magv, Nam1);
            llCaNhan.HienThiHVFull(magv, Nam1);
            llCaNhan.ChiTietLVCH(magv, Nam1);
            llCaNhan.HienThiSachCK(magv, Nam1);
            llCaNhan.HienThiAllBB(magv, Nam1);
            llCaNhan.HienThiSachGT(magv, Nam1);
            llCaNhan.HienThiTLKhac(magv, Nam1);
            llCaNhan.ChiTietLATS(magv, Nam1);
            llCaNhan.SoLVCHdaHD(magv, Nam1);

            llCaNhan.HienThiDetailHPGD(magv, Nam1);
            llCaNhan.ShowDialog();
        }

        private void ltvCNTT_MouseClick(object sender, MouseEventArgs e)
        {
            string nam1 = comboboxNam.SelectedItem.ToString();
            string magv = listViewCNTT.SelectedItems[0].Text;

            FormLyLichCaNhan llcanhan = new FormLyLichCaNhan();
            llcanhan.HienThiHH(nam1, magv);
            llcanhan.HienThiTTGVBM(magv, nam1);
            llcanhan.SoLATSdangHD(magv, nam1);
            llcanhan.HienThiHV(nam1, magv);
            llcanhan.ChiTietLATS(magv, nam1);
            llcanhan.ChiTietLVCH(magv, nam1);
            llcanhan.SoLATSdaHD(magv, nam1);
            llcanhan.HienThiSachCK(magv, nam1);
            llcanhan.HienThiSoBBQuocTe(magv, nam1);
            llcanhan.HienThiSoBBTrongNuoc(magv, nam1);
            llcanhan.HienThiHHFull(magv, nam1);
            llcanhan.HienThiHVFull(magv, nam1);
            llcanhan.HienThiSachGT(magv, nam1);
            llcanhan.HienThiAllBB(magv, nam1);
            llcanhan.HienThiTLKhac(magv, nam1);
            llcanhan.SoLVCHdaHD(magv, nam1);
            llcanhan.HienThiDetailHPGD(magv, nam1);
            llcanhan.ShowDialog();
        }

        private void ltvHTTT_MouseClick(object sender, MouseEventArgs e)
        {
            string Nam1 = comboboxNam.SelectedItem.ToString();
            string magv = listViewHTTT.SelectedItems[0].Text;

            FormLyLichCaNhan llCaNhan = new FormLyLichCaNhan();
            llCaNhan.HienThiTTGVBM(magv, Nam1);
            llCaNhan.HienThiHH(Nam1, magv);
            llCaNhan.HienThiHV(Nam1, magv);
            llCaNhan.SoLATSdaHD(magv, Nam1);
            llCaNhan.ChiTietLVCH(magv, Nam1);
            llCaNhan.SoLATSdangHD(magv, Nam1);
            llCaNhan.ChiTietLATS(magv, Nam1);
            llCaNhan.HienThiSachGT(magv, Nam1);
            llCaNhan.HienThiSoBBQuocTe(magv, Nam1);
            llCaNhan.HienThiSoBBTrongNuoc(magv, Nam1);
            llCaNhan.HienThiHHFull(magv, Nam1);
            llCaNhan.HienThiHVFull(magv, Nam1);
            llCaNhan.HienThiAllBB(magv, Nam1);
            llCaNhan.HienThiTLKhac(magv, Nam1);
            llCaNhan.HienThiSachCK(magv, Nam1);
            llCaNhan.SoLVCHdaHD(magv, Nam1);
            llCaNhan.HienThiDetailHPGD(magv, Nam1);
            llCaNhan.ShowDialog();
        }

        private void ltvATTT_MouseClick(object sender, MouseEventArgs e)
        {
            string Nam1 = comboboxNam.SelectedItem.ToString();
            string magv = listViewATTT.SelectedItems[0].Text;

            FormLyLichCaNhan llCaNhan = new FormLyLichCaNhan();
            llCaNhan.HienThiTTGVBM(magv, Nam1);
            llCaNhan.HienThiHH(Nam1, magv);
            llCaNhan.SoLATSdaHD(magv, Nam1);
            llCaNhan.SoLATSdangHD(magv, Nam1);
            llCaNhan.ChiTietLVCH(magv, Nam1);
            llCaNhan.ChiTietLATS(magv, Nam1);
            llCaNhan.HienThiDetailHPGD(magv, Nam1);
            llCaNhan.SoLVCHdaHD(magv, Nam1);
            llCaNhan.HienThiAllBB(magv, Nam1);
            llCaNhan.HienThiSachCK(magv, Nam1);
            llCaNhan.HienThiSachGT(magv, Nam1);
            llCaNhan.HienThiTLKhac(magv, Nam1);
            llCaNhan.HienThiSoBBQuocTe(magv, Nam1);
            llCaNhan.HienThiSoBBTrongNuoc(magv, Nam1);
            llCaNhan.HienThiHHFull(magv, Nam1);
            llCaNhan.HienThiHVFull(magv, Nam1);
            llCaNhan.HienThiHV(Nam1, magv);
            llCaNhan.ShowDialog();
        }

        

        public void showNam(string nam)
        {
            comboboxNam.Text = nam;
        }

        public void showTen(string ten)
        {
            lblTenKhoa.Text = "Chi tiết khoa "+ten ;
        }

        
    }
}
