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
            TradeFinanceService.ProxyCreditGuaranteeInquiry p = new TradeFinanceService.ProxyCreditGuaranteeInquiry();
            p.ADBAmountCovered = 200;
            p.ApplicantName = "Vdydab";
            p.BeneficiaryName = "duduy";
            p.ConfirmingBankNameIDString = "403646c1-7b7c-e511-80fb-3863bb2e7cd8";
            p.ConfirmingBankNameID = "403646c1-7b7c-e511-80fb-3863bb2e7cd8";
            p.IssuingBankNameIDString = "d721b05c-3027-e511-80e3-3863bb2e7c20";
            p.IssuingBankNameID = "d721b05c-3027-e511-80e3-3863bb2e7c20";
            p.Goods = "okay";
            p.IssuingBankName = "East west";
            p.InquiryReferenceNo = "ST-12383";
            p.Tenor = "voice";
            p.TotalTransactionValue = 432423;
            p.TotalTransactionValueSpecified = true;
            p.TypeOfTradeTransactionID = 100000003;
            p.TypeOfTradeTransactionIDSpecified = true;

            TradeFinanceService.TradeFinanceService service = new TradeFinanceService.TradeFinanceService();
            try
            {
                service.AddTradeFinance(p);
            
            }
            catch
            {

            }
            //Console.ReadLine();

        }
    }
}
