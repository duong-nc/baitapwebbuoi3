using System.ComponentModel.DataAnnotations;

namespace WebApplication3.Models
{
    public class Student
    {
        [Required(ErrorMessage = "MSSV là bắt buộc.")]
        public string MSSV { get; set; }

        [Required(ErrorMessage = "Họ tên là bắt buộc.")]
        public string HoTen { get; set; }

        [Range(0, 10, ErrorMessage = "Điểm TB phải nằm trong khoảng 0 - 10.")]
        public double DiemTB { get; set; }

        [Required(ErrorMessage = "Vui lòng chọn chuyên ngành.")]
        public string ChuyenNganh { get; set; }
    }
}
