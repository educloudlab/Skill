using AisectOnline.Data.Models;
using AisectOnline.Services.Modules.Accounts;
using Azure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Routing;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;
using static AisectOnline.Services.Modules.Common.CommonDTO;

namespace AisectOnline.Services.Modules.Common
{
    //public static class UtilsStudent
    //{
    //    public static bool IsReadOnly(string studentStatus)
    //    {
    //        return (studentStatus == StudentStatus.New || string.IsNullOrEmpty(studentStatus)) ? false : (Convert.ToString(HttpContext.Current.Session["IUSERTYPE"]) == AISECTUserType.ADMIN) ? true : false;
    //    }
    //    public static bool IsReadOnly(int? value)
    //    {
    //        return ((!string.IsNullOrEmpty(Convert.ToString(value))) || value == 0) ? false : true;
    //    }
    //    public static bool IsEnabled(string studentStatus)
    //    {
    //        return (studentStatus == StudentStatus.New || string.IsNullOrEmpty(studentStatus)) ? true : (Convert.ToString(HttpContext.Current.Session["IUSERTYPE"]) == AISECTUserType.ADMIN) ? false : true;
    //    }
    //}

    //public static class Utils
    //{

    //    public static string Base64Encode(string plainText)
    //    {
    //        var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
    //        return System.Convert.ToBase64String(plainTextBytes);
    //    }
    //    public static string Base64Decode(string base64EncodedData)
    //    {
    //        var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
    //        return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
    //    }


    //    public static string encrypt(string strToEncrypt)
    //    {
    //        var key = MD5.Create().ComputeHash(Encoding.UTF8.GetBytes("dY2MN1Kf"));

    //        var iv = new byte[]
    //        {
    //            0,
    //            1,
    //            2,
    //            3,
    //            4,
    //            5,
    //            6,
    //            7,
    //            8,
    //            9,
    //            10,
    //            11,
    //            12,
    //            13,
    //            14,
    //            15
    //        };

    //        string result = "";
    //        using (new RijndaelManaged())
    //        {
    //            byte[] array = EncryptStringToBytes(strToEncrypt, key, iv);
    //            StringBuilder stringBuilder = new StringBuilder();
    //            foreach (byte b in array)
    //            {
    //                stringBuilder.AppendFormat("{0:x2}", b);
    //            }
    //            result = stringBuilder.ToString();
    //        }
    //        return result;
    //    }



    //    private static byte[] EncryptStringToBytes(string plainText, byte[] Key, byte[] IV)
    //    {
    //        if (plainText == null || plainText.Length <= 0)
    //        {
    //            throw new ArgumentNullException("plainText");
    //        }
    //        if (Key == null || Key.Length <= 0)
    //        {
    //            throw new ArgumentNullException("Key");
    //        }
    //        if (IV == null || IV.Length <= 0)
    //        {
    //            throw new ArgumentNullException("Key");
    //        }
    //        byte[] result;
    //        using (RijndaelManaged rijndaelManaged = new RijndaelManaged())
    //        {
    //            rijndaelManaged.Key = Key;
    //            rijndaelManaged.IV = IV;
    //            ICryptoTransform transform = rijndaelManaged.CreateEncryptor(rijndaelManaged.Key, rijndaelManaged.IV);
    //            using (MemoryStream memoryStream = new MemoryStream())
    //            {
    //                using (CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write))
    //                {
    //                    using (StreamWriter streamWriter = new StreamWriter(cryptoStream))
    //                    {
    //                        streamWriter.Write(plainText);
    //                    }
    //                    result = memoryStream.ToArray();
    //                }
    //            }
    //        }
    //        return result;
    //    }


    //    public static string decrypt(string strToDecrypt)
    //    {
    //        var key = MD5.Create().ComputeHash(Encoding.UTF8.GetBytes("dY2MN1Kf"));

    //        var iv = new byte[]
    //        {
    //            0,
    //            1,
    //            2,
    //            3,
    //            4,
    //            5,
    //            6,
    //            7,
    //            8,
    //            9,
    //            10,
    //            11,
    //            12,
    //            13,
    //            14,
    //            15
    //        };
    //        string result;
    //        using (new RijndaelManaged())
    //        {
    //            result = DecryptStringFromBytes(strToDecrypt, key, iv);
    //        }
    //        return result;
    //    }


    //    private static string DecryptStringFromBytes(string encryptedText, byte[] Key, byte[] IV)
    //    {
    //        int length = encryptedText.Length;
    //        byte[] array = new byte[length / 2];
    //        for (int i = 0; i < length; i += 2)
    //        {
    //            array[i / 2] = Convert.ToByte(encryptedText.Substring(i, 2), 16);
    //        }
    //        if (array == null || array.Length <= 0)
    //        {
    //            throw new ArgumentNullException("cipherText");
    //        }
    //        if (Key == null || Key.Length <= 0)
    //        {
    //            throw new ArgumentNullException("Key");
    //        }
    //        if (IV == null || IV.Length <= 0)
    //        {
    //            throw new ArgumentNullException("Key");
    //        }
    //        string result = null;
    //        using (RijndaelManaged rijndaelManaged = new RijndaelManaged())
    //        {
    //            rijndaelManaged.Key = Key;
    //            rijndaelManaged.IV = IV;
    //            ICryptoTransform transform = rijndaelManaged.CreateDecryptor(rijndaelManaged.Key, rijndaelManaged.IV);
    //            using (MemoryStream memoryStream = new MemoryStream(array))
    //            {
    //                using (CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Read))
    //                {
    //                    using (StreamReader streamReader = new StreamReader(cryptoStream))
    //                    {
    //                        result = streamReader.ReadToEnd();
    //                    }
    //                }
    //            }
    //        }
    //        return result;
    //    }

    //    /// <summary>
    //    /// variables for virtual keyboard
    //    /// </summary>
    //    static string buttonHtmlString = "<input type=\"button\" class=\"keys\" value=\"{0}\" name =\"{1}\" id=\"btnVirKey\" onclick=\"func_click(this.value);\" onmousedown = \"hashthekeys();\" onmouseout=\"unhashthekeys();\" onmouseup=\"unhashthekeys();\" />";

    //    static string buttonBackSpace = "<input type=\"button\" class=\"splkeys\" value=\"Backspace\" name=\"Backspace\" id=\"button2\" onclick=\"func_backspace();\" />";

    //    static string buttonClear = "<input type=\"button\" class=\"splkeys\" value=\"Clear\" name=\"Clear\" id=\"button2\" onclick=\"func_clear();\" />";

    //    static string buttonCapsLock = "<input type=\"button\" class=\"splkeys\" value=\"Caps Lock\" name =\"Caps Lock\" id=\"button2\" onclick=\"func_capslocktoggle();\" />";

    //    static List<string> listAlphabets = new List<string>();

    //    static List<string> listNumbers = new List<string>();

    //    static List<string> listSymbols = new List<string>();

    //    const string
    //        CurrentDemoKey = "DXCurrentDemo",
    //        CurrentThemeCookieKeyPrefix = "DXCurrentTheme",
    //         //DefaultTheme = "DevEx";                    
    //         DefaultTheme = "Office2010Blue";

    //    public static string CurrentThemeCookieKey
    //    {
    //        get { return CurrentThemeCookieKeyPrefix; }
    //    }
    //    public static string CurrentTheme
    //    {
    //        get
    //        {
    //            if (Request.Cookies[CurrentThemeCookieKey] != null)
    //                return HttpUtility.UrlDecode(Request.Cookies[CurrentThemeCookieKey].Value);
    //            return DefaultTheme;
    //        }
    //    }
    //    public static void CreateLogEntry2(string strText)
    //    {
    //        // Create a writer and open the file:
    //        StreamWriter log;
    //        string ErrorFileName = HttpContext.Current.Server.MapPath("~/Content/logAirtelBank.txt");
    //        if (!File.Exists(ErrorFileName))
    //        {
    //            log = new StreamWriter(ErrorFileName);
    //        }
    //        else
    //        {
    //            log = File.AppendText(ErrorFileName);
    //        }
    //        // Write to the file:
    //        log.WriteLine(DateTime.Now);
    //        log.WriteLine(strText);
    //        log.WriteLine();
    //        // Close the stream:
    //        log.Close();
    //    }

    //    /// <summary>
    //    /// This function is use to Encrypt the string type value
    //    /// </summary>
    //    /// <param name="param"></param>
    //    /// <returns>String type Encrypted value</returns>
    //    public static string GetEncryptedText(string str)
    //    {
    //        string strReturn = string.Empty;
    //        //EncryptionWrapper netlinkEnc = new EncryptionWrapper(); 
    //        NetlinkCommon.Cryptography.EncryptDecrypt netlinkEnc = new NetlinkCommon.Cryptography.EncryptDecrypt();
    //        //strReturn = netlinkEnc.UniqueEncrypt(studID.ToString()); //EncDec.Encrypt(studID, "p@ssw0rd");
    //        //HttpContext.Current.Server.UrlEncode(strReturn);
    //        int a = 0;
    //        //strReturn = netlinkEnc.UniqueEncrypt(studID.ToString());
    //        while ((a == 0))
    //        {
    //            strReturn = netlinkEnc.UniqueEncrypt(str.ToString());
    //            if (strReturn.Contains("/") || strReturn.Contains("+"))
    //            {
    //                a = 0;
    //            }
    //            else
    //            {
    //                a = 1;
    //            }
    //        }
    //        //strReturn = strReturn.Replace("+", "%2B").Replace("/", "%2F");

    //        //strReturn=HttpUtility.UrlEncode(strReturn);
    //        return strReturn;
    //    }
    //    public static string GetEncryptId(string param)
    //    {
    //        EncryptionWrapper netlinkEnc = new EncryptionWrapper(); //NetlinkCommon.Cryptography.EncryptDecrypt netlinkEnc = new NetlinkCommon.Cryptography.EncryptDecrypt();
    //        string strReturn = "";
    //        if (!string.IsNullOrWhiteSpace(Convert.ToString(param)))
    //        {
    //            int a = 0;
    //            //strReturn = netlinkEnc.UniqueEncrypt(studID.ToString());
    //            while ((a == 0))
    //            {
    //                strReturn = netlinkEnc.UniqueEncrypt(param.ToString());
    //                if (strReturn.Contains("%2B") || strReturn.Contains("%2F"))
    //                {
    //                    a = 0;
    //                }
    //                else
    //                {
    //                    a = 1;
    //                }
    //            }
    //            strReturn = strReturn.Replace("+", "%2B").Replace("/", "%2F");
    //        }
    //        return strReturn;
    //    }

    //    public static string GetUniqueRequestNumber(AppKeyEntity reqNoFor)
    //    {
    //        string prefix = "{0}";
    //        switch (reqNoFor)
    //        {
    //            case AppKeyEntity.Student:
    //                prefix = "S{0}";
    //                break;
    //            case AppKeyEntity.KIOSK:
    //                prefix = "A{0}";
    //                break;
    //        }
    //        return string.Format(prefix, DateTime.Now.ToString("yyyyMMddHHmmssffff"));
    //    }
    //    public static string GetBookUniqueRequestNumber(AppKeyEntity reqNoFor)
    //    {
    //        string prefix = "{0}";
    //        switch (reqNoFor)
    //        {
    //            case AppKeyEntity.Student:
    //                prefix = "B{0}";
    //                break;
    //            case AppKeyEntity.KIOSK:
    //                prefix = "A{0}";
    //                break;
    //        }
    //        return string.Format(prefix, DateTime.Now.ToString("yyyyMMddHHmmssffff"));
    //    }
    //    static HttpContext Context
    //    {
    //        get { return HttpContext.Current; }
    //    }

    //    static HttpRequest Request
    //    {
    //        get { return Context.Request; }
    //    }

    //    public static string ErrorImage
    //    {
    //        get
    //        {
    //            return GetApplicationPath() + "/Content/images/edtError.png";
    //        }
    //    }

    //    public static AjaxOptions ConfigAjaxOptions()
    //    {
    //        AjaxOptions options = new AjaxOptions();
    //        options.HttpMethod = "Post";
    //        options.OnSuccess = "OnSuccess";
    //        options.OnBegin = "LockUIOnCallback('true')";
    //        options.LoadingElementId = "PleaseWait";
    //        options.OnComplete = "LockUIOnCallback('false')";
    //        options.OnFailure = "OnFail";
    //        return options;
    //    }

    //    public static AjaxOptions ConfigAjaxOptionsMsgThenAction()
    //    {
    //        AjaxOptions options = new AjaxOptions();
    //        options.HttpMethod = "Post";
    //        options.OnSuccess = "OnSuccessMsgThenAction";
    //        options.OnBegin = "LockUIOnCallback('true')";
    //        options.LoadingElementId = "PleaseWait";
    //        options.OnComplete = "LockUIOnCallback('false')";
    //        options.LoadingElementDuration = 1000;
    //        options.OnFailure = "OnFail";
    //        return options;
    //    }

    //    //public static string CurrentThemeCookieKey
    //    //{
    //    //    get { return CurrentThemeCookieKeyPrefix + DemosModel.Current.Key; }
    //    //}


    //    //public static string CurrentTheme
    //    //{
    //    //    get
    //    //    {
    //    //        if (Request.Cookies[CurrentThemeCookieKey] != null)
    //    //            return HttpUtility.UrlDecode(Request.Cookies[CurrentThemeCookieKey].Value);
    //    //        return DefaultTheme;
    //    //    }
    //    //}

    //    public static UrlHelper GetUrlHelper()
    //    {
    //        return new UrlHelper(HttpContext.Current.Request.RequestContext);
    //    }

    //    public static string GetActionPath(RequestContext requestContext, string controllerName, string actionName)
    //    {
    //        return GetApplicationPath(requestContext) + string.Format("/{0}/{1}", controllerName, actionName);
    //    }

    //    public static string GetApplicationPath(RequestContext requestContext)
    //    {
    //        string retPath;
    //        string httpOrigin = Request.ServerVariables["HTTP_ORIGIN"];
    //        string applicationPath = Request.ApplicationPath;
    //        //Approach #1: OK:Post
    //        //retPath = (applicationPath == "/" ? httpOrigin : httpOrigin + applicationPath);
    //        //Approach #2 OK:All
    //        retPath = string.Format("{0}://{1}", Request.Url.Scheme, Request.Url.Authority) + (applicationPath == "/" ? "" : applicationPath);
    //        return retPath;
    //    }

    //    public static string GetApplicationPath()
    //    {
    //        string retPath;
    //        string applicationPath = Request.ApplicationPath;
    //        retPath = string.Format("{0}://{1}", Request.Url.Scheme, Request.Url.Authority) + (applicationPath == "/" ? "" : applicationPath);
    //        return retPath;
    //    }

