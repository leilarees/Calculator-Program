using System.Text.RegularExpressions;

string chosenOperation;
double userInputOne;
double userInputTwo;
double resultNumber = 0;
string resultMessage;
bool isValidOperation = true;

//display text on screen to introduce user
Console.WriteLine("Console calculator in c#\r");
Console.WriteLine("------------------------\n");

//display text on screen to provide instructions to user 
Console.WriteLine("Please input first variable");
while (!double.TryParse(Console.ReadLine(), out userInputOne))
{
    Console.WriteLine("Invalid input. Please enter a valid number:");
}


//display text on screen to provide instructions to user
Console.WriteLine("Please input operation type (+, -, *, / ");
chosenOperation = Convert.ToString(Console.ReadLine());

//check if chosenOperation variable aligns with valid operations, and displays error message if not 
while (chosenOperation == null || !Regex.IsMatch(chosenOperation, "[+|/|*|-]"))
{
Console.WriteLine("Invalid input: Please enter a valid operation (+ - / *)");
chosenOperation = Convert.ToString(Console.ReadLine());
}



    //display text on screen to provide instructions to user
    Console.WriteLine("Please input second variable");
    while (!double.TryParse(Console.ReadLine(), out userInputTwo))
    {
        Console.WriteLine("Invalid input. Please enter a valid number:");
    }

    //checks if user has attempted to divide by zero, displays error message if so
    if (chosenOperation == "/" && userInputOne == 0 || userInputTwo == 0)
    {
        Console.WriteLine("Error: Please do not divide by zero");
    }

    //applies chosen operation to two variables
    switch (chosenOperation)
    {
        case "*":
            resultNumber = userInputOne * userInputTwo;
            break;

        case "-":
            resultNumber = userInputOne - userInputTwo;
            break;

        case "+":
            resultNumber = userInputOne + userInputTwo;
            break;

        case "/":
            resultNumber = userInputOne / userInputTwo;
            break;

        default:
            Console.WriteLine("Invalid operation!");
            isValidOperation = false;
            break;

    }

    if (isValidOperation)
    {
        resultMessage = $"The result of {userInputOne} {chosenOperation} {userInputTwo} is {resultNumber}";
        Console.WriteLine(resultMessage);
    }




