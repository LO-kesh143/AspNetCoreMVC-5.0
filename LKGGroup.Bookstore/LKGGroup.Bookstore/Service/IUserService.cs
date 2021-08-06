using LKGGroup.Bookstore.Models;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace LKGGroup.Bookstore.Service
{
    public interface IUserService
    {
        string GetUserId();
        bool IsAuthenticated();
    }
}