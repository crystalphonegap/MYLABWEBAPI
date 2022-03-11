using myLabWebApi.Models;
using myLabWebApi.Models.New;
using System.Collections.Generic;

namespace myLabWebApi.Interface
{
    public interface ICompanyService
    {
        CompanyResponseModel InsertUpdateCompany(CompanyModel model);

        List<CompanyModel> GetCompanyList(CompanySearchModel model);

        CompanyModel GetCompanyDetails(int CompanyId);
    }
}
