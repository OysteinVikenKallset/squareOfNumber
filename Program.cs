int i = 0;
double userInput = 0;
bool isValidInput = false;

Console.WriteLine("Skriv inn et tall");

while (!isValidInput)
{
    isValidInput = double.TryParse(Console.ReadLine(), out userInput);
    
    if (!isValidInput)
    {
        Console.WriteLine("Du må skrive inn et tall");
        isValidInput = false;
        i++;
        if (i >= 4)
        {
            Console.WriteLine("Du har brukt for mange forsøk");
            break;
        }
    }

} 

if (isValidInput)
{
    Console.WriteLine("Kvadratet av tallet er: ");
    Console.WriteLine(squareOfNumber(userInput));
}

static double squareOfNumber(double number){
return number * number;
}