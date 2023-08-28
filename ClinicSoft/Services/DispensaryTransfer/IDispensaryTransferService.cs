using ClinicSoft.Controllers.Dispensary;
using ClinicSoft.Security;
using ClinicSoft.ServerModel;
using ClinicSoft.ServerModel.PharmacyModels;
using ClinicSoft.ViewModel.DispensaryTransfer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;

namespace ClinicSoft.Services.DispensaryTransfer
{
    public interface IDispensaryTransferService
    {
        IList<PHRMStoreModel> GetAllStoresForTransfer();
        Task<IList<GetAllDispensaryStocksVm>> GetAllDispensaryStocks(int DispensaryId);
        Task<int> TransferStock(List<StockTransferModel> value , RbacUser currentUser );
        Task<int> ReturnToStore(List<StockTransferModel> value, RbacUser currentUser);
        Task<int> DispensaryToDispensaryTransfer(List<StockTransferModel> value, RbacUser currentUser);
        Task<IList<GetAllTransactionByStoreIdDTO>> GetAllTransactionByStoreId(int storeId);
    }
}
