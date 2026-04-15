
using AisectOnline.Data.Db;
using AisectOnline.Services.Modules.Common;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AisectOnline.Services.Modules.Common.CommonDTO;

namespace AisectOnline.Services.Modules.Accounts
{
    public class AccountRepository : IAccountService
    {
        private readonly AisectOnlineDbContext _db;
        private readonly string _connectionString;
        private readonly IConfiguration _configuration;
        //private readonly DataHelperClass _dal;
        public AccountRepository(AisectOnlineDbContext db, IConfiguration configuration)
        {
            _db = db;
            _connectionString = configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
            _configuration = configuration;
            //_dal = dal;
        }

        public async Task<string> GetPendingTxn_PaytmGateway(int kioskID)
        {
            string OrderIds = "";
            using var connection = new SqlConnection(_connectionString);
            using var command = new SqlCommand("sp_GetPaytmPendingTxnByKioskID", connection)
            {
                CommandType = CommandType.StoredProcedure,
                CommandTimeout = 300
            };

            command.Parameters.Add(new SqlParameter("KioskID", SqlDbType.Int)
            {
                Direction = ParameterDirection.Input,
                Value = kioskID
            });
            try
            {
                await connection.OpenAsync();

                using var reader = await command.ExecuteReaderAsync();
                if (reader.HasRows)
                {
                    while (await reader.ReadAsync())
                    {

                        OrderIds = Convert.ToString(reader["userID"]);

                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error updating logout info (async)", ex);
            }
            return OrderIds;
        }

        public async Task<string> GetWalletBalanceOnly(int UID, int kioskID)
        {
            string WBalance = "";
            using var connection = new SqlConnection(_connectionString);
            using var command = new SqlCommand("up_GetLiveWalletBalance", connection)
            {
                CommandType = CommandType.StoredProcedure,
                CommandTimeout = 300
            };

            command.Parameters.Add(new SqlParameter("@UserID", SqlDbType.Int)
            {
                Direction = ParameterDirection.Input,
                Value = UID
            });
            command.Parameters.Add(new SqlParameter("@KioskID", SqlDbType.Int)
            {
                Direction = ParameterDirection.Input,
                Value = kioskID
            });

            try
            {
                await connection.OpenAsync();

                using var reader = await command.ExecuteReaderAsync();
                if (reader.HasRows)
                {
                    while (await reader.ReadAsync())
                    {

                        WBalance = Convert.ToString(reader["eWalletBalance"]);

                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error updating logout info (async)", ex);
            }
            return WBalance;
        }

        public async Task<string[]> GetKioskDetails(int UID, int kioskID)
        {
            string[] _return = new string[5];
            using var connection = new SqlConnection(_connectionString);
            using var command = new SqlCommand("up_GetCustomereWalletBalance", connection)
            {
                CommandType = CommandType.StoredProcedure,
                CommandTimeout = 300
            };

            command.Parameters.Add(new SqlParameter("@UserID", SqlDbType.Int)
            {
                Direction = ParameterDirection.Input,
                Value = UID
            });
            command.Parameters.Add(new SqlParameter("@KioskID", SqlDbType.Int)
            {
                Direction = ParameterDirection.Input,
                Value = kioskID
            });

            try
            {
                await connection.OpenAsync();

                using var reader = await command.ExecuteReaderAsync();
                if (reader.HasRows)
                {
                    while (await reader.ReadAsync())
                    {

                        _return[0] = Convert.ToString(reader["LastLoginDate"]);
                        _return[1] = Convert.ToString(reader["eWalletBalance"]);
                        _return[2] = Convert.ToString(reader["ExpiredDays"]);
                        _return[3] = Convert.ToString(reader["KIOSKCode"]);
                        _return[4] = Convert.ToString(reader["JeetkajashnCategory"]);

                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error updating logout info (async)", ex);
            }
            return _return;
        }

        public async Task<int> UpdateLogOutInfoAsync(int auditTrailId)
        {
            using var connection = new SqlConnection(_connectionString);
            using var command = new SqlCommand("up_InsertAuditTrail", connection)
            {
                CommandType = CommandType.StoredProcedure,
                CommandTimeout = 300
            };

            command.Parameters.Add(new SqlParameter("@AuditTrailID", SqlDbType.Int)
            {
                Direction = ParameterDirection.Input,
                Value = auditTrailId
            });

            try
            {
                await connection.OpenAsync();
                int rowsAffected = await command.ExecuteNonQueryAsync();
                return rowsAffected;
            }
            catch (Exception ex)
            {
                throw new Exception("Error updating logout info (async)", ex);
            }
        }


        public async Task<LogOnModel> ValidateLoginAsync(string userID, string password, Audit audit, string salt, string userValMsg, int TrailID)
        {
            LogOnModel user = null;
            userValMsg = string.Empty;
            TrailID = 0;

            int attemptNo = _configuration.GetSection("AppSettings").GetValue<int>("AttemptNo");

            using var connection = new SqlConnection(_connectionString);
            using var command = new SqlCommand("up_AuthenticateUser2", connection)
            {
                CommandType = CommandType.StoredProcedure,
                CommandTimeout = 600
            };

            command.Parameters.Add(new SqlParameter("@LoginID", SqlDbType.NVarChar, 100) { Value = userID });
            command.Parameters.Add(new SqlParameter("@Password", SqlDbType.NVarChar, 100) { Value = salt + password });
            command.Parameters.Add(new SqlParameter("@AttemptNo", SqlDbType.Int) { Value = attemptNo });

            var userValidityParam = new SqlParameter("@UserValidity", SqlDbType.NVarChar, 300)
            {
                Direction = ParameterDirection.InputOutput,
                Value = string.Empty
            };
            command.Parameters.Add(userValidityParam);

            var trailIdParam = new SqlParameter("@AuditTrailID", SqlDbType.Int)
            {
                Direction = ParameterDirection.Output
            };
            command.Parameters.Add(trailIdParam);

            command.Parameters.Add(new SqlParameter("@IPAddress", SqlDbType.NVarChar, 50) { Value = audit.IpAddress ?? (object)DBNull.Value });
            command.Parameters.Add(new SqlParameter("@SessionDetails", SqlDbType.NVarChar, 200) { Value = audit.SessionDetails ?? (object)DBNull.Value });
            command.Parameters.Add(new SqlParameter("@Referrer", SqlDbType.NVarChar, 200) { Value = audit.Referrer ?? (object)DBNull.Value });
            command.Parameters.Add(new SqlParameter("@URL", SqlDbType.NVarChar, 200) { Value = audit.URL ?? (object)DBNull.Value });
            command.Parameters.Add(new SqlParameter("@UserAgent", SqlDbType.NVarChar, 300) { Value = audit.UserAgent ?? (object)DBNull.Value });
            command.Parameters.Add(new SqlParameter("@Country", SqlDbType.NVarChar, 100) { Value = audit.Country ?? (object)DBNull.Value });

            command.Parameters.Add(new SqlParameter("@Salt", SqlDbType.NVarChar, 100) { Value = salt });

            try
            {
                await connection.OpenAsync();

                using var reader = await command.ExecuteReaderAsync();
                if (reader.HasRows)
                {
                    while (await reader.ReadAsync())
                    {
                        user = new LogOnModel
                        {
                            UserID = reader["userID"] != DBNull.Value ? Convert.ToInt32(reader["userID"]) : 0,
                            AccessLevel = reader["IsPasswordChange"] != DBNull.Value ? Convert.ToInt32(reader["IsPasswordChange"]) : 0,
                            Role = reader["ParentRoleName"] != DBNull.Value ? reader["ParentRoleName"].ToString() : "",
                            ChildRole = reader["RoleName"] != DBNull.Value ? reader["RoleName"].ToString() : "",
                            CustomerID = reader["CustomerID"] != DBNull.Value ? Convert.ToInt32(reader["CustomerID"]) : 0,
                            strKioskID = reader["kioskID"] != DBNull.Value ? reader["kioskID"].ToString() : "",
                            LoginID = reader["LoginID"] != DBNull.Value ? reader["LoginID"].ToString() : "",
                            UserName = reader["FirstName"] != DBNull.Value ? reader["FirstName"].ToString() : "",
                            LastName = reader["LastName"] != DBNull.Value ? reader["LastName"].ToString() : "",
                            PANNo = reader["PANNo"] != DBNull.Value ? reader["PANNo"].ToString() : "",
                            Aadhar = reader["Aadhar"] != DBNull.Value ? reader["Aadhar"].ToString() : "",
                            Mobile = reader["Mobile"] != DBNull.Value ? reader["Mobile"].ToString() : "",
                            Email = reader["Email"] != DBNull.Value ? reader["Email"].ToString() : "",
                            Zip = reader["Zip"] != DBNull.Value ? reader["Zip"].ToString() : "",
                            Remarks = reader["Remarks"] != DBNull.Value ? reader["Remarks"].ToString() : ""
                        };

                        if (user.ChildRole == "BlackList")
                        {
                            user.Role = user.ChildRole;
                        }

                        user.UserFullName = $"{user.UserName} {user.LastName}";
                    }
                }

                await reader.CloseAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Error validating user login (async)", ex);
            }

            // Set output parameters
            userValMsg = userValidityParam.Value?.ToString();
            if (trailIdParam.Value != DBNull.Value)
            {
                TrailID = Convert.ToInt32(trailIdParam.Value);
            }

            return user;
        }



    }
}
