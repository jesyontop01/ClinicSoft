﻿
using System;
using System.Collections.Generic;

using System.Linq;
using System.Data.SqlClient;
using ClinicSoft.CommonTypes;
using ClinicSoft.Core.Configuration;
using ClinicSoft.DalLayer;
using ClinicSoft.Security;
using ClinicSoft.ServerModel;
using ClinicSoft.ServerModel.InventoryModels;
using ClinicSoft.Utilities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.EntityFrameworkCore;

namespace ClinicSoft.Controllers
{
    public class AssetManagementController : CommonController
    {
        public AssetManagementController(IOptions<MyConfiguration> _config) : base(_config)
        {

        }

        [HttpGet("{StoreId}")]
        public async Task<IActionResult> GetAssetStockList([FromRoute] int StoreId)
        {
            var responseData = new DanpheHTTPResponse<object>();
            try
            {
                var currentUserId = HttpContext.Session.Get<RbacUser>("currentuser").UserId;
                var inventoryDbContext = new InventoryDbContext(connString);

                var goodsReceiptList = await (from fixedAssetStock in inventoryDbContext.FixedAssetStock
                                              join gritem in inventoryDbContext.GoodsReceiptItems on fixedAssetStock.GoodsReceiptItemId equals gritem.GoodsReceiptItemId into griJ
                                              from griLJ in griJ.DefaultIfEmpty()
                                              join grlist in inventoryDbContext.GoodsReceipts on griLJ.GoodsReceiptId equals grlist.GoodsReceiptID into grJ
                                              from grLJ in grJ.DefaultIfEmpty()
                                              join emp in inventoryDbContext.Employees on griLJ.CreatedBy equals emp.EmployeeId into empJ
                                              from empLJ in empJ.DefaultIfEmpty()
                                              from dontLj in inventoryDbContext.FixedAssetDonation.Where(d => d.DonationId == fixedAssetStock.DonationId).DefaultIfEmpty()
                                              join item in inventoryDbContext.Items on fixedAssetStock.ItemId equals item.ItemId
                                              join vend in inventoryDbContext.Vendors on grLJ.VendorId equals vend.VendorId into vendJ
                                              from vendLJ in vendJ.DefaultIfEmpty()
                                              join substore in inventoryDbContext.StoreMasters on fixedAssetStock.SubStoreId equals substore.StoreId into substoreG
                                              from substoreLJ in substoreG.DefaultIfEmpty()
                                              join don in inventoryDbContext.FixedAssetDonation on fixedAssetStock.DonationId equals don.DonationId into gs
                                              from don in gs.DefaultIfEmpty()
                                              join assetHolder in inventoryDbContext.Employees on fixedAssetStock.AssetHolderId equals assetHolder.EmployeeId into ahJ
                                              from assetHolderLeftJoined in ahJ.DefaultIfEmpty()
                                              where fixedAssetStock.IsActive == true && (fixedAssetStock.IsMaintenanceRequired == false || fixedAssetStock.IsAssetDamaged == true) && fixedAssetStock.StoreId == StoreId
                                              let IsCurrentUserMaintenanceOwner = inventoryDbContext.UserRoleMaps.Any(a => a.RoleId == item.MaintenanceOwnerRoleId && a.UserId == currentUserId)
                                              select new
                                              {
                                                  FixedAssetStockId = fixedAssetStock.FixedAssetStockId,
                                                  BarCodeNumber = fixedAssetStock.BarCodeNumber,
                                                  AssetCode = fixedAssetStock.AssetCode,
                                                  BatchNo = fixedAssetStock.BatchNo,
                                                  WarrantyExpiryDate = fixedAssetStock.WarrantyExpiryDate,
                                                  AssetsLocation = fixedAssetStock.AssetsLocation,
                                                  IsBarCodeGenerated = fixedAssetStock.IsBarCodeGenerated,
                                                  IsAssetDamaged = fixedAssetStock.IsAssetDamaged,
                                                  CreatedBy = fixedAssetStock.CreatedBy,
                                                  CreatedOn = fixedAssetStock.CreatedOn,
                                                  ItemId = fixedAssetStock.ItemId,
                                                  IsActive = fixedAssetStock.IsActive,
                                                  ItemRate = fixedAssetStock.ItemRate,
                                                  MRP = fixedAssetStock.MRP,
                                                  DiscountAmount = fixedAssetStock.DiscountAmount,
                                                  DiscountPercent = fixedAssetStock.DiscountPercent,
                                                  VAT = fixedAssetStock.VAT,
                                                  VATAmount = fixedAssetStock.VATAmount,
                                                  CcAmount = fixedAssetStock.CcAmount,
                                                  CcCharge = fixedAssetStock.CcCharge,
                                                  OtherCharge = fixedAssetStock.OtherCharge,
                                                  ManufactureDate = fixedAssetStock.ManufactureDate,
                                                  YearOfUse = fixedAssetStock.YearOfUse,
                                                  TotalLife = fixedAssetStock.TotalLife,
                                                  Performance = fixedAssetStock.Performance,
                                                  BuildingBlockNumber = fixedAssetStock.BuildingBlockNumber,
                                                  Floors = fixedAssetStock.Floors,
                                                  RoomNumber = fixedAssetStock.RoomNumber,
                                                  RoomPosition = fixedAssetStock.RoomPosition,
                                                  SerialNo = fixedAssetStock.SerialNo,
                                                  ModelNo = fixedAssetStock.ModelNo,
                                                  ExpectedValueAfterUsefulLife = fixedAssetStock.ExpectedValueAfterUsefulLife,
                                                  IsMaintenanceRequired = fixedAssetStock.IsMaintenanceRequired,
                                                  IsAssetDamageConfirmed = fixedAssetStock.IsAssetDamageConfirmed,
                                                  IsAssetScraped = fixedAssetStock.IsAssetScraped,
                                                  ScrapAmount = fixedAssetStock.ScrapAmount,
                                                  ScrapRemarks = fixedAssetStock.ScrapRemarks,
                                                  DonationId = fixedAssetStock.DonationId,
                                                  SubStoreId = fixedAssetStock.SubStoreId,
                                                  StoreId = fixedAssetStock.StoreId,
                                                  AssetHolderId = fixedAssetStock.AssetHolderId,
                                                  StockSpecification = fixedAssetStock.StockSpecification,
                                                  item.ItemName,
                                                  ItemCode = item.Code,
                                                  IsColdStorageApplicable = item.IsColdStorageApplicable,
                                                  VendorName = (vendLJ == null) ? "" : vendLJ.VendorName,
                                                  ContactNo = (vendLJ == null) ? "" : vendLJ.ContactNo,
                                                  ContactAddress = (vendLJ == null) ? "" : vendLJ.ContactAddress,
                                                  Email = (vendLJ == null) ? "" : vendLJ.Email,
                                                  VendorId = vendLJ == null ? 0 : vendLJ.VendorId,
                                                  Name = vendLJ == null ? "" : vendLJ.Name,
                                                  Name2 = vendLJ == null ? "" : vendLJ.Name2,
                                                  PhoneNumber = vendLJ == null ? "" : vendLJ.PhoneNumber,
                                                  PhoneNumber2 = vendLJ == null ? "" : vendLJ.PhoneNumber2,
                                                  CompanyPosition = vendLJ == null ? "" : vendLJ.CompanyPosition,
                                                  CompanyPosition2 = vendLJ == null ? "" : vendLJ.CompanyPosition2,
                                                  CreatedByName = empLJ == null ? "" : empLJ.FullName,
                                                  SubStoreName = substoreLJ == null ? "" : substoreLJ.Name,
                                                  Donation = dontLj.Donation,
                                                  AssetHolderName = (assetHolderLeftJoined != null) ? assetHolderLeftJoined.FullName : "",
                                                  AssetMaintenanceOwnerRoleId = item.MaintenanceOwnerRoleId,
                                                  IsCurrentUserMaintenanceOwner = IsCurrentUserMaintenanceOwner
                                              }).OrderByDescending(a => a.CreatedOn).ToListAsync();
                responseData.Status = "OK";
                responseData.Results = goodsReceiptList;
            }
            catch (Exception ex)
            {
                responseData.Status = "Failed";
                responseData.ErrorMessage = "Failed to load asset gr list. Details: " + ex.ToString();
                return Ok(responseData);
            }
            return Ok(responseData);
        }

