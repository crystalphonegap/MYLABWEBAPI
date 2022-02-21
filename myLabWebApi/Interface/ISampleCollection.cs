using myLabWebApi.Models;
using myLabWebApi.Models.New;
using System.Collections.Generic;

namespace myLabWebApi.Interface
{
   public interface ISampleCollection
    {
        List<SampleCollectionClass> GetSamplePatientList(SampleCollectionClassSearchModel m);
        List<PatientTestDetailsSampleCollection> GetPATIENTTESTDETAILS(int PatientId, string Type);
        List<SampleCollectionTestType> GetTestType();
        string UpdateSampleCollectionDerails(SampleCollectionInsertClass model);
    }
}
