using BusinessObjects;
using DataAccessLayer;

namespace Repositories
{
    public class AccountRepository : IAccountRepository 
    {
        public AccountMember? GetAccountById(string accountId)
            => AccountDAO.GetAccountByID(accountId);
    }
}
