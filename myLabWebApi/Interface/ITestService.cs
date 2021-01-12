using myLabWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myLabWebApi.Interface
{
    public interface ITestService
    {
        long InsertUpdateTestType(TestTypeModel model);

        List<TestTypeModel> GetTestTypeSearch(int PageNo, int PageSize, string KeyWord);

        long GetTestTypeSearchCount(string KeyWord);

        TestTypeModel GetTestTypeUsingId(int Id);

        long DeleteTestTypeById(int Id);

        long InsertUpdatePathalogyTest(PathalogyTestMaster model);

        long InsertUpdatePathalogyTestDetails(PathalogyTestDetails model);

        PathalogyTestMaster GetPathalogyTestMasterUsingId(int Id);

        long DeletePathalogyTestMaster(int Id);

        List<PathalogyTestDetails> GetPathalogyTestDetailsUsingId(int Id);

        List<PathalogyTestMaster> GetPathalogyTestSearch(int PageNo, int PageSize, string KeyWord);

        long GetPathalogyTestSearchCount(string KeyWord);
    }
}
