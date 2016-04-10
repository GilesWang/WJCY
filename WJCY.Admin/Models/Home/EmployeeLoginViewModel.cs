using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WJCY.Admin.Models.Home
{
    public class EmployeeLoginViewModel
    {
        [Required(ErrorMessage = "用户名必填")]
        [Display(Name = "用户名")]
        public int EmployeeNo { get; set; }
        [Required(ErrorMessage = "密码必填")]
        [Display(Name = "密码")]
        public string pwd { get; set; }
    }
}
