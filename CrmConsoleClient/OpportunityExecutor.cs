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
                var infoWorksheet = workbook.Worksheets.Add("Project Information");
                infoWorksheet.Cell("A1").Value = "Project Description";
                infoWorksheet.Cell("B1").Value = result1.ProjectDescription;
                
                infoWorksheet.Cell("A2").Value = "Project Rational";
                infoWorksheet.Cell("B2").Value = result1.ProjectRationale;

                infoWorksheet.Cell("A3").Value = "Category Type";
                infoWorksheet.Cell("B3").Value = result1.CategoryType;

                infoWorksheet.Cell("A4").Value = "Project No";
                infoWorksheet.Cell("B4").Value = result1.ProjectNo;

                infoWorksheet.Cell("A5").Value = "Project Name";
                infoWorksheet.Cell("B5").Value = result1.Name;

                infoWorksheet.Cell("A6").Value = "Region";
                infoWorksheet.Cell("B6").Value = result1.Region;

                infoWorksheet.Cell("A7").Value = "Sector";
                infoWorksheet.Cell("B7").Value = result1.Sector;

                infoWorksheet.Cell("A7").Value = "Sub Sector";
                infoWorksheet.Cell("B7").Value = result1.SubSector;

                infoWorksheet.Cell("A8").Value = "Country";
                infoWorksheet.Cell("B8").Value = result1.Country;

                infoWorksheet.Cell("A9").Value = "Currency";
                infoWorksheet.Cell("B9").Value = result1.Currency;

                infoWorksheet.Cell("A10").Value = "Financing Cost";
                infoWorksheet.Cell("B10").Value = result1.BudgetAmount;

                infoWorksheet.Cell("A11").Value = "Approval Level";
                infoWorksheet.Cell("B11").Value = result1.ApprovalLevel;

                infoWorksheet.Cell("A12").Value = "NS Project Type";
                infoWorksheet.Cell("B12").Value = result1.NSProjectType;

                infoWorksheet.Cell("A13").Value = "NS Core Sector";
                infoWorksheet.Cell("B13").Value = result1.NSCoreSector;

                infoWorksheet.Cell("A14").Value = "NSO Processing Category";
                infoWorksheet.Cell("B14").Value = result1.NSOProcessingCategory;

                infoWorksheet.Cell("A15").Value = "Project Stage";
                infoWorksheet.Cell("B15").Value = result1.ProjectStage;

                infoWorksheet.Cell("A16").Value = "Project Status";
                infoWorksheet.Cell("B16").Value = result1.ProjectStatus;

                infoWorksheet.Cell("A17").Value = "Task Status";
                infoWorksheet.Cell("B17").Value = result1.TaskStatus;

                infoWorksheet.Cell("A18").Value = "Division";
                infoWorksheet.Cell("B18").Value = result1.Division;

                infoWorksheet.Cell("A19").Value = "Division Role";
                infoWorksheet.Cell("B19").Value = result1.DivisionRole;


                infoWorksheet.Cell("A21").Value = "Milestones";

                infoWorksheet.Cell("A22").Value = "PRF Approval";
                infoWorksheet.Cell("B22").Value = result1.PRFApproval;

                infoWorksheet.Cell("A23").Value = "CRP ICM";
                infoWorksheet.Cell("B23").Value = result1.CRPICM;
                
                infoWorksheet.Cell("A24").Value = "Letter of No-Objection";
                infoWorksheet.Cell("B24").Value = result1.LetterOfNoObjection;
    
                infoWorksheet.Cell("A25").Value = "Final Review ICM";
                infoWorksheet.Cell("B25").Value = result1.FinalReviewICM;
        
                infoWorksheet.Cell("A26").Value = "RRP Approval";
                infoWorksheet.Cell("B26").Value = result1.RRPApproval;

                infoWorksheet.Cell("A27").Value = "Signing Date";
                infoWorksheet.Cell("B27").Value = result1.SigningDate;

                infoWorksheet.Cell("A28").Value = "Effectiveness Date";
                infoWorksheet.Cell("B28").Value = result1.EffectivenessDate;
            
                infoWorksheet.Cell("A29").Value = "XARR Date";
                infoWorksheet.Cell("B29").Value = result1.XARRDate;

                infoWorksheet.Cell("A30").Value = "Project End Date";
                infoWorksheet.Cell("B30").Value = result1.ProjectEndDate;                    
                                        
                                            
                                                

                var teamWorksheet = workbook.Worksheets.Add("Project Team");

                teamWorksheet.Cell("A1").Value = "Project Team";

                teamWorksheet.Cell("A2").Value = "Name";
                teamWorksheet.Cell("B2").Value = "Role";

                ProjectTeamExecutor pte = new ProjectTeamExecutor();
                var team = pte.GetAllTeamMembers(result1.OpportunityId);
                int ctr = 2;
                for (int i = 0; i < team.Count; i++)
                {
                    teamWorksheet.Cell(string.Format("A{0}", ctr + i + 1)).Value = team[i].Name;
                    teamWorksheet.Cell(string.Format("B{0}", ctr + i + 1)).Value = team[i].Role;
                }

                var obWorksheet = workbook.Worksheets.Add("Obligors");
                int obCtr = 1;
                obWorksheet.Cell(string.Format("A{0}", obCtr)).Value = "Obligors";
                obCtr++;
                obWorksheet.Cell("A" + obCtr).Value = "Entity Role";
                obWorksheet.Cell("B" + obCtr).Value = "Account Name";
                obWorksheet.Cell("C" + obCtr).Value = "Involvement in Project";

                AccountExecutor acc = new AccountExecutor();
                var obligors = acc.GetAccountsByParentIDAndRole(result1.OpportunityId, "Obligors");

                for (int i = 0; i < obligors.Count; i++)
                {
                    obWorksheet.Cell(string.Format("A{0}", obCtr + i + 1)).Value = obligors[i].EntityRole;
                    obWorksheet.Cell(string.Format("B{0}", obCtr + i + 1)).Value = obligors[i].AccountName;
                    obWorksheet.Cell(string.Format("C{0}", obCtr + i + 1)).Value = obligors[i].InvolvementInProject;
                    obCtr++;
                }

                var spWorksheet = workbook.Worksheets.Add("Sponsors");
                var spCtr = 1;
                spWorksheet.Cell(string.Format("A{0}", spCtr)).Value = "Sponsors";
                spCtr++;
                spWorksheet.Cell("A" + spCtr).Value = "Entity Role";
                spWorksheet.Cell("B" + spCtr).Value = "Account Name";
                spWorksheet.Cell("C" + spCtr).Value = "Country";

                var sponsors = acc.GetAccountsByParentIDAndRole(result1.OpportunityId, "Sponsors");

                if (sponsors.Count > 0)
                {
                    for (int i = 0; i < obligors.Count; i++)
                    {
                        spWorksheet.Cell(string.Format("A{0}", spCtr + i + 1)).Value = sponsors[i].EntityRole;
                        spWorksheet.Cell(string.Format("B{0}", spCtr + i + 1)).Value = sponsors[i].AccountName;
                        spWorksheet.Cell(string.Format("C{0}", spCtr + i + 1)).Value = sponsors[i].Country;
                    }
                }

                var dmfImpWorksheet = workbook.Worksheets.Add("DMF - Impact");
                int dmfImpactCtr = 1;

                dmfImpWorksheet.Cell(string.Format("A{0}", dmfImpactCtr)).Value = "DMF - Impact";
                dmfImpactCtr++;
                dmfImpWorksheet.Cell("A" + dmfImpactCtr).Value = "Impact Statement";
                dmfImpWorksheet.Cell("B" + dmfImpactCtr).Value = "Indicators";
                dmfImpWorksheet.Cell("C" + dmfImpactCtr).Value = "Unit of Measurement";
                dmfImpWorksheet.Cell("D" + dmfImpactCtr).Value = "Baseline Value";
                dmfImpWorksheet.Cell("E" + dmfImpactCtr).Value = "Baseline Year";
                dmfImpWorksheet.Cell("F" + dmfImpactCtr).Value = "Achievement Value";
                dmfImpWorksheet.Cell("G" + dmfImpactCtr).Value = "Achieved by (Year)";

                DMFExecutor dmf = new DMFExecutor();

                var impact = dmf.GetNSOImpact(result1.OpportunityId);
                if (impact.Count > 0)
                {
                    for (int i = 0; i < impact.Count; i++)
                    {
                        dmfImpWorksheet.Cell(string.Format("A{0}", dmfImpactCtr + i + 1)).Value = impact[i].ImpactStatement;
                        dmfImpWorksheet.Cell(string.Format("B{0}", dmfImpactCtr + i + 1)).Value = impact[i].Indicators;
                        dmfImpWorksheet.Cell(string.Format("C{0}", dmfImpactCtr + i + 1)).Value = impact[i].UnitOfMeasurement;
                        dmfImpWorksheet.Cell(string.Format("D{0}", dmfImpactCtr + i + 1)).Value = impact[i].BaselineValue;
                        dmfImpWorksheet.Cell(string.Format("E{0}", dmfImpactCtr + i + 1)).Value = impact[i].BaselineYear;
                        dmfImpWorksheet.Cell(string.Format("F{0}", dmfImpactCtr + i + 1)).Value = impact[i].AchievementValue;
                        dmfImpWorksheet.Cell(string.Format("G{0}", dmfImpactCtr + i + 1)).Value = impact[i].AchievedByYear;
                    }
                }


                var dmfOutcomeWorksheet = workbook.Worksheets.Add("DMF - Outcome");
                int dmfOutcomeCtr = 1;

                dmfOutcomeWorksheet.Cell(string.Format("A{0}", dmfOutcomeCtr)).Value = "DMF - Impact";
                dmfOutcomeCtr++;
                dmfOutcomeWorksheet.Cell("A" + dmfOutcomeCtr).Value = "Outcome Statement";
                dmfOutcomeWorksheet.Cell("B" + dmfOutcomeCtr).Value = "Indicators";
                dmfOutcomeWorksheet.Cell("C" + dmfOutcomeCtr).Value = "Unit of Measurement";
                dmfOutcomeWorksheet.Cell("D" + dmfOutcomeCtr).Value = "Baseline Value";
                dmfOutcomeWorksheet.Cell("E" + dmfOutcomeCtr).Value = "Baseline Year";
                dmfOutcomeWorksheet.Cell("F" + dmfOutcomeCtr).Value = "Achievement Value";
                dmfOutcomeWorksheet.Cell("G" + dmfOutcomeCtr).Value = "Achieved by (Year)";

                var outcome = dmf.GetNSOOutcome(result1.OpportunityId);
                if (outcome.Count > 0)
                {
                    for (int i = 0; i < outcome.Count; i++)
                    {
                        dmfOutcomeWorksheet.Cell(string.Format("A{0}", dmfOutcomeCtr + i + 1)).Value = outcome[i].OutcomeStatement;
                        dmfOutcomeWorksheet.Cell(string.Format("B{0}", dmfOutcomeCtr + i + 1)).Value = outcome[i].Indicators;
                        dmfOutcomeWorksheet.Cell(string.Format("C{0}", dmfOutcomeCtr + i + 1)).Value = outcome[i].UnitOfMeasurement;
                        dmfOutcomeWorksheet.Cell(string.Format("D{0}", dmfOutcomeCtr + i + 1)).Value = outcome[i].BaselineValue;
                        dmfOutcomeWorksheet.Cell(string.Format("E{0}", dmfOutcomeCtr + i + 1)).Value = outcome[i].BaselineYear;
                        dmfOutcomeWorksheet.Cell(string.Format("F{0}", dmfOutcomeCtr + i + 1)).Value = outcome[i].AchievementValue;
                        dmfOutcomeWorksheet.Cell(string.Format("G{0}", dmfOutcomeCtr + i + 1)).Value = outcome[i].AchievedByYear;
                    }
                }



                var dmfOutputWorksheet = workbook.Worksheets.Add("DMF - Output");
                int dmfOutputCtr = 1;

                dmfOutputWorksheet.Cell(string.Format("A{0}", dmfOutputCtr)).Value = "DMF - Impact";
                dmfOutputCtr++;
                dmfOutputWorksheet.Cell("A" + dmfOutputCtr).Value = "Output Statement";
                dmfOutputWorksheet.Cell("B" + dmfOutputCtr).Value = "Indicators";
                dmfOutputWorksheet.Cell("C" + dmfOutputCtr).Value = "Unit of Measurement";
                dmfOutputWorksheet.Cell("D" + dmfOutputCtr).Value = "Baseline Value";
                dmfOutputWorksheet.Cell("E" + dmfOutputCtr).Value = "Baseline Year";
                dmfOutputWorksheet.Cell("F" + dmfOutputCtr).Value = "Achievement Value";
                dmfOutputWorksheet.Cell("G" + dmfOutputCtr).Value = "Achieved by (Year)";

                var output = dmf.GetNSOOutput(result1.OpportunityId);
                if (output.Count > 0)
                {
                    for (int i = 0; i < outcome.Count; i++)
                    {
                        dmfOutputWorksheet.Cell(string.Format("A{0}", dmfOutputCtr + i + 1)).Value = output[i].OutputStatement;
                        dmfOutputWorksheet.Cell(string.Format("B{0}", dmfOutputCtr + i + 1)).Value = output[i].Indicators;
                        dmfOutputWorksheet.Cell(string.Format("C{0}", dmfOutputCtr + i + 1)).Value = output[i].UnitOfMeasurement;
                        dmfOutputWorksheet.Cell(string.Format("D{0}", dmfOutputCtr + i + 1)).Value = output[i].BaselineValue;
                        dmfOutputWorksheet.Cell(string.Format("E{0}", dmfOutputCtr + i + 1)).Value = output[i].BaselineYear;
                        dmfOutputWorksheet.Cell(string.Format("F{0}", dmfOutputCtr + i + 1)).Value = output[i].AchievementValue;
                        dmfOutputWorksheet.Cell(string.Format("G{0}", dmfOutputCtr + i + 1)).Value = output[i].AchievedByYear;
                    }
                }



                var covenantWorksheet = workbook.Worksheets.Add("Project Covenant");
                int covCtr = 1;

                covenantWorksheet.Cell(string.Format("A{0}", covCtr)).Value = "Project Covenant";
                covCtr++;
                covenantWorksheet.Cell("A" + covCtr).Value = "Related Project";
                covenantWorksheet.Cell("B" + covCtr).Value = "Covenant Specific ID";
                covenantWorksheet.Cell("C" + covCtr).Value = "Covenant Type";
                covenantWorksheet.Cell("D" + covCtr).Value = "Covenant Description";
                covenantWorksheet.Cell("E" + covCtr).Value = "Reference";
                covenantWorksheet.Cell("F" + covCtr).Value = "Frequency of Review";
                covenantWorksheet.Cell("G" + covCtr).Value = "Remarks/Issues";
                covenantWorksheet.Cell("H" + covCtr).Value = "Due Date";
                covenantWorksheet.Cell("I" + covCtr).Value = "Complied With?";
                covenantWorksheet.Cell("J" + covCtr).Value = "Submission Date";
                covenantWorksheet.Cell("K" + covCtr).Value = "Status";

                CovenantExecutor covExec = new CovenantExecutor();

                var cov = covExec.GetNSOCovenants(result1.OpportunityId);
                if (cov.Count > 0)
                {
                    for (int i = 0; i < cov.Count; i++)
                    {

                        covenantWorksheet.Cell(string.Format("A{0}", covCtr + i + 1)).Value = cov[i].ParentIDString;
                        covenantWorksheet.Cell(string.Format("B{0}", covCtr + i + 1)).Value = cov[i].Name;
                        covenantWorksheet.Cell(string.Format("C{0}", covCtr + i + 1)).Value = cov[i].CovenantType;
                        covenantWorksheet.Cell(string.Format("D{0}", covCtr + i + 1)).Value = cov[i].CovenantDescription;
                        covenantWorksheet.Cell(string.Format("E{0}", covCtr + i + 1)).Value = cov[i].Reference;
                        covenantWorksheet.Cell(string.Format("F{0}", covCtr + i + 1)).Value = cov[i].FrequencyOfReview;
                        covenantWorksheet.Cell(string.Format("G{0}", covCtr + i + 1)).Value = cov[i].RemarksIssues;
                        covenantWorksheet.Cell(string.Format("H{0}", covCtr + i + 1)).Value = cov[i].DueDate;
                        covenantWorksheet.Cell(string.Format("I{0}", covCtr + i + 1)).Value = cov[i].CompliedWith;
                        covenantWorksheet.Cell(string.Format("J{0}", covCtr + i + 1)).Value = cov[i].SubmissionDate;
                        covenantWorksheet.Cell(string.Format("K{0}", covCtr + i + 1)).Value = cov[i].Status;
                        
                    }
                }


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
