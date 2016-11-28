using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmConsoleClient
{
    public class ConfinancingExecutor
    {
        CofinancingService.CofinancingService s = new CofinancingService.CofinancingService();

        public void Execute()
        {
            //07d2818f-1f72-e511-80f8-3863bb2e7cd8
            var cof = s.GetCommercialCofinancing("07d2818f-1f72-e511-80f8-3863bb2e7cd8");
            foreach (var item in cof)
            {
                Console.WriteLine(item.CofinancingCategory);
            }
        }
    }
}
