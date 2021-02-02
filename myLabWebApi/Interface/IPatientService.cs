using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using myLabWebApi.Models;

namespace myLabWebApi.Interface
{
    public interface IPatientService
    {
        int Create(PatientMasterModel Patient);

        int InsertDOCHDR(DOCHDRModel model);

        int InsertDOCDET(DOCDETModel model);
        int InsertPatientPayment(AmountPaidModel model);

        int InsertPatientHistory(PatientHistoryModel model);
    }
}