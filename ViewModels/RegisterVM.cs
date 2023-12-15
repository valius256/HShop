using System.ComponentModel.DataAnnotations;

namespace HShop.ViewModels
{
    public class RegisterVM
    {
        [Key]
        [Display(Name = "Tên Đăng Nhập")]
        [Required(ErrorMessage = "*")]
        [MaxLength(20, ErrorMessage = "Toi Da 20 ki tu")]
        public string MaKh { get; set; }

        [Display(Name = "Mật Khẩu")]
        [Required(ErrorMessage = "*")]
        public string MatKhau { get; set; }

        [Display(Name = "Họ Tên")]
        [Required(ErrorMessage = "*")]
        [MaxLength(50, ErrorMessage = "Toi Da 50 ki tu")]
        public string HoTen { get; set; }

        public bool GioiTinh { get; set; } = true;

        [Display(Name = "Ngày Sinh")]
        [DataType(DataType.Date)]
        public DateTime? NgaySinh { get; set; }

        [Required(ErrorMessage = "*")]
        [Display(Name = "Địa Chỉ")]
        [MaxLength(60, ErrorMessage = "Toi Da 60 ki tu")]
        public string DiaChi { get; set; }

        [Display(Name = "Điện Thoại")]
        [MaxLength(24, ErrorMessage = "Toi Da 24 ki tu")]
        [Phone(ErrorMessage = "Chưa Đúng Định Dạng Số Điện Thoại")]
        public string? Phone { get; set; }



        [Display(Name = "Email")]
        [EmailAddress(ErrorMessage = "Chưa Đúng Định Dạng Email")]
        public string Email { get; set; }


        [Display(Name = "Hình")]
        public string? Hinh { get; set; }

    }
}
