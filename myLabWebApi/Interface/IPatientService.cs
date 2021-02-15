using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using myLabWebApi.Models;

namespace myLabWebApi.Interface
{
    public interface IPatientService
    {
        int Create(PatientMasterModel Patient, string strMode);

        List<PatientMasterModel>  GetPatientSearch(int PageNo, int PageSize, string KeyWord);

        long GetPatientSearchCount(string KeyWord);

        List<PAIT_HDR_DET_TEST> GetPatientDetail(long ID);
        List<PAIT_HDR_DET_TEST> GetPatientTestDetail(long ID);
    }
}