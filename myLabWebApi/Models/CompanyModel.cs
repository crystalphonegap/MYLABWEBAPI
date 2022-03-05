using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myLabWebApi.Models
{
    public class CompanyModel
    {
        public int COMPANY_Setupid { get; set; }
        public string COMPANY_Name { get; set; }
        public string COMPANY_Address1 { get; set; }
        public string COMPANY_Address2 { get; set; }
        public string COMPANY_City { get; set; }
        public string COMPANY_State { get; set; }
        public string COMPANY_PostalCode { get; set; }
        public string COMPANY_Country { get; set; }
        public string COMPANY_PhoneNumber { get; set; }
        public string COMPANY_Faxnumber { get; set; }
        public string COMPANY_Email { get; set; }
        public string COMPANY_Url { get; set; }
        public string COMPANY_DataLoc { get; set; }
        public string COMPANY_Username { get; set; }
        public string COMPANY_Password { get; set; }
        public string COMPANY_ReportLoc { get; set; }
        public string COMPANY_Pathologist { get; set; }
        public string COMPANY_PathoDegree { get; set; }
        public string COMPANY_Radiologist { get; set; }
        public string COMPANY_RadiologistDegree { get; set; }
        public string COMPANY_SonoLogist { get; set; }
        public string COMPANY_SonoDegree { get; set; }
        public string COMPANY_Abnormal { get; set; }
        public string COMPANY_TopMargin { get; set; }
        public string COMPANY_BotMargin { get; set; }
        public string Remarks { get; set; }
        public string COMPANY_PaperSize { get; set; }
        public string COMPANY_Series { get; set; }
        public int IsSMSSend { get; set; }
        public int Userid { get; set; }
       
    }
    public class CompanyResponseModel
    {
        public int Id { get; set; }
        public string Message { get; set; }
    }
    public class CompanySearchModel
    {
        public int PageNo { get; set; }
        public int PageSize { get; set; }
        public string Keyword { get; set; }
        public string Type { get; set; }
        public int CompanyId { get; set; }
    }
}
