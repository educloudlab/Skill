using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AisectOnline.Services.Modules.Common.CommonDTO;

namespace AisectOnline.Services.Modules.Accounts
{
    public class LogOnModel
    {
        [Display(Name = "User ID")]
        public int UserID { get; set; }

        [Required]
        [Display(Name = "User name")]
        public string UserName { get; set; }
        //[Required]
        //[Display(Name = "User name")]

        public string UserFullName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }


        [Display(Name = "User Type")]
        public int? UserTypeID { get; set; }

        public IEnumerable<UserType> UserTypes { get; set; }

        [Display(Name = "access level")]
        public Int32 AccessLevel { get; set; }

        //[RegularExpression("[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?", ErrorMessage = "Not a valid E-Mail Id/ Reference ID")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Display(Name = "Role")]
        public string Role { get; set; }

        [Display(Name = "CustomerID")]
        public Int32 CustomerID { get; set; }

        public string LoginID { get; set; }

        public int KioskID { get; set; }

        public string strKioskID { get; set; }

        [Display(Name = "ChildRole")]
        public string ChildRole { get; set; }

        public string status { get; set; }

        public string LastName { get; set; }
        public string PANNo { get; set; }
        public string Aadhar { get; set; }
        public string Mobile { get; set; }
        public string Zip { get; set; }
        public string Remarks { get; set; }
    }
    public class UserType
    {
        public int? TypeID { get; set; }
        public string TypeName { get; set; }
    }

    public class IndexViewModel
    {
        public IList<DropDownInfo> RadioList { get; set; }

        [Required(ErrorMessage = "You must select an a kiosk")]
        public String TestRadio { get; set; }
        public String TestRadio2 { get; set; }
        //
        public string comment1 { get; set; }
        public string comment2 { get; set; }
        public string comment3 { get; set; }
        public string comment4 { get; set; }
        public string comment5 { get; set; }

    }
}
