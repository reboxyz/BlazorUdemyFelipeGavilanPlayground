using System.Threading.Tasks;

namespace BlazorMovies.Server.Helpers
{
    public interface IFileStorageService
    {
        // Note! 'container' in Azure Storage is like a category or folder names
        Task<string> EditFile(byte[] content, string extension, string containerName, string fileRoute);
        Task DeleteFile(string fileRoute, string containerName);
        Task<string> SaveFile(byte[] content, string extension, string containerName);
    }
}