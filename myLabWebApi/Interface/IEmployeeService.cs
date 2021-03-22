using myLabWebApi.Models;
using myLabWebApi.Models.New;
using System.Collections.Generic;

namespace myLabWebApi.Interface
{
    public interface IEmployeeService
    {
        List<EMPLOYEE> GetAllEmployeeDetails(int PageNo, int PageSize, string KeyWord);

        List<DOCTOR> GetAllDoctorDetails();

        long InsertUpdateDoctor(DOCTOR orderHeaderdetails);

        List<DOCTOR> GetDoctorSearch(int PageNo, int PageSize, string KeyWord);

        long GetDoctorSearchCount(string KeyWord);

        DOCTOR GetDoctorUsingId(int Id);

        long DeleteDoctorById(int Id);

        List<COLLECTIONCENTER> GetAllCollectionCenterDetails();

        long insertUpdollectionCenter(COLLECTIONCENTER centermodel);

        List<COLLECTIONCENTER> GetCollectionCenterSearch(int PageNo, int PageSize, string KeyWord);

        long GetCollectionCenterSearchCount(string KeyWord);

        COLLECTIONCENTER GetCollectionCenterById(int Id);

        long DeleteCollectionCenterById(int Id);

        //long InsertUpdateEmployee(EMPLOYEE empmodel);

        List<RATELISTHDR> GetRateListSearch(int PageNo, int PageSize, string KeyWord);

        long GetRateListSearchCount(string KeyWord);

        RATELISTHDR GetRateListById(int Id);

        long DeleteRateListById(int Id);

        long insertUpdateRateList(RATELISTHDR RATELISTHDRmodel);

        List<TestMaster> GetTestMasterForRateList(string keyword, string Type, int Catagory);

        long InsertRateListDetails(TestMaster master);

        List<TestMaster> GetRateListDetailsById(int Id);

        long DeleteRateListDetailsById(int Id);

        long InsertUpdateEmployee(EMPLOYEE empmodel);

        EMPLOYEE GetEmployeeListByID(int Id);

        long DeleteEmployeeById(int Id);

        List<EMPLOYEE> GetEmployeeSearch(int PageNo, int PageSize, string KeyWord);

        long GetEmployeeSearchCount(string KeyWord);

        RATELISTHDR GetRateListHeaderById(int Id);

        long insertSaveAsRateList(RATELISTHDRSAVEAS RATELISTHDR);

        List<TestMaster> GetTestMasterByCollectionCenterID(int CenterID, string Type, string KeyWord);
    }
}