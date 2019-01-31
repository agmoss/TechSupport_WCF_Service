using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TechSupportWebClient
{
    public partial class Default : System.Web.UI.Page
    {
        // Create proxy
        IncidentsServiceReference.IncidentsServiceClient proxy =
            new IncidentsServiceReference.IncidentsServiceClient();

        // Incident objects reference
        IncidentsServiceReference.Incidents[] incidents;

        protected void Page_Load(object sender, EventArgs e)
        {
            lblID.Visible = false;
        }

        private void LoadDDL(int?[] arry)
        {
            ddlID.Items.Clear();

            foreach (int? i in arry)
            {
                if (i != null)
                {
                    ddlID.Items.Add(i.ToString());
                }

            }

        }

        private void ClearAndAlter(string name)
        {
            // Change label text
            lblID.Visible = true;
            lblID.Text = name;

            // Clear datagridview
            gvID.DataSource = null;
            gvID.DataBind();
        }

        protected void btnTech_Click(object sender, EventArgs e)
        {

            ClearAndAlter("TechnicianID: ");

            int?[] techIds = proxy.GetIDs(false);

            LoadDDL(techIds);

            Session["Tech"] = 1;
        }

        protected void btnCustomer_Click(object sender, EventArgs e)
        {
            // Clear approproate controlls and change the label name
            ClearAndAlter("CustomerID: ");

            int?[] custIds = proxy.GetIDs(true);

            LoadDDL(custIds);

            Session["Tech"] = 0;
        }

        protected void ddlID_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Populate the grid view with the appropriate incidents
            if (Session["Tech"].Equals(1))
            {
                incidents = proxy.GetTechIncidents(Convert.ToInt32(ddlID.SelectedValue));
            }
            else
            {
                incidents = proxy.GetCustomerIncidents(Convert.ToInt32(ddlID.SelectedValue));
            }

            //Proper Data bind
            gvID.DataSource = incidents;
            gvID.DataBind();

        }

    }
}