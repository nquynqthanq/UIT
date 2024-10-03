using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class SanPhamBLL
    {
        SanPhamDAL dal = new SanPhamDAL();

        public void ThemSanPham(SanPhamDTO sp)
        {
            dal.ThemSanPham(sp);
        }

        public void SuaSanPham(SanPhamDTO sp)
        {
            dal.SuaSanPham(sp);
        }

        public void XoaSanPham(int maSanPham)
        {
            dal.XoaSanPham(maSanPham);
        }

        public void XoaSanPhamQuaHan()
        {
            dal.XoaTatCaSanPhamQuaHan();
        }

        public DataTable LayDanhSachSanPham()
        {
            return dal.LayDanhSachSanPham();
        }

        public DataTable LaySanPhamQuaHan()
        {
            return dal.LaySanPhamQuaHan();
        }

        public DataTable TimSanPhamDonGiaCaoNhat()
        {
            return dal.TimSanPhamDonGiaCaoNhat();
        }

        public DataTable TimSanPhamXuatXuNhatBan()
        {
            return dal.TimSanPhamXuatXuNhatBan();
        }

        public DataTable LaySanPhamTrongKhoangGia(decimal min, decimal max)
        {
            return dal.LaySanPhamTrongKhoangGia(min, max);
        }

        public bool KiemTraMaSanPhamTonTai(int MaSanPham)
        {
            return dal.KiemTraMaSanPhamTonTai(MaSanPham);
        }
    }

}
