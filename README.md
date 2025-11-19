# DeepSeek V3 Console Chat Agent

A C# console application for interacting with AWS Bedrock's DeepSeek V3 model using the OpenAI SDK.

## Prerequisites

- .NET 8.0+
- AWS Bedrock access with DeepSeek V3 enabled

## Setup

1. **Install packages**
   ```bash
   dotnet add package OpenAI
   dotnet add package Microsoft.Extensions.AI
   ```

2. **Set API key**
   ```bash
   # Windows
   setx AWS_BEDROCK_APIKey "your-api-key"
   
   # Linux/macOS
   export AWS_BEDROCK_APIKey="your-api-key"
   ```

3. **Run**
   ```bash
   dotnet run
   ```

## Usage

Enter your questions at the `Q:` prompt. Press Ctrl+C to exit.
