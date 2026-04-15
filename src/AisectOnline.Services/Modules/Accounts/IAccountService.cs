using AisectOnline.Services.Base;
using AisectOnline.Services.Modules.Students;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AisectOnline.Services.Modules.Common.CommonDTO;

namespace AisectOnline.Services.Modules.Accounts
{
    public interface IAccountService
    {
        Task<LogOnModel> ValidateLoginAsync(string userID,string password,Audit audit,string salt,string userValMsg,int TrailID);
        Task<int> UpdateLogOutInfoAsync(Int32 AuditTrailID);
        Task<string> GetPendingTxn_PaytmGateway(int kioskID);

        Task<string> GetWalletBalanceOnly(int UID, int kioskID);
        Task<string[]> GetKioskDetails(int UID, int kioskID);

    }
}
