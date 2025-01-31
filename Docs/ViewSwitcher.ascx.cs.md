# ViewSwitcher.ascx.cs

This file contains the code-behind for the ViewSwitcher user control in the AspNetWebFormsSample project.

## Class: ViewSwitcher

### Namespace
`AspNetWebFormsSample`

### Inheritance
Inherits from `System.Web.UI.UserControl`

### Description
This class represents the code-behind for a ViewSwitcher user control, which allows switching between mobile and desktop views of the website.

### Properties

1. **CurrentView**
   - Type: `string`
   - Access: Protected
   - Description: Represents the current view (Mobile or Desktop).

2. **AlternateView**
   - Type: `string`
   - Access: Protected
   - Description: Represents the alternate view (Desktop if current is Mobile, and vice versa).

3. **SwitchUrl**
   - Type: `string`
   - Access: Protected
   - Description: Stores the URL for switching between views.

### Methods

1. **Page_Load**
   - Access: Protected
   - Parameters: 
     - `object sender`
     - `EventArgs e`
   - Return Type: `void`
   - Description: This method is called when the control is loaded. It determines the current view, sets up the alternate view, and creates the switch URL.

### Logic Flow
1. Determines if the current view is mobile using `WebFormsFriendlyUrlResolver.IsMobileView`.
2. Sets the `CurrentView` and `AlternateView` properties accordingly.
3. Attempts to create a switch URL using the "AspNet.FriendlyUrls.SwitchView" route.
4. If the route is not found, the control is hidden.
5. If the route is found, it constructs the `SwitchUrl` including the current raw URL as a return URL.

### Notes
- The class uses the `Microsoft.AspNet.FriendlyUrls.Resolvers` namespace for mobile view detection.
- The switching mechanism relies on ASP.NET Friendly URLs feature.
- If the Friendly URLs feature is not enabled or misconfigured, the control will be hidden.