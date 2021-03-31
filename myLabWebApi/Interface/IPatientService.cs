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
        List<PAIT_HDR_DET_TEST> GetPatientTestDetail(string ID);

        long UpdateDocDetTestValue(List<PAIT_HDR_DET_TEST> model);

        List<NarrationModel> GetNarration(string KeyWord);

        List<PAIT_HDR_DET_TEST> GetPatientAllTestDetail(long ID);
        List<PAIT_HDR_DET_TEST> GetTestDetailByTestMstID(long ID);

        //Use for Get Patient By Mobile No
        int GetPatientByMobileNoCount(string MobileNo);

        List<PatientMasterModel> GetPatientByMobileNo(string MobileNo);
        //Use for Get Patient By Mobile No


        string GetLabNo(string LabSeriesSetting);

        List<PatientMasterModel> GetPatientMobileNos(string MobileNo);
    }
}