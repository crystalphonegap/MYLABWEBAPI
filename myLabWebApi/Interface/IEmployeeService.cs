using myLabWebApi.Models;
using myLabWebApi.Models.New;
using System.Collections.Generic;

namespace myLabWebApi.Interface
{
    public interface IEmployeeService
    {
        List<EMPLOYEE> GetAllEmployeeDetails(SearchFilters m);

        List<DOCTOR> GetAllDoctorDetails();

        long InsertUpdateDoctor(DOCTOR orderHeaderdetails);

        List<DOCTOR> GetDoctorSearch(SearchFilters m);

        long GetDoctorSearchCount(SearchFilters m);

        DOCTOR GetDoctorUsingId(int Id);

        long DeleteDoctorById(int Id);

        List<COLLECTIONCENTER> GetAllCollectionCenterDetails();

        long insertUpdollectionCenter(COLLECTIONCENTER centermodel);

        List<COLLECTIONCENTER> GetCollectionCenterSearch(SearchFilters m);

        long GetCollectionCenterSearchCount(SearchFilters m);

        COLLECTIONCENTER GetCollectionCenterById(int Id);

        long DeleteCollectionCenterById(int Id);

        //long InsertUpdateEmployee(EMPLOYEE empmodel);

        List<RATELISTHDR> GetRateListSearch(SearchFilters m);

        long GetRateListSearchCount(SearchFilters m);

        RATELISTHDR GetRateListById(int Id);

        long DeleteRateListById(int Id);

        long insertUpdateRateList(RATELISTHDR RATELISTHDRmodel);

        List<TestMaster> GetTestMasterForRateList(string Keyword, string Type, int Catagory);

        long InsertRateListDetails(List<TestMaster> master, long RateListHID);

        List<TestMaster> GetRateListDetailsById(int Id);

        long DeleteRateListDetailsById(long Id);

        long InsertUpdateEmployee(EMPLOYEE empmodel);

        EMPLOYEE GetEmployeeListByID(int Id);

        long DeleteEmployeeById(int Id);

        List<EMPLOYEE> GetEmployeeSearch(SearchFilters m);

        long GetEmployeeSearchCount(SearchFilters m);

        RATELISTHDR GetRateListHeaderById(int Id);

        long insertSaveAsRateList(RATELISTHDRSAVEAS RATELISTHDR);

        List<TestMaster> GetTestMasterByCollectionCenterID(int CenterID, string Type, string Keyword);
    }
}