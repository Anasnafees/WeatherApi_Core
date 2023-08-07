Application FrameWork = net7.0
KEY EXPIRE ON =  21/Aug/2023
Get Your Api = https://www.weatherapi.com/

Nuget Package Installed = System.Net.Http.Json(7.0.0) - Provides extension methods for System.Net.Http.HttpClient and System.Net.Http.HttpContent that perform automatic serialization and deserialization using System.Text.Json.
=======================================================================================================================================
Used dotnet user-secrets init Command To Store Secret Key Of Weather Api(The preceding command adds a UserSecretsId element within a PropertyGroup of the project file. By default, the inner text of UserSecretsId is a GUID. The inner text is arbitrary, but is unique to the project.)

Used  dotnet user-secrets set "WeatherApi:ApiKey" "XXX---USE YOUR API KEY HERE---XXX" To Store The Api Key To Secret Location.(Secrets.json)

dotnet user-secrets list = To View All Secret Keys.

Example:
        PM> dotnet user-secrets list
        WeatherApi:ApiKey = xxxxxxxxxAPI-KEY-VALUExxxxxxxxx

REFERENCE = https://learn.microsoft.com/en-us/aspnet/core/security/app-secrets?view=aspnetcore-7.0&tabs=windows
WeatherApi Docs = https://www.weatherapi.com/docs/
=========================================================================================================================================

Bind The Value Of The Secret Key To The Model Class And Added Model InterFace In The Dependency(Program.cs)


By Anas Nafees
Contact : anasnafees1802@gmail.com
Date : 08/07/2023











