// Initialize counter for number of attempts
int i = 0;

// Variable to hold the user's input
double userInput = 0;

// Boolean flag to indicate whether the user's input is valid
bool isValidInput = false;

// Prompt the user to enter a number
Console.WriteLine("Skriv inn et tall");

// Loop until a valid number is entered or the maximum number of attempts is reached
while (!isValidInput)
{
    // Try to parse the user's input as a double
    // If the parsing is successful, isValidInput will be set to true
    isValidInput = double.TryParse(Console.ReadLine(), out userInput);
    
    // If the input is not valid, display an error message and increment the counter
    if (!isValidInput)
    {
        Console.WriteLine("Du må skrive inn et tall");
        i++;
        
        // If the maximum number of attempts is reached, display a message and break the loop
        if (i >= 4)
        {
            Console.WriteLine("Du har brukt for mange forsøk");
            break;
        }
    }
} 

// If a valid number was entered, calculate its square and display the result
if (isValidInput)
{
    Console.WriteLine($"Kvadratet av tallet er: {squareOfNumber(userInput)}");
}

// Function to calculate the square of a number
static double squareOfNumber(double number){
    return number * number;
}