using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmConsoleClient
{
    public class TradeFinanceServiceExecutor
    {
        public void GetAllCreditGuaranteeRequest()
        {
            TradeFinanceService.TradeFinanceService service = new TradeFinanceService.TradeFinanceService();
            try
            {
                var all = service.GetAllTradeFinanace();
            }
            catch
            {

            }
            Console.ReadLine();
        }
    }
}
