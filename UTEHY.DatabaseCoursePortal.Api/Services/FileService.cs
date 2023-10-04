namespace UTEHY.DatabaseCoursePortal.Api.Services
{
    public class FileService
    {
        private readonly IWebHostEnvironment _webHostEnvironment;

        public FileService(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }

        public async Task<string> SaveFileAsync(Stream fileStream, string fileName)
        {
            try
            {
                var filePath = Path.Combine(_webHostEnvironment.ContentRootPath, "uploads", fileName);

                using (var fileStreamOut = new FileStream(filePath, FileMode.Create))
                {
                    await fileStream.CopyToAsync(fileStreamOut);
                }

                return filePath;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Stream> GetFileAsync(string fileName)
        {
            try
            {
                var filePath = Path.Combine(_webHostEnvironment.ContentRootPath, "uploads", fileName);

                if (File.Exists(filePath))
                {
                    var fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                    return fileStream;
                }

                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<bool> DeleteFileAsync(string fileName)
        {
            try
            {
                var filePath = Path.Combine(_webHostEnvironment.ContentRootPath, "uploads", fileName);

                if (File.Exists(filePath))
                {
                    File.Delete(filePath);
                    return true;
                }

                return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
