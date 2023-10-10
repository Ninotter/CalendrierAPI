
# Calendar API

API en .NET Core 6, avec test unitaire NUnit
## How to use
#### Calendar class

Use Calendar.GetDaysInMonth() to get the required days. It will return a IEnumerable<DateTime> containing all the required days. You can use a DateTime as input, or a simple year and month combination as integers.

Calendar is static, it does not require an instance of it to use this method.