using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicSoft.ServerModel.BillingModels
{
    public class PatientBillsVM : BillingTransactionModel
    {
        public List<InvoiceDetailsModel> InvoicesList { get; set; }

        public List<BillSettlementModel> Settlements { get; set; }
    }
}
