bool isDoorLocked = true;
const int keyCode = 13579;

Console.WriteLine("Please enter the key code");

while (isDoorLocked)
{
    
    int userKeyCode = Convert.ToInt32(Console.ReadLine());

    if (userKeyCode == keyCode)
    {
        Console.WriteLine("The door is now open. Welcome!");
        isDoorLocked = false;
    }

    else
    {
        Console.WriteLine("Incorrect. Please try again");
        isDoorLocked = true;
    }
}
