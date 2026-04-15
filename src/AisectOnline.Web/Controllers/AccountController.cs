using AisectOnline.Common.Users;
using AisectOnline.Services.Modules.Accounts;
using AisectOnline.Services.Modules.MasterData;
using AisectOnline.Services.Modules.Students;
using AisectOnline.Services.Modules.Users;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Distributed;
using System.Security.Cryptography;
using System.Text;
using static AisectOnline.Services.Modules.Accounts.LogOnModel;
using static AisectOnline.Services.Modules.Common.CommonDTO;
using AisectOnline.Services.Modules.Users;
using Microsoft.Extensions.Logging;
using AisectOnline.Common.Session;
using AisectOnline.Web.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using System.Security.Claims;

//using AisectOnline.Web.Models.Account;

namespace AisectOnline.Web.Controllers
{
    public class AccountController : BaseController
    {
        private readonly IDistributedCache _cache;
        //private readonly IMasterDataService _masterDataService;
        private readonly IAccountService _accountService;
        private readonly IWebHostEnvironment _env;
        private readonly ISessionInitializer _sessionInit;
        //private readonly IAccountService _accountService;

        //public AccountController() { }
        public AccountController(
        ILogger<AccountController> logger,
        IUserContextService userContext,
        ISessionInitializer sessionInit,
        IAccountService accountService,
        IWebHostEnvironment env)
        : base(logger, userContext, sessionInit)
        {
            _accountService = accountService;
            _env = env;
        }
        /*public AccountController(IAccountService accountService, IMasterDataService MasterDataService, IWebHostEnvironment env)
        {
            _accountService = accountService;
        }*/
        [AllowAnonymous]
        public async Task<IActionResult> LogOn()
        => View();


        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> LogOn(LogOnModel model)
        {
            try
            {

                Audit objaudit = new Audit();
                int TrailID = 0;
                string userValMsg = "";
                model.Password = EncryptUserPassword(model.Password);
                model.Password = EncryptUserPassword(model.Password + "f9761016cfff9d68df=");
                model = await _accountService.ValidateLoginAsync(model.UserName, model.Password, objaudit, "", userValMsg, TrailID);

                if (model != null)
                {
                    // Optional: Set session for non-auth data

                    HttpContext.Session.SetInt32("TrailID", TrailID);
                    HttpContext.Session.SetInt32("AISECTUSERID", model.UserID);
                    HttpContext.Session.SetString("IUSERTYPE", model.Role);
                    HttpContext.Session.SetString("ICHILDROLE", model.ChildRole);
                    HttpContext.Session.SetString("USERFULLNAME", model.UserFullName);
                    HttpContext.Session.SetInt32("AISECTCUSTOMERID", model.CustomerID);
                    HttpContext.Session.SetString("LOGINNAME", model.LoginID);
                    HttpContext.Session.SetString("AISECTUSERNAME", model.UserName);
                    HttpContext.Session.SetString("AISECTLASTNAME", model.LastName);
                    HttpContext.Session.SetString("AISECTPANNo", model.PANNo);
                    HttpContext.Session.SetString("AISECTAadhar", model.Aadhar);
                    HttpContext.Session.SetString("AISECTMobile", model.Mobile);
                    HttpContext.Session.SetString("AISECTZip", model.Zip);
                    HttpContext.Session.SetString("AISECTEmail", model.Email);
                    HttpContext.Session.SetString("AISECTLOG", model.UserName);
                    HttpContext.Session.SetString("sesAllkioskIds", model.strKioskID);
                    var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.NameIdentifier, model.UserID.ToString()),
                    new Claim(ClaimTypes.Name, model.UserFullName ?? model.UserName),
                    new Claim(ClaimTypes.Email, model.Email ?? ""),
                    new Claim(ClaimTypes.Role, model.Role ?? "")
                };

                    var claimsIdentity = new ClaimsIdentity(claims, "MyCookieAuth");
                    var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);

                    await HttpContext.SignInAsync("MyCookieAuth", claimsPrincipal);

