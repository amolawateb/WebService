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
    [WebServiceBinding(ConformsTo = WsiProfiles.None)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class CalculatorWebService : System.Web.Services.WebService
    {
        List<string> calculations; //to save recent calculations

        [WebMethod (EnableSession = true, Description ="Add 2 Numbers", BufferResponse = true, CacheDuration = 20,  MessageName = "Add2Numbers")]
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

        [WebMethod(EnableSession = true, Description = "Add 3 Numbers", BufferResponse = true, CacheDuration = 20, MessageName = "Add3Numbers")]
        public int Add(int num1, int num2, int num3)
        {
            if (Session["Calc"] == null)
            {
                calculations = new List<string>(); //if first time create new List
            }
            else
            {
                calculations = (List<string>)Session["Calc"]; //if sessions is availble use that
            }

            string strRecentCala = num1.ToString() + " + " + num2.ToString() + " + " + num3.ToString() + " = " + (num1 + num2 + num3).ToString();
            calculations.Add(strRecentCala);

            Session["Calc"] = calculations;

            return num1 + num2;
        }

        [WebMethod(EnableSession = true, CacheDuration = 20)]
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