    //    public static string NewSMSapi(string mobileNos, string SMSText)
    //    {
    //        string strUrl, strmethod, strSendto, strSenderId, strSmSTextmessage, strResponse, strapikey = "";
    //        strUrl = "http://alerts.valueleaf.com/api/v4/?";

    //        strmethod = "sms";

    //        strapikey = "Afffea29cd103f8466ff25c825d6b5529";

    //        strSendto = mobileNos;

    //        strSenderId = "AISECT";

    //        strSmSTextmessage = SMSText;







    //        strUrl += "api_key=" + HttpUtility.UrlEncode(strapikey);

    //        strUrl += "&method=" + HttpUtility.UrlEncode(strmethod);

    //        strUrl += "&message=" + HttpUtility.UrlEncode(strSmSTextmessage);

    //        strUrl += "&to=" + HttpUtility.UrlEncode(strSendto);

    //        strUrl += "&sender=" + HttpUtility.UrlEncode(strSenderId);



    //        //strUrl += "&unicode=" + HttpUtility.UrlEncode(strunicode);



    //        //string TestURL = "http://alerts.valueleaf.com/api/v4/?api_key=Afffea29cd103f8466ff25c825d6b5529&method=sms&message=Test+sms&to=7617223344&sender=AISECT";





    //        //strUrl += "&message=" + strMsgText;

    //        Uri objURI = new Uri(strUrl);

    //        WebRequest objWebRequest = WebRequest.Create(objURI);

    //        WebResponse objWebResponse = objWebRequest.GetResponse();

    //        Stream objStream = objWebResponse.GetResponseStream();

    //        StreamReader objStreamReader = new StreamReader(objStream);

    //        strResponse = objStreamReader.ReadToEnd();

    //        //Utils.CreateLogEntry(strResponse);

    //        return strResponse;
    //    }



    //    #region Sending Emails and SMS

    //    public static void sendInsuranceGHIDetails2(string custName, string CustMob, string Location, string insType, string BmName, string BLocation, string BCode, string BMob)
    //    {
    //        try
    //        {
    //            INotification notification = new EmailNotification();
    //            Event evt = EventFactory.create(30);
    //            evt.content = decorateMailContentGHI(evt.getTemplate(), custName, CustMob, Location, insType, BmName, BLocation, BCode, BMob);
    //            evt.subject = "Group Health Insurance Alert";
    //            evt.to = "sameerap@aisect.org,cordi19@aisect.org";
    //            evt.from = ConfigurationManager.AppSettings["MailFrom"];
    //            notification.sendMail(evt);
    //        }
    //        catch (Exception ex)
    //        {
    //        }
    //    }
    //    private static string decorateMailContentGHI(string data, string custName, string CustMob, string Location, string insType, string BmName, string BLocation, string BCode, string BMob)
    //    {
    //        String content = data;
    //        content = content.Replace("<REPSTR1>", custName);
    //        content = content.Replace("<REPSTR2>", CustMob);
    //        content = content.Replace("<REPSTR3>", Location);
    //        content = content.Replace("<REPSTR4>", insType);
    //        content = content.Replace("<REPSTR6>", BmName);
    //        content = content.Replace("<REPSTR7>", BLocation);
    //        content = content.Replace("<REPSTR8>", BCode);
    //        content = content.Replace("<REPSTR9>", BMob);
    //        //content = content.Replace("<REPSTR5>", CompanyNa);
    //        content = content.Replace("\\n", "</br>");
    //        return content;
    //    }


    //    public static void sendPasswordStudent(string fullName, string email, string username, string password, string mailSubject, string preloginURL)
    //    {
    //        try
    //        {
    //            INotification notification = new EmailNotification();
    //            Event evt = EventFactory.create(28);
    //            evt.content = decorateMailContentAssociateStudent(evt.getTemplate(), fullName, email, username, password, mailSubject, preloginURL);
    //            evt.subject = mailSubject;
    //            evt.to = email;
    //            //evt.
    //            evt.from = ConfigurationManager.AppSettings["MailFrom"];
    //            notification.sendMail(evt);
    //        }
    //        catch (Exception ex)
    //        {
    //        }
    //    }

    //    public static void sendPasswordCitizen(string fullName, string email, string username, string password, string mailSubject)
    //    {
    //        try
    //        {
    //            INotification notification = new EmailNotification();
    //            Event evt = EventFactory.create(40);
    //            evt.content = decorateMailContentCitizenForgot(evt.getTemplate(), fullName, email, username, password, mailSubject);
    //            evt.subject = mailSubject;
    //            evt.to = email;
    //            //evt.
    //            evt.from = ConfigurationManager.AppSettings["MailFrom"];
    //            notification.sendMail(evt);
    //        }
    //        catch (Exception ex)
    //        {
    //        }
    //    }


    //    public static string decorateMailContentAssociateStudent(string data, string fullname, string email, string userName, string Password, string mailSubject, string preloginURL)
    //    {
    //        string content = data;


    //        content = content.Replace("<REPSTR1>", userName);
    //        content = content.Replace("<REPSTR2>", Password);
    //        content = content.Replace("<REPSTR3>", fullname);
    //        content = content.Replace("<REPSTR4>", mailSubject);
    //        content = content.Replace("<REPSTR5>", preloginURL);
    //        //content = content.Replace("<REPSTR2>", email);




    //        return content;
    //    }

    //    public static string decorateMailContentCitizenForgot(string data, string fullname, string email, string userName, string Password, string mailSubject)
    //    {
    //        string content = data;


    //        content = content.Replace("<REPSTR1>", userName);
    //        content = content.Replace("<REPSTR2>", Password);
    //        content = content.Replace("<REPSTR3>", fullname);
    //        content = content.Replace("<REPSTR4>", mailSubject);
    //        //content = content.Replace("<REPSTR5>", preloginURL);
    //        //content = content.Replace("<REPSTR2>", email);




    //        return content;
    //    }


    //    public static void sendNewKioskRequestEmailMultiSkill(string kioskcode, string LoginId, string LoginPassword, string emailId, string TransactionPwd, string Service)
    //    {
    //        try
    //        {
    //            INotification notification = new EmailNotification();
    //            Event evt = EventFactory.create(24);
    //            evt.content = decorateMailContentForMulti(evt.getTemplate(), kioskcode, LoginId, LoginPassword, TransactionPwd, Service);
    //            evt.subject = "Application for Kiosk Registration- Multi Service Center";
    //            evt.to = emailId;
    //            evt.from = ConfigurationManager.AppSettings["MailFrom"];
    //            notification.sendMail(evt);
    //        }
    //        catch (Exception ex)
    //        {
    //        }
    //    }

    //    public static void sendMutliSkillCompaignAndMaterial(string emailId)
    //    {
    //        try
    //        {
    //            INotification notification = new EmailNotification();
    //            Event evt = EventFactory.create(37);
    //            evt.content = decorateMailContentForMulti(evt.getTemplate(), emailId);
    //            evt.subject = "Campaigning and Counseling Material";
    //            evt.to = emailId;
    //            evt.from = ConfigurationManager.AppSettings["MailFrom"];
    //            notification.sendMail(evt);
    //        }
    //        catch (Exception ex)
    //        {
    //        }
    //    }
    //    public static string decorateMailContentForMulti(string data, string emailIds)
    //    {
    //        string content = data;

    //        content = content.Replace("<REPSTR1>", emailIds);



    //        return content;
    //    }
    //    public static string decorateMailContentForMulti(string data, string kioskcode, string LoginId, string LoginPassword, string TransactionPwd, string Service)
    //    {
    //        string content = data;

    //        content = content.Replace("<REPSTR1>", kioskcode);
    //        content = content.Replace("<REPSTR2>", LoginId);
    //        content = content.Replace("<REPSTR3>", LoginPassword);
    //        content = content.Replace("<REPSTR4>", TransactionPwd);
    //        content = content.Replace("<REPSTR5>", Service);


    //        return content;
    //    }



    //    public static void sendInsuranceLeadDetails1(string custName, string CustMob, string LandLine, string PostalAdd, string CompanyNa, string BmName, string BLocation, string BCode, string BMob)
    //    {

    //        try
    //        {
    //            INotification notification = new EmailNotification();
    //            Event evt = EventFactory.create(22);
    //            evt.content = decorateMailContent(evt.getTemplate(), custName, CustMob, LandLine, PostalAdd, CompanyNa, BmName, BLocation, BCode, BMob);
    //            evt.subject = "Insurance Lead";
    //            evt.to = "ulhas@aisect.org,cordi19@aisect.org";
    //            evt.from = ConfigurationManager.AppSettings["MailFrom"];
    //            notification.sendMail(evt);
    //        }
    //        catch (Exception ex)
    //        {
    //        }
    //    }
    //    public static void sendInsuranceLeadDetails2(string custName, string CustMob, string LandLine, string PostalAdd, string CompanyNa, string BmName, string BLocation, string BCode, string BMob)
    //    {
    //        try
    //        {
    //            INotification notification = new EmailNotification();
    //            Event evt = EventFactory.create(22);
    //            evt.content = decorateMailContent(evt.getTemplate(), custName, CustMob, LandLine, PostalAdd, CompanyNa, BmName, BLocation, BCode, BMob);
    //            evt.subject = "Insurance Lead";
    //            evt.to = "sameerap@aisect.org";
    //            evt.from = ConfigurationManager.AppSettings["MailFrom"];
    //            notification.sendMail(evt);
    //        }
    //        catch (Exception ex)
    //        {
    //        }
    //    }

    //    public static void sendNewKioskRequestEmail(string displayName, string requestId, string kioskType, string service, string emailId, string CityName)
    //    {
    //        try
    //        {
    //            INotification notification = new EmailNotification();
    //            Event evt = EventFactory.create(1);
    //            evt.content = decorateMailContent(evt.getTemplate(), displayName, requestId, kioskType, service, CityName);
    //            evt.subject = "Application for Kiosk Registration";//20
    //            evt.to = emailId;
    //            // evt.
    //            //evt.
    //            evt.from = ConfigurationManager.AppSettings["MailFrom"];
    //            notification.sendMail(evt);
    //        }
    //        catch (Exception ex)
    //        {
    //        }
    //    }

    //    //public static void sendNewKioskRequestEmail2(string displayName, string requestId, string kioskType, string service, string emailId, string CityName)
    //    //{
    //    //    try
    //    //    {
    //    //        INotification notification = new EmailNotification();
    //    //        Event evt = EventFactory.create(1);
    //    //        evt.content = decorateMailContent(evt.getTemplate(), displayName, requestId, kioskType, service, CityName);
    //    //        evt.subject = "Application for Kiosk Registration";
    //    //        evt.to = emailId;
    //    //        //evt.cc = "nsinha586@gmail.com";
    //    //        evt.from = ConfigurationManager.AppSettings["MailFrom2"];
    //    //        notification.sendMail(evt);
    //    //    }
    //    //    catch (Exception ex)
    //    //    {
    //    //    }
    //    //}

    //    public static void sendKioskStatus(string KioskCode, string EmailId, string Status)
    //    {
    //        try
    //        {
    //            INotification notification = new EmailNotification();
    //            Event evt = EventFactory.create(21);
    //            if (Status == "Activated/Re-Opened")
    //            {
    //                evt.subject = "Your Center has been Activated";//20
    //            }
    //            else
    //            {
    //                evt.subject = "Your Center has been Deactivated";//20
    //            }
    //            evt.content = decorateMailContent(evt.getTemplate(), KioskCode, Status);

    //            evt.to = EmailId;
    //            evt.from = ConfigurationManager.AppSettings["MailFrom"];
    //            notification.sendMail(evt);
    //        }
    //        catch (Exception ex)
    //        {
    //        }
    //    }
    //    //

    //    public static string decorateMailContentDeactivateCenter(string data, string KioskCode, string Name, string Address, string Block, string Pincode, string District, string state, string Mobile, string Email, string centerType, string datetime)
    //    {
    //        string content = data;

    //        content = content.Replace("<REPSTR1>", KioskCode);
    //        content = content.Replace("<REPSTR2>", Name);
    //        content = content.Replace("<REPSTR3>", Address);
    //        content = content.Replace("<REPSTR4>", Block);
    //        content = content.Replace("<REPSTR5>", Pincode);
    //        content = content.Replace("<REPSTR6>", District);
    //        content = content.Replace("<REPSTR7>", state);

    //        content = content.Replace("<REPSTR8>", Mobile);
    //        content = content.Replace("<REPSTR9>", Email);
    //        content = content.Replace("<REPSTR10>", centerType);
    //        content = content.Replace("<REPSTR11>", datetime);

    //        return content;
    //    }

    //    public static void sendKioskStatusDeactivate(string KioskCode, string Name, string Address, string Block, string Pincode, string District, string state, string Mobile, string Email, string centerType, string datetime)
    //    {
    //        try
    //        {
    //            INotification notification = new EmailNotification();
    //            Event evt = EventFactory.create(32);
    //            //datetime = DateTime.Now.ToShortDateString();

    //            evt.subject = "Your Center has been Deactivated";//20

    //            evt.content = decorateMailContentDeactivateCenter(evt.getTemplate(), KioskCode, Name, Address, Block, Pincode, District, state, Mobile, Email, centerType, datetime);

    //            evt.to = Email;
    //            evt.from = ConfigurationManager.AppSettings["MailFrom"];
    //            notification.sendMail(evt);
    //        }
    //        catch (Exception ex)
    //        {
    //        }
    //    }


    //    //
    //    public static void sendNewStudentRegistrationEmail(string displayName, string requestId, string kiosktype, string emailId, string portalName, string session)
    //    {
    //        try
    //        {
    //            INotification notification = new EmailNotification();
    //            Event evt = EventFactory.create(8);
    //            evt.content = decorateMailContent(evt.getTemplate(), displayName, requestId, kiosktype, portalName, session);
    //            evt.subject = "Your registration to AISECT is completed sucessfully";
    //            evt.to = emailId;
    //            evt.from = ConfigurationManager.AppSettings["MailFrom"];
    //            notification.sendMail(evt);
    //        }
    //        catch (Exception ex)
    //        {
    //        }
    //    }

    //    public static void sendGRSEmail(string CompNo, string Subject, string AnsbyDepartment, string copmbyBranch, string emailId)
    //    {
    //        try
    //        {
    //            INotification notification = new EmailNotification();
    //            Event evt = EventFactory.create(25);
    //            evt.content = decorateMailContent(evt.getTemplate(), CompNo, Subject, AnsbyDepartment, copmbyBranch, null);
    //            evt.subject = "Your Complaint is Done Please Check";
    //            evt.to = emailId;
    //            evt.from = ConfigurationManager.AppSettings["MailFromGRS"];
    //            notification.sendMail(evt);
    //        }
    //        catch (Exception ex)
    //        {
    //        }
    //    }

