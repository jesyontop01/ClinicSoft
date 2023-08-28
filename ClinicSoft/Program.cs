using ClinicSoft.Core.Configuration;
using ClinicSoft.Services.Dispensary;
using ClinicSoft.Services.DispensaryTransfer;
using ClinicSoft.Services.FileUpload;
using ClinicSoft.Services.LIS;
using ClinicSoft.Services.Maternity;
using ClinicSoft.Services.Pharmacy.PharmacyPO;
using ClinicSoft.Services.Pharmacy.Rack;
using ClinicSoft.Services.Pharmacy.SupplierLedger;
using ClinicSoft.Services.QueueManagement;
using ClinicSoft.Services.Vaccination;
using ClinicSoft.Services;
using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Data.SqlClient;
using ClinicSoft.DalLayer;
using ClinicSoft.Core.Caching;
using ClinicSoft.Security;
using Microsoft.AspNetCore.Mvc.Razor;
using ClinicSoft.DalLayer.Models;

var builder = WebApplication.CreateBuilder(args);
// Load configuration from your appsettings.json or other configuration sources
builder.Configuration.AddJsonFile("appsettings.json");

builder.Services.Configure<MyConfiguration>(builder.Configuration.GetSection("MyConfiguration"));
//string connString = builder.Configuration["Connectionstring"];
var connStringss = builder.Configuration.GetSection("MyConfiguration");

builder.Services.AddSingleton(connStringss);

int cacheExpMins = Convert.ToInt32(builder.Configuration["CacheExpirationMinutes"]);
builder.Services.AddDbContext<RbacDbContext>(options => options.UseSqlServer(connStringss.ToString()));
builder.Services.AddDbContext<ClinicSoftContext>(options =>
                            options.UseSqlServer(builder.Configuration.GetConnectionString("" +
                            "DefaultConnection")));
builder.Services.AddDbContext<SystemAdminDbContext>(options =>
                            options.UseSqlServer(builder.Configuration.GetConnectionString("" +
                            "ConnectionStringAdmin")));
//add cache as singleton since there should be one global object of it.. ConnectionStringAdmin
builder.Services.AddSingleton<DanpheCache>(new DanpheCache(connStringss.ToString(), cacheExpMins));
builder.Services.AddSingleton<RBAC>(new RBAC(connStringss.ToString(), cacheExpMins));
// Add services to the container.
builder.Services.AddControllersWithViews();
//builder.Services.AddDbContext<HotelAppContext>(options =>
//                            options.UseSqlServer(builder.Configuration.GetConnectionString("" +
//                            "DefaultConnection")));
builder.Services.AddTransient<IRackService, RackService>();
builder.Services.AddTransient<IInventoryCompanyService, InventoryCompanyService>();
builder.Services.AddTransient<IDesignationService, DesignationService>();
builder.Services.AddTransient<IInventoryReceiptNumberService, InventoryReceiptNumberService>();
builder.Services.AddTransient<IInventoryGoodReceiptService, InventoryGoodReceiptService>();
builder.Services.AddTransient<IEmailService, EmailService>();
builder.Services.AddTransient<IFractionPercentService, FractionPercentService>();
builder.Services.AddTransient<IFractionCalculationService, FractionCalculationService>();
builder.Services.AddTransient<IVerificationService, VerificationService>();
builder.Services.AddTransient<IDispensaryService, DispensaryService>();
builder.Services.AddTransient<IDispensaryRequisitionService, DispensaryRequisitionService>();
builder.Services.AddTransient<IMaternityService, MaternityService>();
builder.Services.AddTransient<IDispensaryTransferService, DispensaryTransferService>();
builder.Services.AddTransient<IActivateInventoryService, ActivateInventoryService>();
builder.Services.AddTransient<IPharmacyPOService, PharmacyPOService>();
builder.Services.AddTransient<IVaccinationService, VaccinationService>();
builder.Services.AddTransient<ICssdItemService, CssdItemService>();
builder.Services.AddTransient<ICssdReportService, CssdReportService>();
builder.Services.AddTransient<INepaliReceiptService, NepaliReceiptService>();
builder.Services.AddTransient<ISupplierLedgerService, SupplierLedgerService>();
////builder.Services.AddTransient<IFileUploadService, GoogleDriveFileUploadService>();
builder.Services.AddTransient<ICustomFileUploadService, FileUploadService>();
builder.Services.AddTransient<ILISService, LISService>();
builder.Services.AddTransient<IQueueManagementService, QueueManagementService>();


//builder.Services.Configure((RazorViewEngineOptions options) =>
//{
//    var previous = options.CompilationCallback;
//    options.CompilationCallback = (context) =>
//    {
//        previous?.Invoke(context);

