using AisectOnline.Services.Modules.StudentAssignment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AisectOnline.Services.Modules.Skill
{
    public interface IExcelUpload
    {
        string UploadExcelToDatabase(Stream excelStream, StudentDeatils _student);
    }
}
