string userAnswer = "";

do
{
    Console.WriteLine("Hello, World!");

    Console.WriteLine("Would you like to continue (y/n)?");
    userAnswer = Console.ReadLine();

} while (userAnswer.ToLower() == "y");

if (userAnswer.ToLower() == "n")
{
    Console.WriteLine("Goodbye!");
}