using ClinicSoft.ServerModel;
using ClinicSoft.ServerModel.PharmacyModels;
using ClinicSoft.ViewModel.Pharmacy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;

namespace ClinicSoft.Services
{
    public interface IDesignationService
    {
        List<DesignationModel> ListDesignation();
        DesignationModel AddDesignation(DesignationModel model);
        DesignationModel UpdateDesignation(DesignationModel model);
        DesignationModel GetDesignation(int id);
    }
}
