using BusinessObjects;

namespace Repositories
{
    public interface IAccountMemberRepository
    {
        AccountMember? GetAccountMemberById(string memberid);
    }
}
