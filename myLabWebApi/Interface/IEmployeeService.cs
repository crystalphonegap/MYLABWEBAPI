﻿using myLabWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myLabWebApi.Interface
{
    public interface IEmployeeService
    {
        List<EmployeeModel> GetAllEmployeeDetails();

        List<DoctorModel> GetAllDoctorDetails();

        long InsertUpdateDoctor(DoctorModel orderHeaderdetails);

        List<DoctorModel> GetDoctorSearch(int PageNo, int PageSize, string KeyWord);

        long GetDoctorSearchCount(string KeyWord);

        DoctorModel GetDoctorById(int Id);

        long DeleteDoctorById(int Id);

        long insertUpdollectionCenter(CollectionCenterModel centermodel);

        List<CollectionCenterModel> GetCollectionCenterSearch(int PageNo, int PageSize, string KeyWord);

        long GetCollectionCenterSearchCount(string KeyWord);
    }
}
