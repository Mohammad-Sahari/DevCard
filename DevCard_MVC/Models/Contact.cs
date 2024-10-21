using System.ComponentModel.DataAnnotations;

namespace DevCard_MVC.Models
{
    public class Contact
    {
        [Required(ErrorMessage = "این فیلد اجباری می باشد")]
        [MinLength(3, ErrorMessage = "حداقل طول نام 3 کاراکتر می باشد")]
        [MaxLength(100, ErrorMessage = "حداکثر طول نام 100 کاراکتر می باشد")]
        public string Name { get; set; }
        [EmailAddress(ErrorMessage = "مقدار وارد شده ایمیل صحیح نمی باشد")]
        [Required(ErrorMessage = "این فیلد اجباری می باشد")]
        public string Email { get; set; }
        public string Message { get; set; }
        public string Service { get; set; }

    }
}
