
using System.Runtime.CompilerServices;
Main();

void PrintMenu()
{
    Console.WriteLine("Please enter a valid option from below:");
    Console.WriteLine("1. Hello in French");
    Console.WriteLine("2. Hello in Spanish");
    Console.WriteLine("3. Hello in German");
    Console.WriteLine("4. Hello in Italian");
    Console.WriteLine("0. Exit application");
}

int Getoption()
{
    try
    {
        int option = Convert.ToInt32(Console.ReadLine());
        return option;
        
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error:{ex.Message}. Please enter a valid operation.");
        return -1;
    }
    finally 
    {
        Console.WriteLine("Operation completed.");
    }
}

static int GetMessage(int option)
{

    switch (option)
    {
        case 0:
            Console.WriteLine("Goodbye");
            break;
        case 1:
            Console.WriteLine("Bonjour");
            break;
        case 2:
            Console.WriteLine("Ola");
            break;
        case 3:
            Console.WriteLine("Hallo");
            break;
        case 4:
            Console.WriteLine("Ciao");
            break;
        default:
            Console.WriteLine("Please enter a valid option");
            break;
    }
    return option;
}
void Main()
{
    PrintMenu();
    int option = Getoption();
    GetMessage(option);
}