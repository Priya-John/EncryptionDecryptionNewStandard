# EncryptionDecryptionNewStandard
Example for Encryption and Decryption in .netstandard2.0 and .netFramework

This solution has 3 projects in main 

1. ClassLibrary1(.Net Standard2.0)
2. ClassLibrary2(.Net Framework 4.6.2)
3. ConsoleApp(.Net Framework 4.6.2)

The ASP.NET Core data protection stack is designed to serve as the long-term replacement for the element in ASP.NET 1.x - 4.x. It was designed to address many of the shortcomings of the old cryptographic stack while providing an out-of-the-box solution for the majority of use cases modern applications are likely to encounter.

There's a replacement in NetStandard Core for the machine keys. 

The ASP.NET Core data protection stack is designed to serve as the long-term replacement for the security elements in .NET Framework web application. It was designed to address many drawbacks of the old cryptographic and providing better solution for VS2017 applications .

Links: 
https://docs.microsoft.com/en-us/aspnet/core/security/data-protection/
https://docs.microsoft.com/en-us/aspnet/core/security/data-protection/using-data-protection

ClassLibrary1 uses Microsoft.AspNetCore.DataProtection which is new way of encryption and decryption

At its simplest protecting data consists of the following steps:

1.Create a data protector from a data protection provider.
2.Call the Protect method with the data you want to protect.
3.Call the Unprotect method with the data you want to turn back into plain text.

ClassLibrary2 uses old way of encryption and decryption using machineKey in System.Web.dll

This sample illustrates coding of DataProtection in .netstandard2.0 compared to MachineKey in .NetFramework.
