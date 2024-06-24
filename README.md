#ASPClientLib
Library of necessary attributes, interfaces and classes representing these from ASP.NET Core
## Why does this exist?
ASP.NET Core framework is not supported on all platforms (eg. .NET MAUI iOS, macOS) and sometimes cannot be referenced. Therefore I've created this library, so that parts of the framework can be used in such clients.
Examples:
- HttpGetAttribute and other attributes
- IActionResult, ActionResult, ActionResult<>
