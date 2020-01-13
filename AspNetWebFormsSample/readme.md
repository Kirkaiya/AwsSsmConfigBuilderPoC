## AWS SSM Parameter Store ConfigurationBuilder Proof of Concept

### Before trying to run the demo, make note of the following:

 * You need to have an AWS account, and to test out the sample project locally, you need your AWS credentials (Access Key ID and Secret Access Key) set up on your local machine
 * You need to create parameters in SSM Parameter Store with the following names:
  * /padnugapp/ApiKeys/TestKey
  * /padnugapp/ApiKeys/TwitterKey
  * /padnugapp/ApiKeys/DefaultConnection
  
Review the web.config file in AspNetWebFormsSample folder to see how the AwsSsmConfigBuilder is set as the source for configuration settings. 

**This code is for demo purposes only - there are no unit tests, no tests of any sort, and it's only been tried out by me - you should NOT put this directly into any production app**

Feel free to use this as a starting point for moving appSettings and ConnectionStrings out of web.config files and into AWS Parameter Store (where they can be encrypted, secured, and rotated).
