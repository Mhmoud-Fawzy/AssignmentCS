using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BLL.Common.Services.Attachments
{
    public class AttachmentService : IAttachmentService
    {
        private readonly List<string> _allowedExtensions = new() { ".png", ".jpg", ".jpeg" };  // To validate Extension of the File
        private const int _allowedSize = 2_097_152;                                            // To validate Size of the File

        public async Task<string?> UploadAsync(IFormFile file, string folderName)
        {
           var extension=Path.GetExtension(file.FileName);

            if(!_allowedExtensions.Contains(extension))
                return null;

            if (file.Length> _allowedSize)
                return null;

            // var folderPath = $"{Directory.GetCurrentDirectory}\\wwwroot\\files\\{folderName}";
            var folderPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\files", folderName);  // Folder Location(path) that have the file on it 

            if(!Directory.Exists(folderPath))
               Directory.CreateDirectory(folderPath);

            var fileName = $"{Guid.NewGuid()}{extension}";  // Create a name for the file Must be Unique

            var filePath=Path.Combine(folderPath, fileName);  // Final File Location Placed

            // Streaming: Data Per Time
            using var fileStream = new FileStream(filePath, FileMode.Create);
            await file.CopyToAsync(fileStream);

            return fileName;
        }


        public bool Delete(string filePath)
        {
            if (File.Exists(filePath))
            { 
                File.Delete(filePath); 
                return true;
            }
            return false;
        }

    }
}
