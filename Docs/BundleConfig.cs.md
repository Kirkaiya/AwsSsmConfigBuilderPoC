# BundleConfig.cs

This file contains the bundle configuration for the AspNetWebFormsSample project.

## Class: BundleConfig

### Namespace
`AspNetWebFormsSample`

### Description
This class is responsible for configuring and registering script and style bundles for the web application.

### Methods

1. **RegisterBundles**
   - Access: Public Static
   - Parameters:
     - `BundleCollection bundles`
   - Return Type: `void`
   - Description: This method registers various script bundles used in the application.

### Bundle Configurations

1. **WebFormsJs Bundle**
   - Name: "~/bundles/WebFormsJs"
   - Files Included:
     - ~/Scripts/WebForms/WebForms.js
     - ~/Scripts/WebForms/WebUIValidation.js
     - ~/Scripts/WebForms/MenuStandards.js
     - ~/Scripts/WebForms/Focus.js
     - ~/Scripts/WebForms/GridView.js
     - ~/Scripts/WebForms/DetailsView.js
     - ~/Scripts/WebForms/TreeView.js
     - ~/Scripts/WebForms/WebParts.js

2. **MsAjaxJs Bundle**
   - Name: "~/bundles/MsAjaxJs"
   - Files Included:
     - ~/Scripts/WebForms/MsAjax/MicrosoftAjax.js
     - ~/Scripts/WebForms/MsAjax/MicrosoftAjaxApplicationServices.js
     - ~/Scripts/WebForms/MsAjax/MicrosoftAjaxTimer.js
     - ~/Scripts/WebForms/MsAjax/MicrosoftAjaxWebForms.js

3. **modernizr Bundle**
   - Name: "~/bundles/modernizr"
   - Files Included:
     - ~/Scripts/modernizr-*

### Notes

- The order of scripts in the MsAjaxJs bundle is important due to dependencies between the files.
- The modernizr bundle uses a wildcard to include all modernizr scripts.
- There's a comment suggesting to use the development version of Modernizr for development and learning, and to use the build tool at https://modernizr.com for production to include only necessary tests.

## Usage

To use this configuration, you would typically call `BundleConfig.RegisterBundles(BundleTable.Bundles)` in your `Global.asax.cs` file's `Application_Start` method.

## Dependencies

- System.Web.Optimization
- System.Web.UI