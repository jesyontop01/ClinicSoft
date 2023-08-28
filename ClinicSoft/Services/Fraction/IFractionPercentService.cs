using ClinicSoft.ServerModel;
using ClinicSoft.ServerModel.FractionModels;
using ClinicSoft.ServerModel.PharmacyModels;
using ClinicSoft.ViewModel.Pharmacy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;

namespace ClinicSoft.Services
{
    public interface IFractionPercentService
    {
        List<FractionPercentVM> ListFractionApplicableItems();
        FractionPercentVM AddFractionPercent(FractionPercentModel model);
        FractionPercentVM UpdateFractionPercent(FractionPercentModel model);
        FractionPercentVM GetFractionPercent(int id);
        FractionPercentVM GetFractionPercentByBillPriceId(int id);

    }
}
