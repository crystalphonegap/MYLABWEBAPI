using myLabWebApi.Models;
using System.Collections.Generic;

namespace myLabWebApi.Interface
{
    public interface ITestService
    {
        long InsertUpdateTestType(TestTypeModel model);

        List<TestTypeModel> GetTestTypeSearch(SearchFilters m);

        long GetTestTypeSearchCount(SearchByKeyword m);

        TestTypeModel GetTestTypeUsingId(int Id);

        long DeleteTestTypeById(int Id);

        long InsertUpdatePathalogyTest(PathalogyTestMaster model);

        long InsertUpdatePathalogyTestDetails(PathalogyTestDetails model);

        PathalogyTestMaster GetPathalogyTestMasterUsingId(int Id);

        long DeletePathalogyTestMaster(int Id);

        List<PathalogyTestDetails> GetPathalogyTestDetailsUsingId(int Id);

        List<PathalogyTestMaster> GetPathalogyTestSearch(SearchByKeywordPageNoPageSizeType m);

        long GetPathalogyTestSearchCount(SearchByKeywordType m);

        long InsertTestFormatDetails(TestFormatDetails model);

        long DeleteTestFormat(int Id);

        List<TestFormatDetails> GetTestFormatDetailList(int Id);
        long GetReSampleReasonSearchCount(SearchByKeyword m);
        List<NarrationModel> GetReSampleReasonSearch(SearchFilters m);
        long InsertUpdateReSampleReason(NarrationModel model);
        public long GetNarrationSearchCount(SearchByKeyword m);
        public List<NarrationModel> GetNarrationSearch(SearchFilters m);
        public long InsertUpdateNarration(NarrationModel model);

    }
}