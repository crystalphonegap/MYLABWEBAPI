using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace myLabWebApi.Utility
{
    public static class FileUtilityService
    {
        public static async Task<string> UploadedSitePhotoFiles(IFormFile File, string FileUniqueName, string ChildLocationFolder, string LocationFolder )
        {
            var fileName = "";
            var file = File;
            string folderName = "UploadedFiles";
            if (!string.IsNullOrEmpty(LocationFolder))
            {
                folderName = Path.Combine(folderName, LocationFolder);
            } 
            folderName = Path.Combine(folderName, ChildLocationFolder);
            string pathToSave = Path.Combine(Directory.GetCurrentDirectory(), folderName);
            if (file.Length > 0)
            {
                var fileName1 = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
                fileName = FileUniqueName + "_" + DateTime.Now.Ticks + fileName1;
                var fullPath = Path.Combine(pathToSave, fileName);
                var dbPath = Path.Combine(folderName, fileName);
                using (var stream = new FileStream(fullPath, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }
                //return Ok(new { dbPath });
            };
            return fileName;
        }

        
    }
}
