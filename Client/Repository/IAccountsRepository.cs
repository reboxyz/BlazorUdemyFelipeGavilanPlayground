using System.Threading.Tasks;
using BlazorMovies.Shared.DTO;

namespace BlazorMovies.Client.Repository
{
    public interface IAccountsRepository
    {
        Task<UserToken> Register(UserInfo userInfo);
        Task<UserToken> Login(UserInfo userInfo);
    }
}