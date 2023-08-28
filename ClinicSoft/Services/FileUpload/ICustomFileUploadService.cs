using ClinicSoft.ViewModel.Files;
using Microsoft.AspNetCore.Http;
using System.Data.SqlClient;

namespace ClinicSoft.Services.FileUpload
{
    public interface ICustomFileUploadService
    {
        Task<FileModel> UploadFileAsync(string UploadFileName, string mimeType = "text/plain");
        Task<FileModel> UploadFileByIdAsync(string fileId, string newFileName, string mimeType = "text/plain");

    }
}
