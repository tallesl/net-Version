# Version

[![][nuget-img]][nuget]

[nuget]:     https://www.nuget.org/packages/Version
[nuget-img]: https://badge.fury.io/nu/Version.svg

A ASP.NET MVC HTML Helper that displays the application version number.

## Usage

On your view:

```
@using VersionLibrary;

<footer>My Great WebSite™ - version @(Html.Version())</footer>
```

It shows either the version of the assembly (AssemblyInfo.cs) or the version configured in the Web.config file.

```xml
<configSections>
  <section name="Version" type="VersionLibrary.Configuration, Version" />
</configSections>

<Version VersionToShow="1.0.0-rc3" />
```
