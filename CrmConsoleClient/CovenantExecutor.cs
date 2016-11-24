using CrmConsoleClient.CovenantService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmConsoleClient
{
    public class CovenantExecutor
    {
        public void Execute()
        {
            using (CovenantService.CovenantService service = new CovenantService.CovenantService())
            {
                //var allnso = service.GetAllNSOCovenant().FirstOrDefault();
                var allsov = service.GetAllSOVCovenant().FirstOrDefault();

            }
        }


        public List<ProxyNSOCovenant> GetNSOCovenants(string oppId)
        {
            List<ProxyNSOCovenant> list = new List<ProxyNSOCovenant>();
            using (CovenantService.CovenantService service = new CovenantService.CovenantService())
            {
                list = service.GetAllNSOCovenant().Where(x => x.ParentID == oppId).ToList();
                //var allsov = service.GetAllSOVCovenant().FirstOrDefault();

            }
            return list;
        }
    }
}
