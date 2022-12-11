using AzureBlobStorageDemo.Models;
using System.IO;

namespace AzureBlobStorageDemo.Repositories
{
    public interface IBlobStorage
    {
        Task UploadFileAsync(FileDetails fileDetails);
    }
}