        [HttpGet("GetAssetInsurance/{fixedAssetStockId}")]
        public async Task<IActionResult> GetAssetsInsurance([FromRoute] int fixedAssetStockId)
        {
            var invDbContext = new InventoryDbContext(connString);
            var resData = new DanpheHTTPResponse<object>();

            try
            {
                var results = await (from stock in invDbContext.FixedAssetInsurance
                                     where stock.FixedAssetStockId == fixedAssetStockId
                                     select stock).FirstOrDefaultAsync();

                resData.Results = results;
                resData.Status = "OK";

            }
            catch (Exception ex)
            {
                resData.Status = "Failed";
                resData.ErrorMessage = ex.ToString();
                return BadRequest(resData);
            }
            return Ok(resData);
        }

        [HttpPost("PostAssetInsurance")]
        public IActionResult PostAssetInsurance()
        {
            var inventoryDbContext = new InventoryDbContext(connString);
            var responseData = new DanpheHTTPResponse<object>();
            RbacUser currentUser = HttpContext.Session.Get<RbacUser>("currentuser");
            try
            {
                string Str = this.ReadPostData();
                FixedAssetInsuranceModel insuranceDetails = DanpheJSONConvert.DeserializeObject<FixedAssetInsuranceModel>(Str);


                using (var dbContextTransaction = inventoryDbContext.Database.BeginTransaction())
                {
                    try
                    {

                        insuranceDetails.CreatedBy = currentUser.EmployeeId;
                        insuranceDetails.CreatedOn = DateTime.Now;

                        inventoryDbContext.FixedAssetInsurance.Add(insuranceDetails);
                        inventoryDbContext.SaveChanges();


                        // After File Added Commit the Transaction
                        dbContextTransaction.Commit();

                    }
                    catch (Exception ex)
                    {
                        dbContextTransaction.Rollback();
                        throw ex;
                    }
                }

                responseData.Results = null;
                responseData.Status = "OK";
            }
            catch (Exception ex)
            {
                responseData.Status = "Failed";
                responseData.ErrorMessage = "Failed to Post Asset Contract!" + ex.ToString();
                return BadRequest(responseData);
            }
            return Ok(responseData);
        }

