# D365ConnectionServ
This code has been written with only intention to save developer's time while testing Dynamics 365 code which requires connection to CRM organization & IOrganizationService and/or ITracingService instances.

As part of initial setup Application User & Azure AD App is required if you don’t have it already please create application user. Once you have all the details, prepare connection string as shown below and use AuthType=ClientSecret here.

All the necessary packages should be installed, package Microsoft.CrmSdk.XrmTooling.CoreAssembly version should be 9.1.0.13 or higher in order to connect using ClientSecret.

Feel free to get back in case of any suggestions/queries.
