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
            try
            {
                var result = service.GetOneOpportunity("573b99ed-bf50-e511-80ee-3863bb2eb8d8");
            }
            catch (Exception e)
            { 

            }
        }
    }
}
