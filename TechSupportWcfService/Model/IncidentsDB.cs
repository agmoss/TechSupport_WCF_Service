using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace TechSupportWcfService.Model
{
    public class IncidentsDB
    {
        private static List<Incidents> GetIncidents()
        {

            List<Incidents> incidents = new List<Incidents>();

            string selectQuery = "SELECT IncidentID, CustomerID, ProductCode, TechID, DateOpened, DateClosed, Title, Description " +
                                  "FROM Incidents " +
                                  "ORDER BY DateOpened;";

            using (SqlConnection con = new SqlConnection(GetConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand(selectQuery, con))
                {
                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    Incidents incd;

                    while (dr.Read())
                    {
                        incd = new Incidents();

                        incd.IncidentID = (int)dr["IncidentID"];
                        incd.CustomerID = (int)dr["CustomerID"];
                        incd.ProductCode = dr["ProductCode"].ToString();

                        if (dr["TechID"] == DBNull.Value)
                        {
                            incd.TechID = null;
                        }
                        else
                        {
                            incd.TechID = (int)dr["TechID"];
                        }

                        if (dr["DateOpened"] == DBNull.Value)
                        {
                            incd.DateOpened = null;
                        }
                        else
                        {
                            incd.DateOpened = Convert.ToDateTime(dr["DateOpened"]);
                        }

                        if (dr["DateClosed"] == DBNull.Value)
                        {
                            incd.DateClosed = null;
                        }
                        else
                        {
                            incd.DateClosed = Convert.ToDateTime(dr["DateClosed"]);
                        }

                        incd.Title = dr["Title"].ToString();
                        incd.Description = dr["Description"].ToString();

                        // Add to return list
                        incidents.Add(incd);
                    }

                }
                return incidents;
            }

        }

        public static List<Incidents> GetTechIncidents(int TechID)
        {
            // Return list
            List<Incidents> techIncidents = new List<Incidents>();

            // Loop object
            Incidents incident;

            // Get list of all incidents
            List<Incidents> allIncidents = GetIncidents();

            var techIncids = from I in allIncidents
                             where I.TechID == TechID
                             select I;

            // Reconstruct into list
            foreach (var incid in techIncids)
            {
                incident = new Incidents();

                incident.IncidentID = Convert.ToInt32(incid.IncidentID);
                incident.CustomerID = Convert.ToInt32(incid.CustomerID);
                incident.ProductCode = incid.ProductCode.ToString();
                incident.TechID = Convert.ToInt32(incid.TechID);
                incident.DateOpened = Convert.ToDateTime(incid.DateOpened);
                incident.DateClosed = Convert.ToDateTime(incid.DateClosed);
                incident.Title = incid.Title.ToString();
                incident.Description = incid.Description.ToString();

                //Add to return list
                techIncidents.Add(incident);

            }
            return techIncidents;
        }


        public static List<Incidents> GetCustomerIncidents(int CustomerID)
        {
            // Return list
            List<Incidents> customerIncidents = new List<Incidents>();

            // Loop object
            Incidents incident;

            // Get list of all incidents
            List<Incidents> allIncidents = GetIncidents();

            var customerIncids = from I in allIncidents
                                 where I.CustomerID == CustomerID
                                 select I;

            // Reconstruct into list
            foreach (var incid in customerIncids)
            {
                incident = new Incidents();

                incident.IncidentID = Convert.ToInt32(incid.IncidentID);
                incident.CustomerID = Convert.ToInt32(incid.CustomerID);
                incident.ProductCode = incid.ProductCode.ToString();
                incident.TechID = Convert.ToInt32(incid.TechID);
                incident.DateOpened = Convert.ToDateTime(incid.DateOpened);
                incident.DateClosed = Convert.ToDateTime(incid.DateClosed);
                incident.Title = incid.Title.ToString();
                incident.Description = incid.Description.ToString();

                //Add to return list
                customerIncidents.Add(incident);

            }

            return customerIncidents;

        }

        public static int?[] GetIDs(bool idType)
        {

            // Get list of all incidents
            List<Incidents> allIncidents = GetIncidents();

            if (idType)
            {
                var Ids = (from I in allIncidents
                           select I.CustomerID).Distinct();

                return Ids.ToArray();

            }
            else
            {
                var Ids = (from I in allIncidents
                           select I.TechID).Distinct();

                return Ids.ToArray();
            }

        }


        private static string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings
                ["TechSupportConnection"].ConnectionString;
        }
    }

}
