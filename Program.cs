//Valerie Aguilar
//October 22, 2022
//------------------Mini Challenge #4: Greater Than or Less Than---------------------//
//Peer Reviewed By:
//comment: 

bool playAgain = true;
bool validNum1 = false;
bool validNum2 = false;
bool anotherRound = true;
int num1;
int num2;


Console.WriteLine("Let's play a game where I tell you whether one number is greater than or less than the other number.");




while (playAgain)
{

    Console.WriteLine("Enter your first number. The number must be a whole number.");
   //TryParse to validate and convert a whole number was input by user, if not, validNum1 will be false, and enter the while loop
    validNum1 = int.TryParse(Console.ReadLine(), out num1);

//while loop to ensure user inputs a whole number, if not loop will repeat until so.
    while (!validNum1)
    {
        if (!validNum1)
        {
            Console.WriteLine("Please enter a valid number.");
            validNum1 = int.TryParse(Console.ReadLine(), out num1);
        }

    }

    Console.WriteLine("Enter a second number");
    //TryParse used to convert second number and validate if second number was a whole number and if so will make validNum2 true; if false, will enter the while loop
    validNum2 = int.TryParse(Console.ReadLine(), out num2);

//while loop until user inputs a valid whole number
    while (!validNum2)
    {
        if (!validNum2)
        {
            Console.WriteLine("Please enter a valid whole number.");
            validNum2 = int.TryParse(Console.ReadLine(), out num2);

        }

    }

//if validNum2 is true, will go through series of if else statements

    if (validNum2)
    {
        if (num1 < num2)
        {
            Console.WriteLine($"{num1} is less than {num2}.");
            Console.WriteLine($"{num2} is greater than {num1}.");

        }

        else if (num1 > num2)
        {
            //Used interpolation to have an integer print out in a string 
            Console.WriteLine($"{num1} is greater than {num2}.");
            Console.WriteLine($"{num2} is less than {num1}.");

        }
        else
        {
            //Used interpolation to have an integer print out in a string
            Console.WriteLine($"{num1} is equal to {num2}.");

        }
        anotherRound = false;
        //set another round to false so it can enter the while loop after going through series of if else statements
    }


    while (!anotherRound)
    {
        Console.WriteLine("Thank you for playing! Would you like to play again? Type YES if so, or type NO if you would like to exit the game");
//if user does not type, yes, will exit the game
        if (Console.ReadLine().ToUpper() != "YES")
        {

            playAgain = false;
        

        }
    //set another to true to exit the while loop, and either repeat game if yes, or exit game if no.
        anotherRound = true;

    }


}


Console.WriteLine("Thank you for playing!");








