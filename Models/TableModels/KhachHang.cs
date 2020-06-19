using System;
using System.ComponentModel.DataAnnotations;

namespace Models.TableModels
{
    public class KhachHang
    {
        [Key]
        public long? Id { get; set; }
        public string HoTen { get; set; }
        public DateTime? NgaySinh { get; set; }
        public short? GioiTinh { get; set; }
        [Required]
        [StringLength(20)]
        public string CMND { get; set; }
        [Required]
        [StringLength(10)]
        public string MaDatNuoc { get; set; }
        [Required]
        [StringLength(10)]
        public string MaThanhPho { get; set; }
        [Required]
        [StringLength(10)]
        public string MaQuanHuyen { get; set; }
        [Required]
        [StringLength(10)]
        public string MaPhuongXa { get; set; }
        [Required]
        [StringLength(500)]
        public string DiaChi { get; set; }
        public string CreateDateTime { get; set; }
        public string Status { get; set; }
    }
}