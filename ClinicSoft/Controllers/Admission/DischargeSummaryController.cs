using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ClinicSoft.Core.Configuration;
using ClinicSoft.ServerModel;
using ClinicSoft.DalLayer;

using Microsoft.Extensions.Options;
using ClinicSoft.Utilities;
using ClinicSoft.CommonTypes;
using ClinicSoft.Core.Caching;
using ClinicSoft.Security;
using ClinicSoft.Controllers.Billing;

namespace ClinicSoft.Controllers
{
    public class DischargeSummaryController : CommonController
    {
        double cacheExpMinutes;//= 5;//this should come from configuration later on.

        public DischargeSummaryController(IOptions<MyConfiguration> _config) : base(_config)
        {
            cacheExpMinutes = _config.Value.CacheExpirationMinutes;
        }

        //[HttpGet]
        //public string Get(string reqType,
        //    int patientId, int patientVisitId,
        //    string admissionStatus, int wardId,
        //    int bedFeatureId, int ipVisitId,
        //    int bedId)
        //{
        //    DanpheHTTPResponse<object> responseData = new DanpheHTTPResponse<object>();
        //    try
        //    {
        //        AdmissionDbContext dbContext = new AdmissionDbContext(base.connString);
        //        MasterDbContext masterDbContext = new MasterDbContext(base.connString);



        //        if (reqType == "getADTList")
        //        {
        //            return "1vcncncvn";
        //        }
        //    }
        //    catch(Exception ex)
        //    {
        //        return "vcvbcnvn";
        //    }       
        //}
    }
}