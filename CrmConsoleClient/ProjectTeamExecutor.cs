﻿using CrmConsoleClient.ProjectTeamService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmConsoleClient
{
    public class ProjectTeamExecutor
    {

        public List<ProxyConnection> GetAllTeamMembers(string id) 
        {
            List<ProxyConnection> team = new List<ProxyConnection>();
            ProjectTeamService.ConnectionService service = new ProjectTeamService.ConnectionService();
            try
            {
                team = service.GetAllConnection().Where(x=>x.OpportunityId == id).ToList();
            }
            catch
            {

            }
            return team;
        }

        public void GetAllTeamMembers()
        {
            ProjectTeamService.ConnectionService service = new ProjectTeamService.ConnectionService();
            try
            {
                var all = service.GetAllConnection();
            }
            catch
            { 

            }
            /*
            foreach (ProxyConnection item in all)
            {
                Console.WriteLine(item.Name);
                if (item.Name.Contains("Chen"))
                { 

                }
            }
             * */
            Console.ReadLine();
        }
    }
}
