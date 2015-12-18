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
            var allimp =service.GetAllNSOImpact();
        }
    }
}
