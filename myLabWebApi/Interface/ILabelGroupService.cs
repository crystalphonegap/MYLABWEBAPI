using myLabWebApi.Models;
using myLabWebApi.Models.New;
using System.Collections.Generic;

namespace myLabWebApi.Interface
{
    public interface ILabelGroupService
    {
        long InsertUpdateLabelGroupMaster(LabelGroupMaster LabelGroupMaster);
        List<TestDetailsClass> GetTestList();

        List<LabelGroupMaster> GetLabelGroupList(SearchByKeywordType m);

        List<LabelGroupDetailsClass> GetLabelGroupDetailsById(int Id);
    }
}
