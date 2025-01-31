# RouteConfig.cs

This file contains the route configuration for the AspNetWebFormsSample project.

## Class: RouteConfig

### Namespace
`AspNetWebFormsSample`

### Description
This static class is responsible for configuring the routing system for the web application.

### Methods

1. **RegisterRoutes**
   - Access: Public Static
   - Parameters:
     - `RouteCollection routes`
   - Return Type: `void`
   - Description: This method sets up the routing configuration for the application.

### Logic Flow

1. Creates a new instance of `FriendlyUrlSettings`.
2. Sets the `AutoRedirectMode` of the `FriendlyUrlSettings` to `RedirectMode.Off`.
3. Enables friendly URLs for the application using the configured settings.

### Notes

- This class uses the `Microsoft.AspNet.FriendlyUrls` namespace, indicating that the application is set up to use ASP.NET Friendly URLs.
- The `AutoRedirectMode` is set to `Off`, which means the application won't automatically redirect between URLs with and without file extensions.
- This configuration is typically called from the `Global.asax.cs` file during application startup.

## Usage

To use this configuration, you would typically call `RouteConfig.RegisterRoutes(RouteTable.Routes)` in your `Global.asax.cs` file's `Application_Start` method.

## Dependencies

- System.Web
- Microsoft.AspNet.FriendlyUrls