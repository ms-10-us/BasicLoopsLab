using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(DoorLock());
    }

    static bool DoorLock()
    {
        bool isDoorLocked = true;
        const int keyCode = 13579;
        const int maxTries = 5;
        int userTry = 0;

        Console.WriteLine("Please enter the key code. You have a max of 5 tries.");

        while (isDoorLocked && userTry < maxTries)
        {
            int userKeyCode = Convert.ToInt32(Console.ReadLine());

            if (userKeyCode == keyCode)
            {
                Console.WriteLine("The door is now open. Welcome!");
                isDoorLocked = false;

            }
            else
            {
                userTry++;

                if (userTry < 5)
                {

                    Console.WriteLine($"Incorrect. You have {maxTries - userTry} tries left");
                    isDoorLocked = true;

                }
                else
                {
                    Console.WriteLine("Access denied!");
                    break;

                }

            }
        }
    return (!isDoorLocked);
    }

}


















