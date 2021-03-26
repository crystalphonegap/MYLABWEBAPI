﻿using myLabWebApi.Models;
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

        long GetDoctorSearchCount(SearchByKeyword m);

        DOCTOR GetDoctorUsingId(int Id);

        long DeleteDoctorById(int Id);

        List<COLLECTIONCENTER> GetAllCollectionCenterDetails();

        long insertUpdollectionCenter(COLLECTIONCENTER centermodel);

        List<COLLECTIONCENTER> GetCollectionCenterSearch(SearchFilters m);

        long GetCollectionCenterSearchCount(SearchByKeyword m);

        COLLECTIONCENTER GetCollectionCenterById(int Id);

        long DeleteCollectionCenterById(int Id);

        //long InsertUpdateEmployee(EMPLOYEE empmodel);

        List<RATELISTHDR> GetRateListSearch(SearchFilters m);

        long GetRateListSearchCount(SearchByKeyword m);

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

        List<EMPLOYEE> GetEmployeeSearch(SearchFilters m);

        long GetEmployeeSearchCount(SearchByKeyword m);

        RATELISTHDR GetRateListHeaderById(int Id);

        long insertSaveAsRateList(RATELISTHDRSAVEAS RATELISTHDR);

        List<TestMaster> GetTestMasterByCollectionCenterID(int CenterID, string Type, string KeyWord);
    }
}