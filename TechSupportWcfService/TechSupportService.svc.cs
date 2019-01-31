using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using TechSupportWcfService.Model;

namespace TechSupportWcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "TechSupportService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select TechSupportService.svc or TechSupportService.svc.cs at the Solution Explorer and start debugging.
    public class TechSupportService : IIncidentsService
    {
        public List<Incidents> GetTechIncidents(int TechID)
        {
            return IncidentsDB.GetTechIncidents(TechID);
        }

        public List<Incidents> GetCustomerIncidents(int CustomerID)
        {
            return IncidentsDB.GetCustomerIncidents(CustomerID);
        }

        public int?[] GetIDs(bool idType)
        {
            return IncidentsDB.GetIDs(idType);
        }

    }
}
