using AisectOnline.Data.Db;
using ExcelDataReader;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AisectOnline.Services.Modules.Skill
{
   
     public class ExcelUpload : IExcelUpload
    {
        SqlConnection connection = null;
        private readonly string _connectionString = string.Empty;
        public ExcelUpload(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("SkillProjectsConnection")
                ?? configuration.GetConnectionString("DefaultConnection")
                ?? throw new InvalidOperationException("No connection string found.");
        }


        public string UploadExcelToDatabase(Stream excelStream, StudentDeatils _student)
        {
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            string result1 = "";
            bool isHeaderRow = true;

            using (var reader = ExcelReaderFactory.CreateReader(excelStream))
            {
                var result = reader.AsDataSet(new ExcelDataSetConfiguration
                {
                    ConfigureDataTable = _ => new ExcelDataTableConfiguration
                    {
                        UseHeaderRow = true
                    }
                });

                var dataTable = result.Tables[0];
                int allCount1 = dataTable.Rows.Count;
                var uniqueRows = dataTable.AsEnumerable()
                    .GroupBy(row => new
                    {
                        SKP_Id = row["SKP_Id"],
                        Student_Name = row["Student_Name"],
                        Father_Name = row["Father_Name"].ToString().ToLower(),
                        Mother_Name = row["Mother_Name"].ToString().ToLower(),
                        Guardian_Name = row["Guardian_Name"].ToString().ToLower(),
                        Address = row["Address"].ToString().ToLower(),
                        City = row["City"].ToString().ToLower(),
                        DistrictId = row["DistrictId"],
                        StateId = row["StateId"],
                        PinCode = row["PinCode"],
                        Zone = row["Zone"],
                        DOB = row["DOB"],
                        Gender = row["Gender"].ToString().ToLower(),
                        Category = row["Category"].ToString().ToLower(),
                        Email = row["Email"].ToString().ToLower(),
                        Mobile = row["Mobile"],
                        AadharNo = row["AadharNo"],
                        Education = row["Education"].ToString().ToLower(),
                        Specialization = row["Specialization"].ToString().ToLower(),
                        Medium = row["Medium"].ToString().ToLower(),
                        Board = row["Board"].ToString().ToLower(),
                        Year = row["Year"],
                        Division = row["Division"],
                        Project_Name = row["Project_Name"].ToString().ToLower(),
                        Funded_By = row["Funded_By"].ToString().ToLower(),
                        Assessment_Mode = row["Assessment_Mode"],
                        Project_FY = row["Project_FY"],
                        Placement = row["Placement"].ToString().ToLower(),
                        Sector_Name = row["Sector_Name"].ToString().ToLower(),
                        Course_Code_QP_Code = row["Course_Code_QP_Code"],
                        Course_Name = row["Course_Name"].ToString().ToLower(),
                        Batch_Id = row["Batch_Id"],
                        Aisect_Entity = row["Aisect_Entity"],
                        Student_Certified = row["Student_Certified"].ToString().ToLower(),
                        Student_Placed = row["Student_Placed"].ToString().ToLower(),
                        Created_By = row["Created_By"].ToString().ToLower(),
                    })
                    .Select(g => g.First()) // Keep only the first row from each group
                    .CopyToDataTable(); // Create a new DataTable with unique rows

                // Update the original DataTable with the unique rows
                dataTable = uniqueRows;

                // Get the new count of rows after removing duplicates
                int allCountAfterDeduplication = dataTable.Rows.Count;

                // Display the count of duplicates removed
                int duplicatesRemoved = allCount1 - allCountAfterDeduplication;

                if (allCountAfterDeduplication > 0)
                {
                    using (connection = new SqlConnection(_connectionString))
                    {
                        try
                        {
                            connection.Open();

                            foreach (DataRow row in dataTable.Rows)
                            {
                                //if (isHeaderRow)
                                //{
                                //    isHeaderRow = false;
                                //    continue;
                                //}
                                //bool isBlankRow = true;
                                //foreach (var item in row.ItemArray)
                                //{
                                //    if (item != null && !string.IsNullOrWhiteSpace(item.ToString()))
                                //    {
                                //        isBlankRow = false;
                                //        break;
                                //    }
                                //}                               
                                //if (isBlankRow)
                                //{
                                //    continue;
                                //}
                                using (var cmd = new SqlCommand("usp_StudentDetails_Insert", connection))
                                {
                                    cmd.CommandType = CommandType.StoredProcedure;
                                    cmd.Parameters.AddWithValue("@SKP_Id", _student.SKP_Id.ToString());
                                    cmd.Parameters.AddWithValue("@Student_Name", row[1].ToString());
                                    cmd.Parameters.AddWithValue("@Father_Name", row[2].ToString());
                                    cmd.Parameters.AddWithValue("@Mother_Name", row[3].ToString());
                                    cmd.Parameters.AddWithValue("@GuardianName", row[4].ToString());
                                    cmd.Parameters.AddWithValue("@Address", row[5].ToString());
                                    cmd.Parameters.AddWithValue("@City", row[6].ToString());
                                    cmd.Parameters.AddWithValue("@DistrictId", _student.DistrictId.ToString());
                                    cmd.Parameters.AddWithValue("@StateId", _student.StateId.ToString());
                                    cmd.Parameters.AddWithValue("@PinCode", row[9].ToString());
                                    cmd.Parameters.AddWithValue("@Zone", row[10].ToString());
                                    cmd.Parameters.AddWithValue("@DOB", row[11].ToString());
                                    cmd.Parameters.AddWithValue("@Gender", row[12].ToString());
                                    cmd.Parameters.AddWithValue("@Category", row[13].ToString());
                                    cmd.Parameters.AddWithValue("@Email", row[14].ToString());
                                    cmd.Parameters.AddWithValue("@Mobile", row[15].ToString());
                                    cmd.Parameters.AddWithValue("@AadharNo", row[16].ToString());
                                    cmd.Parameters.AddWithValue("@Education", row[17].ToString());
                                    cmd.Parameters.AddWithValue("@Specialization", row[18].ToString());
                                    cmd.Parameters.AddWithValue("@Medium", row[19].ToString());
                                    cmd.Parameters.AddWithValue("@Board", row[20].ToString());
                                    cmd.Parameters.AddWithValue("@Year", row[21].ToString());
                                    cmd.Parameters.AddWithValue("@Division", row[22].ToString());
                                    cmd.Parameters.AddWithValue("@Project_Name", row[23].ToString());
                                    cmd.Parameters.AddWithValue("@Funded_By", row[24].ToString());
                                    cmd.Parameters.AddWithValue("@Assessment_Mode", row[25].ToString());
                                    cmd.Parameters.AddWithValue("@Project_FY", row[26].ToString());
                                    cmd.Parameters.AddWithValue("@Placement", row[27].ToString());
                                    cmd.Parameters.AddWithValue("@Sector_Name", row[28].ToString());
                                    cmd.Parameters.AddWithValue("@Courde_Code_QP_Code", row[29].ToString());
                                    cmd.Parameters.AddWithValue("@Course_Name", row[30].ToString());
                                    cmd.Parameters.AddWithValue("@Batch_Id", row[31].ToString());
                                    cmd.Parameters.AddWithValue("@Aisect_Entity", row[32].ToString());
                                    cmd.Parameters.AddWithValue("@StudentCertified", row[33].ToString());
                                    cmd.Parameters.AddWithValue("@StudentPlaced", row[34].ToString());
                                    cmd.Parameters.AddWithValue("@Created_By", row[35].ToString());
                                    cmd.Parameters.AddWithValue("@Count", allCountAfterDeduplication);
                                    SqlParameter outputParam = new SqlParameter("@msg", SqlDbType.VarChar, 100);
                                    outputParam.Direction = ParameterDirection.Output;
                                    cmd.Parameters.Add(outputParam);

                                    cmd.ExecuteNonQuery();
                                    result1 = outputParam.Value.ToString() + "\n" + allCountAfterDeduplication + " Row(s) uploaded Successfully" + "\n" + "Found Duplicate Row(s): " + duplicatesRemoved;
                                }

                                // Break after inserting the first data row
                                //break;
                            }



                        }

                        catch (Exception ex)
                        {
                            Console.WriteLine($"Error: {ex.Message}");
                            result1 = "Record Alrady Saved";
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
            }

            return result1;
        }
        public DataTable GetCurrentData()
        {
            var dataTable = new DataTable();

            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = new SqlCommand("getStudentData", connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        dataTable.Load(reader);
                    }
                }
            }

            return dataTable;
        }

        public List<Zone> GetZone()
        {
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            var items = new List<Zone>();
            using (connection = new SqlConnection(_connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("usp_ZoneMasterGet", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                items.Add(new Zone
                                {
                                    ZoneId = Convert.ToInt32(reader["ZoneId"]),
                                    ZoneName = Convert.ToString(reader["Zone"])
                                });
                            }
                        }
                    }
                }
                catch (Exception ex)
                {

                    Console.WriteLine($"Error: {ex.Message}");
                }
                finally
                {
                    connection.Close();
                }

                return items;
            }
        }
        public List<State> GetDropdownItems()
        {
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            var items = new List<State>();



            using (connection = new SqlConnection(_connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("usp_StateMaster_Get", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                items.Add(new State
                                {
                                    StateID = Convert.ToInt32(reader["StateID"]),
                                    StateName = Convert.ToString(reader["StateName"])
                                });
                            }
                        }
                    }
                }
                catch (Exception ex)
                {

                    Console.WriteLine($"Error: {ex.Message}");
                }
                finally
                {
                    connection.Close();
                }

                return items;
            }
        }
        public List<State> GetStateItems(int ZoneId)
        {
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            var items = new List<State>();
            using (connection = new SqlConnection(_connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("usp_StateMasterDetail", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@ZoneId", ZoneId));
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                items.Add(new State
                                {
                                    StateID = Convert.ToInt32(reader["StateID"]),
                                    StateName = Convert.ToString(reader["StateName"])
                                });
                            }
                        }
                    }
                }
                catch (Exception ex)
                {

                    Console.WriteLine($"Error: {ex.Message}");
                }
                finally
                {
                    connection.Close();
                }

                return items;
            }
        }
        public List<District> GetDistricts(int stateId)
        {
            var districts = new List<District>();

            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                var command = new SqlCommand("usp_DistrictList_Get", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@StateId", stateId));
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        districts.Add(new District
                        {

                            DistrictId = Convert.ToInt32(reader["DistrictId"]),
                            DistrictName = Convert.ToString(reader["DistrictName"])
                        });
                    }
                }
                return districts;
            }

        }
        public List<SKP> GetSKP(int DistrictId)
        {
            var SKP = new List<SKP>();

            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                var command = new SqlCommand("usp_SKPID_get", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@DistrictId", DistrictId));
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        SKP.Add(new SKP
                        {
                            KIOSKID = reader.GetInt32(0),
                            KioskCode = reader.GetString(1)
                        });
                    }
                }
                return SKP;
            }

        }
        public List<Kiosk> GetKiosksByDistrictId(int districtId)
        {
            var skp = new List<Kiosk>();

            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                var command = new SqlCommand("usp_SKPID_get", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@DistrictId", districtId));
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        skp.Add(new Kiosk
                        {

                            KIOSKID = Convert.ToInt32(reader["KIOSKID"]),
                            KioskCode = Convert.ToString(reader["KioskCode"])
                        });
                    }
                }
                return skp;
            }

        }




        public Int32 InsertStudentDeatils(StudentDetail _student)
        {
            int result1 = 0;
            int Allcount = 1;
            try
            {
                var connection = new SqlConnection(_connectionString);
                connection.Open();
                var cmd = new SqlCommand("usp_InsertStudentDetails", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@SKP_Id", _student.SKP_Id.ToString());
                cmd.Parameters.AddWithValue("@Student_Name", _student.Student_Name.ToString());
                cmd.Parameters.AddWithValue("@Father_Name", _student.Father_Name.ToString());
                cmd.Parameters.AddWithValue("@Mother_Name", _student.Mother_Name.ToString());
                cmd.Parameters.AddWithValue("@GuardianName", _student.GuardianName.ToString());
                cmd.Parameters.AddWithValue("@Address", _student.Address.ToString());
                cmd.Parameters.AddWithValue("@DistrictId", _student.DistrictId.ToString());
                cmd.Parameters.AddWithValue("@StateId", _student.StateId.ToString());
                cmd.Parameters.AddWithValue("@City", _student.City.ToString());
                cmd.Parameters.AddWithValue("@PinCode", _student.PinCode.ToString());
                cmd.Parameters.AddWithValue("@Zone", _student.Zone.ToString());
                cmd.Parameters.AddWithValue("@DOB", _student.DOB.ToString());
                cmd.Parameters.AddWithValue("@Gender", _student.Gender.ToString());
                cmd.Parameters.AddWithValue("@Category", _student.Category.ToString());
                cmd.Parameters.AddWithValue("@Email", _student.Email.ToString());
                cmd.Parameters.AddWithValue("@Mobile", _student.Mobile.ToString());
                cmd.Parameters.AddWithValue("@AadharNo", _student.AadharNo.ToString());
                cmd.Parameters.AddWithValue("@Education", _student.Education.ToString());
                cmd.Parameters.AddWithValue("@Specialization", _student.Specialization.ToString());
                cmd.Parameters.AddWithValue("@Medium", _student.Medium.ToString());
                cmd.Parameters.AddWithValue("@Board", _student.Board.ToString());
                cmd.Parameters.AddWithValue("@Year", _student.Year.ToString());
                cmd.Parameters.AddWithValue("@Division", _student.Division.ToString());
                cmd.Parameters.AddWithValue("@Project_Name", _student.Project_Name.ToString());
                cmd.Parameters.AddWithValue("@Funded_By", _student.Funded_By.ToString());
                cmd.Parameters.AddWithValue("@Assessment_Mode", _student.Assessment_Mode.ToString());
                cmd.Parameters.AddWithValue("@Project_FY", _student.Project_FY.ToString());
                cmd.Parameters.AddWithValue("@Placement", _student.Placement.ToString());
                cmd.Parameters.AddWithValue("@Sector_Name", _student.Sector_Name.ToString());
                cmd.Parameters.AddWithValue("@Course_Code_QP_Code", _student.Course_Code_QP_Code.ToString());
                cmd.Parameters.AddWithValue("@Course_Name", _student.Course_Name.ToString());
                cmd.Parameters.AddWithValue("@Batch_Id", _student.Batch_Id.ToString());
                cmd.Parameters.AddWithValue("@Aisect_Entity", _student.Aisect_Entity.ToString());
                cmd.Parameters.AddWithValue("@StudentCertified", _student.StudentCertified.ToString());
                cmd.Parameters.AddWithValue("@StudentPlaced", _student.StudentPlaced.ToString());
                cmd.Parameters.AddWithValue("@Created_By", _student.Created_By.ToString());
                cmd.Parameters.AddWithValue("@Count", Allcount);
                cmd.ExecuteNonQuery();
                return result1 = 1;
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {
            }
            return 0;



        }


        public List<StudentDetail> GetUploadeData(int stateId, int districtId, int kioskID)
        {
            var kiosk = new List<StudentDetail>();

            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                var command = new SqlCommand("usp_SKPID_get", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@stateId", stateId));
                command.Parameters.Add(new SqlParameter("@districtId", districtId));
                command.Parameters.Add(new SqlParameter("@kioskID", kioskID));
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        kiosk.Add(new StudentDetail
                        {

                            SKP_Id = Convert.ToString(reader["SKP_Id"]),
                            Student_Name = Convert.ToString(reader["Student_Name"]),
                            Father_Name = Convert.ToString(reader["Father_Name"]),
                            Mother_Name = Convert.ToString(reader["Mother_Name"]),
                            Address = Convert.ToString(reader["Address"]),
                            DistrictId = Convert.ToString(reader["DistrictId"]),
                            StateId = Convert.ToString(reader["StateId"]),
                            City = Convert.ToString(reader["City"]),
                            PinCode = Convert.ToString(reader["PinCode"]),
                            Zone = Convert.ToString(reader["Zone"]),
                            DOB = Convert.ToString(reader["DOB"]),
                            Gender = Convert.ToString(reader["Gender"]),
                            Category = Convert.ToString(reader["Category"]),
                            Email = Convert.ToString(reader["Email"]),
                            Mobile = Convert.ToString(reader["Mobile"]),
                            AadharNo = Convert.ToString(reader["AadharNo"]),
                            Education = Convert.ToString(reader["Education"]),
                            Specialization = Convert.ToString(reader["Specialization"]),
                            Medium = Convert.ToString(reader["Medium"]),
                            Board = Convert.ToString(reader["Board"]),
                            Year = Convert.ToString(reader["Year"]),
                            Division = Convert.ToString(reader["Division"]),
                            Project_Name = Convert.ToString(reader["Project_Name"]),
                            Funded_By = Convert.ToString(reader["Funded_By"]),
                            Sector_Name = Convert.ToString(reader["Sector_Name"]),
                            Course_Code_QP_Code = Convert.ToString(reader["Course_Code_QP_Code"]),
                            Course_Name = Convert.ToString(reader["Course_Name"]),
                            Batch_Id = Convert.ToString(reader["Batch_Id"]),
                            Aisect_Entity = Convert.ToString(reader["Aisect_Entity"]),
                            Created_By = Convert.ToString(reader["Created_By"])
                        });
                    }
                }
                return kiosk;
            }

        }
        public List<StudentDetail> GetDataByDate(DateTime? fromDate, DateTime? toDate, int stateId, int districtId, string kioskID, string Zone, string fundedby, string AisectEntity, string Assisment)
        {
            var studentDetails = new List<StudentDetail>();

            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = new SqlCommand("usp_StudentDetails_Get", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    // Adding parameters to the stored procedure
                    command.Parameters.AddWithValue("@fromDate", fromDate ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@toDate", toDate ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@stateId", stateId == 0 ? (object)DBNull.Value : stateId);
                    command.Parameters.AddWithValue("@districtId", districtId == 0 ? (object)DBNull.Value : districtId);
                    command.Parameters.AddWithValue("@SKPId", string.IsNullOrEmpty(kioskID) ? (object)DBNull.Value : kioskID);
                    command.Parameters.AddWithValue("@Zone", string.IsNullOrEmpty(Zone) ? (object)DBNull.Value : Zone);
                    command.Parameters.AddWithValue("@Funded_By", string.IsNullOrEmpty(fundedby) ? (object)DBNull.Value : fundedby);
                    command.Parameters.AddWithValue("@Aisect_Entity", string.IsNullOrEmpty(AisectEntity) ? (object)DBNull.Value : AisectEntity);
                    command.Parameters.AddWithValue("@Assessment_Mode", string.IsNullOrEmpty(Assisment) ? (object)DBNull.Value : Assisment);

                    // Execute the reader and populate the list
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var studentDetail = new StudentDetail
                            {
                                SKP_Id = reader["SKP_Id"]?.ToString(),
                                RegistrationNo = reader["RegistrationNo"]?.ToString(),
                                Student_Name = reader["Student_Name"]?.ToString(),
                                Father_Name = reader["Father_Name"]?.ToString(),
                                Mother_Name = reader["Mother_Name"]?.ToString(),
                                Guardian_Name = reader["GuardianName"]?.ToString(),
                                Address = reader["Address"]?.ToString(),
                                City = reader["City"]?.ToString(),
                                DistrictId = reader["DistrictName"]?.ToString(),
                                StateId = reader["Statename"]?.ToString(),
                                PinCode = reader["PinCode"]?.ToString(),
                                Zone = reader["Zone"]?.ToString(),
                                DOB = reader["DOB"]?.ToString(),
                                Gender = reader["Gender"]?.ToString(),
                                Category = reader["Category"]?.ToString(),
                                Email = reader["Email"]?.ToString(),
                                Mobile = reader["Mobile"]?.ToString(),
                                AadharNo = reader["AadharNo"]?.ToString(),
                                Education = reader["Education"]?.ToString(),
                                Specialization = reader["Specialization"]?.ToString(),
                                Medium = reader["Medium"]?.ToString(),
                                Board = reader["Board"]?.ToString(),
                                Year = reader["Year"]?.ToString(),
                                Division = reader["Division"]?.ToString(),
                                Project_Name = reader["Project_Name"]?.ToString(),
                                Funded_By = reader["Funded_By"]?.ToString(),
                                Assessment_Mode = reader["Assessment_Mode"]?.ToString(),
                                Project_FY = reader["Project_FY"]?.ToString(),
                                Placement = reader["Placement"]?.ToString(),
                                Sector_Name = reader["Sector_Name"]?.ToString(),
                                Course_Code_QP_Code = reader["Courde_Code_QP_Code"]?.ToString(),
                                Course_Name = reader["Course_Name"]?.ToString(),
                                Batch_Id = reader["Batch_Id"]?.ToString(),
                                Aisect_Entity = reader["Aisect_Entity"]?.ToString(),
                                Student_Certified = reader["StudentCertified"]?.ToString(),
                                Student_Placed = reader["StudentPlaced"]?.ToString(),
                                Created_By = reader["Created_By"]?.ToString(),
                                Created_On = reader["Created_On"] != DBNull.Value ? Convert.ToDateTime(reader["Created_On"]).ToString("dd-MM-yyyy") : null,
                                LotNo = reader["LotNo"]?.ToString()
                            };

                            studentDetails.Add(studentDetail);
                        }
                    }
                }
            }

            return studentDetails;
        }


        public List<Sectors> GetSectors()
        {
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            var Sectorsitems = new List<Sectors>();
            using (connection = new SqlConnection(_connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("usp_SectorMaster_Get", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Sectorsitems.Add(new Sectors
                                {
                                    Id = Convert.ToInt32(reader["Id"]),
                                    Sector = Convert.ToString(reader["Sector"])
                                });
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
                finally
                {
                    connection.Close();
                }

                return Sectorsitems;
            }
        }

        public List<Education> GetEducation()
        {
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            var Educationitems = new List<Education>();
            using (connection = new SqlConnection(_connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("usp_QualificationMaster_Get", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Educationitems.Add(new Education
                                {
                                    Id = Convert.ToInt32(reader["Id"]),
                                    Qualification = Convert.ToString(reader["Qualification"])
                                });
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
                finally
                {
                    connection.Close();
                }

                return Educationitems;
            }
        }


        public Int32 DeleteStudentDeatilsbylotNo(string LotNo)
        {
            int result1 = 0;
            try
            {
                var connection = new SqlConnection(_connectionString);
                connection.Open();
                var cmd = new SqlCommand("usp_DeleteStudentDetails", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@LotNo", LotNo.ToString());
                cmd.ExecuteNonQuery();
                return result1 = 1;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {
            }
            return 0;



        }

    }
}

