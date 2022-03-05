using myLabWebApi.Models;
using System.Collections.Generic;

namespace myLabWebApi.Interface
{
    public interface IUserMasterService
    {
        long Delete(long id);

        UserMasterModel GetById(long id);

        List<ErrorModel> GetError(string fromdate, string todate, int PageNo, int PageSize, string Keyword, string Type);

        string Update(UserMasterModel UserMaster);

        string EditProfile(UserMasterModel UserMaster);

        string ChangePassword(UserMasterModel UserMaster);

        int Create(UserMasterModel UserMasterDetails);

        long UserCount();

        long DeleteErrorLog(string DelDate);

        List<UserMasterModel> ListAll();

        List<UserMasterModel> Search(string Keyword);

        List<UserMasterModel> UserPaging(int pageNo, int pageSize);

        UserMasterModel Login(string usercode, string password);

        UserMasterModel LoginLogs(string UserCode, string UserName, string UserType, string BrowserName, string IpAddress);

        int SaveRefreshToken(string username, string refreshToken);

        string GetRefreshToken(string usercode, string reftoken);

        int DeleteRefreshToken(string usercode, string token);

        List<UserMasterModel> GetAllUserMasterForDivisionalAdminSearch(int PageNo, int PageSize, string Keyword);

        List<UserMasterModel> GetAllUserMasterByParentCode(string status, string CustomerId, int PageNo, int PageSize, string Keyword);

        long GetAllUserMasterCountByParentCode(string status, string CustomerId, string Keyword);

        List<UserMasterModel> GetAllUserMasterForDivisionalAdminDownload(string Keyword);

        long GetAllUserMasterForDivisionalAdminCount(string Keyword);

        List<UserMasterModel> ExportToExcelForParent(string ParentCode, string status, string Keyword);

        string ResetPassword(UserMasterModel UserMaster);
        object GetusermasterSearch(SearchFilters m);

        long GetusermasterSearchCount(SearchFilters m);
        long InsertUpdateUsermaster(UserMdsignusers Data);

        UserMdsignusers GetUsermasterUsingId(int Id);

    }
}