    //    //
    //    //Utils.sendAssocaitewithusEmail(contact.name, contact.EmailId, contact.mobNo, contact.State, contact.Loacation, contact.Address, contact.SelectedItems, contact.Message);
    //    public static void sendAssocaitewithusEmail(string name, string email, string mobno, string state, string location, string address, string selItems, string msg)
    //    {
    //        try
    //        {
    //            INotification notification = new EmailNotification();
    //            Event evt = EventFactory.create(26);
    //            evt.content = decorateMailContentAssociate(evt.getTemplate(), name, email, mobno, state, location, address, selItems, msg);
    //            evt.subject = "Contact request from Associate With Us-www.aisectonline.com";
    //            evt.to = "newcentre@aisect.org,cordi19@aisect.org";
    //            //evt.
    //            evt.from = ConfigurationManager.AppSettings["MailFrom"];
    //            notification.sendMail(evt);
    //        }
    //        catch (Exception ex)
    //        {
    //        }
    //    }
    //    //public static void sendBirthDayWishEmail(string SKPName, string emailId)
    //    //{
    //    //    try
    //    //    {
    //    //        INotification notification = new EmailNotification();
    //    //        Event evt = EventFactory.create(41);//20
    //    //        evt.content = decorateMailContent(evt.getTemplate(), SKPName, emailId);
    //    //        //evt.subject = "Password Info";
    //    //        evt.subject = "BirthDay Reminder";
    //    //        evt.to = emailId;
    //    //        evt.from = ConfigurationManager.AppSettings["MailFrom"];
    //    //        notification.sendMail(evt);
    //    //    }
    //    //    catch (Exception ex)
    //    //    {
    //    //    }
    //    //}


    //    public static void sendBirthDayWishEmail(string SKPName, string emailId)
    //    {
    //        try
    //        {
    //            INotification notification = new EmailNotification();
    //            Event evt = EventFactory.create(41);//20
    //            evt.content = decorateMailContent(evt.getTemplate(), SKPName, emailId);
    //            //evt.subject = "Password Info";
    //            evt.subject = "Wishing you a very Happy Birthday";
    //            evt.to = emailId + ",cordi20@aisect.org";

    //            evt.from = ConfigurationManager.AppSettings["MailFrom"];
    //            notification.sendMail(evt);
    //        }
    //        catch (Exception ex)
    //        {
    //        }
    //    }

    //    public static void sendEnquiryEmail(string email)
    //    {
    //        try
    //        {
    //            INotification notification = new EmailNotification();
    //            Event evt = EventFactory.create(33);
    //            evt.content = decorateMailContentEnquiry(evt.getTemplate(), email);
    //            evt.subject = "Auto generated message";
    //            evt.to = email;
    //            //evt.
    //            evt.from = "aisectonlineho@aisect.org";
    //            notification.sendMail(evt);
    //        }
    //        catch (Exception ex)
    //        {
    //        }
    //    }


    //    //public static void sendAssocaitewithusEmailStudent(string email)
    //    //{
    //    //    try
    //    //    {
    //    //        INotification notification = new EmailNotification();
    //    //        Event evt = EventFactory.create(27);
    //    //        evt.content = decorateMailContentAssociateStudent(evt.getTemplate(), email);
    //    //        evt.subject = "Contact request from Association With Us";
    //    //        evt.to = email;
    //    //        //evt.
    //    //        evt.from = ConfigurationManager.AppSettings["MailFrom"];
    //    //        notification.sendMail(evt);
    //    //    }
    //    //    catch (Exception ex)
    //    //    {
    //    //    }
    //    //}




    //    public static string decorateMailContentEnquiry(string data, string email)
    //    {
    //        string content = data;

    //        content = content.Replace("<REPSTR2>", email);

    //        return content;
    //    }





    //    public static void sendAssocaitewithusEmailStudent(string email)
    //    {
    //        try
    //        {
    //            INotification notification = new EmailNotification();
    //            Event evt = EventFactory.create(27);
    //            evt.content = decorateMailContentAssociateStudent(evt.getTemplate(), email);
    //            evt.subject = "Contact request from Association With Us";
    //            evt.to = email;
    //            //evt.
    //            evt.from = ConfigurationManager.AppSettings["MailFrom"];
    //            notification.sendMail(evt);
    //        }
    //        catch (Exception ex)
    //        {
    //        }
    //    }



    //    public static string decorateMailContentAssociate(string data, string name, string email, string mobno, string state, string location, string address, string selItems, string msg)
    //    {
    //        string content = data;

    //        content = content.Replace("<REPSTR1>", name);
    //        content = content.Replace("<REPSTR2>", email);
    //        content = content.Replace("<REPSTR3>", mobno);
    //        content = content.Replace("<REPSTR4>", state);
    //        content = content.Replace("<REPSTR5>", location);
    //        content = content.Replace("<REPSTR6>", address);
    //        content = content.Replace("<REPSTR7>", selItems);
    //        content = content.Replace("<REPSTR8>", msg);



    //        return content;
    //    }

    //    public static string decorateMailContentAssociateStudent(string data, string email)
    //    {
    //        string content = data;


    //        content = content.Replace("<REPSTR2>", email);




    //        return content;
    //    }
    //    //
    //    public static void sendNewStudentRegistrationEmailFSA(string displayName, string emailId, string requestId, string course, string LoginId, string Password)
    //    {
    //        try
    //        {
    //            INotification notification = new EmailNotification();
    //            Event evt = EventFactory.create(34);
    //            evt.content = decorateMailContentCampusFSA(evt.getTemplate(), displayName, requestId, course, LoginId, Password);
    //            evt.subject = "Your registration to AISECT is completed sucessfully";
    //            evt.to = emailId;
    //            evt.from = ConfigurationManager.AppSettings["MailFrom"];
    //            notification.sendMail(evt);
    //        }
    //        catch (Exception ex)
    //        {
    //        }
    //    }
    //    //kiosk renewal success start
    //    public static string decorateMailContentRenewalSuccess(string data, string SKP, string AcademyName, string renewal1, string aorenewal)
    //    {
    //        string content = data;

    //        content = content.Replace("<REPSTR1>", SKP);
    //        content = content.Replace("<REPSTR2>", AcademyName);
    //        content = content.Replace("<REPSTR3>", renewal1);
    //        content = content.Replace("<REPSTR4>", aorenewal);
    //        // content = content.Replace("<REPSTR4>", LoginId);
    //        // content = content.Replace("<REPSTR5>", Password);

    //        return content;
    //    }

    //    public static void sendKioskRenewalSuccess(string SKP, string emailId, string AcademyName, string renewal1, string aorenewal)
    //    {
    //        try
    //        {
    //            INotification notification = new EmailNotification();
    //            Event evt = EventFactory.create(35);
    //            evt.content = decorateMailContentRenewalSuccess(evt.getTemplate(), SKP, AcademyName, renewal1, aorenewal);
    //            evt.subject = "Kiosk Renewal FY 2025-26";
    //            evt.to = emailId;
    //            evt.from = ConfigurationManager.AppSettings["MailFrom"];
    //            notification.sendMail(evt);
    //        }
    //        catch (Exception ex)
    //        {
    //        }
    //    }
    //    //kiosk renewal success End
    //    //Campus-Direct Admission Mail & SMS Starts
    //    public static void sendNewStudentRegistrationEmailCampus(string displayName, string requestId, string emailId)
    //    {
    //        try
    //        {
    //            INotification notification = new EmailNotification();
    //            Event evt = EventFactory.create(8);
    //            evt.content = decorateMailContentCampus(evt.getTemplate(), displayName, requestId);
    //            evt.subject = "Your registration to AISECT is completed sucessfully";
    //            evt.to = emailId;
    //            evt.from = ConfigurationManager.AppSettings["MailFrom"];
    //            notification.sendMail(evt);
    //        }
    //        catch (Exception ex)
    //        {
    //        }
    //    }



    //    public static string decorateMailContentCampusFSA(string data, string Name, string RequestNo, string course, string LoginId, string Password)
    //    {
    //        string content = data;

    //        content = content.Replace("<REPSTR1>", Name);
    //        content = content.Replace("<REPSTR2>", RequestNo);
    //        content = content.Replace("<REPSTR3>", course);
    //        content = content.Replace("<REPSTR4>", LoginId);
    //        content = content.Replace("<REPSTR5>", Password);

    //        return content;
    //    }
    //    public static string decorateMailContentCampus(string data, string Name, string RequestNo)
    //    {
    //        string content = data;

    //        content = content.Replace("<REPSTR1>", Name);
    //        content = content.Replace("<REPSTR2>", RequestNo);
    //        //content = content.Replace("<REPSTR3>", status);
    //        //content = content.Replace("<REPSTR4>", strFormat4);
    //        return content;
    //    }

    //    public static void sendNewStudentRegistrationSMSCampus(string displayName, string MobileNo, string RequestNo, string SmsText)
    //    {
    //        if (MobileNo.Length > 0)
    //        {
    //            string mobileNo = "";
    //            string smsTxt = "";
    //            for (int h = 0; h < MobileNo.Length; h++)
    //            {
    //                mobileNo = mobileNo + MobileNo[h];
    //                if (mobileNo.Length == 10)
    //                {
    //                    mobileNo = "91" + mobileNo;
    //                }
    //                else
    //                {
    //                    if (mobileNo.IndexOf("0") == 0)
    //                    {
    //                        mobileNo = mobileNo.Substring(1, (mobileNo.Length) - 1);
    //                        mobileNo = "91" + mobileNo;
    //                    }
    //                }
    //            }
    //            smsTxt = Utils.GetSMSText(SmsText, displayName, RequestNo, null, null, null, null);
    //            Utils.SendSMS(mobileNo, smsTxt, SMSStatus.RegistrationSuccess);
    //        }
    //    }
    //    //
    //    public static void sendAddEditServicesEmail(string displayName, string kioskCenter, string kioskCenterCode, string kioskType, string service, string emailId)
    //    {
    //        try
    //        {
    //            INotification notification = new EmailNotification();
    //            Event evt = EventFactory.create(4);
    //            evt.content = decorateMailContent(evt.getTemplate(), displayName, kioskCenter, kioskCenter, kioskType, service);
    //            evt.subject = "Your request for Add/Edit Service(s) is submitted successfully.";
    //            evt.to = emailId;
    //            evt.from = ConfigurationManager.AppSettings["MailFrom"];
    //            notification.sendMail(evt);
    //        }
    //        catch (Exception ex)
    //        {
    //        }
    //    }
    //    //Retvalue=-1
    //    public static void sendStudentEditMail(string studentid, string studentName, string CourseName, string KioskCode, string Email, string UserId, string IpAddress, string StudentCourse)
    //    {
    //        try
    //        {
    //            INotification notification = new EmailNotification();
    //            Event evt = EventFactory.create(23);
    //            evt.content = decorateMailContentStudentEdit(evt.getTemplate(), studentid, studentName, CourseName, KioskCode, UserId, IpAddress, StudentCourse);

    //            evt.subject = "Student Edit Alert";
    //            evt.to = Email;
    //            evt.from = ConfigurationManager.AppSettings["MailFrom"];
    //            notification.sendMail(evt);
    //        }
    //        catch (Exception ex)
    //        {
    //        }
    //    }
    //    private static string decorateMailContentStudentEdit(string data, string strStuId, string strStuName, string strRegNo, string strKioskCode, string strUserId, string StrIPAddress, string StudentCourse)
    //    {
    //        String content = data;
    //        content = content.Replace("<REPSTR1>", strStuId);
    //        content = content.Replace("<REPSTR2>", strStuName);
    //        content = content.Replace("<REPSTR3>", strRegNo);
    //        content = content.Replace("<REPSTR4>", strKioskCode);
    //        content = content.Replace("<REPSTR5>", strUserId);
    //        content = content.Replace("<REPSTR6>", StrIPAddress);
    //        content = content.Replace("<REPSTR7>", StudentCourse);
    //        //content = content.Replace("<REPSTR7>", strFormat7);
    //        content = content.Replace("\\n", "</br>");
    //        return content;
    //    }

    //    //public static void sendStudentEditMail(string studentid, string studentName, string CourseName, string KioskCode, string Email, string UserId, string IpAddress)
    //    //{
    //    //    try
    //    //    {
    //    //        INotification notification = new EmailNotification();
    //    //        Event evt = EventFactory.create(23);
    //    //        evt.content = decorateMailContent(evt.getTemplate(), studentid, studentName, CourseName, KioskCode, UserId, IpAddress);

    //    //        evt.subject = "Student Edit Alert";
    //    //        evt.to = Email;
    //    //        evt.from = ConfigurationManager.AppSettings["MailFrom"];
    //    //        notification.sendMail(evt);
    //    //    }
    //    //    catch (Exception ex)
    //    //    {
    //    //    }
    //    //}
    //    //private static string decorateMailContent(string data, string strStuId, string strStuName, string strRegNo, string strKioskCode, string strUserId, string StrIPAddress)
    //    //{
    //    //    String content = data;
    //    //    content = content.Replace("<REPSTR1>", strStuId);
    //    //    content = content.Replace("<REPSTR2>", strStuName);
    //    //    content = content.Replace("<REPSTR3>", strRegNo);
    //    //    content = content.Replace("<REPSTR4>", strKioskCode);
    //    //    content = content.Replace("<REPSTR5>", strUserId);
    //    //    content = content.Replace("<REPSTR6>", StrIPAddress);
    //    //    //content = content.Replace("<REPSTR7>", strFormat7);
    //    //    content = content.Replace("\\n", "</br>");
    //    //    return content;
    //    //}





    //    public static void sendAppRejServicesEmail(string displayName, string kioskCenter, string kioskCenterCode, string kioskType, string serviceApp, string serviceRej, string emailId)
    //    {
    //        try
    //        {
    //            INotification notification = new EmailNotification();
    //            Event evt = EventFactory.create(3);
    //            evt.content = decorateMailContent(evt.getTemplate(), displayName, kioskCenter, kioskType, serviceApp, serviceRej);
    //            evt.subject = "Services Approvals.";//20
    //            evt.to = emailId;
    //            evt.from = ConfigurationManager.AppSettings["MailFrom"];
    //            notification.sendMail(evt);
    //        }
    //        catch (Exception ex)
    //        {
    //        }
    //    }

