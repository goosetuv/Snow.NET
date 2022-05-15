# Goosetuv.Snow.NET
.NET Framework API Wrapper for Snow License Manager 9.

[![Snow License Manager](https://img.shields.io/badge/Snow%20License%20Manager-9.20-f39f37?style=flat-square)](https://snowsoftware.com/current-product-versions)
[![License](https://img.shields.io/github/license/goosetuv/snow.net?style=flat-square)](https://github.com/goosetuv/Snow.NET/blob/main/LICENSE)

# Features
99% API coverage[*](#missing-items) || Authentication Support || Additional Parameter Support || Service Provider and Enterprise Edition Support

# System Requirements
## Standard Requirements
If you want the requirements for building from source, review the [Build Requirements](#build-requirements) section, otherwise if you're just using the NuGet package or downloading from releases, the only major requirement is .NET Framework 4.7.2 is required. 

## Build Requirements
The below is what is required to build from source.  If you just want to use the package in your own program and not build from source or customize it, ignore this section.

- Visual Studio 2022 (Community is what I use)
- RestSharp and it's dependencies
- System.Text.Json and it's dependencies 

You should be able to restore the package dependencies when opening the source in Visual Studio.

---

# Issues and Contributions
Do you want to report a bug? [Create an issue](https://github.com/goosetuv/Goosetuv.SnowNET/issues/new)

Do you want to contribute? Fork and push a pull request. :)

---

# Installation
The easist method for getting started would be adding Snow.NET via NuGet Package Manager in Visual Studio, however if that's not possible for some reason, you can download the latest release from Releases and add a reference to all of the included DLL files. 

---

# Packages
Package pending NuGet approval.

---
# Examples
Below are some starter examples.  There is also the [Snow.NET.Examples](https://github.com/goosetuv/Snow.NET.Examples) repo on here that may be useful.

## Basic Example
### Data Update Job
This example assumes that you have ran the Data Update Job at least once.

```csharp
// Initiate the Authentication class
Authenticate _auth = new Authenticate("http://snow.domain.scot/api/", "Administrator", "SnowNET2022?");

// Initiate the Platform Data class and Authenticate with our Client
PlatformData _platformData = new PlatformData(_auth.Client);

var _duj = _platformData.DataUpdateJob();

Console.WriteLine(
    $"  > Last Start Time       : {_duj.Body.LastStartTime}\n" +
    $"  > Last Execution Time   : {_duj.Body.LastExecutionTime}\n" +
    $"  > Is Running            : {_duj.Body.IsRunning}\n" +
    $"  > State                 : {_duj.Body.State}\n" 
);
```

The above example will output the following:

```text
   > Last Start Time         : 05/05/2022 21:07:23
   > Last Execution Time     : 00:23:56
   > Is Running              : False
   > State                   : FinishedOrOnlyMinorErrors
```

### System Information and System User Data

```csharp
// Initiate the Authentication class
Authenticate _auth = new Authenticate("http://snow.domain.scot/api/", "Administrator", "SnowNET2022?");

// Initiate the Platform Data class and Authenticate with our Client
PlatformData _platformData = new PlatformData(_auth.Client);

var _systemUser = _platformData.SystemUser();

Console.WriteLine(
    $"  > Display Name              : {_systemUser.Body.FirstName} {_systemUser.Body.LastName}\n" +
    $"  > Current Time              : {DateTime.Now}\n" +
    $"  > Assigned Customer ID      : {_systemUser.Body.CustomerId}\n"
);
```

The above will output the following:

```text
   > Display Name              : System Administrator
   > Current Time              : 06/05/2022 20:27:49
   > Assigned Customer ID      : 1
```

# Missing Items
Unfortunately I don't have any Demo Data for Mobiles, so the following cannot be queried. 

- Mobile Devices
- Agreement Mobile Devices
- User Mobile Devices
- Application Mobile Devices

If you have Mobile Data in your system and you're willing to offer a hand, please drop me an email at **me (at) laim.scot**.
