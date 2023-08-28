using ClinicSoft.ServerModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;

namespace ClinicSoft.Services
{
    public interface IActivateInventoryService
    {
        IList<ActivateInventoryDTO> GetAllInventories();
        PHRMStoreModel GetInventory(int id);
    }
}
