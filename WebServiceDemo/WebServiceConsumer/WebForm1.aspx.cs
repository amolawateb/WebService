using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebServiceConsumer.CalculatorService;

namespace WebServiceConsumer
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            CalculatorWebServiceSoapClient cal = new CalculatorWebServiceSoapClient();
            lblResult.Text = cal.Add(Convert.ToInt32(txtNumber1.Text), Convert.ToInt32(txtNumber2.Text)).ToString();
            gvRecentCalc.DataSource = cal.GetCalc();
            gvRecentCalc.DataBind();
            gvRecentCalc.HeaderRow.Cells[0].Text = "Recent Calc";
        }
    }
}