using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

/// <summary>
/// Summary description for SampleWebService
/// </summary>
[WebService(Namespace = "http://deephavenmortgage.com/webservices")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class SampleWebService : System.Web.Services.WebService
{

    public SampleWebService()
    {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    [WebMethod(Description = "Hello world method to test web service functionality. Paramters are string firstName, string lastName")]
    public string HelloWorld(string firstName, string lastName)
    {
        return string.Format ("Hello {0} {1}", firstName, lastName);
    }

    [WebMethod(Description = "Calculator method with parameters: int firstVal, int secondVal, string operation(i.e. +,-,*,/")]
    public WebServiceResponse Calculator(int firstVal, int secondVal, string operation)
    {
        WebServiceResponse response = new WebServiceResponse();
        try
        {
            switch (operation)
            {
                case "+": response.Result = Convert.ToString(firstVal + secondVal);
                    break;
                case "-":  response.Result = Convert.ToString( firstVal - secondVal);
                    break;
                case "*":  response.Result = Convert.ToString(firstVal * secondVal);
                    break;
                case "/":  response.Result = Convert.ToString(firstVal / secondVal);
                    break;
            }
            response.ErrorMessage = string.Empty;
        }
        catch (Exception ex)
        {
            response.Result = string.Empty;
            response.ErrorMessage = "Error: " + ex.Message;
        }
        return response;
    }
}
