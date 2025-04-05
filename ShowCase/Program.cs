using StringLibrary;

namespace ShowCase;

internal class Program
{
    static void Main(string[] args)
    {
        string testString1 = "Hello, Azure DevOps!";
        string testString2 = "hello, azure devops!";

        Console.WriteLine($"'{testString1}' starts with uppercase: {testString1.StartsWithUpper()}");
        Console.WriteLine($"'{testString2}' starts with uppercase: {testString2.StartsWithUpper()}");

        Console.ReadLine();
    }
}