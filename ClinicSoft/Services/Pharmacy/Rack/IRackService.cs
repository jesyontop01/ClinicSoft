using ClinicSoft.ServerModel;
using ClinicSoft.ServerModel.PharmacyModels;
using ClinicSoft.ViewModel.Pharmacy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;

namespace ClinicSoft.Services.Pharmacy.Rack
{
    public interface IRackService
    {
        List<RackViewModel> ListRack();
        RackViewModel AddRack(PHRMRackModel model);
        RackViewModel UpdateRack(RackViewModel model);
        RackViewModel GetRack(int id);
        void DeleteRack(int id);
        List<RackViewModel> GetParentRack();
        List<PHRMItemMasterModel> GetDrugList(int rackId);
        string GetStoreRackNameByItemId(int itemId);
    }
}
