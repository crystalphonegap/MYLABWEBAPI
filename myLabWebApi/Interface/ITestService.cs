﻿using myLabWebApi.Models;
using System.Collections.Generic;

namespace myLabWebApi.Interface
{
    public interface ITestService
    {
        long InsertUpdateTestType(TestTypeModel model);

        List<TestTypeModel> GetTestTypeSearch(int PageNo, int PageSize, string KeyWord);

        long GetTestTypeSearchCount(string KeyWord);

        TestTypeModel GetTestTypeUsingId(int Id);

        long DeleteTestTypeById(int Id);

        long InsertUpdatePathalogyTest(PathalogyTestMaster model);

        long InsertUpdatePathalogyTestDetails(PathalogyTestDetails model);

        PathalogyTestMaster GetPathalogyTestMasterUsingId(int Id);

        long DeletePathalogyTestMaster(int Id);

        List<PathalogyTestDetails> GetPathalogyTestDetailsUsingId(int Id);

        List<PathalogyTestMaster> GetPathalogyTestSearch(int PageNo, int PageSize, string KeyWord);

        long GetPathalogyTestSearchCount(string KeyWord);

        long InsertTestFormatDetails(TestFormatDetails model);

        long DeleteTestFormat(int Id);

        List<TestFormatDetails> GetTestFormatDetailList(int Id);
        long GetReSampleReasonSearchCount(string KeyWord);
        List<NarrationModel> GetReSampleReasonSearch(int PageNo, int PageSize, string KeyWord);
        long InsertUpdateReSampleReason(NarrationModel model);
        public long GetNarrationSearchCount(string KeyWord);
        public List<NarrationModel> GetNarrationSearch(int PageNo, int PageSize, string KeyWord);
        public long InsertUpdateNarration(NarrationModel model);

    }
}