                    if (string.IsNullOrEmpty(model.strKioskID))
                        return RedirectToAction("Index", "Home");
                    else
                        return RedirectToAction("SelectKiosk");
                }

                ModelState.AddModelError("", "Invalid login attempt.");
                return View(model);
            }
            catch(Exception ex)
            {
                throw;
            }
        }
        
        



        [HttpGet]
        public async Task<IActionResult> SelectKiosk()
        {
            var SessionValues = HttpContext.Session.GetString("sesAllkioskIds");
            string allkiosk = Convert.ToString(SessionValues);


            LogOnModel usr = new LogOnModel();

            IList<DropDownInfo> lstKiosk = new List<DropDownInfo>();
            string[] strKiosk = allkiosk.Split(',');
            IndexViewModel ix = new IndexViewModel();
            foreach (var item in strKiosk)
            {

                if (item != "")
                {
                    string val = item.Split('|')[2];

                    if (val != "")
                    {
                        DateTime exdate = Convert.ToDateTime(val);
                        DateTime curdate = DateTime.Now;
                        string usertype = Convert.ToString(HttpContext.Session.GetString("IUSERTYPE"));
                        string ChildRole = Convert.ToString(HttpContext.Session.GetString("ICHILDROLE"));
                        if ((exdate >= curdate) || ((exdate < curdate) && (usertype == "RenewalPending")) || ChildRole == "BlackList")
                        {
                            lstKiosk.Add(new DropDownInfo() { ValueField = Convert.ToInt32(item.Split('|')[0]), TextField = Convert.ToString(item.Split('|')[1]) });
                            ix.TestRadio = item.Split('|')[2];
                        }
                    }
                }

            }
            ix.RadioList = lstKiosk;
            return View("SelectKiosk", ix);
        }
        [HttpGet]
        public async Task<IActionResult>StoreSelectedKiosk(string id)
        {
            HttpContext.Session.SetInt32("KIOSKID", Convert.ToInt32(id));
            string[] KioskDetails = await _accountService.GetKioskDetails(Convert.ToInt32(HttpContext.Session.GetInt32("AISECTUSERID")),Convert.ToInt32(HttpContext.Session.GetInt32("KIOSKID")));
            HttpContext.Session.SetString("LastLoginDate", KioskDetails[0]);
            HttpContext.Session.SetString("eWalletBalance", KioskDetails[1]);
            HttpContext.Session.SetString("ExpiredDays", KioskDetails[2]);
            HttpContext.Session.SetString("KIOSKCode", KioskDetails[3]);
            HttpContext.Session.SetString("JeetkajashnCategory", KioskDetails[4]);
            return Ok();
        }
        
        public async Task<IActionResult> LogOff()
        {
            Audit objaudit = new Audit();
            
            objaudit.AuditTrailID = Convert.ToInt32(HttpContext.Session.GetInt32("TrailID"));
            int Ret = await _accountService.UpdateLogOutInfoAsync(objaudit.AuditTrailID);
            //SecurityHelper.ClearAuthentication(HttpContext);
            await HttpContext.SignOutAsync("MyCookieAuth");
            HttpContext.Session.Clear();
            //Session.Clear();
            
            return RedirectToAction("LogOn");
        }
        public async Task<IActionResult> GetBalance()
        {
            int? userId = HttpContext.Session.GetInt32("AISECTUSERID");
            int? kioskId = HttpContext.Session.GetInt32("KIOSKID");

            if (userId == null || kioskId == null)
            {
                return Json(new { balance = "Session expired or invalid" });
            }

            string balanceText = await _accountService.GetWalletBalanceOnly(userId.Value, kioskId.Value);
            return Json(new { balance = balanceText });
        }
        public string EncryptUserPassword(string input)
        {

            //string strF = string.Empty;
            MD5 md5Hash = MD5.Create();
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
            StringBuilder sBuilder = new StringBuilder();

            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            //strF = EncryptUserPassword(sBuilder + "f9761016cfff9d68df=");

            //}
            return sBuilder.ToString();


        }
        
    }
}
