using Amazon.SimpleSystemsManagement;
using Amazon.SimpleSystemsManagement.Model;
using Microsoft.Extensions.Configuration;

namespace converted.Services
{
    public class AwsSsmConfigService : IConfigurationSource
    {
        private readonly string _baseParameterPath;
        private readonly IAmazonSimpleSystemsManagement _client;

        public AwsSsmConfigService(string baseParameterPath)
        {
            _baseParameterPath = baseParameterPath;
            _client = new AmazonSimpleSystemsManagementClient();
        }

        public IConfigurationProvider Build(IConfigurationBuilder builder)
        {
            return new AwsSsmConfigProvider(_baseParameterPath, _client);
        }
    }

    public class AwsSsmConfigProvider : ConfigurationProvider
    {
        private readonly string _baseParameterPath;
        private readonly IAmazonSimpleSystemsManagement _client;

        public AwsSsmConfigProvider(string baseParameterPath, IAmazonSimpleSystemsManagement client)
        {
            _baseParameterPath = baseParameterPath;
            _client = client;
        }

        public override void Load()
        {
            var request = new GetParametersByPathRequest
            {
                Path = _baseParameterPath,
                Recursive = true,
                WithDecryption = true
            };

            var response = _client.GetParametersByPathAsync(request).Result;

            foreach (var parameter in response.Parameters)
            {
                Data[parameter.Name.Substring(_baseParameterPath.Length + 1)] = parameter.Value;
            }
        }
    }
}