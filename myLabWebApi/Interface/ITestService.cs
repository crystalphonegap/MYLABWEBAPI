using myLabWebApi.Models;
using System.Collections.Generic;

namespace myLabWebApi.Interface
{
    public interface ITestService
    {
        long InsertUpdateTestType(TestTypeModel model);

        List<TestTypeModel> GetTestTypeSearch(SearchFilters m);
        List<TestDetModel> GetPTestResult(long ID);

        long GetTestTypeSearchCount(SearchFilters m);

        TestTypeModel GetTestTypeUsingId(int Id);

        long DeleteTestTypeById(int Id);

        long InsertUpdatePathalogyTest(PathalogyTestMaster model);
        long InsertRemarkMaster(List<TestDetModel> model,string ID);
        long InsertUpdateTest(PathalogyTestMaster model);

        long InsertUpdatePathalogyTestDetails(PathalogyTestDetails model);

        PathalogyTestMaster GetPathalogyTestMasterUsingId(int Id);

        long DeletePathalogyTestMaster(int Id);

        List<PathalogyTestDetails> GetPathalogyTestDetailsUsingId(int Id);

        List<PathalogyTestMaster> GetPathalogyTestSearch(SearchByKeywordPageNoPageSizeType m);

        long GetPathalogyTestSearchCount(SearchByKeywordType m);

        long InsertTestFormatDetails(TestFormatDetails model);

        long DeleteTestFormat(int Id);

        List<TestFormatDetails> GetTestFormatDetailList(int Id);
        long GetReSampleReasonSearchCount(SearchFilters m);
        List<NarrationModel> GetReSampleReasonSearch(SearchFilters m);
        long InsertUpdateReSampleReason(NarrationModel model);
        public long GetNarrationSearchCount(SearchFilters m);
        public List<NarrationModel> GetNarrationSearch(SearchFilters m);
        public long InsertUpdateNarration(NarrationModel model);


        List<PAIT_HDR_DET_TEST_New> GetAllTestDetailsbyPatientID(long ID);

        List<PatientMasterModel> GetPatientListforDataEntry(string Keyword, string FromDate, string ToDate);

        List<PAIT_HDR_DET_TEST_New> GetPatientAllTestDetail(long ID);


         PAIT_HDR_DET_TEST_smsreport GetPatientAllTestDetailsmsreport(string SendSMS, int myvalue, string testname);
       

        long InsertUpdateProfileTest(ProfileTestModel model);
      
    }
}