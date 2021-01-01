using myLabWebApi.Models.DB;
using myLabWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myLabWebApi.Interface
{
    public interface IMaster
    {
        List<CollectionCenterModel> GetAllCollectionCenterDetails();
             

        long InsertUpdateCollectioncenter(CollectionCenterModel Collectioncenterdetails);
    }
}
