Console.WriteLine("Would you like to [gamble] or use an ew yucky ducky [calculator]?");
string firstOption = Console.ReadLine();
bool gambleOn = true;
int money = 1000;
if (firstOption == "gamble")
{
    while (gambleOn == true)
    {

        Console.ForegroundColor = ConsoleColor.Red;
        Console.Clear();
        Console.WriteLine("How much would you like to bet?? you have " + money);

        string userbet;
        userbet = Console.ReadLine();
        
        int userbetint = int.Parse(userbet);
        if (userbetint > 0 && userbetint <= money)
            Console.Clear();
            Console.WriteLine("You bet " + userbet + "\nPress [enter] to roll the dice, if it lands on 6 you double your bet");
        money -= userbetint;
        Console.ReadLine();
        Random diceNumber = new Random();
        int diceNumberInt = diceNumber.Next(1, 6);
        Console.WriteLine("you rolled a " + diceNumberInt);
        if (diceNumberInt == 6)
        {

            money += userbetint;
            Console.WriteLine("Money increased to " + money);
        }
        else
        {
            Console.WriteLine("Womp Womp try again next time\nType anything to try again, or [return] to return.");
        }
        if (Console.ReadLine() == "return")
            gambleOn = false;
        Console.Clear();
    }
}

//Console.WriteLine("\n\n\nIGNORE THE STUFF BELLOW ITS JUST FOR APPLIES LOL\n");


float userInput1 = 0;
float userInput2 = 0;
string operation;
    Console.Clear();
    Console.WriteLine("Welcome to the calculator, what’s the first number you would like to use ?");
    while (!float.TryParse(Console.ReadLine(), out userInput1))
    {
        Console.WriteLine("Nah that aint a number, try again.");
    }
    Console.Clear();
    Console.WriteLine("-<| " + userInput1 + " |>-");
    Console.WriteLine("Now what would you like to do with this number? (you can +(add), -(subtract), /(divide),*(times))");
operation = Console.ReadLine();
while (operation != "+" && operation != "/" && operation    != "-" && operation != "*")
{
    Console.WriteLine("Nah that aint an operation, try again.");
    operation = Console.ReadLine();
}
    
    Console.Clear();
    Console.WriteLine("-<| " + userInput1 + " " + operation + " |>-");
    Console.WriteLine("What’s the second number you would like to use ?");
    while (!float.TryParse(Console.ReadLine(), out userInput2))
    {
        Console.WriteLine("Nah that aint a number, try again.");
    }

    if (operation == "/" && userInput2 == 0)
    {
        Console.WriteLine("Nuh uh you cant do that boi");
    }
    else
    {
        Console.WriteLine("-<| " + userInput1 + " " + operation + " " + userInput2 + " |>-");
        float output = 0;
        switch (operation)
        {
            case "+": output = userInput1 + userInput2; break;
            case "-": output = userInput1 - userInput2; break;
            case "*": output = userInput1 * userInput2; break;
            case "/": output = userInput1 / userInput2; break;
            default: output = 0; break;
        }
        Console.Clear();
        Console.WriteLine("-<| " + userInput1 + " " + operation + " " + userInput2 + " = " + output + " |>-");
    }



