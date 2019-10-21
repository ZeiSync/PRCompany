using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PRCompany.Models
{

    public class Company
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Không được để trống trường này")]
        [Display(Name = "Tên công ty")]
        public string CompanyName { get; set; }

        [Required(ErrorMessage = "Không được để trống trường này")]
        [DataType(DataType.ImageUrl, ErrorMessage = "Url ảnh ko hợp lệ")]
        [Display(Name = "Ảnh")]
        public string CompanyImg { get; set; }

        [Required(ErrorMessage = "Không được để trống trường này")]
        public string Address { get; set; }

        public CompanyType  CompanyType { get; set; }

        [Required(ErrorMessage = "Không được để trống trường này")]
        [DataType(DataType.PhoneNumber, ErrorMessage = "Số điện thoại không hợp lệ")]
        [Display(Name = "Số điện thoại")]
        public string Contact { get; set; }

        [Required(ErrorMessage = "Không được để trống trường này")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Email không hợp lệ")]
        public string Email { get; set; }

        public string Website { get; set; }

        public IEnumerable<C_PL> C_PLs { get; set; }    
    }
}
