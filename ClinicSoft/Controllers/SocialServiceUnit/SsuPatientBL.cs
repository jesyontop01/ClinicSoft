using ClinicSoft.Core;
using ClinicSoft.Core.Parameters;
using ClinicSoft.DalLayer;
using ClinicSoft.ServerModel;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;

namespace ClinicSoft.Controllers
{
    public class SsuPatientBL
    {
        public static NewPatientUniqueNumbersVM GetPatNumberNCodeForNewPatient(string connString)
        {
            NewPatientUniqueNumbersVM retValue = new NewPatientUniqueNumbersVM();
            //int newPatNo = 0;
            string newPatNo = "";
            string newPatCode = "";

            PatientDbContext patientDbContext = new PatientDbContext(connString);
            var maxPatNo = patientDbContext.Patients.DefaultIfEmpty().Max(p => p == null ? "" : p.ClinicCardNo);
            newPatNo = maxPatNo;


            string patCodeFormat = "YYMM-PatNum";//this is default value.
            string hospitalCode = "";//default empty


            CoreDbContext coreDbContext = new CoreDbContext(connString);

            List<ParameterModel> allParams = coreDbContext.Parameters.ToList();


            ParameterModel patCodeFormatParam = allParams
               .Where(a => a.ParameterGroupName == "Patient" && a.ParameterName == "LPNoFormat")
               .FirstOrDefault<ParameterModel>();
            if (patCodeFormatParam != null)
            {
                patCodeFormat = patCodeFormatParam.ParameterValue;
            }


            ParameterModel hospCodeParam = allParams
                .Where(a => a.ParameterName == "HospitalCode")
                .FirstOrDefault<ParameterModel>();
            if (hospCodeParam != null)
            {
                hospitalCode = hospCodeParam.ParameterValue;
            }



            if (patCodeFormat == "YYMM-PatNum")
            {
                newPatCode = DateTime.Now.ToString("yy") + DateTime.Now.ToString("MM") + String.Format("{0:D6}", newPatNo);
            }
            else if (patCodeFormat == "HospCode-PatNum")
            {
                newPatCode = hospitalCode + newPatNo;
            }
            else if (patCodeFormat == "PatNum")
            {
                newPatCode = newPatNo.ToString();
            }


            retValue.ClinicCardNo = newPatNo;
            retValue.LPNo = newPatCode;

            return retValue;
        }
    }
}
