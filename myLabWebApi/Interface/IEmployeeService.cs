using myLabWebApi.Models;
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
    }
}
