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
    }
}
