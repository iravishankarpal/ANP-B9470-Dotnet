using MiniWcf.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MiniWcf
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DataTable dt = new DataTable();
                ServiceReference1.TstClient tstsi = new ServiceReference1.TstClient();
                DataTable dataTable = tstsi.GetRecordList();
                dt = dataTable;
                if (dt.Rows.Count > 0)
                {
                    grduser.DataSource = dt;
                    grduser.DataBind();
                }

            }


         
        }

        protected void btnSmt_click(object sender, EventArgs e)
        {
            ServiceReference1.TstClient siclnt = new TstClient();
            int tst = siclnt.CalculateSI(Convert.ToInt32(txtP.Text), Convert.ToInt32(txtR.Text), Convert.ToInt32(txtT.Text));
            lblval.Text = "Simple Intrest : " + Convert.ToString(tst);
        }
    }
}