        [HttpPut("PutAssetInsurance")]
        public IActionResult PutAssetInsurance()
        {
            var inventoryDbContext = new InventoryDbContext(connString);
            var responseData = new DanpheHTTPResponse<object>();
            RbacUser currentUser = HttpContext.Session.Get<RbacUser>("currentuser");
            try
            {
                var Str = this.ReadPostData();
                FixedAssetInsuranceModel insuranceDetails = DanpheJSONConvert.DeserializeObject<FixedAssetInsuranceModel>(Str);



                insuranceDetails.ModifiedBy = currentUser.EmployeeId;
                insuranceDetails.ModifiedOn = DateTime.Now;

                var temp = inventoryDbContext.FixedAssetInsurance.Attach(insuranceDetails);
                inventoryDbContext.Entry(insuranceDetails).Property(x => x.AssetInsurannceId).IsModified = false;
                inventoryDbContext.Entry(insuranceDetails).Property(x => x.FixedAssetStockId).IsModified = false;

                inventoryDbContext.Entry(temp).State = EntityState.Modified;

                inventoryDbContext.SaveChanges();
                responseData.Results = insuranceDetails;
                responseData.Status = "OK";
            }
            catch (Exception ex)
            {
                responseData.Status = "Failed";
                responseData.ErrorMessage = "Failed to Update Asset Contract!" + ex.ToString();
                return BadRequest(responseData);
            }
            return Ok(responseData);
        }


