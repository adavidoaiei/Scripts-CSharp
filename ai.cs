#!/home/adavidoaiei/dotnet/dotnet run
#:package Microsoft.SemanticKernel@1.59.0

using Microsoft.SemanticKernel;
using Microsoft.SemanticKernel.KernelExtensions;

var kernel = Kernel.Builder.Build();

kernel.Config.AddOpenAICompletionBackend(
    "davinci-backend",
    "text-davinci-003",
    "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"
);

string skPrompt = @"
{{$input}}

Give me the TLDR in 5 words.
";

string textToSummarize = @"
1) A robot may not injure a human being or, through inaction,
allow a human being to come to harm.

2) A robot must obey orders given it by human beings except where
such orders would conflict with the First Law.

3) A robot must protect its own existence as long as such protection
does not conflict with the First or Second Law.
";

var tldrFunction = kernel.CreateSemanticFunction(skPrompt);

var summary = await kernel.RunAsync(textToSummarize, tldrFunction);

Console.WriteLine(summary);

// Output => Protect humans, follow orders, survive.