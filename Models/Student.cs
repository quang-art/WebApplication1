using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Student
    {
        [Required(ErrorMessage = "Vui lòng nhập MSSV")]
        public string MSSV { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập Họ tên")]
        public string HoTen { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập Điểm TB")]
        [Range(0, 10, ErrorMessage = "Điểm TB phải từ 0 đến 10")]
        public float DiemTB { get; set; }

        [Required(ErrorMessage = "Vui lòng chọn Chuyên ngành")]
        public string ChuyenNganh { get; set; }
    }
}