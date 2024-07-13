using Microsoft.AspNetCore.Components.Forms;
using YahyaFarms.Web.Service.IService;

namespace YahyaFarms.Web.Service
{
    public class FileUpload : IFileUpload
    {
        private readonly IWebHostEnvironment webHostEnvironment;

        public FileUpload(IWebHostEnvironment webHostEnvironment)
        {
            this.webHostEnvironment = webHostEnvironment;
        }
        public bool DeleteFile(string fileName)
        {
            try
            {
                string fileFullPath = Path.Combine(webHostEnvironment.WebRootPath, "ItemsImages", fileName);
                if (File.Exists(fileFullPath))
                {
                    File.Delete(fileFullPath);
                    return true;
                }
                return false;
            }
            catch
            {
                throw;
            }
        }

        public async Task<string> UploadFile(IBrowserFile browserFile)
        {
            try
            {
                FileInfo fileInfo = new(browserFile.Name);
                string fileName = $"{Guid.NewGuid()}{fileInfo.Extension}";
                string fileDirectory = $"{webHostEnvironment.WebRootPath}\\ItemsImages";
                string filePath = Path.Combine(fileDirectory, fileName);
                MemoryStream msFile = new();
                await browserFile.OpenReadStream(3*1024*1024).CopyToAsync(msFile);
                if (!Directory.Exists(fileDirectory))
                    Directory.CreateDirectory(fileDirectory);
                await using (FileStream fs = new(filePath, FileMode.Create, FileAccess.Write))
                {
                    msFile.WriteTo(fs);
                }
                return $"ItemsImages/{fileName}";
            }
            catch
            {
                throw;
            }
        }
    }
}
