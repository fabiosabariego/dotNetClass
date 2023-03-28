using Microsoft.AspNetCore.StaticFiles;

namespace BlazorFileUpload.Services
{
    public interface IFileDownload
    {
        Task<List<String>> GetUploadFiles();
    }

    public class FileDownload : IFileDownload
    {
        private IWebHostEnvironment _webHostEnvironment;

        public async Task<List<string>> GetUploadFiles()
        {
            var base64Urls = new List<string>();
            var uploadPath = Path.Combine(_webHostEnvironment.WebRootPath, "uploads");
            var files = Directory.GetFiles(uploadPath);

            if(files is not null && files.Length > 0)
            {
                foreach (var file in files)
                {
                    using(var fileInput = new FileStream(file, FileMode.Open, FileAccess.Read))
                    {
                        var memoryStream = new MemoryStream();
                        await fileInput.CopyToAsync(memoryStream);
                        var buffer = memoryStream.ToArray();
                        var fileType = GetMimeTypeForFileExtension(file);
                        base64Urls.Add($"data:{fileType}; base64,{Convert.ToBase64String(buffer)}");
                    }
                }
            }

            return base64Urls;
        }

        private string GetMimeTypeForFileExtension(string filePath)
        {
            const string DefaultContentType = "application/octet-stream";
            var provider = new FileExtensionContentTypeProvider();
            if(!provider.TryGetContentType(filePath, out string contentType))
            {
                contentType = DefaultContentType;
            }
            return contentType;
        }
    }
}
