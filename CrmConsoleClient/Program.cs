﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            TradeFinanceServiceExecutor tf = new TradeFinanceServiceExecutor();
            tf.GetAllCreditGuaranteeRequest();
            tf.AddSomething();
            */
             
            /*
            DMFExecutor dmf = new DMFExecutor();
            dmf.Execute();
            */
 


            
            /*
            OpportunityExecutor ex = new OpportunityExecutor();
            ex.GetOpportunity();
            */


            ConfinancingExecutor cex = new ConfinancingExecutor();
            cex.Execute();
            
            
            //AccountExecutor aex = new AccountExecutor();
            //aex.GetAllAccounts();
         

            
           /*
            ProjectTeamExecutor pte = new ProjectTeamExecutor();
            pte.GetAllTeamMembers();
            */

      
      //      CovenantExecutor ce = new CovenantExecutor();
        //    ce.Execute();
            
             
            /*
            BPService.BaselineProjectionService client = new BPService.BaselineProjectionService();
            var bps = client.GetAllBaselineProjection();
            
            /*
            StringBuilder builder = new StringBuilder();
            foreach (var item in bps)
            {

                builder.AppendLine(string.Format("{0}-{1}", item.Id, item.Name));
            }

            File.WriteAllText(@"C:\Users\vd2\dumpfile.txt", builder.ToString());
            

            //533c17a0-7666-e511-80f8-3863bb2e7cd8

            BPService.CustomBaselineProjection filter = new BPService.CustomBaselineProjection();
            filter.Id = "533c17a0-7666-e511-80f8-3863bb2e7cd8";

            client.UpdateBaselineProjection(filter);*/
        }
    }
}