    //    public static void sendLoginInfoEmail(string displayName, string userName, string loginId, string password, string transPassword, string emailId, string kioskCode, string service, int academy)
    //    {
    //        try
    //        {
    //            INotification notification = new EmailNotification();
    //            Event evt = EventFactory.create(2);
    //            evt.content = decorateMailContent(evt.getTemplate(), displayName, userName, loginId, password, transPassword, kioskCode, service);
    //            evt.subject = "Login Info "; //20
    //            evt.to = emailId;
    //            evt.from = ConfigurationManager.AppSettings["MailFrom"];
    //            notification.sendMail(evt);
    //        }
    //        catch (Exception ex)
    //        {
    //        }
    //    }
    //    public static void sendLoginInfoEmail(string kioskCode, string service, string displayName, string userName, string loginId, string password, string transPassword, string emailId)
    //    {
    //        try
    //        {
    //            INotification notification = new EmailNotification();
    //            Event evt = EventFactory.create(2);
    //            evt.content = decorateMailContent(evt.getTemplate(), displayName, userName, loginId, password, transPassword);
    //            evt.subject = "Login Info ";//20
    //            evt.to = emailId;
    //            evt.from = ConfigurationManager.AppSettings["MailFrom"];
    //            notification.sendMail(evt);
    //        }
    //        catch (Exception ex)
    //        {
    //        }
    //    }


    //    //public static void sendStudentRejectInfoEmail(string displayName, string loginId, string password, string emailId, string service)
    //    //{
    //    //    try
    //    //    {
    //    //        INotification notification = new EmailNotification();
    //    //        Event evt = EventFactory.create(17);
    //    //        evt.content = decorateMailContent(evt.getTemplate(), displayName, loginId, password, service, null);
    //    //        evt.subject = "Your Form Is Rejected";
    //    //        evt.to = emailId;
    //    //        evt.from = ConfigurationManager.AppSettings["MailFrom"];
    //    //        notification.sendMail(evt);
    //    //    }
    //    //    catch (Exception ex)
    //    //    {
    //    //    }
    //    //}
    //    public static void sendStudentRejectInfoEmail(string EmailID, string studReg, string stuname, string stuFathername, string course, string session, string mobile, string reason)
    //    {
    //        try
    //        {
    //            INotification notification = new EmailNotification();
    //            Event evt = EventFactory.create(17);
    //            evt.content = decorateMailContent(evt.getTemplate(), studReg, stuname, stuFathername, course, session, mobile, reason);
    //            evt.subject = "Rejected Student Details";
    //            evt.to = EmailID;
    //            evt.from = ConfigurationManager.AppSettings["MailFrom"];
    //            notification.sendMail(evt);
    //        }
    //        catch (Exception ex)
    //        {
    //        }
    //    }



    //    public static void sendStudentUpdateEmail(string Email, string studReg, string str2, string str3, string str4, string str5, string str6, string str7, string str8, string str9, string str10, string str11, string str12, string str13, string str14, string UserName)
    //    {
    //        try
    //        {
    //            INotification notification = new EmailNotification();
    //            Event evt = EventFactory.create(19);
    //            evt.content = decorateMailContent(evt.getTemplate(), Email, studReg, str2, str3, str4, str5, str6, str7, str8, str9, str10, str11, str12, str13, str14, UserName);
    //            evt.subject = "Student Details";
    //            evt.to = Email;

    //            evt.from = ConfigurationManager.AppSettings["MailFrom"];
    //            notification.sendMail(evt);
    //        }
    //        catch (Exception ex)
    //        {
    //        }
    //    }
    //    //public static void sendStudentUpdateEmail2(string studReg, string str2, string str3, string str4, string str5, string str6, string str7, string str8, string str9, string str10, string str11, string str12, string str13, string str14, string UserName)
    //    //{
    //    //    try
    //    //    {
    //    //        INotification notification = new EmailNotification();
    //    //        Event evt = EventFactory.create(19);
    //    //        evt.content = decorateMailContent(evt.getTemplate(), studReg, str2, str3, str4, str5, str6, str7, str8, str9, str10, str11, str12, str13, str14, UserName);
    //    //        evt.subject = "Student Details";
    //    //        evt.to = "yatin@aisect.org";

    //    //        evt.from = ConfigurationManager.AppSettings["MailFrom"];
    //    //        notification.sendMail(evt);
    //    //    }
    //    //    catch (Exception ex)
    //    //    {
    //    //    }
    //    //}
    //    //public static void sendStudentUpdateEmail3(string studReg, string str2, string str3, string str4, string str5, string str6, string str7, string str8, string str9, string str10, string str11, string str12, string str13, string str14,string str15)
    //    //{
    //    //    try
    //    //    {
    //    //        INotification notification = new EmailNotification();
    //    //        Event evt = EventFactory.create(19);
    //    //        evt.content = decorateMailContent(evt.getTemplate(), studReg, str2, str3, str4, str5, str6, str7, str8, str9, str10, str11, str12, str13, str14,str15);
    //    //        evt.subject = "Student Details";
    //    //        evt.to = "mannojshukla@gmail.com";

    //    //        evt.from = ConfigurationManager.AppSettings["MailFrom"];
    //    //        notification.sendMail(evt);
    //    //    }
    //    //    catch (Exception ex)
    //    //    {
    //    //    }
    //    //}

    //    //On Student Cancellation



    //    public static string decorateMailContent(string data, string KioskCode, string status)
    //    {
    //        string content = data;

    //        content = content.Replace("<REPSTR1>", KioskCode);
    //        content = content.Replace("<REPSTR2>", status);
    //        //content = content.Replace("<REPSTR3>", status);
    //        //content = content.Replace("<REPSTR4>", strFormat4);


    //        return content;
    //    }



    //    public static string decorateMailContentStudentDocument(string data, string FirstName, string DocuName, string RequestNo, string status, string Remarks)
    //    {
    //        string content = data;

    //        //content = content.Replace("<REPSTR1>", KioskCode);


    //        content = content.Replace("<REPSTR1>", FirstName);
    //        content = content.Replace("<REPSTR2>", DocuName);
    //        content = content.Replace("<REPSTR3>", RequestNo);
    //        content = content.Replace("<REPSTR4>", status);
    //        content = content.Replace("<REPSTR5>", Remarks);
    //        //content = content.Replace("<REPSTR4>", strFormat4);


    //        return content;
    //    }

    //    public static string decorateMailContentAssociate(string data, string name, string email, string strFormat1, string strFormat2, string strFormat3, string strFormat4, string strFormat5, string strFormat6, string strFormat7)
    //    {
    //        string content = data;

    //        content = content.Replace("<REPSTR1>", name);
    //        content = content.Replace("<REPSTR2>", email);
    //        content = content.Replace("<REPSTR3>", strFormat1);
    //        content = content.Replace("<REPSTR4>", strFormat2);
    //        content = content.Replace("<REPSTR5>", strFormat3);
    //        content = content.Replace("<REPSTR6>", strFormat4);
    //        content = content.Replace("<REPSTR7>", strFormat5);
    //        content = content.Replace("<REPSTR6>", strFormat6);
    //        content = content.Replace("<REPSTR7>", strFormat7);


    //        return content;
    //    }


    //    public static string decorateMailContent(string data, string email, string strFormat1, string strFormat2, string strFormat3, string strFormat4, string strFormat5, string strFormat6, string strFormat7, string strFormat8, string strFormat9, string strFormat10, string strFormat11, string strFormat12, string strFormat13, string strFormat14, string strFormat15)
    //    {
    //        string content = data;

    //        content = content.Replace("<REPSTR1>", strFormat1);
    //        content = content.Replace("<REPSTR2>", strFormat2);
    //        content = content.Replace("<REPSTR3>", strFormat3);
    //        content = content.Replace("<REPSTR4>", strFormat4);
    //        content = content.Replace("<REPSTR5>", strFormat5);
    //        content = content.Replace("<REPSTR6>", strFormat6);
    //        content = content.Replace("<REPSTR7>", strFormat7);
    //        content = content.Replace("<REPSTR8>", strFormat8);
    //        content = content.Replace("<REPSTR9>", strFormat9);
    //        content = content.Replace("<REPSTR10>", strFormat10);
    //        content = content.Replace("<REPSTR11>", strFormat11);
    //        content = content.Replace("<REPSTR12>", strFormat12);
    //        content = content.Replace("<REPSTR13>", strFormat13);
    //        content = content.Replace("<REPSTR14>", strFormat14);
    //        content = content.Replace("<REPSTR15>", strFormat15);

    //        return content;
    //    }



    //    //On Student Cancellation

    //    public static void sendStudentCancellationMail1(string str1, string str2, string str3, string str4, string str5, string str6)
    //    {
    //        try
    //        {
    //            INotification notification = new EmailNotification();
    //            //List<Student> li = new List<Student>();
    //            Event evt = EventFactory.create(20);
    //            evt.content = decorateMailContentA(evt.getTemplate(), str1, str2, str3, str4, str5, str6);
    //            evt.subject = "Cancelled Students";
    //            evt.to = "yatin@aisect.org,cordi19@aisect.org";
    //            evt.from = ConfigurationManager.AppSettings["MailFrom"];
    //            notification.sendMail(evt);
    //        }
    //        catch (Exception ex)
    //        {
    //        }
    //    }
    //    public static void sendStudentCancellationMail2(string str1, string str2, string str3, string str4, string str5, string str6)
    //    {
    //        try
    //        {
    //            INotification notification = new EmailNotification();
    //            Event evt = EventFactory.create(20);
    //            evt.content = decorateMailContentA(evt.getTemplate(), str1, str2, str3, str4, str5, str6);
    //            evt.subject = "Cancelled Students";
    //            evt.to = "venkatraman@aisect.org";
    //            evt.from = ConfigurationManager.AppSettings["MailFrom"];
    //            notification.sendMail(evt);
    //        }
    //        catch (Exception ex)
    //        {
    //        }
    //    }
    //    public static void sendStudentCancellationMail3(string str1, string str2, string str3, string str4, string str5, string str6)
    //    {
    //        try
    //        {
    //            INotification notification = new EmailNotification();
    //            Event evt = EventFactory.create(20);
    //            evt.content = decorateMailContentA(evt.getTemplate(), str1, str2, str3, str4, str5, str6);
    //            evt.subject = "Cancelled Students";
    //            evt.to = "vinu@aisect.org";
    //            evt.from = ConfigurationManager.AppSettings["MailFrom"];
    //            notification.sendMail(evt);
    //        }
    //        catch (Exception ex)
    //        {
    //        }
    //    }
    //    //





    //    public static string decorateMailContent(string data, string strFormat1, string strFormat2, string strFormat3, string strFormat4, string strFormat5, string strFormat6, string strFormat7, string strFormat8, string strFormat9, string strFormat10, string strFormat11, string strFormat12, string strFormat13, string strFormat14)
    //    {
    //        string content = data;
    //        content = content.Replace("<REPSTR1>", strFormat1);
    //        content = content.Replace("<REPSTR2>", strFormat2);
    //        content = content.Replace("<REPSTR3>", strFormat3);
    //        content = content.Replace("<REPSTR4>", strFormat4);
    //        content = content.Replace("<REPSTR5>", strFormat5);
    //        content = content.Replace("<REPSTR6>", strFormat6);
    //        content = content.Replace("<REPSTR7>", strFormat7);
    //        content = content.Replace("<REPSTR8>", strFormat8);
    //        content = content.Replace("<REPSTR9>", strFormat9);
    //        content = content.Replace("<REPSTR10>", strFormat10);
    //        content = content.Replace("<REPSTR11>", strFormat11);
    //        content = content.Replace("<REPSTR12>", strFormat12);
    //        content = content.Replace("<REPSTR13>", strFormat13);
    //        content = content.Replace("<REPSTR14>", strFormat14);

    //        return content;
    //    }


    //    //public static void sendStudentOnHoldInfoEmail(string displayName, string Remarks, string Course, string loginId, string password, string emailId, string service)
    //    //{
    //    //    try
    //    //    {
    //    //        INotification notification = new EmailNotification();
    //    //        Event evt = EventFactory.create(18);
    //    //        evt.content = decorateMailContent(evt.getTemplate(), displayName, loginId, password, service, null);
    //    //        evt.subject = "OnHold Info ";
    //    //        evt.to = emailId;
    //    //        evt.from = ConfigurationManager.AppSettings["MailFrom"];
    //    //        notification.sendMail(evt);
    //    //    }
    //    //    catch (Exception ex)
    //    //    {
    //    //    }
    //    //}

    //    public static void sendStudentOnHoldInfoEmail(string EmailID, string studReg, string stuname, string stuFathername, string course, string session, string mobile, string reason)
    //    {
    //        try
    //        {
    //            INotification notification = new EmailNotification();
    //            Event evt = EventFactory.create(18);
    //            evt.content = decorateMailContent(evt.getTemplate(), studReg, stuname, stuFathername, course, session, mobile, reason);
    //            evt.subject = "OnHold Student Info";
    //            evt.to = EmailID;
    //            evt.from = ConfigurationManager.AppSettings["MailFrom"];
    //            notification.sendMail(evt);
    //        }
    //        catch (Exception ex)
    //        {
    //        }
    //    }

    //    public static void sendStudentVerifiedEmail(string EmailID, string FirstName, string DocuName, string RequestNo, string status, string Remarks)
    //    {
    //        try
    //        {
    //            INotification notification = new EmailNotification();
    //            Event evt = EventFactory.create(36);
    //            evt.content = decorateMailContentStudentDocument(evt.getTemplate(), FirstName, DocuName, RequestNo, status, Remarks);
    //            evt.subject = "Verified Student Info";
    //            evt.to = EmailID;
    //            evt.from = ConfigurationManager.AppSettings["MailFrom"];
    //            notification.sendMail(evt);
    //        }
    //        catch (Exception ex)
    //        {
    //        }
    //    }


    //    public static void sendStudentLoginInfoEmail(string displayName, string loginId, string password, string emailId, string service)
    //    {
    //        try
    //        {
    //            INotification notification = new EmailNotification();
    //            Event evt = EventFactory.create(12);
    //            evt.content = decorateMailContent(evt.getTemplate(), displayName, loginId, password, service, null);
    //            evt.subject = "Login Info ";
    //            evt.to = emailId;
    //            evt.from = ConfigurationManager.AppSettings["MailFrom"];
    //            notification.sendMail(evt);
    //        }
    //        catch (Exception ex)
    //        {
    //        }
    //    }

    //    //AptechStudentList
    //    public static void sendStudentRegistrationSuccessAptech(string StudentName, string ServiceName, string CourseName, string ScholarNo, string Fee, string EmailAddress, string TotalFee)
    //    {
    //        try
    //        {
    //            INotification notification = new EmailNotification();
    //            Event evt = EventFactory.create(42);
    //            evt.content = decorateMailContentAptech(evt.getTemplate(), StudentName, ServiceName, CourseName, ScholarNo, Fee, TotalFee);
    //            evt.subject = "Your registration to AISECT is completed successfully";
    //            evt.to = EmailAddress;
    //            evt.cc = ConfigurationManager.AppSettings["AptechStudentCC"];
    //            evt.from = ConfigurationManager.AppSettings["MailFrom"];
    //            notification.sendMail(evt);
    //        }
    //        catch (Exception ex)
    //        {
    //        }
    //    }

