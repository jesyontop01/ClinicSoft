using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v3;
using Google.Apis.Drive.v3.Data;
using Google.Apis.Services;
using Google.Apis.Upload;
using ClinicSoft.Core.Configuration;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using ClinicSoft.Services.FileUpload;
using System.Data.SqlClient;
using ClinicSoft.ViewModel.Files;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;
//using Microsoft.AspNetCore.Http.Internal;

namespace ClinicSoft.Services
{
    public class FileUploadService : ICustomFileUploadService
    {
        private readonly IWebHostEnvironment _environment;

        public FileUploadService(IWebHostEnvironment environment)
        {
            _environment = environment;

        }
        public async Task<FileModel> UploadFileAsync(string fileName, string mimeType = "text/plain")
        {
            if (!string.IsNullOrEmpty(fileName))
            {
                try
                {
                    // Create an empty IFormFile instance
                    IFormFile file = new FormFile(null, 0, 0, fileName, fileName);

                    // Define the path to save the file
                    string uploadsPath = Path.Combine(_environment.WebRootPath, "uploads");

                    // Create the directory if it doesn't exist
                    if (!Directory.Exists(uploadsPath))
                    {
                        Directory.CreateDirectory(uploadsPath);
                    }

                    string filePath = Path.Combine(uploadsPath, fileName);

                    // Save the file to the specified path
                    using (var outputStream = new FileStream(filePath, FileMode.Create))
                    {
                        await file.CopyToAsync(outputStream);
                    }

                    // Create and return the FileModel instance
                    var fileModel = new FileModel
                    {
                        FileName = fileName,
                        FilePath = filePath
                    };
                    return fileModel;
                }
                catch (Exception ex)
                {
                    // Handle the exception or log it
                    throw ex;
                }
            }

            return null;
        }

        public Task<FileModel> UploadFileByIdAsync(string fileId, string newFileName, string mimeType = "text/plain")
        {
            throw new NotImplementedException();
        }
    }
}
