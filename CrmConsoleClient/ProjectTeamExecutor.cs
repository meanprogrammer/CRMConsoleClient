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
        public void GetAllTeamMembers()
        {
            ProjectTeamService.ConnectionService service = new ProjectTeamService.ConnectionService();
            var all = service.GetAllConnection();
            foreach (ProxyConnection item in all)
            {
                Console.WriteLine(item.Name);
                if (item.Name.Contains("Chen"))
                { 

                }
            }
            Console.ReadLine();
        }
    }
}