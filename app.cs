#!/home/adavidoaiei/dotnet/dotnet run
#:package OllamaSharp@5.1.19

using OllamaSharp;

// set up the client
var uri = new Uri("http://localhost:11434");
var ollama = new OllamaApiClient(uri);
ollama.SelectedModel = "gemma3:1b";
var chat = new Chat(ollama);

Console.WriteLine("Argument " + args[0] + " is the image file to process");
// read the image file from arguments
byte[] imageBytes = File.ReadAllBytes(args[0]);

if (imageBytes.Length != 0 && imageBytes != null)
{
    Console.WriteLine("Image is not empty");
}

var imageBytesEnumerable = new List<IEnumerable<byte>> { imageBytes };

if (imageBytesEnumerable != null || imageBytesEnumerable.Any())
{
    Console.WriteLine("imageBytesEnumerable is not null or empty");
}

if (chat != null)
{
    Console.WriteLine("Chat client is not null");
}

// generate the alt text
var message = "Generate a complete alt text description for the attached image. The description should be detailed and suitable for visually impaired users. Do not include any information about the image file name or format. must be in Spanish.";
await foreach (var answerToken in chat.SendAsync(message: message))
    Console.Write(answerToken);

// done
Console.WriteLine($">> Ollama done");