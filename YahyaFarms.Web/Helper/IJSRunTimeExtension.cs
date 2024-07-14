using Microsoft.JSInterop;

namespace YahyaFarms.Web.Helper
{
    public static class IJSRunTimeExtension
    {
        public static async Task ToastrSuccess(this IJSRuntime JSRuntime, string Message)
        {
            await JSRuntime.InvokeVoidAsync("ShowToastr", "success", Message);
        }
        public static async Task ToastrError(this IJSRuntime JSRuntime, string Message)
        {
            await JSRuntime.InvokeVoidAsync("ShowToastr", "error", Message);
        }
        public static async Task<bool> ConfirmDelete(this IJSRuntime JSRuntime)
        {
            return await JSRuntime.InvokeAsync<bool>("SwalConfirm");
        }
    }
}
