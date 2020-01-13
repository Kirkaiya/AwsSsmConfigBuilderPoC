using Amazon.SimpleSystemsManagement;
using Amazon.SimpleSystemsManagement.Model;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;

namespace Microsoft.Configuration.ConfigurationBuilders
{
    public class AwsSsmConfigBuilder : KeyValueConfigBuilder
    {
        private string BaseParameterPath = "/padnugapp/ApiKeys";
        private static IAmazonSimpleSystemsManagement _client;

        static AwsSsmConfigBuilder()
        {
            _client = new AmazonSimpleSystemsManagementClient();
        }

        public override void Initialize(string name, NameValueCollection config)
        {
            base.Initialize(name, config);

            if (config["ssmPrefix"] == null)
                return;

            BaseParameterPath = config["ssmPrefix"];
        }

        public override ICollection<KeyValuePair<string, string>> GetAllValues(string prefix)
        {
            if (_client == null)
                return null;

            var request = new GetParametersByPathRequest
            {
                Path = $"{BaseParameterPath}/{prefix}",
                WithDecryption = true,
            };

            var response = _client.GetParametersByPathAsync(request).Result;

            var result = response.Parameters.ToDictionary(param => param.Name, param => param.Value, StringComparer.OrdinalIgnoreCase);

            return result;
        }

        public override string GetValue(string key)
        {
            if (_client == null)
                return null;

            var request = new GetParameterRequest
            {
                Name = $"{BaseParameterPath}/{key}",
                WithDecryption = true,
            };

            try
            {
                var response = _client.GetParameterAsync(request).Result;

                return response.Parameter.Value;
            } catch
            {
                return null;
            }
        }
    }
}