//        context.Compilation = context.Compilation.
//                    AddReferences(MetadataReference.CreateFromFile(typeof(
//                     MasterDbContext).Assembly.Location));

//        context.Compilation = context.Compilation.
//                   AddReferences(MetadataReference.CreateFromFile(typeof(
//                   CountryModel).Assembly.Location));
//        context.Compilation = context.Compilation.
//                   AddReferences(MetadataReference.CreateFromFile(typeof(
//                   CountrySubDivisionModel).Assembly.Location));

//        context.Compilation = context.Compilation.
//                   AddReferences(MetadataReference.CreateFromFile(typeof(
//                   ICD10CodeModel).Assembly.Location));
//        context.Compilation = context.Compilation.
//                   AddReferences(MetadataReference.CreateFromFile(typeof(
//                   EmployeeModel).Assembly.Location));
//        context.Compilation = context.Compilation.
//                  AddReferences(MetadataReference.CreateFromFile(typeof(
//                  ServiceDepartmentModel).Assembly.Location));
//        context.Compilation = context.Compilation.
//                AddReferences(MetadataReference.CreateFromFile(typeof(LoginViewModel).Assembly.Location));
//        context.Compilation = context.Compilation.
//               AddReferences(MetadataReference.CreateFromFile(typeof(DanpheRoute).Assembly.Location));
//        context.Compilation = context.Compilation.
//             AddReferences(MetadataReference.CreateFromFile(typeof(DanpheCache).Assembly.Location));

//    };
//});

// Add framework builder.Services.
builder.Services.AddOptions();

//builder.Services.Configure<MyConfiguration>(Configuration);
builder.Services.AddSession(options =>
{
    //IMPORTANT-- remove the hardcoded value 20 from below
    //keep short timeout like max 2-3 hours, 
    //we've to redirect to login once the session expires.
    options.IdleTimeout = TimeSpan.FromHours(2);
    options.Cookie.HttpOnly = true;

});
// Get the connection string from the configuration
string connStrs = builder.Configuration["Connectionstring"];

// Register DbContext instances with their respective options
//builder.Services.AddDbContext<MasterDbContext>(options =>
//    options.UseSqlServer(connStrs));

//builder.Services.AddDbContext<AccountingDbContext>(options =>
//    options.UseSqlServer(connStrs));


//var myAppSettings = builder.Configuration.Get<MyConfiguration>();
//myAppSettings.Connectionstring = connStrs;
string connStr = builder.Configuration["Connectionstring"];
SqlConnectionStringBuilder connStringBuilder = new SqlConnectionStringBuilder(connStr);
//myAppSettings.Connectionstring = connStringBuilder.ConnectionString.ToString();
//string encPassword = connStringBuilder.Password;
//builder.Services.AddSingleton(myAppSettings.Connectionstring);
var app = builder.Build();
string contentRootPaths = app.Services.GetService<IWebHostEnvironment>().ContentRootPath;

var builders = new ConfigurationBuilder()
              .SetBasePath(contentRootPaths)
              .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
              .AddJsonFile($"appsettings.{app.Environment.EnvironmentName}.json", optional: true)
              .AddEnvironmentVariables();
// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    string contentRootPath = app.Services.GetService<IWebHostEnvironment>().ContentRootPath;

    var provider = new PhysicalFileProvider(
                            Path.Combine(contentRootPath, "wwwroot\\DanpheApp\\node_modules")
                        );
    var options = new FileServerOptions();
    options.RequestPath = "/node_modules";
    options.StaticFileOptions.FileProvider = provider;
    options.EnableDirectoryBrowsing = true;
    app.UseFileServer(options);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();
app.UseSession();
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "DefaultRoute",
        pattern: "{controller}/{action}",
        defaults: new { controller = "Account", action = "Login" }

    //defaults: new { controller = "Home", action = "Index" }
    );

    endpoints.MapControllerRoute(
        name: "Default",
        pattern: "{controller}/{action}",
        defaults: new { controller = "Account", action = "Login" }
    );
});

//app.MapControllerRoute(
//    name: "default",
//    pattern: "{controller=Home}/{action=Index}/{id?}");
app.UseFileServer();

// set a home page
DefaultFilesOptions defaultoptions = new DefaultFilesOptions();
defaultoptions.DefaultFileNames.Clear();
defaultoptions.DefaultFileNames.Add("UI/Main.html");
app.UseDefaultFiles(defaultoptions);
//app.UseMiddleware<>
app.UseStaticFiles();
app.Run();
