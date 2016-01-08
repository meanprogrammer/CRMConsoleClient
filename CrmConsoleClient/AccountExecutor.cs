using CrmConsoleClient.AccountService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmConsoleClient
{
    public class AccountExecutor
    {
        public void GetAllAccounts()
        {
            AccountService.AccountService service = new AccountService.AccountService();
            var all = service.GetAllAccounts();

            foreach (ProxyAccount a in all)
            {
                if (a.ParentID == "573b99ed-bf50-e511-80ee-3863bb2eb8d8")
                {
                    Console.WriteLine(string.Format("{0} - {1}", a.AccountName, a.EntityRole));

                }
            }

            Console.ReadLine();
        }
    }
}
