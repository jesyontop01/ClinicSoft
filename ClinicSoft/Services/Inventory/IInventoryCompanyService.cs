using ClinicSoft.ServerModel;
using ClinicSoft.ServerModel.PharmacyModels;
using ClinicSoft.ViewModel.Pharmacy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;

namespace ClinicSoft.Services
{
    public interface IInventoryCompanyService
    {
        List<InventoryCompanyModel> ListCompany();
        InventoryCompanyModel AddCompany(InventoryCompanyModel model);
        InventoryCompanyModel UpdateCompany(InventoryCompanyModel model);
        InventoryCompanyModel GetCompany(int id);
        void DeleteInventoryCompany(int id);
    }
}
