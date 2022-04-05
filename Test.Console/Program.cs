using CrmService.CrmHelper;
using Microsoft.Crm.Sdk.Messages;

namespace Test.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var crmServiceSingleton = CrmServiceSingleton.GetService();
            var crmService = crmServiceSingleton.OrganizationService;

            WhoAmIRequest request = new WhoAmIRequest();
            WhoAmIResponse response = (WhoAmIResponse)
            crmService.Execute(request);

            var userId = response.UserId;

        }
    }
}
