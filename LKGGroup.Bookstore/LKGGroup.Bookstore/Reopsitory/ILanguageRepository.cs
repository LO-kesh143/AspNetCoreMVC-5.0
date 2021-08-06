using LKGGroup.Bookstore.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LKGGroup.Bookstore.Reopsitory
{
    public interface ILanguageRepository
    {
        Task<List<LanguageModel>> GetLanguages();
    }
}