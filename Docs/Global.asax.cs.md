# Global.asax.cs

This file contains the global application class for the AspNetWebFormsSample project.

## Class: Global

### Namespace
`AspNetWebFormsSample`

### Inheritance
Inherits from `System.Web.HttpApplication`

### Description
This class represents the global application class for the web application. It handles application-wide events and initialization.

### Methods

1. **Application_Start**
   - Access: `void` (implicitly private)
   - Parameters: 
     - `object sender`
     - `EventArgs e`
   - Description: This method is called when the application starts. It performs the following actions:
     - Registers routes using `RouteConfig.RegisterRoutes`
     - Registers bundles using `BundleConfig.RegisterBundles`

### Notes
- The class uses various namespaces including System.Web.Optimization and System.Web.Routing.
- The `Application_Start` method is automatically called by the ASP.NET runtime when the application starts.
- Route configuration and bundle configuration are separated into their own classes (`RouteConfig` and `BundleConfig` respectively) and are called from this global application class.