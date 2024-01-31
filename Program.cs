using System;
bool runProgram = true;
bool validate = true;
while (runProgram)
{

Console.WriteLine("Welcome to the Dice Roller. How many sides should each dice have? Please only choose a postive number.");
int dice1side = -1;
//Tim's valid. loop to see if user input a postive number
while (int.TryParse(Console.ReadLine(), out dice1side) == false || dice1side <= 0)
{
    Console.WriteLine("Try again");
}
while (validate) 
 {

Console.WriteLine("Please type 'roll' to roll the dice.");
string choice = Console.ReadLine().ToLower().Trim();
if (choice == "roll")
{

    //roll results

    int roll1 = Roll(dice1side);
    Console.WriteLine($"{roll1}");
    int roll2 = Roll(dice1side);
    Console.WriteLine($"{roll2}");
    int total = roll1 + roll2;
    Console.WriteLine($"Your total was {total}");
     if (dice1side == 6)
    {
        Console.WriteLine(dicecombo(roll1, roll2));
        Console.WriteLine(Totals(roll1, roll2));
    }
            break;
} 

else 
{
    Console.WriteLine("Please enter 'roll'");
}
    }
    Console.WriteLine("Would you like to continue playing? 'yes'/'no'");
    string choice2 = Console.ReadLine().ToLower().Trim();
    if (choice2 == "yes")
    {
        runProgram = true;
    }
    else if (choice2 == "no")
    {
        runProgram = false;
    }
    else
    {
        Console.WriteLine("Please choose only 'yes' or 'no'");
    }
}







//methods
//Roll method
static int Roll(int dice1side)
{
    Random rnd = new Random();
    int newdice = rnd.Next(1, dice1side + 1);
    return newdice;
}
//combo method

static string dicecombo(int roll1, int roll2)
{
    if (roll1 == 1 && roll2 == 1)
    {
        return ("Snake Eyes");
    }
    else if (roll1 == 1 && roll2 == 2 || roll1 == 2 && roll2 == 1)
    {
        return ("Ace Deuce");
    }
    else if (roll1 == 6 && roll2 == 6)
    {
        return "Box Car";
    }
    else
    {
        return "";
    }
}
//wins method
static string Totals (int roll1, int roll2)
{
    if (roll1 + roll2 == 7 || roll1 + roll2 == 11) 
    {
        return ("Win");
    }
    else if (roll1 + roll2 == 2 || roll1 + roll2 == 3 || roll1 + roll2 == 12)
    {
        return ("Crabs");
    }
    else
    {
        return "";
    }
} 


