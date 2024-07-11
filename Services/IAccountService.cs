using System;
using System.Collections.Generic;
using BusinessObjects;

namespace Services
{
    public interface IAccountService
    {
        AccountMember? GetAccountById(string accountId);
    }
}
