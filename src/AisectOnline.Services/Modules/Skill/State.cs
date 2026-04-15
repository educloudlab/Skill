using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AisectOnline.Services.Modules.Skill
{
    public class State
    {
        public int StateID { get; set; }
        public string StateName { get; set; }
    }

    public class Zone
    {
        public int ZoneId { get; set; }
        public string ZoneName { get; set; }
    }

    public class Sectors
    {
        public int Id { get; set; }
        public string Sector { get; set; }
    }


    public class Education
    {
        public int Id { get; set; }
        public string Qualification { get; set; }
    }

    public class District
    {
        public int DistrictId { get; set; }
        public string DistrictName { get; set; }
        public int StateId { get; set; } // Foreign key
    }

    public class SKP
    {
        public int DistrictId { get; set; }
        public int KIOSKID { get; set; }
        public String KioskCode { get; set; } // Foreign key
    }

    public class Kiosk
    {
        public int KIOSKID { get; set; }
        public string KioskCode { get; set; }
    }


    public class StudentDeatils
    {
        public string SKP_Id { get; set; }
        public int StateId { get; set; }
        public int DistrictId { get; set; }
        public int result1 { get; set; }

        public string msg { get; set; }

        public List<StudentDeatils> listdisplay { get; set; }

    }
}
