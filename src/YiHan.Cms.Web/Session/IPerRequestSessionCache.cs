using System.Threading.Tasks;
using YiHan.Cms.Sessions.Dto;

namespace YiHan.Cms.Web.Session
{
    public interface IPerRequestSessionCache
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformationsAsync();
    }
}
