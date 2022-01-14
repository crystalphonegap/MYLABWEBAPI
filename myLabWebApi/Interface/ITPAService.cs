using myLabWebApi.Models;
using myLabWebApi.Models.New;
using System.Collections.Generic;

namespace myLabWebApi.Interface
{
   public interface ITPAService
    {
       public List<TPAClass> GetAllTPADetails(SearchFilters m);

       public long GetAllTPADetailsCount(SearchFilters m);
       public long InsertUpdateTPADetails(TPAClass model);
        public TPAClass GetTPADetailsByID(int Id);
       public string DeleteTPAById(int Id);
    }
}
