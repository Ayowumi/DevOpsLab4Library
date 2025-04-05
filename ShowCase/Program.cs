using StringLibrary;

namespace ShowCase;

internal class Program
{
    static void Main(string[] args)
    {
        string testString1 = "Hello, Azure DevOps!";
        string testString2 = "hello, azure devops!";

        Console.WriteLine($"'{testString1}' starts with uppercase: {testString1.StartsWithUpperCase()}");
        Console.WriteLine($"'{testString2}' starts with uppercase: {testString2.StartsWithUpperCase()}");

        Console.ReadLine();
    }
}