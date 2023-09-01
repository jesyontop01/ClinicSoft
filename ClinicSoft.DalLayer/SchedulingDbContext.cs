﻿using System;
using System.Collections.Generic;
//using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClinicSoft.ServerModel.SchedulingModels;
using ClinicSoft.ServerModel;
using Microsoft.EntityFrameworkCore;

namespace ClinicSoft.DalLayer
{
    public class SchedulingDbContext : DbContext
    {
        private string connStr = null;
        public SchedulingDbContext(string conn)
        {
            connStr = conn;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder

                .UseSqlServer(connStr);


        }
        public DbSet<EmployeeModel> Employee { get; set; }
        public DbSet<EmpDayWiseAvailability> DayWiseAvailability { get; set; }
        public DbSet<EmployeeShifts> EmpShifts { get; set; }
        public DbSet<EmpSchedules> EmpSchedules { get; set; }
        public DbSet<ShiftsMasterModel> ShiftsMaster { get; set; }
        public DbSet<EmployeeShiftMap> EmpShiftMAP { get; set; }
        public DbSet<EmployeeRoleModel> EmpRole { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EmployeeModel>().ToTable("EMP_Employee");
            modelBuilder.Entity<EmpDayWiseAvailability>().ToTable("SCH_EmpDayWiseAvailability");
            modelBuilder.Entity<EmployeeShifts>().ToTable("SCH_EmployeeShifts");
            modelBuilder.Entity<EmpSchedules>().ToTable("SCH_EmployeeSchedules");
            modelBuilder.Entity<ShiftsMasterModel>().ToTable("SCH_MST_Shifts");
            modelBuilder.Entity<EmployeeShiftMap>().ToTable("SCH_MAP_EmployeeShift");
            modelBuilder.Entity<EmployeeRoleModel>().ToTable("EMP_EmployeeRole");
        }
    }
}