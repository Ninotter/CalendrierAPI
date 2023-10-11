
# Calendar API

API en .NET Core 6,with unit test NUnit
## How to use
#### Calendar class

Use Calendar.GetDaysInMonth() to get the required days. It will return a IEnumerable<DateTime> containing all the required days. You can use a DateTime as input, or a simple year and month combination as integers.

Calendar is static, it does not require an instance of it to use this method.

## Building the dll
### Prerequisites
.NET Core 6 SDK must be installed on your system before using the command
### Build
Use dotnet build at the root of the CalendrierApi project. The outputing dll will be in CalendrierApi/bin/Release/.