        [HttpPut("PutAssetDamageConfirmation")]
        public IActionResult PutAssetDamageConfirmation()
        {
            var inventoryDbContext = new InventoryDbContext(connString);
            var responseData = new DanpheHTTPResponse<object>();
            RbacUser currentUser = HttpContext.Session.Get<RbacUser>("currentuser");
            try
            {
                var Str = this.ReadPostData();
                FixedAssetStockModel assetDetails = DanpheJSONConvert.DeserializeObject<FixedAssetStockModel>(Str);



                assetDetails.ModifiedBy = currentUser.EmployeeId;
                assetDetails.ModifiedOn = DateTime.Now;

                var temp = inventoryDbContext.FixedAssetStock.Attach(assetDetails);
                inventoryDbContext.Entry(temp).Property(x => x.Entity.FixedAssetStockId).IsModified = false;
                inventoryDbContext.Entry(temp).Property(x => x.Entity.IsAssetDamageConfirmed).IsModified = true;
                inventoryDbContext.Entry(temp).Property(x => x.Entity.ModifiedBy).IsModified = true;
                inventoryDbContext.Entry(temp).Property(x => x.Entity.ModifiedOn).IsModified = true;

                //inventoryDbContext.Entry(temp).State = EntityState.Modified;


                inventoryDbContext.SaveChanges();
                responseData.Results = assetDetails;
                responseData.Status = "OK";
            }
            catch (Exception ex)
            {
                responseData.Status = "Failed";
                responseData.ErrorMessage = ex.ToString();
                return BadRequest(responseData);
            }
            return Ok(responseData);
        }

