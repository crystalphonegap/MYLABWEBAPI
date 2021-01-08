using myLabWebApi.Models;
using myLabWebApi.Models.New;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myLabWebApi.Interface
{
    public interface IEmployeeService
    {
        List<EMPLOYEE> GetAllEmployeeDetails(int PageNo, int PageSize, string KeyWord);
        long InsertUpdateEmployee(EMPLOYEE _Employee);

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
    }
}