    //    //moocs
    //    public static void sendStudentLoginInfoEmailForMoocs(string displayName, string loginId, string emailTo, string password, string url, string course)
    //    {
    //        try
    //        {
    //            INotification notification = new EmailNotification();
    //            Event evt = EventFactory.create(31);
    //            evt.content = decorateMailContent(evt.getTemplate(), displayName, loginId, password, url, course);
    //            evt.subject = "Login Info MOOCs ";
    //            evt.to = emailTo;
    //            evt.from = ConfigurationManager.AppSettings["MailFrom"];
    //            notification.sendMail(evt);
    //        }
    //        catch (Exception ex)
    //        {
    //        }
    //    }
    //    //

    //    public static void sendForgotPasswordEmail(string displayName, string userName, string loginId, string password, string emailId)
    //    {
    //        try
    //        {
    //            INotification notification = new EmailNotification();
    //            Event evt = EventFactory.create(5);
    //            evt.content = decorateMailContent(evt.getTemplate(), displayName, userName, loginId, password, "");
    //            evt.subject = "Password Info";//20
    //            evt.to = emailId;
    //            evt.from = ConfigurationManager.AppSettings["MailFrom"];
    //            notification.sendMail(evt);
    //        }
    //        catch (Exception ex)
    //        {
    //        }
    //    }

    //    public static void sendForgotTransPasswordEmail(string displayName, string userName, string loginId, string password, string emailId)
    //    {
    //        try
    //        {
    //            INotification notification = new EmailNotification();
    //            Event evt = EventFactory.create(10);
    //            evt.content = decorateMailContent(evt.getTemplate(), displayName, userName, loginId, password, "");
    //            evt.subject = "Password Info";//20
    //            evt.to = emailId;
    //            evt.from = ConfigurationManager.AppSettings["MailFrom"];
    //            notification.sendMail(evt);
    //        }
    //        catch (Exception ex)
    //        {
    //        }
    //    }

    //    public static void sendFresetPasswordEmail(string displayName, string linkRe, string emailId)
    //    {
    //        try
    //        {
    //            INotification notification = new EmailNotification();
    //            Event evt = EventFactory.create(9);//20
    //            evt.content = decorateMailContent(evt.getTemplate(), displayName, linkRe, "", "", "");
    //            //evt.subject = "Password Info";
    //            evt.subject = "Application For Reset Login Password";
    //            evt.to = emailId;
    //            evt.from = ConfigurationManager.AppSettings["MailFrom"];
    //            notification.sendMail(evt);
    //        }
    //        catch (Exception ex)
    //        {
    //        }
    //    }

    //    public static void sendKioskUserInfoEmail(string displayName, string kioskName, string loginId, string password, string emailId, string transpass)
    //    {
    //        try
    //        {
    //            INotification notification = new EmailNotification();
    //            Event evt = EventFactory.create(6);
    //            evt.content = decorateMailContent(evt.getTemplate(), displayName, kioskName, loginId, password, transpass);
    //            evt.subject = "Kiosk User Login Info ";
    //            evt.to = emailId;
    //            evt.from = ConfigurationManager.AppSettings["MailFrom"];
    //            notification.sendMail(evt);
    //        }
    //        catch (Exception ex)
    //        {
    //        }
    //    }

    //    public static void sendTransactionSuccessEmail(string kioskID, string displayName, string DebitCredit, string emailId, string TransactionNo, string Amount, string BalAmount, string Service)
    //    {
    //        try
    //        {
    //            INotification notification = new EmailNotification();
    //            Event evt = EventFactory.create(7);
    //            evt.content = decorateMailContentA(evt.getTemplate(), BalAmount, displayName, TransactionNo, Amount, DebitCredit, Service);
    //            evt.subject = "Your Transaction is completed sucessfully";
    //            evt.to = emailId;
    //            evt.from = ConfigurationManager.AppSettings["MailFrom"];
    //            notification.sendMail(evt);
    //        }
    //        catch (Exception ex)
    //        {
    //        }
    //    }
    //    public static void sendCSCRegEmail(string StudentName, string Course, string CourseFee, string TransId, string TransDate, string VleId, string RegNo, string eMail)
    //    {
    //        try
    //        {
    //            INotification notification = new EmailNotification();
    //            Event evt = EventFactory.create(16);
    //            evt.content = decorateMailContentLCSC(evt.getTemplate(), StudentName, Course, CourseFee, TransId, TransDate, VleId, RegNo);
    //            evt.subject = "Your Transaction is completed sucessfully";
    //            evt.to = eMail;
    //            evt.from = ConfigurationManager.AppSettings["MailFrom"];
    //            notification.sendMail(evt);
    //        }
    //        catch (Exception ex)
    //        {
    //            Utils.CreateLogEntry("sendCSCRegEmail :" + ex.Message + Environment.NewLine + ex.StackTrace);
    //        }
    //    }
    //    public static void sendTransactionSuccessSMS(string balAmount, string displayName, string MobileNo, string TransactionNo, string Amount, string SmsText)
    //    {
    //        if (MobileNo.Length > 0)
    //        {
    //            string mobileNo = "";
    //            string smsTxt = "";
    //            for (int h = 0; h < MobileNo.Length; h++)
    //            {
    //                mobileNo = mobileNo + MobileNo[h];
    //                if (mobileNo.Length == 10)
    //                {
    //                    mobileNo = "91" + mobileNo;
    //                }
    //                else
    //                {
    //                    if (mobileNo.IndexOf("0") == 0)
    //                    {
    //                        mobileNo = mobileNo.Substring(1, (mobileNo.Length) - 1);
    //                        mobileNo = "91" + mobileNo;
    //                    }
    //                }
    //            }
    //            smsTxt = Utils.GetSMSText(SmsText, null, displayName, TransactionNo, Amount, balAmount, null);
    //            Utils.SendSMS(mobileNo, smsTxt, SMSStatus.FeePaySuccess);
    //        }
    //    }

    //    public static void sendKioskTransactionSuccessSMS(string TransactionNo, string ServiceID, string ServiceName, string Amount, string Balance, string MobileNo, string SmsText)
    //    {
    //        if (MobileNo.Length > 0)
    //        {
    //            string mobileNo = "";
    //            string smsTxt = "";
    //            for (int h = 0; h < MobileNo.Length; h++)
    //            {
    //                mobileNo = mobileNo + MobileNo[h];
    //                if (mobileNo.Length == 10)
    //                {
    //                    mobileNo = "91" + mobileNo;
    //                }
    //                else
    //                {
    //                    if (mobileNo.IndexOf("0") == 0)
    //                    {
    //                        mobileNo = mobileNo.Substring(1, (mobileNo.Length) - 1);
    //                        mobileNo = "91" + mobileNo;
    //                    }
    //                }
    //            }
    //            smsTxt = Utils.GetSMSText(SmsText, TransactionNo, ServiceID, ServiceName, Amount, Balance, null);

    //            Utils.SendSMS(mobileNo, smsTxt, SmsText);
    //        }
    //    }
    //    public static void sendCSCTransactionSuccessSMS(string RegistrationNo, string VlieId, string StudentName, string Course, string MobileNo, string SmsText)
    //    {
    //        if (MobileNo.Length > 0)
    //        {
    //            string mobileNo = "";
    //            string smsTxt = "";
    //            for (int h = 0; h < MobileNo.Length; h++)
    //            {
    //                mobileNo = mobileNo + MobileNo[h];
    //                if (mobileNo.Length == 10)
    //                {
    //                    mobileNo = "91" + mobileNo;
    //                }
    //                else
    //                {
    //                    if (mobileNo.IndexOf("0") == 0)
    //                    {
    //                        mobileNo = mobileNo.Substring(1, (mobileNo.Length) - 1);
    //                        mobileNo = "91" + mobileNo;
    //                    }
    //                }
    //            }

    //            smsTxt = Utils.GetSMSText(SmsText, StudentName, Course, VlieId, RegistrationNo, null, null);
    //            Utils.CreateLogEntry("SMS:" + smsTxt);
    //            Utils.SendSMS(mobileNo, smsTxt, SMSStatus.cscRegistration);
    //        }
    //    }
    //    public static void sendNewStudentRegistrationSMS(string displayName, string MobileNo, string RequestNo, string SmsText)
    //    {
    //        if (MobileNo.Length > 0)
    //        {
    //            string mobileNo = "";
    //            string smsTxt = "";
    //            for (int h = 0; h < MobileNo.Length; h++)
    //            {
    //                mobileNo = mobileNo + MobileNo[h];
    //                if (mobileNo.Length == 10)
    //                {
    //                    mobileNo = "91" + mobileNo;
    //                }
    //                else
    //                {
    //                    if (mobileNo.IndexOf("0") == 0)
    //                    {
    //                        mobileNo = mobileNo.Substring(1, (mobileNo.Length) - 1);
    //                        mobileNo = "91" + mobileNo;
    //                    }
    //                }
    //            }
    //            smsTxt = Utils.GetSMSText(SmsText, displayName, RequestNo, null, null, null, null);
    //            Utils.SendSMS(mobileNo, smsTxt, SMSStatus.RegistrationSuccess);
    //        }
    //    }

    //    //Auto Mailer

    //    public static void sendRenewalNotificationEmail(string MailType, string kioskCode, string kioskname, string KioskOwner, string KioskAddress, string KioskPIN, string KioskState, string KioskDistrict, string KioskMobile, string KioskEmail, string Academy)
    //    {
    //        try
    //        {
    //            INotification notification = new EmailNotification();
    //            Event evt = null;
    //            if (MailType == "AgreementPending")
    //            {
    //                evt = EventFactory.create(38);
    //                evt.content = decorateMailContent(evt.getTemplate(), kioskCode, kioskname, KioskOwner, KioskAddress, KioskPIN, KioskState, KioskDistrict, KioskMobile, KioskEmail, Academy);
    //                evt.subject = "Renewal agreement for the session 2024-2025 not received yet ";

    //            }
    //            else if (MailType == "AGU_RenewalPending")
    //            {
    //                evt = EventFactory.create(39);
    //                evt.content = decorateMailContent(evt.getTemplate(), kioskCode, kioskname, KioskOwner, KioskAddress, KioskPIN, KioskState, KioskDistrict, KioskMobile, KioskEmail, Academy);
    //                evt.subject = "AGU Referral Service not Renewed ";
    //            }
    //            evt.to = KioskEmail + ConfigurationManager.AppSettings["EmailIDRenewalAlert"];
    //            evt.from = ConfigurationManager.AppSettings["MailFrom"];

    //            //notification.sendMail(
    //            notification.sendMail(evt);
    //        }
    //        catch (Exception ex)
    //        {
    //        }
    //    }

    //    public static string decorateMailContent(string data, string kioskCode, string kioskname, string KioskOwner, string KioskAddress, string KioskPIN, string KioskState, string KioskDistrict, string KioskMobile, string KioskEmail, string academy)
    //    {
    //        string content = data;

    //        content = content.Replace("<REPSTR1>", kioskCode);
    //        content = content.Replace("<REPSTR2>", KioskOwner);
    //        content = content.Replace("<REPSTR3>", KioskAddress);
    //        content = content.Replace("<REPSTR4>", KioskPIN);
    //        content = content.Replace("<REPSTR5>", KioskDistrict);
    //        content = content.Replace("<REPSTR6>", KioskState);
    //        content = content.Replace("<REPSTR7>", KioskMobile);
    //        content = content.Replace("<REPSTR8>", KioskEmail);
    //        content = content.Replace("<REPSTR9>", academy);
    //        content = content.Replace("<REPSTR10>", kioskname);



    //        return content;
    //    }


    //    //public static void sendActivateEmail(string displayName, string loginId, string password, string emailId, string transPassword)
    //    //{
    //    //    try
    //    //    {
    //    //        INotification notification = new EmailNotification();
    //    //        Event evt = EventFactory.create(2);
    //    //        evt.content = decorateMailContent(evt.getTemplate(), displayName, loginId, password, transPassword, null);
    //    //        evt.subject = "Your registration to KIOSK is completed sucessfully";
    //    //        evt.to = emailId;
    //    //        evt.from = ConfigurationManager.AppSettings["MailFrom"];
    //    //        notification.sendMail(evt);
    //    //    }
    //    //    catch (Exception ex)
    //    //    {
    //    //    }
    //    //}

    //    //public static void sendDeActivateEmail(string displayName, string loginId, string password, string emailId)
    //    //{
    //    //    try
    //    //    {
    //    //        INotification notification = new EmailNotification();
    //    //        Event evt = EventFactory.create(3);
    //    //       // evt.content = decorateMailContent(evt.getTemplate(), displayName, loginId, password);
    //    //        evt.subject = "Your profile to aisect is deactivated sucessfully";
    //    //        evt.to = emailId;
    //    //        evt.from = ConfigurationManager.AppSettings["MailFrom"];
    //    //        notification.sendMail(evt);
    //    //    }
    //    //    catch (Exception ex)
    //    //    {
    //    //    }
    //    //}

    //    #region DISPATCH EMAIL & SMS
    //    //DISPATCH EMAIL AND SMS
    //    public static void sendDispatchInfoEmail(string emailId, string displayName, string challanNo, string courierName, string docketNo, string dispatchDate, string Modules)
    //    {
    //        try
    //        {
    //            INotification notification = new EmailNotification();
    //            Event evt = EventFactory.create(11);
    //            evt.content = decorateMailDispatch(evt.getTemplate(), displayName, challanNo, courierName, docketNo, dispatchDate, Modules);
    //            evt.subject = "Dispatch details from AISECT";
    //            evt.to = emailId;
    //            evt.from = ConfigurationManager.AppSettings["MailFrom"];
    //            notification.sendMail(evt);
    //        }
    //        catch (Exception ex)
    //        {
    //        }
    //    }

    //    public static void sendDispatchInfoSMS(string MobileNo, string displayName, string challanNo, string courierName, string docketNo, string dispatchDate, string Modules, string SmsText)
    //    {
    //        if (MobileNo.Length > 0)
    //        {
    //            string mobileNo = "";
    //            string smsTxt = "";
    //            for (int h = 0; h < MobileNo.Length; h++)
    //            {
    //                mobileNo = mobileNo + MobileNo[h];
    //                if (mobileNo.Length == 10)
    //                {
    //                    mobileNo = "91" + mobileNo;
    //                }
    //                else
    //                {
    //                    if (mobileNo.IndexOf("0") == 0)
    //                    {
    //                        mobileNo = mobileNo.Substring(1, (mobileNo.Length) - 1);
    //                        mobileNo = "91" + mobileNo;
    //                    }
    //                }
    //            }
    //            smsTxt = Utils.GetDispatchSMSText(displayName, challanNo, courierName, docketNo, dispatchDate, Modules);
    //            Utils.SendSMS(mobileNo, smsTxt, SMSStatus.DispatchInfo);
    //        }
    //    }
    //    #endregion

