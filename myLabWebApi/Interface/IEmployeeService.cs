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
        List<EMPLOYEE> GetAllEmployeeDetails();

        List<DOCTOR> GetAllDoctorDetails();

        long InsertUpdateDoctor(DOCTOR orderHeaderdetails);

        List<DOCTOR> GetDoctorSearch(int PageNo, int PageSize, string KeyWord);

        long GetDoctorSearchCount(string KeyWord);

        DOCTOR GetDoctorUsingId(int Id);

        long DeleteDoctorById(int Id);

        List<CollectionCenterModel> GetAllCollectionCenterDetails();

        long insertUpdollectionCenter(CollectionCenterModel centermodel);

        List<CollectionCenterModel> GetCollectionCenterSearch(int PageNo, int PageSize, string KeyWord);

        long GetCollectionCenterSearchCount(string KeyWord);

        CollectionCenterModel GetCollectionCenterById(int Id);

        long DeleteCollectionCenterById(int Id);

        long InsertUpdateEmployee(EMPLOYEE empmodel);
    }
}
