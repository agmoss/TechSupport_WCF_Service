using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace TechSupportWcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IIncidentsService" in both code and config file together.
    [ServiceContract]
    public interface IIncidentsService
    {
        [OperationContract]
        List<Incidents> GetTechIncidents(int TechID);

        [OperationContract]
        List<Incidents> GetCustomerIncidents(int CustomerID);

        [OperationContract]
        int?[] GetIDs(bool idType);

    }

    [DataContract]
    public class Incidents
    {
        [DataMember]
        public int IncidentID { get; set; }

        [DataMember]
        public int? CustomerID { get; set; }

        [DataMember]
        public string ProductCode { get; set; }

        [DataMember]
        public int? TechID { get; set; }

        [DataMember]
        public DateTime? DateOpened { get; set; }

        [DataMember]
        public DateTime? DateClosed { get; set; }

        [DataMember]
        public string Title { get; set; }

        [DataMember]
        public string Description { get; set; }

    }
}
