using CrmConsoleClient.OpportunityService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmConsoleClient
{
    public class OpportunityExecutor
    {
        public void GetOpportunity()
        {
            OpportunityService.OpportunityService service = new OpportunityService.OpportunityService();
            var result1 = service.GetAllOpportunity().Where(x => x.Name.Contains("Shapoorji")).FirstOrDefault();
            try
            {
                
                var result = service.GetOneOpportunity("573b99ed-bf50-e511-80ee-3863bb2eb8d8");
                
                Console.WriteLine(string.Format("Project Name : {0}", result.Name));
                Console.WriteLine(string.Format("Region : {0}", result.Region));
                Console.WriteLine(string.Format("Sector : {0}", result.Sector));
                Console.WriteLine(string.Format("Sub Sector : {0}", result.SubSector));
                Console.WriteLine(string.Format("Country : {0}", result.Country));
                Console.WriteLine(string.Format("Currency : {0}", result.Currency));
                Console.WriteLine(string.Format("Financing Cost : {0}", result.BudgetAmount));
                Console.WriteLine(string.Format("Approval Level : {0}", result.ApprovalLevel));
                Console.WriteLine(string.Format("Guarantee : {0}", result.Guarantee));
                Console.WriteLine(string.Format("Borrower : {0}", result.Borrower));
                Console.WriteLine(string.Format("Category Type : {0}", result.CategoryType));
                Console.WriteLine(string.Format("Model of Financial Ass : {0}", result.ModeOfFinancialAssistance));
                Console.WriteLine(string.Format("Processing Category : {0}", result.ProcessingCategory));
                Console.WriteLine(string.Format("Processing Scenario : {0}", result.processingScenario));
                Console.WriteLine(string.Format("Expected Approval Year : {0}", result.ExpectedApprovalYear));
                Console.WriteLine(string.Format("Additional Financing : {0}", result.AdditionalFinancing));
                Console.WriteLine(string.Format("Project Stage : {0}", result.ProjectStage));
                Console.WriteLine(string.Format("Project Status : {0}", result.ProjectStatus));
                Console.WriteLine("==============================");
                Console.WriteLine(string.Format("Division : {0}", result.Division));
                Console.WriteLine(string.Format("Division Role : {0}", result.DivisionRole));

                /*
                var result = service.GetAllOpportunity();

                foreach (var r in result)
                {
                    Console.WriteLine(string.Format("Project Name : {0}", r.Name));
                    Console.WriteLine(string.Format("Region : {0}", r.Region));
                    Console.WriteLine(string.Format("Sector : {0}", r.Sector));
                    Console.WriteLine(string.Format("Sub Sector : {0}", r.SubSector));
                    Console.WriteLine(string.Format("Country : {0}", r.Country));
                    Console.WriteLine(string.Format("Currency : {0}", r.Currency));
                    Console.WriteLine(string.Format("Financing Cost : {0}", r.BudgetAmount));
                    Console.WriteLine(string.Format("Approval Level : {0}", r.ApprovalLevel));
                    Console.WriteLine(string.Format("Guarantee : {0}", r.Guarantee));
                    Console.WriteLine(string.Format("Borrower : {0}", r.Borrower));
                    Console.WriteLine(string.Format("Category Type : {0}", r.CategoryType));
                    Console.WriteLine(string.Format("Model of Financial Ass : {0}", r.ModeOfFinancialAssistance));
                    Console.WriteLine(string.Format("Processing Category : {0}", r.ProcessingCategory));
                    Console.WriteLine(string.Format("Processing Scenario : {0}", r.processingScenario));
                    Console.WriteLine(string.Format("Expected Approval Year : {0}", r.ExpectedApprovalYear));
                    Console.WriteLine(string.Format("Additional Financing : {0}", r.AdditionalFinancing));
                    Console.WriteLine(string.Format("Project Stage : {0}", r.ProjectStage));
                    Console.WriteLine(string.Format("Project Status : {0}", r.ProjectStatus));
                    Console.WriteLine("==============================");
                    Console.WriteLine(string.Format("Division : {0}", r.Division));
                    Console.WriteLine(string.Format("Division Role : {0}", r.DivisionRole));
                }
                */



                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadLine();
            }
        }
    }
}
