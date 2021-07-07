using System;

namespace Guys
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                // Create a new Guy object in a variable called joe
                // Set its Name field to "Joe"
                // Set its Cash field to 50
                Guy joe = new Guy() { cashOnGuy = 50, name = "Joe" };
                // Create a new Guy object in a variable called bob
                // Set its Name field to "Bob"
                // Set its Cash field to 100
                Guy bob = new Guy() { cashOnGuy = 100, name = "Bob" };
                while (true)
                {
                    // Call the WriteMyInfo methods for each Guy object
                    joe.WriteMyInfo();
                    bob.WriteMyInfo();

                    Console.Write("Enter an amount: ");
                    string howMuch = Console.ReadLine();
                    
                    //Blank to exit
                    if (howMuch == "") return;
                    // Use int.TryParse to try to convert the howMuch string to an int
                    // if it was successful (just like you did earlier in the chapter)
                    if (int.TryParse(howMuch, out int amount))
                    {
                        Console.Write("Who should give the cash: ");
                        string whichGuy = Console.ReadLine();
                        if (whichGuy == "Joe")
                        {
                            // Call the joe object's GiveCash method and save the results
                            joe.GiveCash(amount);
                            // Call the bob object's ReceiveCash method with the saved results
                            bob.ReceiveCash(amount);
                        }
                        else if (whichGuy == "Bob")
                        {
                            // Call the bob object's GiveCash method and save the results
                            bob.GiveCash(amount);
                            // Call the joe object's ReceiveCash method with the saved results
                            joe.ReceiveCash(amount);
                        }
                        else
                        {
                            Console.WriteLine("Please enter 'Joe' or 'Bob'");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please enter an amount (or a blank line to exit).");
                    }
                }
            }
        }
    }
}
