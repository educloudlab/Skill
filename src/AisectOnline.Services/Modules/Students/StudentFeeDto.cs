using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Net.Mail;
using System.Net.NetworkInformation;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace AisectOnline.Services.Modules.Students
{
    
    public class StudentFeeDto
    {
        public long? Seq_No { get; set; }             
        public string? RequestNo { get; set; }
        public Int32? StudentID { get; set; }             
        public string? StudentName { get; set; }
        public string? FatherName { get; set; }
        public Int32? CourseID { get; set; }             
        public string? CourseName { get; set; }
        public Int32? ProgrammeID { get; set; }           
        public string? ProgrammeName { get; set; }
        public string? FeeType { get; set; }
        public byte? Month { get; set; }                  
        public decimal? Fee { get; set; }
        public decimal? LateFee { get; set; }
        public decimal? TotalFee { get; set; }
        public decimal? ServiceTax { get; set; }
        public string? SessionName { get; set; }
        public Int32? SessionID { get; set; }
        public string? EmailAddress { get; set; }
        [Key]
        public Int32? StudentCourseFeeID { get; set; }  
        public Int32? ServiceID { get; set; }
        public string? MobileNo { get; set; }
        public string? Scheme { get; set; }
        public string? ProspectusNo { get; set; }
        public string? OfflineBranchcode { get; set; }
    }


}
