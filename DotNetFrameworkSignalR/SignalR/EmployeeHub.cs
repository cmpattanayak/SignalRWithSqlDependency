using DotNetFrameworkSignalR.Data;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace DotNetFrameworkSignalR.SignalR
{
    public class EmployeeHub : Hub
    {
        [HubMethodName("NotifyClients")]
        public static void NotifyCurrentEmployeeInformationToAllClients()
        {
            SqlDependency dependency = new SqlDependency();
            //dependency.OnChange += new OnChangeEventHandler(dependency_OnChange);

            IHubContext context = GlobalHost.ConnectionManager.GetHubContext<EmployeeHub>();

            // the update client method will update the connected client about any recent changes in the server data
            context.Clients.All.updatedClients();
        }
    }
}