        [HttpPut("UpdateAssetManagementList")]
        public IActionResult UpdateAssetManagementList()
        {
            var responseData = new DanpheHTTPResponse<object>();

            try
            {
                var inventorygDbContext = new InventoryDbContext(connString);
                RbacUser currentUser = HttpContext.Session.Get<RbacUser>("currentuser");


                string str = this.ReadPostData();
                FixedAssetStockModel fixedAssetstock = DanpheJSONConvert.DeserializeObject<FixedAssetStockModel>(str);
                AssetLocationHistoryModel assetslocation = new AssetLocationHistoryModel();
                using (var dbTransaction = inventorygDbContext.Database.BeginTransaction())
                {
                    try
                    {
                        fixedAssetstock.ModifiedBy = currentUser.EmployeeId;
                        fixedAssetstock.ModifiedOn = DateTime.Now;
                        //fixedAssetstock.IsActive = true;
                        var temp = inventorygDbContext.FixedAssetStock.Attach(fixedAssetstock);
                        inventorygDbContext.Entry(temp).State = EntityState.Modified;
                        //inventorygDbContext.Entry(temp).Property(x => x.FixedAssetStockId).IsModified = false;
                        inventorygDbContext.Entry(temp).Property(x => x.Entity.ItemId).IsModified = false;
                        inventorygDbContext.Entry(temp).Property(x => x.Entity.ItemRate).IsModified = false;
                        inventorygDbContext.Entry(temp).Property(x => x.Entity.DiscountAmount).IsModified = false;
                        inventorygDbContext.Entry(temp).Property(x => x.Entity.DiscountPercent).IsModified = false;
                        inventorygDbContext.Entry(temp).Property(x => x.Entity.VATAmount).IsModified = false;
                        inventorygDbContext.Entry(temp).Property(x => x.Entity.VAT).IsModified = false;
                        inventorygDbContext.Entry(temp).Property(x => x.Entity.MRP).IsModified = false;
                        inventorygDbContext.Entry(temp).Property(x => x.Entity.CcAmount).IsModified = false;
                        inventorygDbContext.Entry(temp).Property(x => x.Entity.CcCharge).IsModified = false;
                        inventorygDbContext.Entry(temp).Property(x => x.Entity.OtherCharge).IsModified = false;
                        inventorygDbContext.Entry(temp).Property(x => x.Entity.CounterId).IsModified = false;
                        inventorygDbContext.Entry(temp).Property(x => x.Entity.CreatedOn).IsModified = false;
                        inventorygDbContext.Entry(temp).Property(x => x.Entity.CreatedBy).IsModified = false;
                        inventorygDbContext.Entry(temp).Property(x => x.Entity.GoodsReceiptItemId).IsModified = false;
                        inventorygDbContext.Entry(temp).Property(x => x.Entity.TotalLife).IsModified = false;
                        inventorygDbContext.Entry(temp).Property(x => x.Entity.YearOfUse).IsModified = false;
                        inventorygDbContext.Entry(temp).Property(x => x.Entity.Performance).IsModified = false;
                        inventorygDbContext.Entry(temp).Property(x => x.Entity.ManufactureDate).IsModified = false;
                        inventorygDbContext.Entry(temp).Property(x => x.Entity.AssetsLocation).IsModified = true;
                        inventorygDbContext.Entry(temp).Property(x => x.Entity.WarrantyExpiryDate).IsModified = true;
                        inventorygDbContext.Entry(temp).Property(x => x.Entity.SerialNo).IsModified = true;
                        inventorygDbContext.Entry(temp).Property(x => x.Entity.ModelNo).IsModified = true;
                        inventorygDbContext.Entry(temp).Property(x => x.Entity.BuildingBlockNumber).IsModified = true;
                        inventorygDbContext.Entry(temp).Property(x => x.Entity.Floors).IsModified = true;
                        inventorygDbContext.Entry(temp).Property(x => x.Entity.RoomNumber).IsModified = true;
                        inventorygDbContext.Entry(temp).Property(x => x.Entity.RoomPosition).IsModified = true;
                        inventorygDbContext.Entry(temp).Property(x => x.Entity.AssetHolderId).IsModified = true;
                        inventorygDbContext.Entry(temp).Property(x => x.Entity.StoreId).IsModified = true;
                        inventorygDbContext.Entry(temp).Property(x => x.Entity.AssetCode).IsModified = true;
                        inventorygDbContext.SaveChanges();

                        //adding LocationHistory in AssetsLocationHistory
                            var assetLastLocationHistory = inventorygDbContext.AssetLocationHistory
                                                                         .Where(x => x.FixedAssetStockId == fixedAssetstock.FixedAssetStockId)
                                                                         .OrderByDescending(x => x.AssetsLocationHistoryId)
                                                                         .FirstOrDefault();

                        if (assetLastLocationHistory != null)
                        {
                            assetLastLocationHistory.EndDate = DateTime.Now;
                        }
                        var newAssetLocationHistory = new AssetLocationHistoryModel
                        {
                            CreatedBy = currentUser.EmployeeId,
                            StartDate = DateTime.Now,
                            OldLocation = temp.Entity.AssetsLocation,
                            OldStoreId = temp.Entity.StoreId,
                            OldAssetHolderId = temp.Entity.AssetHolderId,
                            FixedAssetStockId = temp.Entity.FixedAssetStockId
                        };
                        inventorygDbContext.AssetLocationHistory.Add(newAssetLocationHistory);
                        inventorygDbContext.SaveChanges();
                        dbTransaction.Commit();
                        responseData.Results = fixedAssetstock;
                        responseData.Status = "OK";
                    }
                    catch (Exception ex)
                    {
                        responseData.ErrorMessage = "Failed! Details:" + ex.ToString();
                        responseData.Status = "Failed";
                        dbTransaction.Rollback();
                    }
                }

            }
            catch (Exception ex)
            {
                responseData.ErrorMessage = "Failed ! Error Details: " + ex.ToString();
                return BadRequest(responseData);

            }
            return Ok(responseData);
        }


        [HttpGet("GetAllInventoryFiscalYears")]
        public async Task<IActionResult> GetAllInventoryFiscalYears()
        {
            var db = new InventoryDbContext(connString);
            var responseData = new DanpheHTTPResponse<object>();
            try
            {
                var fiscalYearList = await db.InventoryFiscalYears.ToListAsync();
                if (fiscalYearList == null || fiscalYearList.Count() == 0)
                {
                    responseData.Status = "Failed";
                    responseData.ErrorMessage = "No fiscal year found.";
                    return NotFound(responseData);
                }
                responseData.Results = fiscalYearList;
                responseData.Status = "OK";
            }
            catch (Exception ex)
            {
                responseData.Status = "Failed";
                responseData.ErrorMessage = $"Failed to obtain fiscal years. Message: {ex.Message}";
                return BadRequest(responseData);
            }
            return Ok(responseData);
        }


    }
}
