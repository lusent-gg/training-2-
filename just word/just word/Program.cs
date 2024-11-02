


using static System.Runtime.InteropServices.JavaScript.JSType;

char x;

do
{
    x = Console.ReadKey().KeyChar;
}while (!char.IsDigit(x) );

Console.WriteLine("\nYou have entered a number: " + x);
