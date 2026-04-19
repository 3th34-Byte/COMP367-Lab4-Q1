using StringExtensionsLib;

Console.WriteLine("Enter a string:");
string input = Console.ReadLine() ?? "";

bool result = input.StartsWithUppercase();

Console.WriteLine(result
    ? "Starts with uppercase"
    : "Does NOT start with uppercase");