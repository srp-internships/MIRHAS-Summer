using System.Net.Http.Json;
using System.Text.Json;

class Program
{
    private static readonly HttpClient client = new HttpClient();
    private const string apiKey = "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";
    private const string endpoint = "https://api.openai.com/v1/chat/completions";

    static async Task Main(string[] args)
    {
        Console.WriteLine("Welcome to the Chatbot!");

        while (true)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("You: ");
            string userInput = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(userInput))
                break;

            string jsResponce = await GetChatbotResponse(userInput);
            string responce = ExtractChatbotMessage(jsResponce);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Chatbot: " + responce);
        }
    }

    static async Task<string> GetChatbotResponse(string message)
    {
        client.DefaultRequestHeaders.Clear();
        client.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");

        var requestBody = new
        {
            model = "gpt-3.5-turbo",
            messages = new List<object>
            {
                new { role = "system", content = "You are a chatbot" },
                new { role = "user", content = message }
            },
            max_tokens = 1000
        };

        var response = await client.PostAsJsonAsync(endpoint, requestBody);
        string jsonResponse = await response.Content.ReadAsStringAsync();

        return jsonResponse;
    }
    static string ExtractChatbotMessage(string jsonResponse)
    {
        var jsonDoc = JsonDocument.Parse(jsonResponse);
        var choices = jsonDoc.RootElement.GetProperty("choices");
        var message = choices[0].GetProperty("message");
        var content = message.GetProperty("content").GetString();

        return content;
    }
}
