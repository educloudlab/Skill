using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AisectOnline.Services.Modules.Common
{
    public class CommonDTO
    {
        public class MenuItem
        {
            public string Id { get; set; } // e.g., "dashboard", "reports"
            public string Title { get; set; }
            public string PartialViewName { get; set; }
        }
        public class DropDownInfo
        {
            public int ValueField { get; set; }
            public string TextField { get; set; }
            public string DescriptionField { get; set; }
        }
        public class DropDownInfoStr
        {
            public string ValueField { get; set; }
            public string TextField { get; set; }
            public string DescriptionField { get; set; }
        }

        public class ComboBoxCasecade
        {
            public IList<DropDownInfo> ListDropDownInfo { get; set; }
            public IList<DropDownInfoStr> ListDropDownInfoStr { get; set; }
            public string Name { get; set; }
            public string Caption { get; set; }
            public bool IsRequired { get; set; }
            public bool IsReadOnly { get; set; }
            public bool IsVisible { get; set; }
            public bool IsActive { get; set; }
            public string RegEx { get; set; }
            public string JsOnInit { get; set; }
            public string JsOnKeyPress { get; set; }
            public string JsOnChanged { get; set; }
            public string JsOnTextChanged { get; set; }
            public string JsOnClick { get; set; }
            public string JsOnValidation { get; set; }
            public string JsOnBeginCallback { get; set; }
            public string JsOnEndCallback { get; set; }
            public Type ValueType { get; set; }
            public bool IsSubmit { get; set; }
            public int SelectedIndex { get; set; }
            public string ValidationGroup { get; set; }
            public string CallbackName { get; set; }
            public string CallbackValue { get; set; }
            public string CallbackSPName { get; set; }
            public int Value { get; set; }
            public int Width { get; set; }
        }

        public class State
        {
            public int StateID { get; set; }
            public string StateName { get; set; }
            public string StateCode { get; set; }
            public int CountryID { get; set; }
            public string Country { get; set; }
            public decimal Discount { get; set; }
            public IList<State> GetStateList { get; set; }
        }

        public class District
        {
            public int DistrictID { get; set; }
            public string DistrictName { get; set; }
            public int StateID { get; set; }
        }

        public class Block
        {
            public int BlockID { get; set; }
            public string BlockName { get; set; }
            public int DistrictID { get; set; }
        }

        public class Village
        {
            public int VillageID { get; set; }
            public string VillageName { get; set; }
            public int BlockID { get; set; }
        }

        public class ReportHeader
        {
            public int KioskID { get; set; }
            public string KioskType { get; set; }
            public string KioskService { get; set; }
            public string KioskName { get; set; }
            public string Kioskcode { get; set; }

            public string Address { get; set; }
            public string City { get; set; }
            public string District { get; set; }
            public string State { get; set; }
            public string Pin { get; set; }
            //public IList<FeesSummary> ListFeesSummary { get; set; }
        }

        public class Audit
        {
            public Int32 AuditTrailID { get; set; }
            public string IpAddress { get; set; }
            public string AuditDate { get; set; }
            public string AuditTime { get; set; }
            public Int32 userID { get; set; }
            public string SessionDetails { get; set; }
            public string Referrer { get; set; }
            public string URL { get; set; }
            public string UserAgent { get; set; }
            public string Country { get; set; }
            public string LoginID { get; set; }
            public string Password { get; set; }
            public DateTime LogInTime { get; set; }
            public string LogOutTime { get; set; }
            public IList<Audit> ListAudit { get; set; }

            public DateTime FromDate { get; set; }
            public DateTime ToDate { get; set; }
            public string strControlName { get; set; }
            public string strControlValue { get; set; }
            public string rptTitle { get; set; }
            //  public int ServiceID { get; set; }
            //  public string Service { get; set; }
            public string IsSuccess { get; set; }
        }
        public class RoleMenu
        {
        
            public int MenuID { get; set; }                // PK, not null
            public string? MenuName { get; set; }          // nullable
            public string? ControllerName { get; set; }    // nullable
            public string? ActionName { get; set; }        // nullable
            public int? MenuPID { get; set; }              // nullable (parent id)
            public string? DisplayName { get; set; }       // nullable
            public int? MenuOrder { get; set; }            // nullable
            public string? ImageName { get; set; }         // nullable
            public string? ImageName2 { get; set; }        // nullable
            public bool IsActive { get; set; }             // assume NOT NULL bit
        }
    }
}
