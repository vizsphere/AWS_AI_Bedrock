using OpenAI;
using Microsoft.Extensions.AI;
using System.ClientModel;

var endpoint = "https://bedrock-runtime.eu-west-2.amazonaws.com/openai/v1";
var model = "deepseek.v3-v1:0";
var apiKey = Environment.GetEnvironmentVariable("AWS_BEDROCK_APIKey", EnvironmentVariableTarget.User) ?? "";

var client = new OpenAIClient(new ApiKeyCredential(apiKey), new OpenAIClientOptions() { Endpoint = new Uri(endpoint) });
var context = @"You are a helpful assistant designed to support Microsoft developers";

while (true)
{
    var agent = client.GetChatClient(model).CreateAIAgent();

    Console.WriteLine("Q:");

    string userPrompt = Console.ReadLine();

    var messages = new List<ChatMessage>
        {
            new ChatMessage(ChatRole.System, context),
            new ChatMessage(ChatRole.User, userPrompt)
        };

    var response = await agent.RunAsync(messages);

    Console.WriteLine(response.Text);
}
