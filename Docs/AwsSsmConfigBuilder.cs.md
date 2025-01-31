# AwsSsmConfigBuilder.cs

This file contains the implementation of the `AwsSsmConfigBuilder` class, which is part of the`Microsoft.Configuration.ConfigurationBuilders` namespace.

## Class: AwsSsmConfigBuilder

### Namespace
`Microsoft.Configuration.ConfigurationBuilders`

### Inheritance
Inherits from `KeyValueConfigBuilder`

### Description
This class is a configuration builder that retrieves configuration values from AWS Systems Manager Parameter Store. It allows for easy integration of AWS SSM parameters into the application's configuration system.

### Fields

1. **BaseParameterPath**
   - Type: `string`
   - Access: Private
   - Default Value: "/padnugapp/ApiKeys"
   - Description: The base path for SSM parameters.

2. **_client**
   - Type: `IAmazonSimpleSystemsManagement`
   - Access: Private Static
   - Description: The AWS SSM client used to interact with the Parameter Store.

### Constructor

- A static constructor initializes the `_client` field with a new instance of `AmazonSimpleSystemsManagementClient`.

### Methods

1. **Initialize**
   - Access: Public Override
   - Parameters:
     - `string name`
     - `NameValueCollection config`
   - Description: Initializes the config builder. If a "ssmPrefix" is provided in the config, it updates the `BaseParameterPath`.

2. **GetAllValues**
   - Access: Public Override
   - Parameters:
     - `string prefix`
   - Return Type: `ICollection<KeyValuePair<string, string>>`
   - Description: Retrieves all parameters under the specified prefix from SSM Parameter Store.

3. **GetValue**
   - Access: Public Override
   - Parameters:
     - `string key`
   - Return Type: `string`
   - Description: Retrieves a single parameter value from SSM Parameter Store.

### Logic Flow

- The `Initialize` method sets up the base parameter path, allowing for customization via configuration.
- `GetAllValues` retrieves multiple parameters using the `GetParametersByPathAsync` method of the SSM client.
- `GetValue` retrieves a single parameter using the `GetParameterAsync` method of the SSM client.
- Both methods use the `BaseParameterPath` as a prefix for the requested keys.

### Error Handling

- The `GetValue` method catches any exceptions that occur during parameter retrieval and returns `null` in case of an error.

### Notes

- This class requires AWS SDK for .NET and appropriate AWS credentials to function correctly.
- It's designed to work with the ASP.NET configuration builder system.
- The class uses asynchronous methods from the AWS SDK but blocks on their results, which might not be ideal for high-performance scenarios.