using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class AccountMemberDAO
    {
        private static AccountMemberDAO instance = null;
        private static readonly object instanceLock = new object();
        public MyStoreDBContext _context;
        public static AccountMemberDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new AccountMemberDAO();
                    }
                    return instance;
                }
            }
        }

        public AccountMember? GetAccountById(string memberid)
        {
            _context = new MyStoreDBContext();
            return _context.AccountMember.FirstOrDefault(a => a.MemberID.Equals(memberid));
        }
    }
}
