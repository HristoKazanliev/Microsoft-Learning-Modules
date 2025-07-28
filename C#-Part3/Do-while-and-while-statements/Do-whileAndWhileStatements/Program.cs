// int heroHP = 10;
// int monsterHP = 10;

// Random heroAttack = new Random();
// Random monsterAttack = new Random();

// while (monsterHP > 0 && heroHP > 0)
// {
//     int heroDamage = heroAttack.Next(1, 11);
//     monsterHP -= heroDamage;

//     Console.WriteLine($"Monster was damaged and lost {heroDamage} health and now has {monsterHP} health.");

//     if (monsterHP > 0)
//     {
//         int monsterDamage = monsterAttack.Next(1, 11);
//         heroHP -= monsterDamage;

//         Console.WriteLine($"Hero was damaged and lost {monsterDamage} health and now has {heroHP} health.");
//     }
// }

// Console.WriteLine(heroHP > monsterHP ? "Hero wins!" : "Monster wins!");

//Code project 1 - write code that validates integer input
// Console.WriteLine("Enter an integer value between 5 and 10");
// string? input;
// bool validEntry = false;
// bool validNumber = false;
// int number = 0;

// do
// {
//     input = Console.ReadLine();
//     if (input != null)
//     {
//         validEntry = int.TryParse(input, out number);
//     }

//     if (validEntry == true)
//     {
//         if (number >= 5 && number <= 10)
//         {
//             Console.WriteLine($"Your input value ({number}) has been accepted.");
//             break;
//         }
//         else
//         {
//             Console.WriteLine($"You entered {number}. Please enter a number between 5 and 10.");
//         }
//     }
//     else
//     {
//         Console.WriteLine("Sorry, you entered an invalid number, please try again");
//     }

// } while (validNumber == false);

//Code project 2 - write code that validates string input

// string? input = "";
// bool validEntry = false;
// string role = "";

// Console.WriteLine("Enter your role name (Administrator, Manager, or User)");
// while (validEntry == false)
// {
//     input = Console.ReadLine();

//     if (input != null)
//     {
//         role = input.Trim();
//     }

//     if (role.ToLower() == "administrator" || role.ToLower() == "manager" || role.ToLower() == "user")
//     {
//         validEntry = true;
//         Console.WriteLine($"Your input value ({role}) has been accepted.");
//     }
//     else
//     {
//         Console.WriteLine($"The role name that you entered, \"{role}\" is not valid. ");
//         continue;
//     }

// }


//Code project 3 - Write code that processes the contents of a string array
string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
int periodLocation = 0;
string myString;

for (int i = 0; i < myStrings.Length; i++)
{
    myString = myStrings[i];
    periodLocation = myString.IndexOf('.');

    string mySentence;

    // extract sentences from each string and display them one at a time
    while (periodLocation != -1)
    {
        // first sentence is the string value to the left of the period location
        mySentence = myString.Remove(periodLocation);

        // the remainder of myString is the string value to the right of the location
        myString = myString.Substring(periodLocation + 1);

        // remove any leading white-space from myString
        myString = myString.TrimStart();

        // update the comma location and increment the counter
        periodLocation = myString.IndexOf('.');

        Console.WriteLine(mySentence);
    }

    mySentence = myString.Trim();
    Console.WriteLine(mySentence);
}