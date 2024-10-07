// See https://aka.ms/new-console-template for more information
using System.IO.Pipes;

Console.WriteLine("Magic Eight Ball");

string input = "";
// https://pastebin.com/raw/7pB7EYUk
List<string> listOfFortunes = new() {
                "It is certain.",
                "It is decidedly so.",
                "Without a doubt.",
                "Yes – definitely.",
                "You may rely on it.",
                "As I see it, yes.",
                "Most likely.",
                "Outlook good.",
                "Yes.",
                "Signs point to yes.",
                "Reply hazy, try again.",
                "Ask again later",
                "Better not tell you now.",
                "Cannot predict now.",
                "Concentrate and ask again.",
                "Don't count on it.",
                "My reply is no.",
                "My sources say no.",
                "Outlook not so good.",
                "Very doubtful."
            };




Random randomGenerator = new Random();



while (true && !input.ToLower().Equals("stop"))
{
    Console.WriteLine($"Ask a questions");
    input = Console.ReadLine();



    if (!input.ToLower().Equals("stop"))
    {
        Console.WriteLine($"You asked: {input} ");
        int result = randomGenerator.Next(0, listOfFortunes.Count());

        // Convert to an array as it's easier to retreive by index position
        string answer = listOfFortunes.ToArray()[result];

        Console.WriteLine($"This is what I think: {answer}");
    }


}
