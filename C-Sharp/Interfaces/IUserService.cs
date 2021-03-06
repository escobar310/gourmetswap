using GSwap.Models;
using GSwap.Models.Domain;
using GSwap.Models.Domain.Users;
using GSwap.Models.Requests.Email;
using GSwap.Models.Requests.Users;
using GSwap.Models.Domain.Cooks;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace GSwap.Services
{
    public interface IUserService
    {       
        int Create(UserAddRequest userModel, string role);
        void SetNewPassword(ResetRequest request,int userId);
        bool LogIn(string email, string password);
        string GetCookie();
        UserInfo GetUser(int id);
        PagedList<User> GetPaginatedUsers(PagedUsersRequest request);
        void ChangeUserDisableStatus(UpdateDisableStatusRequest model);
        
        

    }
}
