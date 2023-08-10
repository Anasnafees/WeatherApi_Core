Application FrameWork = net7.0

KEY EXPIRE ON =  21/Aug/2023

Get Your Api = https://www.weatherapi.com/


Nuget Package Installed = 
System.Net.Http.Json(7.0.0) - Provides extension methods for System.Net.Http.HttpClient and 
System.Net.Http.HttpContent that perform automatic serialization and deserialization using System.Text.Json.

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

==========================================================================================================================================

Added xUnit Project For Basic Unit Testing Of The Application :

Added Interface Of GetWeatherServices To The Dependency Injection

Using Mock To Provide Fake Reference .

Reference = https://code-maze.com/aspnetcore-unit-testing-xunit/

[Fact] – attribute states that the method should be executed by the test runner
[Theory] – attribute implies that we are going to send some parameters to our testing code. So, it is similar to the [Fact] attribute, because it states that the method should be executed by the test runner, but additionally implies that we are going to send parameters to the test method
[InlineData] – attribute provides those parameters we are sending to the test method. If we are using the [Theory] attribute, we have to use the [InlineData] as well

![image](https://github.com/Anasnafees/WeatherApi_Core/assets/75159560/0dd70103-0e89-48b3-88a1-c9a686381a8a)

![image](https://github.com/Anasnafees/WeatherApi_Core/assets/75159560/88c94416-1433-4af9-9cc7-24c35df2981c)

![image](https://github.com/Anasnafees/WeatherApi_Core/assets/75159560/8b2ee6bd-d1c3-43f2-a3d3-2f020128ce12)

![image](https://github.com/Anasnafees/WeatherApi_Core/assets/75159560/b9a7f1a1-378c-493e-ada0-60cd611702c1)





By Anas Nafees
Contact : anasnafees1802@gmail.com
Date : 08/07/2023
