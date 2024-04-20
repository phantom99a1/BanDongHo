using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BanDongHo.Domain.DataContext;

namespace BanDongHo.Areas.Admin.Models
{
    public class OrderViewModel
    {
        public List<DONHANG> ListOrder { get; set; }
        public List<CHITIETDONHANG> ListOrderDetail { get; set; }
        public List<SANPHAM> ListProduct { get; set; }
        public int TotalPage { get; set; }

        public int mahd { get; set; }
        public int makh { get; set; }
        public string tennguoinhan { get; set; }
        public string sodt { get; set; }
        public string diachi { get; set; }
        public string ngaymua { get; set; }
        public string ngaygiao { get; set; }
        public string tinhtrang { get; set; }
        public int[] mangmasp { get; set; }
        public int[] mangsoluong { get; set; }
        public string[] mangtensp { get; set; }
    }
}