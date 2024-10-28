using BusinessObjects;
using DataAccessLayer;

namespace Repositories
{
    public class AccountRepository : IAccountMemberRepository
    {
        public AccountMember? GetAccountMemberById(string memberid)
        {
            return AccountMemberDAO.Instance.GetAccountById(memberid);
        }
    }
}
