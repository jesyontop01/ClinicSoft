using ClinicSoft.Security;
using ClinicSoft.ViewModel.Pharmacy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;

namespace ClinicSoft.Services.Pharmacy.SupplierLedger
{
    public interface ISupplierLedgerService
    {
        Task<GetSupplierLedgerGRDetailsVM> GetSupplierLedgerGRDetails(int supplierId);
        Task<GetPHRMSupplierLedgerVM> GetAllAsync();
        int MakeSupplierLedgerPayment(IList<MakeSupplierLedgerPaymentVM> ledgerTxn, RbacUser currentUser);
    }
}
