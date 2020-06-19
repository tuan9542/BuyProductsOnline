using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Models.TableModels
{
    public class Product
    {
        public long? Id { get; set; }
        public string MaSanPham { get; set; }
        public string TenSanPham { get; set; }
        public string HangSanXuat { get; set; }
        public string ThongTin { get; set; }
        public short? Status { get; set; }
        public DateTime? CreateDateTime { get; set; }
    }
}