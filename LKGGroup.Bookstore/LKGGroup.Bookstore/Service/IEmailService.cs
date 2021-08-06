using LKGGroup.Bookstore.Models;
using System.Threading.Tasks;

namespace LKGGroup.Bookstore.Service
{
    public interface IEmailService
    {
        Task SendTestEmail(UserEmailOptions userEmailOptions);
    }
}