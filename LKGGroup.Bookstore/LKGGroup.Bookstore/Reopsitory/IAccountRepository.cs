using LKGGroup.Bookstore.Models;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace LKGGroup.Bookstore.Reopsitory
{
    public interface IAccountRepository
    {
        Task<IdentityResult> CreateUserAsync(SignUpUserModel userModel);

        Task<SignInResult> PasswordSignInAsync(SignInModel signInModel);

        Task SignOutAsync();

        Task<IdentityResult> ChangePasswordAsync(ChangePasswordModel model);
    }
}