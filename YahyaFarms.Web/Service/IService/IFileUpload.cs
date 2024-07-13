using Microsoft.AspNetCore.Components.Forms;

namespace YahyaFarms.Web.Service.IService
{
    public interface IFileUpload
    {
        Task<string> UploadFile(IBrowserFile browserFile);
        bool DeleteFile(string fileName);
    }
}
