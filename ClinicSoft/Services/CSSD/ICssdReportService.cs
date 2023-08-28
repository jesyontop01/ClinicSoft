using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;

namespace ClinicSoft.Services
{
    public interface ICssdReportService
    {
        Task<IList<IntegratedCssdReportDto>> GetIntegratedCssdReport(DateTime FromDate, DateTime ToDate);
    }
}
