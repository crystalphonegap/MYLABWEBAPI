using myLabWebApi.Models;
using myLabWebApi.Models.New;
using System.Collections.Generic;

namespace myLabWebApi.Interface
{
    public interface ILabelGroupService
    {
        long InsertUpdateLabelGroupMaster(LabelGroupMaster LabelGroupMaster);
    }
}
