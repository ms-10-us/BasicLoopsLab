string userAnswer = "";

do
{
    Console.WriteLine("Enter a number:");
    int userNumber = Convert.ToInt32(Console.ReadLine());

    for (int i = userNumber; i >= 0; i--)
    {
        Console.Write($"{i} ");
    }

    Console.WriteLine();

    for (int i = 0; i <= userNumber; i++)
    {
        Console.Write($"{i} ");
    }

    Console.WriteLine();

    Console.WriteLine("Would like to continue (y/n)?");
    userAnswer = Console.ReadLine();

} while (userAnswer.ToLower() == "y");

if (userAnswer.ToLower() == "n")
{
    Console.WriteLine("Goodbye!");
}