    //    #region ExpiryAlert
    //    public static void SendkioskExpiryEmail(string KioOwnerName, string EmailID, string Mob, string ExpDate)
    //    {
    //        try
    //        {
    //            INotification notification = new EmailNotification();
    //            Event evt = EventFactory.create(15);
    //            evt.content = decorateMailContent(evt.getTemplate(), KioOwnerName, ExpDate, "", "", "");
    //            evt.subject = "Kiosk Expiry alert";
    //            evt.to = EmailID;
    //            evt.from = ConfigurationManager.AppSettings["MailFrom"];
    //            notification.sendMail(evt);
    //        }
    //        catch (Exception ex)
    //        {
    //        }
    //    }

    //    public static void SendkioskExpirySMS(string KioskOwnerName, string MobileNo, string SmsText, string expDate)
    //    {
    //        if (MobileNo.Length > 0)
    //        {
    //            string mobileNo = "";
    //            string smsTxt = "";
    //            for (int h = 0; h < MobileNo.Length; h++)
    //            {
    //                mobileNo = mobileNo + MobileNo[h];
    //                if (mobileNo.Length == 10)
    //                {
    //                    mobileNo = "91" + mobileNo;
    //                }
    //                else
    //                {
    //                    if (mobileNo.IndexOf("0") == 0)
    //                    {
    //                        mobileNo = mobileNo.Substring(1, (mobileNo.Length) - 1);
    //                        mobileNo = "91" + mobileNo;
    //                    }
    //                }
    //            }
    //            smsTxt = Utils.GetSMSText(SmsText, KioskOwnerName, expDate, "", "", "", null);
    //            Utils.SendSMS(mobileNo, smsTxt, SMSStatus.KioskRenewal);
    //        }
    //    }

    //    #endregion

    //    #region SBILife EMail & SMS
    //    public static void sendSBILifeSuccessEmail(string PolicyOwnerName, string EmailID, string PloicyNo, string PaymentDate, double Amount)
    //    {
    //        try
    //        {
    //            INotification notification = new EmailNotification();
    //            Event evt = EventFactory.create(13);
    //            evt.content = decorateMailContent(evt.getTemplate(), PolicyOwnerName, PloicyNo, EmailID, PaymentDate, Convert.ToString(Amount));
    //            evt.subject = "SBI-Life premium success";
    //            evt.to = EmailID;
    //            evt.from = ConfigurationManager.AppSettings["MailFrom"];
    //            notification.sendMail(evt);
    //        }
    //        catch (Exception ex)
    //        {
    //        }
    //    }

    //    public static void sendKioskSBILifeSuccessEmail(string EmailID, string CustomerName, string Debit, double TxnAmount, string serviceName, string PolicyNo, string PolicyOwnerName, string TxnDate, string Balamount)
    //    {
    //        try
    //        {
    //            INotification notification = new EmailNotification();
    //            Event evt = EventFactory.create(14);
    //            evt.content = decorateMailContentLSBILIfe(evt.getTemplate(), CustomerName, Debit, Convert.ToString(TxnAmount), serviceName, PolicyNo, PolicyOwnerName, TxnDate, Balamount);
    //            evt.subject = "SBI-Life premium success";
    //            evt.to = EmailID;
    //            evt.from = ConfigurationManager.AppSettings["MailFrom"];
    //            notification.sendMail(evt);
    //        }
    //        catch (Exception ex)
    //        {
    //        }
    //    }
    //    public static void SENDKIoskBulkEmail(string emailId, string emailSubject, string emailBody)
    //    {
    //        try
    //        {
    //            INotification notification = new EmailNotification();
    //            Event evt = EventFactory.create(2);
    //            evt.content = emailBody;
    //            evt.subject = emailSubject.Trim();
    //            evt.to = emailId;
    //            evt.from = ConfigurationManager.AppSettings["MailFrom"];
    //            notification.sendMail(evt);
    //        }
    //        catch (Exception ex)
    //        {
    //        }
    //    }

    //    public static void sendSBILifeSuccessSMS(string PolicyOwnerName, string MobileNo, string PolicyNo, string SmsText, double Amount, string KioskCode)
    //    {
    //        if (MobileNo.Length > 0)
    //        {
    //            string mobileNo = "";
    //            string smsTxt = "";
    //            for (int h = 0; h < MobileNo.Length; h++)
    //            {
    //                mobileNo = mobileNo + MobileNo[h];
    //                if (mobileNo.Length == 10)
    //                {
    //                    mobileNo = "91" + mobileNo;
    //                }
    //                else
    //                {
    //                    if (mobileNo.IndexOf("0") == 0)
    //                    {
    //                        mobileNo = mobileNo.Substring(1, (mobileNo.Length) - 1);
    //                        mobileNo = "91" + mobileNo;
    //                    }
    //                }
    //            }
    //            smsTxt = Utils.GetSMSText(SmsText, PolicyOwnerName, PolicyNo, Convert.ToString(Amount), KioskCode, null, null);
    //            Utils.SendSMS(mobileNo, smsTxt, SMSStatus.SBILife);
    //        }
    //    }

    //    public static void sendKioskSBILifeSuccessSMS(double TxnAmount, string PolicyNo, string PolicyOwnerName, string Balamount, string MobileNo, string SmsText)
    //    {
    //        if (MobileNo.Length > 0)
    //        {
    //            string mobileNo = "";
    //            string smsTxt = "";
    //            for (int h = 0; h < MobileNo.Length; h++)
    //            {
    //                mobileNo = mobileNo + MobileNo[h];
    //                if (mobileNo.Length == 10)
    //                {
    //                    mobileNo = "91" + mobileNo;
    //                }
    //                else
    //                {
    //                    if (mobileNo.IndexOf("0") == 0)
    //                    {
    //                        mobileNo = mobileNo.Substring(1, (mobileNo.Length) - 1);
    //                        mobileNo = "91" + mobileNo;
    //                    }
    //                }
    //            }
    //            smsTxt = Utils.GetSMSText(SmsText, Convert.ToString(TxnAmount), PolicyNo, PolicyOwnerName, Balamount, null, null);
    //            Utils.SendSMS(mobileNo, smsTxt, SMSStatus.KioskSBIPaySuccess);
    //        }
    //    }


    //    #endregion

    //    private static string decorateMailContent(string data, string custName, string CustMob, string LandLine, string PostalAdd, string CompanyNa, string BmName, string BLocation, string BCode, string BMob)
    //    {
    //        String content = data;
    //        content = content.Replace("<REPSTR1>", custName);
    //        content = content.Replace("<REPSTR2>", CustMob);
    //        content = content.Replace("<REPSTR3>", LandLine);
    //        content = content.Replace("<REPSTR4>", PostalAdd);
    //        content = content.Replace("<REPSTR5>", CompanyNa);

    //        content = content.Replace("<REPSTR6>", BmName);
    //        content = content.Replace("<REPSTR7>", BLocation);
    //        content = content.Replace("<REPSTR8>", BCode);
    //        content = content.Replace("<REPSTR9>", BMob);
    //        //content = content.Replace("<REPSTR5>", CompanyNa);
    //        content = content.Replace("\\n", "</br>");
    //        return content;
    //    }
    //    //decorateMailContent(evt.getTemplate(), displayName, userName, loginId, password, transPassword,string kioskCode,string service);
    //    private static string decorateMailContent(string data, string strFormat1, string strFormat2, string strFormat3, string strFormat4, string strFormat5, string strFormat6, string strFormat7)
    //    {
    //        String content = data;
    //        content = content.Replace("<REPSTR1>", strFormat1);
    //        content = content.Replace("<REPSTR2>", strFormat2);
    //        content = content.Replace("<REPSTR3>", strFormat3);
    //        content = content.Replace("<REPSTR4>", strFormat4);
    //        content = content.Replace("<REPSTR5>", strFormat5);
    //        content = content.Replace("<REPSTR6>", strFormat6);
    //        content = content.Replace("<REPSTR7>", strFormat7);
    //        content = content.Replace("\\n", "</br>");
    //        return content;
    //    }
    //    private static string decorateMailContentAptech(string data, string strFormat1, string strFormat2, string strFormat3, string strFormat4, string strFormat5, string strFormat6)
    //    {
    //        String content = data;
    //        content = content.Replace("<REPSTR1>", strFormat1);
    //        content = content.Replace("<REPSTR2>", strFormat2);
    //        content = content.Replace("<REPSTR3>", strFormat3);
    //        content = content.Replace("<REPSTR4>", strFormat4);
    //        content = content.Replace("<REPSTR5>", strFormat5);
    //        content = content.Replace("<REPSTR6>", strFormat6);
    //        content = content.Replace("\\n", "</br>");
    //        return content;
    //    }
    //    private static string decorateMailContent(string data, string strFormat1, string strFormat2, string strFormat3, string strFormat4, string strFormat5)
    //    {
    //        String content = data;
    //        content = content.Replace("<REPSTR1>", strFormat1);
    //        content = content.Replace("<REPSTR2>", strFormat2);
    //        content = content.Replace("<REPSTR3>", strFormat3);
    //        content = content.Replace("<REPSTR4>", strFormat4);
    //        content = content.Replace("<REPSTR5>", strFormat5);
    //        content = content.Replace("\\n", "</br>");
    //        return content;
    //    }

    //    private static string decorateMailContentA(string data, string strFormat1, string strFormat2, string strFormat3, string strFormat4, string strFormat5, string strFormat6)
    //    {
    //        String content = data;
    //        content = content.Replace("<REPSTR1>", strFormat1);
    //        content = content.Replace("<REPSTR2>", strFormat2);
    //        content = content.Replace("<REPSTR3>", strFormat3);
    //        content = content.Replace("<REPSTR4>", strFormat4);
    //        content = content.Replace("<REPSTR5>", strFormat5);
    //        content = content.Replace("<REPSTR6>", strFormat6);
    //        content = content.Replace("\\n", "</br>");
    //        return content;
    //    }

    //    private static string decorateMailContentLSBILIfe(string data, string strFormat1, string strFormat2, string strFormat3, string strFormat4, string strFormat5, string strFormat6, string strFormat7, string strFormat8)
    //    {
    //        String content = data;
    //        content = content.Replace("<REPSTR1>", strFormat1);
    //        content = content.Replace("<REPSTR2>", strFormat2);
    //        content = content.Replace("<REPSTR3>", strFormat3);
    //        content = content.Replace("<REPSTR4>", strFormat4);
    //        content = content.Replace("<REPSTR5>", strFormat5);
    //        content = content.Replace("<REPSTR6>", strFormat6);
    //        content = content.Replace("<REPSTR7>", strFormat7);
    //        content = content.Replace("<REPSTR8>", strFormat8);
    //        content = content.Replace("\\n", "</br>");
    //        return content;
    //    }
    //    private static string decorateMailContentLCSC(string data, string strFormat1, string strFormat2, string strFormat3, string strFormat4, string strFormat5, string strFormat6, string strFormat7)
    //    {
    //        String content = data;
    //        content = content.Replace("<REPSTR1>", strFormat1);
    //        content = content.Replace("<REPSTR2>", strFormat2);
    //        content = content.Replace("<REPSTR3>", strFormat3);
    //        content = content.Replace("<REPSTR4>", strFormat4);
    //        content = content.Replace("<REPSTR5>", strFormat5);
    //        content = content.Replace("<REPSTR6>", strFormat6);
    //        content = content.Replace("<REPSTR7>", strFormat7);
    //        content = content.Replace("\\n", "</br>");
    //        return content;
    //    }
    //    private static string decorateMailDispatch(string data, string strFormat1, string strFormat2, string strFormat3, string strFormat4, string strFormat5, string strFormat6)
    //    {
    //        String content = data;
    //        content = content.Replace("<REPSTR1>", strFormat1);
    //        content = content.Replace("<REPSTR2>", strFormat2);
    //        content = content.Replace("<REPSTR3>", strFormat3);
    //        content = content.Replace("<REPSTR4>", strFormat4);
    //        content = content.Replace("<REPSTR5>", strFormat5);
    //        content = content.Replace("<REPSTR6>", strFormat6);
    //        content = content.Replace("\\n", "</br>");
    //        return content;
    //    }

    //    //public static string SendSMS(string mobileNos, string SMSText) //
    //    //{
    //    //    string strUrl = string.Empty;
    //    //    string strUser = string.Empty;
    //    //    string strPassword = string.Empty;
    //    //    string strSenderID = string.Empty;
    //    //    string strRecip = string.Empty;
    //    //    string strMsgText = string.Empty;
    //    //    string strResponse = string.Empty;

    //    //    try
    //    //    {
    //    //        strUser = Convert.ToString(ConfigurationManager.AppSettings["WebSMSAcID"]);
    //    //        strPassword = Convert.ToString(ConfigurationManager.AppSettings["WebSMSAcPwd"]);
    //    //        strSenderID = Convert.ToString(ConfigurationManager.AppSettings["WebSMSAcSenID"]);
    //    //        strRecip = mobileNos;
    //    //        strMsgText = SMSText;

    //    //        strUrl = Convert.ToString(ConfigurationManager.AppSettings["WebSMSURL"]);

    //    //        //strUrl += "?username=" + HttpUtility.UrlEncode(strUser);
    //    //        //strUrl += "&password=" + HttpUtility.UrlEncode(strPassword);
    //    //        //strUrl += "&sendername=" + HttpUtility.UrlEncode(strSenderID);
    //    //        //strUrl += "&mobileno=" + HttpUtility.UrlEncode(strRecip);
    //    //        //strUrl += "&message=" + HttpUtility.UrlEncode(strMsgText);

    //    //        strUrl += "?user=" + HttpUtility.UrlEncode(strUser);
    //    //        strUrl += "&password=" + HttpUtility.UrlEncode(strPassword);
    //    //        //strUrl += "&tempid=" + HttpUtility.UrlEncode(smsTempid);
    //    //        strUrl += "&senderid=" + HttpUtility.UrlEncode(strSenderID);
    //    //        strUrl += "&mobiles=" + HttpUtility.UrlEncode(strRecip);
    //    //        strUrl += "&sms=" + HttpUtility.UrlEncode(strMsgText);


    //    //        //strUrl += "&message=" + strMsgText;
    //    //        Uri objURI = new Uri(strUrl);
    //    //        WebRequest objWebRequest = WebRequest.Create(objURI);
    //    //        objWebRequest.Timeout = Convert.ToInt32(ConfigurationManager.AppSettings["WaitTimeEmailSMS"]);
    //    //        WebResponse objWebResponse = objWebRequest.GetResponse();
    //    //        Stream objStream = objWebResponse.GetResponseStream();
    //    //        StreamReader objStreamReader = new StreamReader(objStream);
    //    //        strResponse = objStreamReader.ReadToEnd();
    //    //        Utils.CreateLogEntry(strResponse);
    //    //        return strResponse;
    //    //    }
    //    //    catch (Exception ex)
    //    //    {
    //    //        strResponse = ex.Message;
    //    //        Utils.CreateLogEntry("Error:" + strResponse);
    //    //        return strResponse;
    //    //    }
    //    //}

