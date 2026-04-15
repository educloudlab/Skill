using AisectOnline.Services.Modules.Students;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AisectOnline.Services.Modules.Admin
{
    public class AdminDto
    {
    }
    public class AcademyAllotmentDto
    {
        public List<ListItems> Academy { get; set; }
        public int AcademyId1 { get; set; }
        public int AcademyId2 { get; set; }
    }
}
