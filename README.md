# Version

[![][nuget-img]][nuget]

[nuget]:     https://www.nuget.org/packages/Version
[nuget-img]: https://badge.fury.io/nu/Version.svg


I have used [this little snippet] countless times to show the system version number on it's footer.

[this little snippet]: http://stackoverflow.com/a/9486407

## Usage

```
@using VersionLibrary;

<footer>My Great WebSite™ - version @(Html.Version())</footer>
```