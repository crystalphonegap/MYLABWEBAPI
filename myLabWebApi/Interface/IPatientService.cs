using myLabWebApi.Models.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace myLabWebApi.Interface
{
    public interface IPatientService
    {
        int Create(Patient Patient);
    }
}
