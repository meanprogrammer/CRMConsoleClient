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
    }
}
