using ClosedXML.Excel;
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
                StringBuilder builder = new StringBuilder();

                var workbook = new XLWorkbook();
                var worksheet = workbook.Worksheets.Add("Sheet1");
                worksheet.Cell("A1").Value = "Project Description";
                worksheet.Cell("B1").Value = result1.ProjectDescription;

                worksheet.Cell("A2").Value = "Project Rational";
                worksheet.Cell("B2").Value = result1.ProjectRationale;

                worksheet.Cell("A3").Value = "Category Type";
                worksheet.Cell("B3").Value = result1.CategoryType;

                worksheet.Cell("A4").Value = "Project No";
                worksheet.Cell("B4").Value = result1.ProjectNo;

                worksheet.Cell("A5").Value = "Project Name";
                worksheet.Cell("B5").Value = result1.Name;

                worksheet.Cell("A6").Value = "Region";
                worksheet.Cell("B6").Value = result1.Region;

                worksheet.Cell("A7").Value = "Sector";
                worksheet.Cell("B7").Value = result1.Sector;

                worksheet.Cell("A7").Value = "Sub Sector";
                worksheet.Cell("B7").Value = result1.SubSector;

                worksheet.Cell("A8").Value = "Country";
                worksheet.Cell("B8").Value = result1.Country;

                worksheet.Cell("A9").Value = "Currency";
                worksheet.Cell("B9").Value = result1.Currency;

                worksheet.Cell("A10").Value = "Financing Cost";
                worksheet.Cell("B10").Value = result1.BudgetAmount;

                worksheet.Cell("A11").Value = "Approval Level";
                worksheet.Cell("B11").Value = result1.ApprovalLevel;

                worksheet.Cell("A12").Value = "NS Project Type";
                worksheet.Cell("B12").Value = result1.NSProjectType;

                worksheet.Cell("A13").Value = "NS Core Sector";
                worksheet.Cell("B13").Value = result1.NSCoreSector;

                worksheet.Cell("A14").Value = "NSO Processing Category";
                worksheet.Cell("B14").Value = result1.NSOProcessingCategory;

                worksheet.Cell("A15").Value = "Project Stage";
                worksheet.Cell("B15").Value = result1.ProjectStage;

                worksheet.Cell("A16").Value = "Project Status";
                worksheet.Cell("B16").Value = result1.ProjectStatus;

                worksheet.Cell("A17").Value = "Task Status";
                worksheet.Cell("B17").Value = result1.TaskStatus;

                worksheet.Cell("A18").Value = "Division";
                worksheet.Cell("B18").Value = result1.Division;

                worksheet.Cell("A19").Value = "Division Role";
                worksheet.Cell("B19").Value = result1.DivisionRole;


                worksheet.Cell("A21").Value = "Project Team";

                worksheet.Cell("A22").Value = "Name";
                worksheet.Cell("B22").Value = "Role";

                ProjectTeamExecutor pte = new ProjectTeamExecutor();
                var team = pte.GetAllTeamMembers(result1.OpportunityId);
                int ctr = 22;
                for (int i = 0; i < team.Count; i++)
                {
                    worksheet.Cell(string.Format("A{0}",22+i+1)).Value = team[i].Name;
                    worksheet.Cell(string.Format("B{0}",22+i+1)).Value = team[i].Role;
                    ctr++;
                }

                ctr++;
                ctr++;

                worksheet.Cell(string.Format("A{0}", ctr)).Value = "Obligors";
                ctr++;
                worksheet.Cell("A"+ctr).Value = "Entity Role";
                worksheet.Cell("B"+ctr).Value = "Account Name";
                worksheet.Cell("C"+ctr).Value = "Involvement in Project";

                workbook.SaveAs("Shapoorji.xlsx");

                //builder.AppendLine(string.Format("Project Description : {0}", result1.ProjectDescription));
                //builder.AppendLine(string.Format("Project Rationale : {0}", result1.ProjectRationale));
                
                //builder.AppendLine(string.Format("Category Type : {0}", result1.CategoryType));
                //builder.AppendLine(string.Format("Project No : {0}", result1.ProjectNo));
                //builder.AppendLine(string.Format("Project Name : {0}", result1.Name));
                //builder.AppendLine(string.Format("Region : {0}", result1.Region));
                //builder.AppendLine(string.Format("Sector : {0}", result1.Sector));
                //builder.AppendLine(string.Format("Sub Sector : {0}", result1.SubSector));
                //builder.AppendLine(string.Format("Country : {0}", result1.Country));
                //builder.AppendLine(string.Format("Currency : {0}", result1.Currency));
                //builder.AppendLine(string.Format("Financing Cost : {0}", result1.BudgetAmount));
                //builder.AppendLine(string.Format("Approval Level : {0}", result1.ApprovalLevel));
                //builder.AppendLine(string.Format("NS Project Type : {0}", result1.NSProjectType));
                //builder.AppendLine(string.Format("NS Core Sector : {0}", result1.NSCoreSector));
                //builder.AppendLine(string.Format("NSO Processing Category : {0}", result1.NSOProcessingCategory));
                //builder.AppendLine(string.Format("Project Stage : {0}", result1.ProjectStage));
                //builder.AppendLine(string.Format("Project Status : {0}", result1.ProjectStatus));
                //builder.AppendLine(string.Format("Task Status : {0}", result1.TaskStatus));
                //builder.AppendLine("==============================");
                //builder.AppendLine(string.Format("Division : {0}", result1.Division));
                //builder.AppendLine(string.Format("Division Role : {0}", result1.DivisionRole));


                builder.AppendLine(string.Format("Guarantee : {0}", result1.Guarantee));
                builder.AppendLine(string.Format("Borrower : {0}", result1.Borrower));
                
                builder.AppendLine(string.Format("Model of Financial Ass : {0}", result1.ModeOfFinancialAssistance));
                builder.AppendLine(string.Format("Processing Category : {0}", result1.ProcessingCategory));
                builder.AppendLine(string.Format("Processing Scenario : {0}", result1.processingScenario));
                builder.AppendLine(string.Format("Expected Approval Year : {0}", result1.ExpectedApprovalYear));
                builder.AppendLine(string.Format("Additional Financing : {0}", result1.AdditionalFinancing));


                /*
                 builder.AppendLine(string.Format("Project Description : {0}", result1.ProjectDescription));
                builder.AppendLine(string.Format("Project Rationale : {0}", result1.ProjectRationale));
                
                builder.AppendLine(string.Format("Category Type : {0}", result1.CategoryType));
                builder.AppendLine(string.Format("Project No : {0}", result1.ProjectNo));
                builder.AppendLine(string.Format("Project Name : {0}", result1.Name));
                builder.AppendLine(string.Format("Region : {0}", result1.Region));
                builder.AppendLine(string.Format("Sector : {0}", result1.Sector));
                builder.AppendLine(string.Format("Sub Sector : {0}", result1.SubSector));
                builder.AppendLine(string.Format("Country : {0}", result1.Country));
                builder.AppendLine(string.Format("Currency : {0}", result1.Currency));
                builder.AppendLine(string.Format("Financing Cost : {0}", result1.BudgetAmount));
                builder.AppendLine(string.Format("Approval Level : {0}", result1.ApprovalLevel));
                builder.AppendLine(string.Format("NS Project Type : {0}", result1.NSProjectType));
                builder.AppendLine(string.Format("NS Core Sector : {0}", result1.NSCoreSector));
                builder.AppendLine(string.Format("NSO Processing Category : {0}", result1.NSOProcessingCategory));
                builder.AppendLine(string.Format("Project Stage : {0}", result1.ProjectStage));
                builder.AppendLine(string.Format("Project Status : {0}", result1.ProjectStatus));
                builder.AppendLine(string.Format("Task Status : {0}", result1.TaskStatus));
                builder.AppendLine("==============================");
                builder.AppendLine(string.Format("Division : {0}", result1.Division));
                builder.AppendLine(string.Format("Division Role : {0}", result1.DivisionRole));


                builder.AppendLine(string.Format("Guarantee : {0}", result1.Guarantee));
                builder.AppendLine(string.Format("Borrower : {0}", result1.Borrower));
                
                builder.AppendLine(string.Format("Model of Financial Ass : {0}", result1.ModeOfFinancialAssistance));
                builder.AppendLine(string.Format("Processing Category : {0}", result1.ProcessingCategory));
                builder.AppendLine(string.Format("Processing Scenario : {0}", result1.processingScenario));
                builder.AppendLine(string.Format("Expected Approval Year : {0}", result1.ExpectedApprovalYear));
                builder.AppendLine(string.Format("Additional Financing : {0}", result1.AdditionalFinancing));
                
                 */

                /*
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
                */

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


                Console.WriteLine("Complete");
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
