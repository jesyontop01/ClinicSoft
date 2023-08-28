﻿using System;
using System.Collections.Generic;
using System.Linq;
using ClinicSoft.DalLayer;
using ClinicSoft.Core.Configuration;
using Microsoft.Extensions.Options;
using ClinicSoft.ServerModel;
using Microsoft.EntityFrameworkCore;

namespace ClinicSoft.Services
{
    public class InventoryCompanyService : IInventoryCompanyService
    {
        public InventoryDbContext db;
        private readonly string connString = null;

        public InventoryCompanyService(IOptions<MyConfiguration> _config)
        {
            connString = _config.Value.Connectionstring;
            db = new InventoryDbContext(connString);
        }

        public List<InventoryCompanyModel> ListCompany()
        {
            //todo:add server side pagination
            var query = db.InventoryCompany.ToList();
            return query;
        }

        public InventoryCompanyModel AddCompany(InventoryCompanyModel model)
        {
            model.CreatedOn = DateTime.Now;
            db.InventoryCompany.Add(model);
            db.SaveChanges();
            return model;
        }

        public InventoryCompanyModel UpdateCompany(InventoryCompanyModel model)
        {
            db.Entry(model).State = EntityState.Modified;
            db.SaveChanges();
            return model;
        }

        public InventoryCompanyModel GetCompany(int id)
        {
            var result = db.InventoryCompany.Where(x => x.CompanyId == id).FirstOrDefault();      
            return result;
        }

        public void DeleteInventoryCompany(int id)
        {
            throw new NotImplementedException();
        }
    }
}
