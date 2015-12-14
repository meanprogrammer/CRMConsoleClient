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
            Console.ReadLine();
        }
    }
}
