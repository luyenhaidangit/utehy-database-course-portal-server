using Microsoft.AspNetCore.Mvc;

namespace UTEHY.DatabaseCoursePortal.Api.Services
{
    public class FileService
    {
        private readonly IWebHostEnvironment _webHostEnvironment;

        public FileService(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }

        public async Task<string> UploadFile(IFormFile? file, string folder)
        {
            string webRootPath = _webHostEnvironment.WebRootPath;
            string relativeFolderPath = folder;
            string uploadsFolder = Path.Combine(webRootPath, relativeFolderPath);

            if (!Directory.Exists(uploadsFolder))
            {
                Directory.CreateDirectory(uploadsFolder);
            }

            string uniqueFileName = Guid.NewGuid().ToString() + "_" + file.FileName;
            string filePath = Path.Combine(relativeFolderPath, uniqueFileName);

            using (var stream = new FileStream(Path.Combine(webRootPath, filePath), FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }

            string absoluteFilePath = Path.Combine(webRootPath, folder, uniqueFileName);
            string relativeFilePath = Path.GetRelativePath(webRootPath, absoluteFilePath);

            return "/" + relativeFilePath.Replace("\\", "/");
        }
    }
}
