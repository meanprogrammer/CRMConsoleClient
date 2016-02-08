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

        public void AddSomething()
        {
            TradeFinanceService.ProxyCreditGuaranteeRequest p = new TradeFinanceService.ProxyCreditGuaranteeRequest();
            p.ADBAmountCovered = 200;
            p.ApplicantName = "Vdydab";
            p.BeneficiaryName = "duduy";
            p.ConfirmingBankName = "BeefyEye";
            p.Goods = "okay";
            p.IssuingBankName = "East west";
            p.RequestNo = "ST-12383";
            p.Tenor = "voice";
            p.TotalTransactionValue = 2;
            p.TypeOfTradeTransactionID = 100000003;

            TradeFinanceService.TradeFinanceService service = new TradeFinanceService.TradeFinanceService();
            try
            {
                service.AddTradeFinance(p);
            }
            catch
            {

            }
            Console.ReadLine();

        }
    }
}
