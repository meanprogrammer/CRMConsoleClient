using CrmConsoleClient.DMFService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmConsoleClient
{
    public class DMFExecutor
    {
        public void Execute()
        {
            DMFService.DMFService service = new DMFService.DMFService();
            var allimp =service.GetAllNSOOutput();
        }

        public List<ProxyNSOImpact> GetNSOImpact(string oppId)
        {
            DMFService.DMFService service = new DMFService.DMFService();
            var allimp = service.GetAllNSOImpact().Where(x=>x.OpportunityID == oppId).ToList();

            return allimp;
        }

        public List<ProxyNSOOutcome> GetNSOOutcome(string oppId)
        {
            DMFService.DMFService service = new DMFService.DMFService();
            var allimp = service.GetAllNSOOutcome().Where(x => x.OpportunityID == oppId).ToList();

            return allimp;
        }


        public List<ProxyNSOOutput> GetNSOOutput(string oppId)
        {
            DMFService.DMFService service = new DMFService.DMFService();
            var allimp = service.GetAllNSOOutput().Where(x => x.OpportunityID == oppId).ToList();

            return allimp;
        }
    }
}