    //    public static string SendSMS(string mobileNos, string SMSText, string SmsForTempId) //
    //    {
    //        string strUrl = string.Empty;
    //        string strUser = string.Empty;
    //        string strPassword = string.Empty;
    //        string strSenderID = string.Empty;
    //        string strRecip = string.Empty;
    //        string strMsgText = string.Empty;
    //        string strResponse = string.Empty;
    //        string smsTempid = string.Empty;
    //        switch (SmsForTempId)
    //        {
    //            case SMSStatus.New:
    //                smsTempid = "1707161241630600213";
    //                break;
    //            case SMSStatus.StudentActivationMoocs:
    //                smsTempid = "1707162427556370491";
    //                break;
    //            case SMSStatus.sendOTP:
    //                smsTempid = "1707159867265066127";
    //                break;
    //            case SMSStatus.Approval:
    //                smsTempid = "1707161241680029933";
    //                break;
    //            case SMSStatus.Login:
    //                smsTempid = "1707161241712771466";
    //                break;
    //            case SMSStatus.OnMarksheetDispatch:
    //                smsTempid = "1707161241974150591";

    //                break;
    //            case SMSStatus.PaySuccess:
    //                //smsTempid = "1707161241795902718";
    //                smsTempid = "1707161241795902718";

    //                break;
    //            case SMSStatus.FeePaySuccess:
    //                // smsTempid = "1707161189309286594";
    //                // smsTempid = "1707161241841654153";
    //                smsTempid = "1707161241841654153";
    //                break;
    //            case SMSStatus.RegistrationSuccess:
    //                smsTempid = "1707159870303849095";
    //                break;
    //            case SMSStatus.DispatchInfo:
    //                //smsTempid = "1707161190145122863";
    //                smsTempid = "170716595122261461";
    //                break;
    //            case SMSStatus.StudentActivation:
    //                smsTempid = "1707161241879291800";
    //                break;
    //            case SMSStatus.SBILife:
    //                // smsText = string.Format("Hi {0}, Premimum for your SBI Life policy no {1} have been paid successfully.", strFormat1, strFormat2);
    //                smsTempid = "1707161241886673010";
    //                break;
    //            case SMSStatus.KioskSBIPaySuccess:
    //                smsTempid = "1707161241896849226";
    //                break;

    //            case SMSStatus.KioskRenewal:
    //                smsTempid = "1707161241934613529";
    //                break;
    //            case SMSStatus.cscRegistration:
    //                smsTempid = "1707161241946319223";
    //                break;
    //            case SMSStatus.ChangePassword:
    //                smsTempid = "1707161241961044092";
    //                break;

    //        }
    //        try
    //        {
    //            strUser = Convert.ToString(ConfigurationManager.AppSettings["WebSMSAcID"]);
    //            strPassword = Convert.ToString(ConfigurationManager.AppSettings["WebSMSAcPwd"]);
    //            strSenderID = Convert.ToString(ConfigurationManager.AppSettings["WebSMSAcSenID"]);
    //            strRecip = mobileNos;
    //            strMsgText = SMSText;

    //            strUrl = Convert.ToString(ConfigurationManager.AppSettings["WebSMSURL"]);

    //            //strUrl += "?username=" + HttpUtility.UrlEncode(strUser);
    //            //strUrl += "&password=" + HttpUtility.UrlEncode(strPassword);
    //            //strUrl += "&sendername=" + HttpUtility.UrlEncode(strSenderID);
    //            //strUrl += "&mobileno=" + HttpUtility.UrlEncode(strRecip);
    //            //strUrl += "&message=" + HttpUtility.UrlEncode(strMsgText);

    //            strUrl += "?user=" + HttpUtility.UrlEncode(strUser);
    //            strUrl += "&password=" + HttpUtility.UrlEncode(strPassword);
    //            strUrl += "&tempid=" + HttpUtility.UrlEncode(smsTempid);
    //            strUrl += "&senderid=" + HttpUtility.UrlEncode(strSenderID);
    //            strUrl += "&mobiles=" + HttpUtility.UrlEncode(strRecip);
    //            strUrl += "&sms=" + HttpUtility.UrlEncode(strMsgText);


    //            //strUrl += "&message=" + strMsgText;
    //            Uri objURI = new Uri(strUrl);
    //            WebRequest objWebRequest = WebRequest.Create(objURI);
    //            objWebRequest.Timeout = Convert.ToInt32(ConfigurationManager.AppSettings["WaitTimeEmailSMS"]);
    //            WebResponse objWebResponse = objWebRequest.GetResponse();
    //            Stream objStream = objWebResponse.GetResponseStream();
    //            StreamReader objStreamReader = new StreamReader(objStream);
    //            strResponse = objStreamReader.ReadToEnd();
    //            Utils.CreateLogEntry(strResponse);
    //            return strResponse;
    //        }
    //        catch (Exception ex)
    //        {
    //            strResponse = ex.Message;
    //            Utils.CreateLogEntry("Error:" + strResponse);
    //            return strResponse;
    //        }
    //    }

    //    public static string GetSMSText(string SMSFor, string strFormat1, string strFormat2, string strFormat3, string strFormat4, string strFormat5, string strFormat6)
    //    {
    //        string smsText = "";
    //        switch (SMSFor)
    //        {
    //            case SMSStatus.New:
    //                smsText = string.Format("Kiosk registered with ID {0}.Check your e-mail as given in the form for detailed instructions. You will get another message when activated." + " AISECT LIMITED", strFormat2);
    //                break;
    //            case SMSStatus.Approval:
    //                smsText = string.Format("Hi {0}, Your Center is approved for following details. KIOSK Code: {1}, Kiosk Type: {2}, Approved Service(s): {3} AISECT LIMITED", strFormat1, strFormat2, strFormat3, strFormat4);
    //                break;
    //            case SMSStatus.Login:
    //                smsText = string.Format("Hi {0}, Welcome to AISECT.Your Login Id: {1}, Password: {2} and Transaction Password: {3}. AISECT LIMITED", strFormat1, strFormat2, strFormat3, strFormat4);
    //                break;
    //            case SMSStatus.TransactionSuccess:
    //                smsText = string.Format("Transaction Success. TRAN ID {0} Recharge e-wallet with amount {1}.  Available balance {2} See details in your e-wallet recharge report.", strFormat1, strFormat4, strFormat5);

    //                break;
    //            case SMSStatus.PaySuccess:
    //                smsText = string.Format("Transaction Success.TRAN ID {0} For Service ID {1} Service Name {2} Amount {3}. See details in your e-wallet transaction report.Available balance {4} AISECT LIMITED", strFormat1, strFormat2, strFormat3, strFormat4, strFormat5);
    //                break;
    //            case SMSStatus.FeePaySuccess:
    //                smsText = string.Format("Transaction Success.TRAN ID {0} For Student fee payment of Rs: {1} made from your E-wallet.Available balance {2} AISECT LIMITED ", strFormat3, strFormat4, strFormat5);
    //                break;
    //            case SMSStatus.RegistrationSuccess:
    //                smsText = string.Format("Hi {0} , Thank you for registering with aisectonline.com  your registration no is: : {1}", strFormat1, strFormat2);
    //                break;
    //            case SMSStatus.DispatchInfo:
    //                smsText = string.Format("Hi {1}, Study Materials are dispatched at your correspondance Address. Details are: Challan No.:{0}, Courier Name:{1},Docket No:{2},Dispatch Date:{3},Dispatch Items:{4} AISECT LIMITED", strFormat1, strFormat2, strFormat3, strFormat4, strFormat5);
    //                break;
    //            case SMSStatus.StudentActivation:
    //                smsText = string.Format("Hi {0}, Welcome to AISECTONLINE for online training.Your credential for login into the Online LMS is as follows: Your Login ID : {1}, Password:{2} AISECT LIMITED", strFormat1, strFormat2, strFormat3);
    //                break;
    //            case SMSStatus.SBILife:
    //                // smsText = string.Format("Hi {0}, Premimum for your SBI Life policy no {1} have been paid successfully.", strFormat1, strFormat2);
    //                smsText = string.Format("Dear {0}, Premium for your SBI Life policy no{1} have been paid successfully for amount {2}at aisectonline Kiosk {3} AISECT LIMITED", strFormat1, strFormat2, strFormat3, strFormat4);
    //                break;
    //            case SMSStatus.KioskSBIPaySuccess:
    //                smsText = string.Format("Payment for Rs. {0} deducted for the SBI Life Premium against the policy No {1} , {2}. Total balance remaining in the e-wallet is now Rs. {3} AISECT LIMITED", strFormat1, strFormat2, strFormat3, strFormat4);
    //                break;

    //            case SMSStatus.KioskRenewal:
    //                smsText = string.Format("Dear {0}Your Kiosk is about to expire on {1} Please pay renewal fee to continue your activation. AISECT LIMITED", strFormat1, strFormat2);
    //                break;
    //            case SMSStatus.cscRegistration:
    //                smsText = string.Format("Dear {0}, You are provisionally registered with CVRU in the {1}. through the {2}.Your Registration ID is {3}.You can check your approval status at aisectonline.com. AISECT LIMITED", strFormat1, strFormat2, strFormat3, strFormat4);
    //                break;
    //            case SMSStatus.StudentActivationMoocs:
    //                smsText = string.Format("Dear {0}, Your login details for AISECT MOOCS are as follows: URL: {1} Login ID:{2} Login Password:{3} Course:{4} Registration No. {5} AL", strFormat1, strFormat2, strFormat3, strFormat4, strFormat5, strFormat6);
    //                break;
    //        }
    //        return smsText;
    //    }




    //    public static string GetDispatchSMSText(string strFormat1, string strFormat2, string strFormat3, string strFormat4, string strFormat5, string strFormat6)
    //    {
    //        string smsText = "";
    //        smsText = string.Format("Hi {0}, Study Materials are dispatched at your correspondance Address. Details are: Challan No.:, Courier Name:{1},Docket No:{2},Dispatch Date:{3},Dispatch Items:{4} AISECT LIMITED", strFormat1, strFormat2, strFormat3, strFormat4, strFormat5, strFormat6);
    //        return smsText;
    //    }

    //    #endregion

    //    public static string GetCurrentDemoPageTitle()
    //    {
    //        StringBuilder builder = new StringBuilder();
    //        string group = "";
    //        if (!string.IsNullOrEmpty(group))
    //        {
    //            builder.Append(" - ");
    //            builder.Append(group);
    //        }
    //        builder.Append(" - ");
    //        return builder.ToString();
    //    }

    //    public static IEnumerable<DropDownInfo> getDropDownData(string type)
    //    {
    //        List<DropDownInfo> categories = new List<DropDownInfo>();
    //        switch (type)
    //        {
    //            case "IndustriesID":
    //                categories.Add(new DropDownInfo() { ValueField = 1, TextField = "1" });
    //                categories.Add(new DropDownInfo() { ValueField = 2, TextField = "2" });
    //                categories.Add(new DropDownInfo() { ValueField = 3, TextField = "3" });
    //                break;
    //            case "WorkExperienceMonth":
    //                categories.Add(new DropDownInfo() { ValueField = 1, TextField = "1" });
    //                categories.Add(new DropDownInfo() { ValueField = 2, TextField = "2" });
    //                categories.Add(new DropDownInfo() { ValueField = 3, TextField = "3" });
    //                break;
    //            default:
    //                break;
    //        }
    //        return categories;
    //    }

    //    public static CustomModel GetHomeModel()
    //    {
    //        CustomModel customModel = new CustomModel();
    //        customModel.logOnModel = new LogOnModel();
    //        return customModel;
    //    }

    //    //Open file into a filestream and 
    //    //read data in a byte array.

    //    public static byte[] ReadFile(string sPath)
    //    {
    //        //Initialize byte array with a null value initially.
    //        byte[] data = null;

    //        //Use FileInfo object to get file size.
    //        FileInfo fInfo = new FileInfo(sPath);
    //        long numBytes = fInfo.Length;

    //        //Open FileStream to read file
    //        FileStream fStream = new FileStream(sPath, FileMode.Open, FileAccess.Read);

    //        //Use BinaryReader to read file stream into byte array.
    //        BinaryReader br = new BinaryReader(fStream);

    //        //When you use BinaryReader, you need to 

    //        //supply number of bytes to read from file.
    //        //In this case we want to read entire file. 

    //        //So supplying total number of bytes.
    //        data = br.ReadBytes((int)numBytes);
    //        return data;
    //    }

    //    public static void GenerateDocument(string fileName, string fileExtension, byte[] fileData)
    //    {
    //        string path = UploadControlDemosHelper.UploadDirectory + fileName + fileExtension;
    //        path = HttpContext.Current.Request.MapPath(path);
    //        using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write))
    //        {
    //            if (fileData != null)
    //            {
    //                BinaryWriter br = new BinaryWriter(fs);
    //                br.Write(fileData);
    //            }
    //        }
    //    }

    //    public static bool checkIfNumber(string value)
    //    {
    //        try
    //        {
    //            Int32.Parse(value);
    //        }
    //        catch (Exception ex)
    //        {
    //            return false;
    //        }

    //        return true;
    //    }

    //    public static string EncodePassword(string originalPassword)
    //    {
    //        //Declarations
    //        Byte[] originalBytes;
    //        Byte[] encodedBytes;
    //        MD5 md5;
    //        //Instantiate MD5CryptoServiceProvider, get bytes for original password and compute hash (encoded password)
    //        md5 = new MD5CryptoServiceProvider();
    //        originalBytes = ASCIIEncoding.Default.GetBytes(originalPassword);
    //        encodedBytes = md5.ComputeHash(originalBytes);
    //        //Convert encoded bytes back to a 'readable' string
    //        return BitConverter.ToString(encodedBytes);
    //    }

    //    public static MemoryStream SerializeToStream(object o)
    //    {
    //        MemoryStream stream = new MemoryStream();
    //        IFormatter formatter = new BinaryFormatter();
    //        formatter.Serialize(stream, o);
    //        return stream;
    //    }

    //    public static object DeserializeFromStream(MemoryStream stream)
    //    {
    //        IFormatter formatter = new BinaryFormatter();
    //        stream.Seek(0, SeekOrigin.Begin);
    //        object o = formatter.Deserialize(stream);
    //        return o;
    //    }

