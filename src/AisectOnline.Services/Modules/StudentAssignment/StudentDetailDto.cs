using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AisectOnline.Services.Modules.StudentAssignment
{
    public class StudentDetailDto
    {
        public int Id { get; set; }
        public int StudentID { get; set; }

        public string SKP_Id { get; set; }
        public string RegistrationNo { get; set; }
        public string Student_Name { get; set; }
        public string Father_Name { get; set; }
        public string Mother_Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string DistrictId { get; set; }
        public string StateId { get; set; }
        public string PinCode { get; set; }
        public string Zone { get; set; }
        public string DOB { get; set; }
        public string Gender { get; set; }
        public string Category { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string AadharNo { get; set; }
        public string Education { get; set; }
        public string Specialization { get; set; }
        public string Medium { get; set; }
        public string Board { get; set; }
        public string Year { get; set; }
        public string Division { get; set; }
        public string Project_Name { get; set; }
        public string Funded_By { get; set; }
        public string Assessment_Mode { get; set; }
        public string Project_FY { get; set; }
        public string Sector_Name { get; set; }
        public string Course_Code_QP_Code { get; set; }
        public string Course_Name { get; set; }
        public string Batch_Id { get; set; }
        public string Aisect_Entity { get; set; }
        public string Created_By { get; set; }
        public string Created_On { get; set; }
        public string LotNo { get; set; }

        public IList<StudentDetailDto> Liststudent { get; set; }

        
        public int? courseSelect { get; set; }
        public int? AssignmentType { get; set; }
        
        public List<CourseName> listcoursename { get; set; } = new List<CourseName>();

        public List<SubjectNamess> listSubjectName { get; set; } = new List<SubjectNamess>();

        public int? UniversitySelect { get; set; }
        public List<Servicess> listservice { get; set; }

        public int? CategorySelect { get; set; }
        public List<Categorys> listcategory { get; set; } = new List<Categorys>();
        public string GuardianName { get; set; }
        public string Placement { get; set; }
        public string StudentCertified { get; set; }
        public string StudentPlaced { get; set; }
        public string Student_Certified { get; set; }
        public string Student_Placed { get; set; }
        public string Guardian_Name { get; set; }
    }

    public class CourseName
    {
        public int CourseID { get; set; }
        public string Name { get; set; }
    }

    public class Servicess
    {
        public int KIOSKServiceID { get; set; }
        public string ServiceName { get; set; }
    }

    public class Categorys
    {
        public int CourseCategoryID { get; set; }
        public string CourseCategory { get; set; }
    }

    public class SubjectNamess
    {
        public int ExamPaperId { get; set; }
        public string Paper { get; set; }
        public string SessionId { get; set; }
        public string PracticalMax { get; set; }


    }

    public class std
    {
        public int StudentID { get; set; }
        public string FirstName { get; set; }
        public string RequestNo { get; set; }
        public string Name { get; set; }
    }
    public class students
    {
        public string StudentName { get; set; }
        public int StudentID { get; set; }

        public string RegistrationNo { get; set; }
        public string SchemeId { get; set; }
        public string SubjectName { get; set; }
        public string AssignmentMarks { get; set; }
        public string PracticalMarks { get; set; }
        public string KioskCode { get; set; }

        public string Course { get; set; }

        public int SessionId { get; set; }
        public string CreatedOn { get; set; }
        public string UpdatedOn { get; set; }

        public List<string> Courses { get; set; }
        public List<string> SubjectNames { get; set; }
        public List<string> Marks { get; set; }

        public string TypeAssignment { get; set; }

        //public string Coursess { get; set; }
        //public string SubjectNamess { get; set; }





    }
}
