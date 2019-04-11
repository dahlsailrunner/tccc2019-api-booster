# TCCC 2019 Api Booster

[![Build status](https://knowyourtoolset.visualstudio.com/TCCC-2019/_apis/build/status/TCCC-2019-CI)](https://knowyourtoolset.visualstudio.com/TCCC-2019/_build/latest?definitionId=13)

# RealPage.Logging

![BuildStatus](https://tfs.realpage.com/tfs/DefaultCollection/_apis/public/build/definitions/689bc146-c417-4893-b306-2909db3e86b7/2/badge)

This solution contains helper libraries to make error and usage logging to the ELK
stack and SQL Server for performance entries easier for .NET Core web projects.  It 
uses Serilog to do the logging.

An awesome benefit of using the package is that great detail is automatically included in every log entry, including:

* all user claims for authenticated users 
* route/path and method information (e.g. GET /api/values/1)
* query string contents
* server name
* error id's for easy support correlation
* all details from exceptions - including inner exceptions 

## Quickstart
To jump right in for quick and almost immediate results, do the following:

1. Add a package reference to `Tccc2019.ApiBooster` from the Azure DevOps Artifacts: https://knowyourtoolset.visualstudio.com/TCCC-2019/_packaging?_a=package&feed=TCCC-2019&package=Tccc2019.ApiBooster&protocolType=NuGet&version=1.0.4 .

....

