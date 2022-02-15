﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using myLabWebApi.Models;

namespace myLabWebApi.Interface
{
    public interface IPatientService
    {
        LabNoClassModel Create(PatientMasterModel Patient, string strMode);

        List<PatientMasterModel>  GetPatientSearch(int PageNo, int PageSize, string Keyword,string FromDate,string ToDate,string UserId);

        List<PAIT_HDR_DET_TEST> GetAllTESTDETForPathTest(string search);

        long GetPatientSearchCount(string Keyword, string FromDate, string ToDate, string UserId);

        List<PAIT_HDR_DET_TEST_New> GetPatientDetail(long ID);

        List<PAIT_HDR_DET_TEST> GetPatientDetail2(string mobile);

        List<PAIT_HDR_DET_TEST> GetPatientTestDetail(string ID);

        long UpdateDocDetTestValue(List<PAIT_HDR_DET_TEST> model,string AddedBy,string Markcomplete2,string value1,string test);

        //long UpdateDocDetTestValuemarkcomplete(string DOCHDR_lDocumentId, string Markcomplete2, string LoginByID);

        List<NarrationModel> GetNarration(string Keyword);

        List<PAIT_HDR_DET_TEST_New> GetPatientAllTestDetail(long ID);

        List<PAIT_HDR_DET_TEST> GetTestDetailByTestMstID(long ID);

        int GetPatientByMobileNoCount(string MobileNo);

        List<PatientMasterModel> GetPatientByMobileNo(string MobileNo);

        LabNoClassModel GetLabNo(string LabSeriesSetting);

        List<PatientMasterModel> GetPatientMobileNos(string MobileNo);
        string GlobalDelete(GlobalDeleteModal model);

        long DeleteBlackListMobiles(int ID);

        long GetBlackListMobilesSearchCount(SearchFilters model);

        List<BlackListMobilesModel> GetBlackListMobilesSearch(SearchFilters model);

        long InsertBlackListMobiles(BlackListMobilesModel model);

        long SaveDocument(DocumentClassModel model,string filename);
        long patientTesthistory(DocumentClassModel model);
        List<BalancePatientClass> GetPatientListBlanceAmount(PaymentSearchFilters model);
        BalancePatientClass GetPatientListBlanceAmountByID(int PATIENT_ID);
        long PaidBalanceAmount(AmountPaidClass model);
    }
}