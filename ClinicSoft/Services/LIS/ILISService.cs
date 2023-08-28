using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using ClinicSoft.ServerModel;

namespace ClinicSoft.Services.LIS
{
    public interface ILISService
    {
        Task<LISMasterData> GetAllMasterDataAsync();
        Task<List<LISComponentMapModel>> GetAllMappedData();
        IEnumerable<ComponentMasterToMap> GetAllNotMappedDataByMachineId(int id, int? slectedMapId);
        LISComponentMapModel GetSelectedMappedDataById(int id);
        void AddUpdateMapping(List<LISComponentMapModel> mapping);
        void DeleteMapping(int id, int userId);
        Task<List<MachineResultsFormatted>> GetMachineResults(int machineId);
        IEnumerable<LISMachineMaster> GetAllMachines();
        Task<bool> AddLISDataToDanphe(List<MachineResultsVM> machineData);
    }
}