    //    /// <summary>
    //    /// AISECT - KIOSK MGT Changes
    //    /// </summary>
    //    /// <param name="toEncrypt"></param>
    //    /// <param name="useHashing"></param>
    //    /// <returns>Password Encrypt</returns>
    //    public static string PasswordEncrypt(string toEncrypt, bool useHashing)
    //    {
    //        byte[] keyArray;
    //        byte[] toEncryptArray = UTF8Encoding.UTF8.GetBytes(toEncrypt);

    //        System.Configuration.AppSettingsReader settingsReader = new AppSettingsReader();
    //        // Get the key from config file

    //        string key = (string)settingsReader.GetValue("SecurityKey", typeof(String));
    //        //System.Windows.Forms.MessageBox.Show(key);
    //        //If hashing use get hashcode regards to your key
    //        if (useHashing)
    //        {
    //            MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
    //            keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
    //            //Always release the resources and flush data
    //            // of the Cryptographic service provide. Best Practice
    //            hashmd5.Clear();
    //        }
    //        else
    //            keyArray = UTF8Encoding.UTF8.GetBytes(key);

    //        TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
    //        //set the secret key for the tripleDES algorithm
    //        tdes.Key = keyArray;
    //        //mode of operation. there are other 4 modes.
    //        //We choose ECB(Electronic code Book)
    //        tdes.Mode = CipherMode.ECB;
    //        //padding mode(if any extra byte added)

    //        tdes.Padding = PaddingMode.PKCS7;

    //        ICryptoTransform cTransform = tdes.CreateEncryptor();
    //        //transform the specified region of bytes array to resultArray
    //        byte[] resultArray =
    //          cTransform.TransformFinalBlock(toEncryptArray, 0,
    //          toEncryptArray.Length);
    //        //Release resources held by TripleDes Encryptor
    //        tdes.Clear();
    //        //Return the encrypted data into unreadable string format
    //        return Convert.ToBase64String(resultArray, 0, resultArray.Length);
    //    }
    //    /// <summary>
    //    /// AISECT - KIOSK MGT Changes
    //    /// </summary>
    //    /// <param name="toEDecrypt"></param>
    //    /// <param name="useHashing"></param>
    //    /// <returns>Password Decrypt</returns>
    //    public static string PasswordDecrypt(string cipherString, bool useHashing)
    //    {
    //        byte[] keyArray;
    //        //get the byte code of the string

    //        byte[] toEncryptArray = Convert.FromBase64String(cipherString);

    //        System.Configuration.AppSettingsReader settingsReader = new AppSettingsReader();
    //        //Get your key from config file to open the lock!
    //        string key = (string)settingsReader.GetValue("SecurityKey", typeof(String));

    //        if (useHashing)
    //        {
    //            //if hashing was used get the hash code with regards to your key
    //            MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
    //            keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
    //            //release any resource held by the MD5CryptoServiceProvider

    //            hashmd5.Clear();
    //        }
    //        else
    //        {
    //            //if hashing was not implemented get the byte code of the key
    //            keyArray = UTF8Encoding.UTF8.GetBytes(key);
    //        }

    //        TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
    //        //set the secret key for the tripleDES algorithm
    //        tdes.Key = keyArray;
    //        //mode of operation. there are other 4 modes. 
    //        //We choose ECB(Electronic code Book)

    //        tdes.Mode = CipherMode.ECB;
    //        //padding mode(if any extra byte added)
    //        tdes.Padding = PaddingMode.PKCS7;

    //        ICryptoTransform cTransform = tdes.CreateDecryptor();
    //        byte[] resultArray = cTransform.TransformFinalBlock(
    //                             toEncryptArray, 0, toEncryptArray.Length);
    //        //Release resources held by TripleDes Encryptor                
    //        tdes.Clear();
    //        //return the Clear decrypted TEXT
    //        return UTF8Encoding.UTF8.GetString(resultArray);
    //    }
    //    /// <summary>
    //    /// AISECT - KIOSK MGT Changes
    //    /// </summary>
    //    /// <param name="string Length"></param>
    //    /// <returns>Generate Random String</returns>
    //    public static string GenerateRandomString(int passwordLength)
    //    {
    //        const string allowedChars = "ABCDEFGHJKLMNOPQRSTUVWXYZabcdefghijkmnopqrstuvwxyz0123456789!@$?_-";
    //        char[] chars = new char[passwordLength];
    //        var rd = new Random();

    //        for (int i = 0; i < passwordLength; i++)
    //        {
    //            chars[i] = allowedChars[rd.Next(0, allowedChars.Length)];
    //        }

    //        return new string(chars);
    //    }

    //    public static string MD5Hash(string text)
    //    {
    //        MD5 md5 = new MD5CryptoServiceProvider();

    //        //compute hash from the bytes of text
    //        md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(text));

    //        //get hash result after compute it
    //        byte[] result = md5.Hash;

    //        StringBuilder strBuilder = new StringBuilder();
    //        for (int i = 0; i < result.Length; i++)
    //        {
    //            //change it into 2 hexadecimal digits
    //            //for each byte
    //            strBuilder.Append(result[i].ToString("x2"));
    //        }

    //        return strBuilder.ToString();
    //    }

    //    public static string DecryptConnectionString(string connectionString)
    //    {
    //        string result = "";

    //        bool app = false;

    //        app = IsBase64String(connectionString);
    //        if (app == true)
    //        {
    //            Byte[] b = Convert.FromBase64String(connectionString);
    //            string decryptedConnectionString = System.Text.ASCIIEncoding.ASCII.GetString(b);
    //            result = decryptedConnectionString;
    //        }
    //        else if (app == false)
    //        {
    //            result = connectionString;
    //        }

    //        return result;
    //    }

    //    public static bool IsBase64String(string s)
    //    {
    //        s = s.Trim();
    //        return (s.Length % 4 == 0) && Regex.IsMatch(s, @"^(?:[A-Za-z0-9+/]{4})*(?:[A-Za-z0-9+/]{2}==|[A-Za-z0-9+/]{3}=)?$", RegexOptions.None);

    //    }

    //    public static string passMD5(string text)
    //    {
    //        //text = "111111";
    //        System.Configuration.AppSettingsReader settingsReader = new AppSettingsReader();
    //        string key = (string)settingsReader.GetValue("SecurityKey1", typeof(String));
    //        return MD5Hash(MD5Hash(text) + key);
    //    }

    //    public static string GetAHSHEALTH()
    //    {
    //        System.Configuration.AppSettingsReader settingsReader = new AppSettingsReader();
    //        string key = (string)settingsReader.GetValue("SecurityKey1", typeof(String));
    //        return key;
    //    }

    //    /// <summary>
    //    /// For Virtual keyboard start
    //    /// </summary>
    //    public static string CreateTable()
    //    {
    //        Random rand = new Random();
    //        StringBuilder htmltbl = new StringBuilder();
    //        htmltbl.Append("<table id=\"tblv\" width=\"400\"  cellspacing=\"0\" cellpadding=\"0\" style=\"border:1px solid black;border-collapse:inherit;\">");
    //        htmltbl.Append("<tr><td>");
    //        //pattern1
    //        /*      row1 - 15 char - alphabets
    //         *      row2 - 11 char - alphabets
    //         *      row3 - 10 char - numbers + 2 char symbols
    //         *      row4 - 15 char - symbols
    //         *      row5 - 15 char - symbols
    //         *      row6 - Back Space, Clear, Caps Lock
    //         */


    //        //Filling first 2 rows -Alphabets            
    //        for (int i = 0; i < 26; i++)
    //        {
    //            int next = rand.Next(1, listAlphabets.Count) - 1;
    //            htmltbl.Append(string.Format(buttonHtmlString, listAlphabets[next], listAlphabets[next]));
    //            listAlphabets.RemoveAt(next);

    //            if (i == 14)
    //            {
    //                //adding the second row
    //                htmltbl.Append("</td></tr><tr><td>");
    //            }
    //        }

    //        htmltbl.Append("</td></tr><tr><td>");

    //        //filling third row - numbers
    //        for (int i = 0; i < 10; i++)
    //        {
    //            int next = rand.Next(1, listNumbers.Count) - 1;
    //            htmltbl.Append(string.Format(buttonHtmlString, listNumbers[next], listNumbers[next]));
    //            listNumbers.RemoveAt(next);
    //        }


    //        //Filling symbols  [ 3rd and 4th rows]    
    //        for (int i = 0; i < 32; i++)
    //        {
    //            int next = rand.Next(1, listSymbols.Count) - 1;
    //            htmltbl.Append(string.Format(buttonHtmlString, listSymbols[next], listSymbols[next]));
    //            listSymbols.RemoveAt(next);

    //            if (i == 1)
    //            {
    //                //row seperation after 2 nos for 4rd row
    //                htmltbl.Append("</td></tr><tr><td>");
    //            }
    //            else if (i == 16)
    //            {
    //                //adding the fifth row
    //                htmltbl.Append("</td></tr><tr><td>");
    //            }
    //        }

    //        htmltbl.Append("</td></tr><tr><td>");

    //        htmltbl.Append(buttonBackSpace + "&nbsp;");
    //        htmltbl.Append(buttonClear + "&nbsp;");
    //        htmltbl.Append(buttonCapsLock + "&nbsp;");

    //        htmltbl.Append("</td></tr></table>");

    //        // divVirkey.InnerHtml = htmltbl.ToString();
    //        return HttpUtility.HtmlEncode(htmltbl.ToString());

    //    }

    //    public static void CreateLists()
    //    {
    //        CreateAlphabets();
    //        CreateNumberlist();
    //        CreateSymbolList();
    //    }

    //    public static void CreateSymbolList()
    //    {
    //        //32 symbols
    //        // didn't want to tackle with the ascii- just typed all the symbols I could find on my keyboard
    //        string[] symbollist = new string[] { "!", "@", "#", "$", "%", "^", "&", "*", "(", ")", "_", "-", "+", "=", "~", "`", "&quot;", ":", ";", "'", ",", ".", "/", "<", ">", "?", "{", "}", "[", "]", "|", "\\" };
    //        listSymbols.AddRange(symbollist);
    //    }

    //    public static void CreateNumberlist()
    //    {
    //        for (int i = 0; i < 10; i++)
    //        {
    //            listNumbers.Add(i.ToString());
    //        }
    //    }

    //    public static void CreateAlphabets()
    //    {
    //        for (int i = 97; i <= 122; i++)
    //        {
    //            //a = 97; z=122
    //            //felt bored to type
    //            listAlphabets.Add(char.ConvertFromUtf32(i).ToString());
    //        }
    //    }
        

    //    public static void CreateLogEntrympcz(string strText)
    //    {
    //        // Create a writer and open the file:
    //        try
    //        {
    //            //string ErrorFileName = HttpContext.Current.Server.MapPath("~/Content/mpczlog.txt");
    //            string date = "_" + DateTime.Now.Day.ToString() + "_" + DateTime.Now.Month.ToString() + "_" + DateTime.Now.Year.ToString();
    //            string ErrorFileName = "G:/Logs/mpcz/mpczlog" + date + ".log";
    //            using (StreamWriter log = System.IO.File.AppendText(ErrorFileName))
    //            {
    //                // Write to the file:
    //                log.WriteLine(DateTime.Now);
    //                log.WriteLine(strText);
    //                log.WriteLine();
    //                // Close the stream:
    //                log.Close();
    //            }
    //        }
    //        catch (Exception ex) { Console.WriteLine(ex.Message); }
    //    }

    //    public static void CreateLogEntryMobikwik(string strText)
    //    {
    //        // Create a writer and open the file:
    //        try
    //        {
    //            //string ErrorFileName = HttpContext.Current.Server.MapPath("~/Content/mpczlog.txt");
    //            string date = "_" + DateTime.Now.Day.ToString() + "_" + DateTime.Now.Month.ToString() + "_" + DateTime.Now.Year.ToString();
    //            string ErrorFileName = "G:/Logs/mobikwik/" + date + ".log";

    //            //string ErrorFileName = "F:/Logs/mobikwik/Mobikwiklog" + date + ".log";
    //            using (StreamWriter log = System.IO.File.AppendText(ErrorFileName))
    //            {
    //                // Write to the file:
    //                log.WriteLine(DateTime.Now);
    //                log.WriteLine(strText);
    //                log.WriteLine();
    //                // Close the stream:
    //                log.Close();
    //            }
    //        }
    //        catch (Exception ex) { Console.WriteLine(ex.Message); }
    //    }


    //    public static void CreateLogEntry4(string strText)
    //    {
    //        // Create a writer and open the file:
    //        StreamWriter log;
    //        string ErrorFileName = @"E:/LOGS/log.txt";
    //        if (!File.Exists(ErrorFileName))
    //        {
    //            log = new StreamWriter(ErrorFileName);
    //        }
    //        else
    //        {
    //            log = File.AppendText(ErrorFileName);
    //        }
    //        // Write to the file:
    //        log.WriteLine(DateTime.Now);
    //        log.WriteLine(strText);
    //        log.WriteLine();
    //        // Close the stream:
    //        log.Close();
    //    }


      

       

    //    #endregion

    //    public static string ExportDataTabletoCSV(System.Data.DataTable datatable, string delimited, bool exportcolumnsheader)
    //    {
    //        StringBuilder sb = new StringBuilder();
    //        if (exportcolumnsheader)
    //        {
    //            string Columns = string.Empty;
    //            foreach (DataColumn column in datatable.Columns)
    //            {
    //                Columns += column.ColumnName + delimited;
    //            }
    //            sb.AppendLine(Columns.Remove(Columns.Length - 1, 1));
    //        }
    //        foreach (DataRow datarow in datatable.Rows)
    //        {
    //            string row = string.Empty;
    //            foreach (object items in datarow.ItemArray)
    //            {
    //                row += items.ToString() + delimited;
    //            }
    //            sb.AppendLine(row.Remove(row.Length - 1, 1));
    //        }
    //        return Convert.ToString(sb);
    //    }

    //    /////////////////////////Generate Random string 
    //    public static string RandomString(int Size, string Key)
    //    {
    //        Random random = new Random();
    //        string input = Key + "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz" + DateTime.Now.ToString();
    //        int rndSize = GetRandomNumber(Size, Size * 2);
    //        StringBuilder builder = new StringBuilder();
    //        char ch;
    //        for (int i = 0; i < rndSize; i++)
    //        {
    //            ch = input[random.Next(0, input.Length)];
    //            builder.Append(ch);
    //        }
    //        return builder.ToString();
    //    }
    //    private static readonly Random getrandom = new Random();
    //    private static readonly object syncLock = new object();
    //    public static int GetRandomNumber(int min, int max)
    //    {
    //        lock (syncLock)
    //        { // synchronize
    //            return getrandom.Next(min, max);
    //        }

    //    }
    //    /////////////////////////Generate Random string 
    //}
}
