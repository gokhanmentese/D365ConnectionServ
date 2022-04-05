# D365ConnectionServ
This code has been written with only intention to save developer's time while testing Dynamics 365 code which requires connection to CRM organization & IOrganizationService and/or ITracingService instances.

As part of initial setup Application User & Azure AD App is required if you don’t have it already please create application user. Once you have all the details, prepare connection string as shown below and use AuthType=ClientSecret here.

To prepare Application User, please visit.

https://www.cozumpark.com/dynamics-365-uygulama-kullanicisi/

All the necessary packages should be installed, package Microsoft.CrmSdk.XrmTooling.CoreAssembly version should be 9.1.0.13 or higher in order to connect using ClientSecret.

![organizationService](https://user-images.githubusercontent.com/69807493/161737992-5eea239b-28b8-4f9b-96be-0229f2722c3c.png)

![serviceappuser](https://user-images.githubusercontent.com/69807493/161738359-941fd1e9-71ac-4af1-9abc-476dc33fe9fc.png)


Feel free to get back in case of any suggestions/queries.
