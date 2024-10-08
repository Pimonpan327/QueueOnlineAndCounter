using System.ComponentModel.DataAnnotations;

namespace QMS.Models
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "กรุณากรอกรหัสบัตรประชาชน")]

        public string citizen_id_number { get; set; }
 

        [Required(ErrorMessage = "กรุณากรอกชื่อจริง")]

        public string firstname { get; set; }


        [Required(ErrorMessage = "กรุณากรอกนามสกุล")]

        public string lastname { get; set; }


        [Required(ErrorMessage = "กรุณากรอกอีเมล")]
        [EmailAddress(ErrorMessage = "รูปแบบอีเมลไม่ถูกต้อง")]

        public string user_email { get; set; }


        [Required(ErrorMessage = "กรุณากรอกเบอร์โทรศัพท์")]

        public string phone_number { get; set; }


        [Required(ErrorMessage = "กรุณากรอกรหัสผ่าน")]
        [MinLength(6, ErrorMessage = "รหัสผ่านต้องมีความยาวอย่างน้อย 6 ตัวอักษร")]

        public string password { get; set; }


        [Required(ErrorMessage = "กรุณายืนยันรหัสผ่าน")]
        [Compare("password", ErrorMessage = "รหัสผ่านไม่ตรงกัน")]

        public string confirm_password { get; set; }

    }

}
