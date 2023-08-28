
using ClinicSoft.CommonTypes;
using ClinicSoft.DalLayer;
using ClinicSoft.ServerModel;
using ClinicSoft.Utilities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace ClinicSoft.Controllers
{
    public class StickersBL
    {
        public List<PatientStickerModel> GetPatientStickerDetails (PatientDbContext context, int PatientId)
        {
            throw new NotImplementedException();
                //List<PatientStickerModel> Data = context.Database.SqlQuery<PatientStickerModel>("exec SP_GetPatientStickerDetails @PatientId",
                //new SqlParameter("@PatientId", PatientId)).ToList();
                //return Data;            
        }

    }
}
