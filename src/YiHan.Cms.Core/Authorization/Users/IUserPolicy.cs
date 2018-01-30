using System.Threading.Tasks;
using Abp.Domain.Policies;

namespace YiHan.Cms.Authorization.Users
{
    public interface IUserPolicy : IPolicy
    {
        Task CheckMaxUserCountAsync(int tenantId);
    }
}
