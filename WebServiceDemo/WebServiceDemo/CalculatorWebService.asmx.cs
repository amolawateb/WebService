using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebServiceDemo
{
    /// <summary>
    /// Summary description for CalculatorWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class CalculatorWebService : System.Web.Services.WebService
    {
        List<string> calculations; //to save recent calculations

        [WebMethod (EnableSession = true)]
        public int Add(int num1, int num2)
        {
            if(Session["Calc"] == null)
            {
                calculations = new List<string>(); //if first time create new List
            }
            else
            {
                calculations = (List<string>)Session["Calc"]; //if sessions is availble use that
            }

            string strRecentCala = num1.ToString() + " + " + num2.ToString() + " = " + (num1 + num2).ToString();
            calculations.Add(strRecentCala);

            Session["Calc"] = calculations;

            return num1 + num2;
        }

        [WebMethod(EnableSession = true)]
        public List<string> GetCalc()
        {
            if(Session["Calc"] == null)
            {
                calculations.Add("no Recent Calcultaion");
                return calculations;
            }
            else
            {
                return (List<String>)Session["Calc"];
            }
        }
    }
}
